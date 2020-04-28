using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCheckApp
{
    public partial class Form1 : Form
    {
        protected string name;
        protected double basePrice;
        protected double package;
        protected double tradeIn;
        protected double salesTax;
        protected double totalPrice;

        bool isMakeChecked = false;
        bool isPackageChecked = false;
        bool isNameFilled = false;
        bool isTradeInFilled = false;
        bool preCheckPassed = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            // form function
            mazda = 19000.00;
            ford = 17000.00;
            honda = 20000.00;
            standard = 2000.00;
            lx = 5000.00;
        }

        // model and package
        protected double mazda, honda, ford;
        protected double standard, lx;


        // make radial buttons
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = System.Convert.ToString("$" + mazda);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = System.Convert.ToString("$" + honda);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = System.Convert.ToString("$" + ford);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = System.Convert.ToString("$" + standard);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = System.Convert.ToString("$" + lx);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            tradeIn = System.Convert.ToInt32(textBox4.Text);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // checks to make sure name, radials, and trade-in are filled before subtotalling.

        private void subTotalPreCheck()
        {

            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                isMakeChecked = true;
            }
            
            if (radioButton4.Checked == true || radioButton5.Checked == true)
            {
                isMakeChecked = true;
            }

            if (textBox1.Text != "")
            {
                isNameFilled = true;
            }

            if (textBox4.Text != "")
            {
                isTradeInFilled = true;
            }

            if (isMakeChecked == true && isNameFilled == true && isTradeInFilled == true)
            {

            }

        }
    }
}
