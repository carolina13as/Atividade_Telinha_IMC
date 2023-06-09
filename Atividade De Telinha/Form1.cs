using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_De_Telinha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            
        }
       
        private void botao1_Click(object sender, EventArgs e)
        {
            string nome = txt1.Text;
            string CPF = txt2.Text;
            int idade = Convert.ToInt32(txt3.Text);
            string sexo = txt4.Text;
            double peso = Convert.ToDouble(txt5.Text);
           double altura = Convert.ToDouble(txt6.Text);
            Pessoa a = new Pessoa(nome,CPF, idade,sexo,peso,altura);
            (double imc, string cla, string grau) = a.Calcular();
            label3.Text = $"O imc é: {imc.ToString("F2")}";
            label4.Text = $"A classificação é: {cla}";
            label5.Text = $"O grau é:{grau}";
            bool retornoCPF = Validacoes.ValidaCpf(CPF);           
            if(retornoCPF == false)
            {
                label6.ForeColor = Color.Red;
                label6.Text = "CPF invalido";
            }
            else
            {
                label6.Text = "";
            }

                     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "0";
            txt4.Text = "";
            txt5.Text = "0,00";
            txt6.Text = "0,00";
            label3.Text = "";
            label5.Text = "";
            label4.Text = "";
            label6.Text = "";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro_Cliente cl = new Cadastro_Cliente();
            cl.ShowDialog();
        }
    }
}
