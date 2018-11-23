#include <Wire.h>
#include <Adafruit_Sensor.h>
#include <Adafruit_BMP280.h>
#include <TinyGPS++.h>
#include <SoftwareSerial.h>
#include "MPU9250.h"

//////////////////////////////////////Objetos//////////////////////////////////

Adafruit_BMP280 bmp;    //bmp object
TinyGPSPlus gps;        //gps object

/////////////////////////////////////Variables/////////////////////////////////

float P0; //Atmospheric pressure
int RXPin = 9; //Pin RX to connect TX from GPS
int TXPin = 8; //Pin TX to connect RX from GPS
int status;

const int Trigger = 2;   //Pin digital 2 para el Trigger del sensor
const int Echo = 3;   //Pin digital 3 para el Echo del sensor


String lt;
String ln;
String s;
String alt;
String x;
String y;
String z;
String data;
String coma = ",";

/////////////////////////////////Comunicación/////////////////////////////////

SoftwareSerial GPS(RXPin, TXPin); //Serial ports for GPS communication
MPU9250 IMU(Wire,0x68); //I2C for IMU

/////////////////////////////////////SETUP/////////////////////////////////////

void setup() {
  Serial.begin(9600);       //Serial will be use by xBee communication
  GPS.begin(9600);
  
  if ( !bmp.begin() ) 
  {
    while (1){
      Serial.println("0,0,0,BMP_Error,0,0,0");
      delay(1000);
    }
  }
  
  while(!Serial) {}

  status = IMU.begin();
  if (status < 0) {
    while(1) {
      Serial.println("0,0,0,0,IMU,ERROR,WIRING");
      delay(1000);
      }
  }

  pinMode(Trigger, OUTPUT); //pin como salida
  pinMode(Echo, INPUT);  //pin como entrada
  digitalWrite(Trigger, LOW);//Inicializamos el pin con 0

  P0=bmp.readPressure()/100;

}

//////////////////////////////////////LOOP/////////////////////////////////////

void loop() {
  data = "";
  //GPS
  if(gps.location.isValid() && gps.altitude.isValid() && gps.speed.isValid())
  {
    lt = gps.location.lat();
    ln = gps.location.lng();
    s = gps.speed.mps();
  }
  else{
    lt = "************";
    ln = "************";
    s = "************";
  }
  smartDelay(1000);

  //BPM
  alt = bmp.readAltitude(P0);

  long t; //timepo que demora en llegar el eco
  long d; //distancia en centimetros

  digitalWrite(Trigger, HIGH);
  delayMicroseconds(10);          //Enviamos un pulso de 10us
  digitalWrite(Trigger, LOW);
  
  t = pulseIn(Echo, HIGH); //obtenemos el ancho del pulso
  d = t/59;             //escalamos el tiempo a una distancia en cm

  //GYRO
  IMU.readSensor();
  x=IMU.getAccelX_mss();
  y=IMU.getAccelY_mss();
  z=IMU.getAccelZ_mss();

  data = lt + coma;
  data = data + ln + coma;
  data = data + s + coma;
  data = data + alt + coma;
  data = data + x + coma;
  data = data + y + coma;
  data = data + d;

  Serial.println(data);
  
}

//////////////////////////////////Funciones//////////////////////////////////////

static void smartDelay(unsigned long ms)
{
  unsigned long start = millis();
  do
  {
    while (GPS.available())
      gps.encode(GPS.read());
  } while (millis() - start < ms);
}
