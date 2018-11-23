using System;
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
    public partial class formLogo : Form
    {
        public formLogo()
        {
            InitializeComponent();
        }

        private void formLogo_Load(object sender, EventArgs e)
        {
            lbHora.Text = System.DateTime.Now.ToString("h:mm:ss");
        }
    }
}
