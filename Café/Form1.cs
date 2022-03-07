namespace Café
{
    public partial class Coffe : Form
    {
        double saldo = 0;
        bool cafe, cappuccino, mocha;


        public Coffe()
        {
            InitializeComponent();
            pictureBoxCappuccino.Visible = false;
            pictureBoxMocha.Visible = false;
            pictureBoxCafe.Visible = false;

            comboBox1.Text = "1,00";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBoxMocha_Click(object sender, EventArgs e)
        {


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e) //Café com Leite Selecionado
        {
            labelEntrada.Text = "R$3,00 150ml";

            cappuccino = false;
            mocha = false;
            cafe = true;

            pictureBoxCappuccino.Visible = false;
            pictureBoxMocha.Visible = false;
            pictureBoxCafe.Visible = true;

            buttonCafecomleite.Enabled = false;
            buttonMocha.Enabled = true;
            buttonCappuccino.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e) //Cappuccino Selecionado
        {
            cappuccino = true;
            mocha = false;
            cafe = false;


            labelEntrada.Text = " R$3,50 200ml";

            pictureBoxCappuccino.Visible = true;
            pictureBoxMocha.Visible = false;
            pictureBoxCafe.Visible = false;

            buttonCappuccino.Enabled = false;
            buttonMocha.Enabled = true;
            buttonCafecomleite.Enabled = true;
        }
        private void buttonMocha_Click(object sender, EventArgs e) //Mocha Selecionada
        {
            labelEntrada.Text = "R$4,00 500ml";
            cappuccino = false;
            mocha = true;
            cafe = false;

            pictureBoxCappuccino.Visible = false;
            pictureBoxMocha.Visible = true;
            pictureBoxCafe.Visible = false;

            buttonMocha.Enabled = false;
            buttonCafecomleite.Enabled = true;
            buttonCappuccino.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saldo = 0.00f;
            labelTotal.Text = "R$ 0,00";
        }

        private void buttonConfirmar_Click(object sender, EventArgs e) //Botão Confirmar
        { 

            if (cafe == true)
            {
             if (saldo >= 3.00f )
                {
                    saldo -= 3.00f;
                    MessageBox.Show("café com leite");
                }
                else
                {
                    MessageBox.Show("faltou dinheiro, coloque mais, pobre!");
                }
            }
            else if (cappuccino == true)
            {
                if ( saldo >= 3.50f )
                {
                    saldo -= 3.50f;
                    MessageBox.Show("Cappuccino");
                }
                else
                {
                    MessageBox.Show("faltou dinheiro, coloque mais, pobre!");
                }
            }
            else if (mocha == true)
            {
                if (saldo >= 4.00f)
                {
                    saldo -= 4.00f;
                    MessageBox.Show("Mocha");            
                }
                else
                {
                    MessageBox.Show("faltou dinheiro, coloque mais, pobre!");
                }
            }

            labelTotal.Text = saldo.ToString("C2");
        }


        private void button1_Click_1(object sender, EventArgs e) // Botão Adicionar
        {
            switch (comboBox1.Text)

            {
                case "1,00": saldo += 1.00f; break;
                case "0,50": saldo += 0.50f; break;
                case "0,25": saldo += 0.25f; break;
                case "0,10": saldo += 0.10f; break;
                case "0,05": MessageBox.Show("não aceitamos moedas pequenas"); break;
                case "0,01": MessageBox.Show("nem existe moedas de 1 centavo cara!"); break;
            }
            labelTotal.Text = saldo.ToString("C2");
        }
    }
}