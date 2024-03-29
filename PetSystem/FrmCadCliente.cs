﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetSystem {
    public partial class FrmCadCliente : Form {
        public FrmCadCliente() {
            InitializeComponent();
        }
        
        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            try {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(petshopDataSet.cliente);
                btnFoto.Enabled = false;
                MessageBox.Show("Registro salvo!");
            } catch (Exception) {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
               
            }

        }

        private void FrmCadCliente_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.petshopDataSet.cliente);

        }

        // Adicionar novo cliente.
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) {
            clienteBindingSource.AddNew();
            btnFoto.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            clienteBindingSource.CancelEdit();
            btnFoto.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            btnFoto.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) {
            try {
                if (MessageBox.Show("Confirme exclusão do registro", "PetSystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    clienteBindingSource.RemoveCurrent(); // remove
                    clienteTableAdapter.Update(petshopDataSet.cliente); // salva
                }
            } catch (Exception) {
                clienteTableAdapter.Fill(petshopDataSet.cliente);
                MessageBox.Show("Registro não pode ser excluido");
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                openFileDialog1.Filter = "Fotos (*.jpg; *.png; *.jpeg;) | *.jpg; *.png; *.jpeg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                    cli_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
            } catch (Exception) {
                MessageBox.Show("Erro ao carregar o arquivo de imagem", "PetSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
    }
}
