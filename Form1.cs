using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace Projeto_Eduardo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoras_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCarro_TextChanged(object sender, EventArgs e)
        {

        }
        float valor;
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Adionar as variáveis para receber os valores dos TextBox 
            float dias;
            float km;
            float.TryParse(txtKm.Text, out km);
            float.TryParse(txtDias.Text, out dias);
            float resultado = 0;
            float valor;

            if (!float.TryParse(txtKm.Text, out valor))//verificação de dados p não ficar em branco
            {
                MessageBox.Show("Digite a quantidade de quilometros rodados");
                txtKm.Focus();
                return;
            }
            if (!float.TryParse(txtDias.Text, out valor)) //verificação de dados p não ficar em branco
            {
                MessageBox.Show("Digite a quantidade de dias");
                txtDias.Focus();
                return;
            }
            if (comboBoxCarros.SelectedIndex == 0) //verificação de dados p não ficar em branco
            {
                MessageBox.Show("Selecione a classe do carro");
                comboBoxCarros.Focus();
                return;
            }
            // adicionar valor da classe do carro Popular
            if (comboBoxCarros.SelectedIndex == 1)
            {
                valor = 50;
                resultado = (float)(valor + (dias * 10) + (km * 5.5));
            }
            // adicionar valor da classe do carro intermediário
            if (comboBoxCarros.SelectedIndex == 2)
            {
                valor = 90;
                resultado = (float)(valor + (dias * 10) + (km * 5.5));
            }
            // adiocionar valor da classe do carro de premium
            if (comboBoxCarros.SelectedIndex == 3)
            {
                valor = 140;

                resultado = (float)(valor + (dias * 10) + (km * 5.5));
            }

            //Adicionar os campos no DataGrid
            dataGridView2.Rows.Add
            (comboBoxCarros.Text, dias.ToString("N2"), km.ToString("N2"), "R$" + resultado.ToString("N2"));

            //Limpeza dos campos 
            txtDias.Clear();
            comboBoxCarros.SelectedItem = null;
            txtKm.Clear();
            txtDias.Focus();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //verificar se existe uma linha selecionada
            if (dataGridView2.SelectedRows.Count > 0)
            {
                //Remove a linha selecionada 
                dataGridView2.Rows.RemoveAt(
                    dataGridView2.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Selecione a linha que deseja remover");
            }
        }
    }
}
