using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parentesco_Taulogia
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;
        List<String> parentesco;
        public Form1()
        {
            InitializeComponent();
            pessoas = new List<Pessoa>();
            PessoasTeste();
            MontarLista();
            parentesco = new List<string>();
            PreencherComboParentesco();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text) 
                || string.IsNullOrEmpty(txtNome2.Text) 
                || cboParentesco.SelectedIndex == 0) return;

            pessoas.Add(new Pessoa(txtNome.Text, (cboParentesco.SelectedItem as string), txtNome2.Text));
            MontarLista();
            LimparCampos();
        }


        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text)
                || string.IsNullOrEmpty(txtNome2.Text)
                || cboParentesco.SelectedIndex == 0) return;

            string nome = txtNome.Text;
            int comboIndex = cboParentesco.SelectedIndex;
            string nome2 = txtNome2.Text;

            // Pai
            if (comboIndex == 1)
            {
                Pessoa p = pessoas.Find(f => f.Nome == nome
                && f.Parentesco == "pai"
                && f.Nome2 == nome2);
                if (p != null) MessageBox.Show(String.Format("{0} é pai de {1}", nome, nome2));
                else MessageBox.Show(String.Format("{0} não é pai de {1}", nome, nome2));
            }

            // Mae
            if (comboIndex == 2)
            {
                Pessoa p = pessoas.Find(f => f.Nome == nome
                && f.Parentesco == "mae"
                && f.Nome2 == nome2);
                if (p != null) MessageBox.Show(String.Format("{0} é mãe de {1}", nome, nome2));
                else MessageBox.Show(String.Format("{0} não é mãe de {1}", nome, nome2));
            }

            // Irmao
            if (comboIndex == 3)
            {
                Pessoa p = pessoas.Find(f => f.Nome2 == nome
                && f.Parentesco == "pai");
                if (p != null)
                {
                    p = pessoas.Find(f => f.Nome == p.Nome
                    && f.Parentesco == "pai" && f.Nome2 == nome2);

                    if (p != null) MessageBox.Show(String.Format("{0} é irmão de {1}", nome, nome2));
                    else MessageBox.Show(String.Format("{0} não é irmão de {1}", nome, nome2));
                } else MessageBox.Show(String.Format("Não encontrado informações suficientes para determinar um relacionamento de irmão."));
            }

            // Filho
            if (comboIndex == 4)
            {
                Pessoa p = pessoas.Find(f => f.Nome2 == nome
                && f.Parentesco == "pai" && f.Nome == nome2);
                if (p != null) MessageBox.Show(String.Format("{0} é filho de {1}", nome, nome2));
                else MessageBox.Show(String.Format("{0} não é filho de {1}", nome, nome2));
            }

            // Conjuge
            if (comboIndex == 5)
            {
                Pessoa p = pessoas.Find(f => f.Nome == nome
                && f.Parentesco == "conjuge"
                && f.Nome2 == nome2);
                if (p != null) MessageBox.Show(String.Format("{0} é conjuge de {1}", nome, nome2));
                else MessageBox.Show(String.Format("{0} não é conjuge de {1}", nome, nome2));
            }

            // Tio / Tia
            if (comboIndex == 6 || comboIndex == 7)
            {
                List<Pessoa> listaPessoas = pessoas.FindAll(f => f.Nome == nome
                && f.Parentesco == "irmao");

                foreach (var i in listaPessoas)
                {
                    Pessoa p = pessoas.Find(f => f.Nome == i.Nome2
                    && (f.Parentesco == "pai" || f.Parentesco == "mae" ) && f.Nome2 == nome2);
                    if (p != null)
                    {
                        MessageBox.Show(String.Format("{0} é tio/tia de {1}", nome, nome2));
                    }
                }
                MessageBox.Show(String.Format("{0} não é tio/tia de {1}", nome, nome2));
            }

            // Primo / Prima
            if (comboIndex == 8)
            {
                Pessoa p = pessoas.Find(f => f.Nome2 == nome
                && f.Parentesco == "pai");
                if (p != null)
                {
                    Pessoa p2 = pessoas.Find(f => f.Nome2 == nome2
                    && f.Parentesco == "pai");
                    if (p2 == null) MessageBox.Show(String.Format("{0} não é primo/prima de {1}", nome, nome2));

                    Pessoa p3 = pessoas.Find(f => (f.Nome == p.Nome && f.Parentesco == "irmao" && f.Nome2 == p2.Nome) || (f.Nome == p.Nome2 && f.Parentesco == "irmao" && f.Nome2 == p2.Nome));
                    if (p3 != null)
                        MessageBox.Show(String.Format("{0} é primo/prima de {1}", nome, nome2));
                    else MessageBox.Show(String.Format("{0} não é primo/prima de {1}", nome, nome2));

                } else MessageBox.Show(String.Format("{0} não é primo/prima de {1}", nome, nome2));
            }

            // Cunhado
            if (comboIndex == 9)
            {
                Pessoa p = pessoas.Find(f => (f.Nome == nome && f.Parentesco == "conjuge"));
                if (p != null)
                {
                    p = pessoas.Find(f => (f.Nome == p.Nome2 && p.Parentesco == "irmao" && f.Nome2 == nome2) || (f.Nome == nome2 && p.Parentesco == "irmao" && f.Nome2 == p.Nome2));
                    if (p != null)
                    {
                        MessageBox.Show(String.Format("{0} é cunhado/cunhada de {1}", nome, nome2));
                    }
                }
                if (p == null)
                {
                    p = pessoas.Find(f => (f.Nome2 == nome && f.Parentesco == "conjuge"));
                    if (p != null)
                    {
                        Pessoa p2 = pessoas.Find(f => f.Nome == p.Nome && p.Parentesco == "irmao" && f.Nome2 == nome2);
                        if (p2 == null) p2 = pessoas.Find(f => f.Nome == nome2 && p.Parentesco == "irmao" && f.Nome2 == p.Nome);
                        if (p != null)
                        {
                            MessageBox.Show(String.Format("{0} é cunhado/cunhada de {1}", nome, nome2));
                        }
                    }
                }
                if (p == null) MessageBox.Show(String.Format("{0} não é cunhado/cunhada de {1}", nome, nome2));
            }

            LimparCampos();
        }



        private void MontarLista()
        {
            StringBuilder stringBuilder = new StringBuilder();
            pessoas.ForEach((v) =>
            {
                stringBuilder.AppendFormat("{0} {1} {2} \r\n", v.Nome, v.Parentesco, v.Nome2);
            });
            txtLista.Text = stringBuilder.ToString();
        }

        private void PreencherComboParentesco()
        {
            parentesco.Add("SELECIONE");
            parentesco.Add("pai");
            parentesco.Add("mae");
            parentesco.Add("irmao");
            parentesco.Add("filho");
            parentesco.Add("conjuge");
            parentesco.Add("tio");
            parentesco.Add("tia");
            parentesco.Add("primo");
            parentesco.Add("cunhado");
            parentesco.ForEach((v) => cboParentesco.Items.Add(v));
            cboParentesco.SelectedIndex = 0;
        }

        private void PessoasTeste()
        {
            pessoas.Add(new Pessoa("Joao", "pai", "Marcos"));
            pessoas.Add(new Pessoa("Joao", "pai", "Matheus"));
            pessoas.Add(new Pessoa("Ze", "irmao", "Joao"));
            pessoas.Add(new Pessoa("Ze", "pai", "Lucas"));
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            cboParentesco.SelectedIndex = 0;
            txtNome2.Text = "";
        }

    }
}
