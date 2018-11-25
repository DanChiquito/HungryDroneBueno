#include <SoftwareSerial.h>

SoftwareSerial xBee(3,4);

void setup() {
  Serial.begin(9600);
  xBee.begin(9600);

}

void loop() {

}

void serialEvent(){
  if(xBee.available()){
    Serial.write(xBee.read());
  }
  
}
