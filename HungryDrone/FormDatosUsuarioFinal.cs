﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HungryDrone
{
    public partial class FormDatosUsuarioFinal : Form
    {
        /*public FormDatosUsuarioFinal()
        {

        }
        
        */
        public FormDatosUsuarioFinal(string nombre, string direccion, byte hotdogs, byte sushi, byte pizza, byte pasta, byte burro, byte burguer, float total)
        {
            InitializeComponent();
        }
    }
}