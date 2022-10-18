using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Azpetrol
{
    public partial class Azpetrol_form : Form
    {
        int tmp = 0;
        private int num = 0;
        public decimal[] price = { 0.90m, 1.10m, 1.60m, 2.00m };
        public decimal[] price_cafe = { 1.30m, 1m, 1.50m, 0.80m };
        public int xz = 0;

        //List<decimal> lists = new List<decimal>();/////////////////////////////////////////////////////

        public Azpetrol_form()
        {
            InitializeComponent();
            reset_button.Enabled=false;
            pay_button.Enabled = false;
            choose_cafe_button.Enabled = false;
            kol_burqer_textBox.Enabled = false;
            kol_enerqetik_textBox.Enabled = false;
            kol_hot_dog__textBox.Enabled = false;
            kol_cola_textBox.Enabled = false;


            price_burger_textBox.Text = price_cafe[0].ToString();
            price_energetik_textBox.Text = price_cafe[1].ToString();
            pric_hot_dog_etextBox.Text = price_cafe[2].ToString();
            price_cola_textBox.Text = price_cafe[3].ToString();

            choose_button.Enabled = false;
            comboBox1.SelectedIndex = 0;
            price_textBox.Text = price[0].ToString();

            summa_textBox.Enabled = false;
            kollicestvo_textBox.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox1.SelectedIndex = 0;
                price_textBox.Text = price[0].ToString();
                oplata_textBox.Text = price[0].ToString();
                tmp_label2.Text = price[0].ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox1.SelectedIndex = 1;
                price_textBox.Text = price[1].ToString();
                oplata_textBox.Text = price[1].ToString();
                tmp_label2.Text = price[1].ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox1.SelectedIndex = 2;
                price_textBox.Text = price[2].ToString();
                oplata_textBox.Text = price[2].ToString();
                tmp_label2.Text = price[2].ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                comboBox1.SelectedIndex = 3;
                price_textBox.Text = price[3].ToString();
                oplata_textBox.Text = price[3].ToString();
                tmp_label2.Text = price[3].ToString();
            }

        }

        private void kollicestvo_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (kollicestvo_radioButton.Checked == true)
            {
                oplata_textBox.Text = tmp_label2.Text;
                summa_textBox.Text = null;
                kollicestvo_textBox.Enabled = true;
                summa_textBox.Enabled = false;
                choose_button.Enabled = false;
            }
        }

        private void summa_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (summa_radioButton.Checked == true)
            {
                kollicestvo_textBox.Text = null;
                summa_textBox.Enabled = true;
                kollicestvo_textBox.Enabled = false;
                choose_button.Enabled = false;
                oplata_textBox.Text = null;
            }
        }


        private void kollicestvo_textBox_TextChanged(object sender, EventArgs e)
        {

            if (kollicestvo_textBox.Text == "")
            {
                choose_button.Enabled = false;
            }
            else
            {
                choose_button.Enabled = true;
            }

        }

        private void summa_textBox_TextChanged(object sender, EventArgs e)
        {
            //oplata_textBox.Text = tmp_label2.Text;
            if (summa_textBox.Text == "")
            {
                choose_button.Enabled = false;
            }
            else
            {
                choose_button.Enabled = true;
            }

        }

        private void choose_button_Click(object sender, EventArgs e)
        {

            if (kollicestvo_textBox.Enabled == true)
            {
                //if (tmp == 0)
                //{
                decimal oplata_old = Convert.ToDecimal(oplata_textBox.Text);
                tmp_label.Text = oplata_old.ToString();
                decimal oplata_new = Convert.ToDecimal(kollicestvo_textBox.Text);
                decimal result = oplata_old * oplata_new;
                oplata_textBox.Text = result.ToString();
                tmp++;
                choose_button.Enabled = false;
                if (oplata_textBox.Text!="" && oplata_cafe_textBox.Text!="")
                {
                    pay_button.Enabled = true;
                }
            }
            else
            {
                choose_button.Enabled = false;

                //decimal oplata_old = Convert.ToDecimal(tmp_label.Text);
                //decimal oplata_new = Convert.ToDecimal(summa_textBox.Text);
                //decimal result = oplata_old + oplata_new;
                //oplata_textBox.Text = result.ToString();
                oplata_textBox.Text = summa_textBox.Text;
                tmp++;
            }
        }

        private void Burger_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            kol_burqer_textBox.Enabled = true;
            kol_enerqetik_textBox.Enabled = false;
            kol_hot_dog__textBox.Enabled = false;
            kol_cola_textBox.Enabled = false;
        }

        private void Energetik_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            kol_enerqetik_textBox.Enabled = true;
            kol_burqer_textBox.Enabled = false;
            kol_hot_dog__textBox.Enabled = false;
            kol_cola_textBox.Enabled = false;
        }

        private void hotdog_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            kol_hot_dog__textBox.Enabled = true;
            kol_burqer_textBox.Enabled = false;
            kol_enerqetik_textBox.Enabled = false;
            kol_cola_textBox.Enabled = false;
        }

        private void Cola_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            kol_cola_textBox.Enabled = true;
            kol_burqer_textBox.Enabled = false;
            kol_enerqetik_textBox.Enabled = false;
            kol_hot_dog__textBox.Enabled = false;
        }


        public decimal burger_kollicestvo;
        public decimal result;
        private void kol_burqer_textBox_TextChanged(object sender, EventArgs e)
        {
            if (kol_burqer_textBox.Text == "")
            {
                choose_cafe_button.Enabled = false;
            }
            else
            {
                choose_cafe_button.Enabled = true;
                burger_kollicestvo = Convert.ToDecimal(kol_burqer_textBox.Text);
                result = burger_kollicestvo * price_cafe[0];
            }
        }

        private void kol_enerqetik_textBox_TextChanged(object sender, EventArgs e)
        {
            if (kol_enerqetik_textBox.Text == "")
            {
                choose_cafe_button.Enabled = false;
            }
            else
            {
                choose_cafe_button.Enabled = true;
                decimal energy_kol = decimal.Parse(kol_enerqetik_textBox.Text);
                decimal result_energy = price_cafe[1] * energy_kol;
                result += result_energy;
            }
        }

        private void kol_hot_dog__textBox_TextChanged(object sender, EventArgs e)
        {
            if (kol_hot_dog__textBox.Text == "")
            {
                choose_cafe_button.Enabled = false;
            }
            else
            {
                choose_cafe_button.Enabled = true;
                decimal hot_dog_kol = decimal.Parse(kol_hot_dog__textBox.Text);
                decimal result_hotdog = price_cafe[2] * hot_dog_kol;
                result += result_hotdog;
            }
        }

        private void kol_cola_textBox_TextChanged(object sender, EventArgs e)
        {
            if (kol_cola_textBox.Text == "")
            {
                choose_cafe_button.Enabled = false;
            }
            else
            {
                choose_cafe_button.Enabled = true;
                decimal cola_kol = Convert.ToDecimal(kol_cola_textBox.Text);
                decimal result_cola = price_cafe[3] * cola_kol;
                result += result_cola;
            }
        }

        //
        private void choose_cafe_button_Click(object sender, EventArgs e)
        {
            oplata_cafe_textBox.Text = result.ToString();
            choose_cafe_button.Enabled = false;
            if (oplata_textBox.Text != "" && oplata_cafe_textBox.Text != "")
            {
                pay_button.Enabled = true;
            }
        }

        private void pay_button_Click(object sender, EventArgs e)
        {
            //if (vseqo_oplata_label.Text == "")
            //{
            //    pay_button.Enabled = false;
            //}
            //else
            //{
                pay_button.Enabled = true;
                decimal xz_1 = Convert.ToDecimal(oplata_textBox.Text);
                decimal xz_2 = Convert.ToDecimal(oplata_cafe_textBox.Text);
                decimal result = xz_1 + xz_2;
                vseqo_oplata_label.Text = result.ToString();
                pay_button.Enabled = false;
                Thread.Sleep(10000);//cerez 10 sekund knopka reset budet aktivna
                reset_button.Enabled = true;
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            kollicestvo_textBox.Text = null;
            summa_textBox.Text = null;
            kol_burqer_textBox.Text = null;
            kol_hot_dog__textBox.Text = null;
            kol_cola_textBox.Text = null;
            kol_enerqetik_textBox.Text = null;
            oplata_textBox.Text=null;
            oplata_cafe_textBox.Text= null;
            vseqo_oplata_label.Text=null;
        }
    }
}