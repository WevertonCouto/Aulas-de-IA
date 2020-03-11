using ProMedico.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace ProMedico
{
    public partial class Form1 : Form
    {
        public List<Sintoma> Sintomas { get; set; }
        public List<Doenca> Doencas { get; set; }

        public Form1()
        {
            InitializeComponent();
            Sintomas = new List<Sintoma>();
            Doencas = new List<Doenca>();
        }

        private void BtnNovoSintoma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeSintoma.Text)) return;
            Sintomas.Add(new Sintoma(txtNomeSintoma.Text));
            txtNomeSintoma.Text = "";
            RecarregarListaSintomas();
        }

        private void RecarregarListaSintomas()
        {
            chklSintomasCadastro.Items.Clear();
            chklSintomas.Items.Clear();
            foreach (var sintoma in Sintomas)
            {
                chklSintomasCadastro.Items.Add(sintoma.GetNome());
                chklSintomas.Items.Add(sintoma.GetNome());
            }
        }

        private void BtnSalvarDoenca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeDoenca.Text) || chklSintomasCadastro.CheckedItems.Count == 0) return;
            List<Sintoma> Sint = new List<Sintoma>();

            foreach (var item in chklSintomasCadastro.CheckedItems) Sint.Add(new Sintoma((item as String)));

            Doencas.Add(new Doenca
            {
                Nome = txtNomeDoenca.Text,
                Sintomas = Sint
            });

            txtNomeDoenca.Text = "";
            foreach (int item in chklSintomasCadastro.CheckedIndices) chklSintomasCadastro.SetItemChecked(item, false);
        }

        private void BtnVerificarSintomas_Click(object sender, EventArgs e)
        {
            List<Sintoma> sintomasSelecionados = new List<Sintoma>();
            foreach (var item in chklSintomas.CheckedItems)
            {
                sintomasSelecionados.Add(new Sintoma(item as string));
            }

            string resultado = "";
            foreach (var doenca in Doencas)
            {
                int count = 0;
                foreach (var sintoma in sintomasSelecionados)
                {
                    var res = doenca.Sintomas.Find(p => p.GetNome() == sintoma.GetNome());
                    if (res != null) count++;
                }
                double m1 = ((double.Parse(count.ToString()) / sintomasSelecionados.Count) * 100);
                double m2 = ((double.Parse(count.ToString())) / doenca.Sintomas.Count) * 100;
                if (count != 0) resultado += $"Doença: {doenca.Nome}, porcentagem: {Math.Round(((m1 + m2) / 2), 2)} % \n";
            }
            lblResultado.Text = resultado;
        }

        private void GroupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
