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

        
        private void btnInicio_Click(object sender, EventArgs e) {
            panelCentral.Controls.Clear();

            //Aplicando a posição do eixo Y do botao ao panelSelecao
            panelSelecao.Top = btnInicio.Top;
        }

        private void btnCliente_Click(object sender, EventArgs e) {
            FrmCadCliente cliente = new FrmCadCliente();
            cliente.TopLevel = false;
            cliente.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear(); // Limpa o painel
            panelCentral.Controls.Add(cliente); // Adiciona o form no painel
            cliente.Show();

            //Aplicando a posição do eixo Y do botao ao panelSelecao
            panelSelecao.Top = btnCliente.Top;
        }

        private void btnRaca_Click(object sender, EventArgs e) {
            FrmRacas racas = new FrmRacas();
            racas.TopLevel = false;
            racas.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(racas);
            racas.Show();

            //Aplicando a posição do eixo Y do botao ao panelSelecao
            panelSelecao.Top = btnRaca.Top;

        }

        private void btnAnimal_Click(object sender, EventArgs e) {
            FrmAnimal animais = new FrmAnimal();
            animais.TopLevel = false;
            animais.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(animais);
            animais.Show();

            //Aplicando a posição do eixo Y do botao ao panelSelecao
            panelSelecao.Top = btnAnimal.Top;
        }

        private void btnServicos_Click(object sender, EventArgs e) {
            FrmServicos servicos = new FrmServicos();
            servicos.TopLevel = false;
            servicos.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(servicos);
            servicos.Show();

            //Aplicando a posição do eixo Y do botao ao panelSelecao
            panelSelecao.Top = btnServicos.Top;
        }

        private void btnAgendamento_Click(object sender, EventArgs e) {
            FrmAgendamento agendamentos = new FrmAgendamento();
            agendamentos.TopLevel = false;
            agendamentos.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(agendamentos);
            agendamentos.Show();

            //Aplicando a posição do eixo Y do botao ao panelSelecao
            panelSelecao.Top = btnAgendamento.Top;
        }
    }
}
