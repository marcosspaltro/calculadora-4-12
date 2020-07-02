using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (lblDisplay.Text.IndexOf(",") == -1)


                lblDisplay.Text += ",";


            else

                lblDisplay.Text += "";


        }

        private void button11_Click(object sender, EventArgs e)
        {
            //{
            //    lbln2.Text = lblDisplay.Text;

            //    float valor1;
            //    float valor2;

            //    valor1 = float.Parse(lbln1.Text);
            //    valor2 = float.Parse(lbln2.Text);

            //    {
            //        switch (lblsigno.Text)
            //        {

            //       case  "+";
            //            lblDisplay.Text = (valor1 + valor2).ToString();
            //            break;

            //       case "-";
            //            lblDisplay.Text = (valor1 - valor2).ToString();
            //            break;

            //        case "/";
            //            lblDisplay.Text = (valor1 / valor2).ToString();
            //            break;

            //          case "*";
            //            lblDisplay.Text = (valor1 * valor2).ToString();
            //            break;
            //        }
            //    }
            //}

            {
                lbln2.Text = lblDisplay.Text;

                float valor1;
                float valor2;

                valor1 = float.Parse(lbln1.Text);
                valor2 = float.Parse(lbln2.Text);

                if (lblsigno.Text == "+")
                {
                    lblDisplay.Text = (valor1 + valor2).ToString();
                }
                if (lblsigno.Text == "-")
                {
                    lblDisplay.Text = (valor1 - valor2).ToString();
                }
                if (lblsigno.Text == "*")
                {
                    lblDisplay.Text = (valor1 * valor2).ToString();
                }
                if (lblsigno.Text == "/")
                {
                    lblDisplay.Text = (valor1 / valor2).ToString();
                }
                if (lblsigno.Text == "˄")
                {
                    double v1;
                    double v2;
                    v1 = double.Parse(lbln1.Text);
                    v2 = double.Parse(lbln2.Text);
                    lblDisplay.Text = Math.Pow(v1,v2).ToString();
                }


                lsthist.Items.Add(lbln1.Text + lblsigno.Text + lbln2.Text + "=" + lblDisplay.Text);

                lsthist.Items.Add("_____________________________________________");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mult_Click(object sender, EventArgs e)
        {

            {
                int buscarop = lbln1.Text.IndexOf("0");

                if (buscarop == 0)

                    lbln1.Text = lblDisplay.Text;

                else

                    lbln2.Text = lblDisplay.Text;
            }
            lblDisplay.Text = "0";
            lblsigno.Text = "*";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "1";
                }

            else
            {
                lblDisplay.Text += "1";
            }
            if (lbln2.Text!= "0")
            {
                lblDisplay.Text = "1";
                lbln1.Text = "0";
                lbln2.Text = "0";
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)

        {

        }

        private void mas_Click(object sender, EventArgs e)
        //ver
        {
            {
                int buscarop = lbln1.Text.IndexOf("0");
                int buscarop2 = lbln1.Text.IndexOf(Text);
                if (buscarop == 0)
                {
                    lbln1.Text = lblDisplay.Text;
                    if (buscarop2 == 0)

                        lbln1.Text = lblDisplay.Text;
                }
                else

                    lbln2.Text = lblDisplay.Text;
            }
            lblDisplay.Text = "0";
            lblsigno.Text = "+";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "2";

                }
                else
                {
                    lblDisplay.Text += "2";
                }
            if (lbln2.Text != "0")
            {
                lblDisplay.Text = "2";
                lbln1.Text = "0";
                lbln2.Text = "0";
            }
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "3";

                }
                else
                {
                    lblDisplay.Text += "3";
                }
            if (lbln2.Text != "0")
            {
                lblDisplay.Text = "3";
                lbln1.Text = "0";
                lbln2.Text = "0";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "4";

                }
                else
                {
                    lblDisplay.Text += "4";
                }
            if (lbln2.Text != "0")
            {
                lblDisplay.Text = "4";
                lbln1.Text = "0";
                lbln2.Text = "0";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "5";

                }
                else
                {
                    lblDisplay.Text += "5";
            }
            if (lbln2.Text != "0")
            {
                lblDisplay.Text = "5";
                lbln1.Text = "0";
                lbln2.Text = "0";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "6";

                }
                else
                {
                    lblDisplay.Text += "6";
                }
            if (lbln2.Text != "0")
            {
                lblDisplay.Text = "6";
                lbln1.Text = "0";
                lbln2.Text = "0";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "7";

                }
                else
                {
                    lblDisplay.Text += "7";
            }
            if (lbln2.Text != "0")
            {
                lblDisplay.Text = "7";
                lbln1.Text = "0";
                lbln2.Text = "0";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "8";

                }
                else
                {
                    lblDisplay.Text += "8";
                }
            if (lbln2.Text != "0")
            {
                lblDisplay.Text = "8";
                lbln1.Text = "0";
                lbln2.Text = "0";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "9";

                }
                else
                {
                    lblDisplay.Text += "9";
                }
            if (lbln2.Text != "0")
            {
                lblDisplay.Text = "9";
                lbln1.Text = "0";
                lbln2.Text = "0";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "0";

            }
            else
            {
                lblDisplay.Text += "0";
            }
            if (lbln2.Text != "0")
            {
                lblDisplay.Text = "0";
                lbln1.Text = "0";
                lbln2.Text = "0";
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            
                {
                    int buscarop = lbln1.Text.IndexOf("0");

                    if (buscarop == 0)

                        lbln1.Text = lblDisplay.Text;

                    else

                        lbln2.Text = lblDisplay.Text;
                }
                lblDisplay.Text = "0";
                lblsigno.Text = "/";

            }
        

        private void men_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            lbln1.Text = "0";
            lbln2.Text = "0";
            lblsigno.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int buscar = lblDisplay.Text.IndexOf("-");

            if (buscar == -1)

                lblDisplay.Text = "-" + lblDisplay.Text;

            else

                lblDisplay.Text = lblDisplay.Text.Substring(buscar + 1);

        }

        private void cmcMenos_Click(object sender, EventArgs e)
        {
            
                {
                    int buscarop = lbln1.Text.IndexOf("0");

                    if (buscarop == 0)

                        lbln1.Text = lblDisplay.Text;

                    else

                        lbln2.Text = lblDisplay.Text;
                }
                lblDisplay.Text = "0";
                lblsigno.Text = "-";

            
        }

        private void cdmmenor_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != ("0"))
            {
                lblDisplay.Text = lblDisplay.Text.Substring(0);
            }
        }

        private void cdmborrarizq_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length != 1)
            {
                lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1);
            }
            else
                lblDisplay.Text = "0";
        }

        private void cdmborrarder_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length != 1)
            {
                lblDisplay.Text = lblDisplay.Text.Substring(1);
            }
            else
                lblDisplay.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)

        {
            float memoria;
            float memoria1;
            memoria = float.Parse(lblDisplay.Text);
            memoria1 = float.Parse(lblmemoria.Text);

            memoria = float.Parse(lblDisplay.Text);
            memoria1 = float.Parse(lblmemoria.Text);
            lblDisplay.Text = "0";
            lblmemoria.Text = (memoria + memoria1).ToString();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            
                float memoria;
                float memoria1;
                memoria = float.Parse(lblDisplay.Text);
                memoria1 = float.Parse(lblmemoria.Text);
                lblDisplay.Text = "0";
                lblmemoria.Text = (memoria1 - memoria).ToString();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            lblDisplay.Text = lblmemoria.Text;
        }

        private void lblsigno_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            lblmemoria.Text = "0";
        }

        private void lsthist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsthist.SelectedIndex != (-1))

            {
                lsthist.Items.RemoveAt(lsthist.SelectedIndex + 1);
                lsthist.Items.RemoveAt(lsthist.SelectedIndex);
            }
        }

        private void lbln2_Click(object sender, EventArgs e)
        {

        }

        private void cdmpot_Click(object sender, EventArgs e)
        {
            {
                int buscarop = lbln1.Text.IndexOf("0");
                int buscarop2 = lbln1.Text.IndexOf(Text);
                if (buscarop == 0)
                {
                    lbln1.Text = lblDisplay.Text;
                    if (buscarop2 == 0)

                        lbln1.Text = lblDisplay.Text;
                }
                else

                    lbln2.Text = lblDisplay.Text;
            }
            lblDisplay.Text = "0";
            lblsigno.Text = "^";
        }
    }
}