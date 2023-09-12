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
    public partial class AtualizarDeletarEstudante : Form
    {

        Estudante estudante = new Estudante();
        public AtualizarDeletarEstudante()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArquivo = new OpenFileDialog();
            abrirArquivo.Filter = "Seleciona a Foto(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(abrirArquivo.FileName);
            }
        }

        bool Verificar()
        {
            if ((textBoxNome.Text.Trim() == "") ||
                (textBoxSobrenome.Text.Trim() == "") ||
                (textBoxTelefone.Text.Trim() == "") ||
                (textBoxEndereco.Text.Trim() == "") ||
                (pictureBoxFoto.Image == null))

            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            // Estudante estudante = new Estudante();
            int id = Convert.ToInt32(textBoxID.Text);
            string nome = textBoxNome.Text;
            string sobrenome = textBoxEndereco.Text;
            DateTime nascimento = dateTimePickerNascimento.Value;
            string telefone = textBoxTelefone.Text;
            string endereco = textBoxEndereco.Text;
            string genero = "Feminino";

            if (radioButtonMasculino.Checked)
            {
                genero = "Masculino";
            }

            MemoryStream foto = new MemoryStream();

            int anoDeNascimento = dateTimePickerNascimento.Value.Year;
            int anoAtual = DateTime.Now.Year;
            if ((anoAtual - anoDeNascimento) < 10 ||
               (anoAtual - anoDeNascimento) > 100)
            {
                MessageBox.Show("A idade precisa ser entre 10 e 100 anos.", "Idade Inválida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Verificar())
            {
                pictureBoxFoto.Image.Save(foto, pictureBoxFoto.Image.RawFormat);
                if (estudante.atualizarEstudante(id, nome, sobrenome, nascimento, telefone, genero, endereco, foto))
                {
                    MessageBox.Show("Informações Atualizadas!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro", "Inserir Estudante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Campos não preenchidos", "Inserir Estudante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
        }
    }
}

