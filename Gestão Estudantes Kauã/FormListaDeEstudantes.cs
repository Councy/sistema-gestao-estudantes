﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_Estudantes_Kauã
{
    public partial class FormListaDeEstudantes : Form
    {
        public FormListaDeEstudantes()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void FormListaDeEstudantes_Load(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`");
            dataGridViewLista.ReadOnly = true;
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            dataGridViewLista.RowTemplate.Height = 80;
            dataGridViewLista.DataSource = estudante.pegarEstudantes(comando);
            colunaDeFotos = (DataGridViewImageColumn)dataGridViewLista.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewLista.AllowUserToAddRows = false;
        }

        private void dataGridViewLista_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewLista_DoubleClick(object sender, EventArgs e)
        {
            AtualizarDeletarEstudante atualizarDeletarEstudante = new AtualizarDeletarEstudante();
            atualizarDeletarEstudante.textBoxID.Text = dataGridViewLista.CurrentRow.Cells[0].Value.ToString();
            atualizarDeletarEstudante.textBoxNome.Text = dataGridViewLista.CurrentRow.Cells[1].Value.ToString();
            atualizarDeletarEstudante.textBoxSobrenome.Text = dataGridViewLista.CurrentRow.Cells[2].Value.ToString();
            atualizarDeletarEstudante.dateTimePickerNascimento.Value = (DateTime)dataGridViewLista.CurrentRow.Cells[3].Value;
            
            if (dataGridViewLista.CurrentRow.Cells[4].Value.ToString() == "Masculino")
            {
                atualizarDeletarEstudante.radioButtonMasculino.Checked = true;
            }
            else
            {
                atualizarDeletarEstudante.radioButtonFeminino.Checked = true;
            }

            atualizarDeletarEstudante.textBoxTelefone.Text = dataGridViewLista.CurrentRow.Cells[5].Value.ToString();
            atualizarDeletarEstudante.textBoxEndereco.Text = dataGridViewLista.CurrentRow.Cells[6].Value.ToString();

            byte[] fotoDaLista;
            fotoDaLista = (byte[]) dataGridViewLista.CurrentRow.Cells[7].Value;
            MemoryStream fotoDoEstudante = new MemoryStream(fotoDaLista);
            atualizarDeletarEstudante.pictureBoxFoto.Image = Image.FromStream(fotoDoEstudante);
            atualizarDeletarEstudante.Show();
        }
    }
}
