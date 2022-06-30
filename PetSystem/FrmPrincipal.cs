using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetSystem {
    public partial class FrmPrincipal : Form {
        public FrmPrincipal() {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Deseja mesmo sair?", "PetSystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.Exit();
            }            
        }

        private void btnMin_Click(object sender, EventArgs e) {
            //Minimizar a aplicação
            this.WindowState=FormWindowState.Minimized;
        }
    }
}
