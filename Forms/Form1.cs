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
            MessageBox.Show("Daten erfolgreich gespeichert!");
            this.Close();
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
        string message = "Wollen Sie wirklich abbrechen?";
        string title = "Achtung!";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
        if (result == DialogResult.Yes) {
            this.Close();
        }
        }
    }
}
