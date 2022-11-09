using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFesta
{
    public partial class pibbackground : Form
    {
        public pibbackground()
        {
            InitializeComponent();
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            // obter a idade do txb:
            int ano = (int)txbidade.Value;
            int idade;
            string nome = txbnome.Text;
            string sobrenome = txbsobrenome.Text;

            // Verificar a Idade:
            idade = (DateTime.Now.Year - ano);
            if(idade >= 18)
            {
                // Mudar a imagem para ok
                pibicone.Image = Properties.Resources.OK;
                txbsaudacao.Text = "Bem Vindo";
                txbexibicao.Text = "Nome: " + nome + " " + sobrenome + " || Idade: " + idade + " Anos";
            } 
            else
            {
                pibicone.Image = Properties.Resources.fechar;
                txbsaudacao.Text = "Acesso Negado";
                txbexibicao.Text = " ";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            // Voltar ao cadeado:
            pibicone.Image = null;
        }

        private void lblsair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Botao Sair
            this.Close();
        }

        private void lblidade_Click(object sender, EventArgs e)
        {

        }

        private void txbnome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbsobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbexibicao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
