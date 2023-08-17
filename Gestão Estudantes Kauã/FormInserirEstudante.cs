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
    public partial class FormInserirEstudante : Form
    {
        public FormInserirEstudante()
        {
            InitializeComponent();
        }

        private void btnEnviarFoto_Click(object sender, EventArgs e)
        {
            // Pesquisa pela imagem no PC.
            OpenFileDialog abrirArquivo = new OpenFileDialog();
            abrirArquivo.Filter = "Seleciona a Foto(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(abrirArquivo.FileName);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Estudante estudante = new Estudante();
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
            if((anoAtual - anoDeNascimento) < 10 ||
               (anoAtual - anoDeNascimento) > 100)
            {
                MessageBox.Show("A idade precisa ser entre 10 e 100 anos.", "Idade Inválida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Verificar())
            {
                pictureBoxFoto.Image.Save(foto, pictureBoxFoto.Image.RawFormat);
                if (estudante.inserirEstudante(nome, sobrenome, nascimento, telefone, genero, endereco, foto))
                {
                    MessageBox.Show("Novo estudante cadastrado.", "Sucesso!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro", "Inserir Estudante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
    }
}
