using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_App_Solaranlage
{
    public partial class frmSolarpanel : Form
    {
        public frmSolarpanel()
        {
            InitializeComponent();
        }


        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
