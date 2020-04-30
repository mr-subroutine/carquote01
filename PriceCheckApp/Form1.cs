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
        protected double subtotal;

        protected bool isMakeChecked = false;
        protected bool isPackageChecked = false;
        protected bool isNameFilled = false;
        protected bool isTradeInFilled = false;
        protected bool hasPreCheckPassed = false;

        // model and package
        protected double mazda = 19000.00;
        protected double honda = 17000.00;
        protected double ford = 20000.00;
        protected double standard = 2000.00;
        protected double lx = 5000.00;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // make radial buttons
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = System.Convert.ToString("$" + mazda);
            basePrice += mazda;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = System.Convert.ToString("$" + honda);
            basePrice += honda;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = System.Convert.ToString("$" + ford);
            basePrice += ford;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = System.Convert.ToString("$" + standard);
            package += standard;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = System.Convert.ToString("$" + lx);
            package += lx;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Double.TryParse(textBox4.Text, out tradeIn);
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
            name = textBox1.Text;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_compute_Click(object sender, EventArgs e)
        {
            // updates all GUI text if precheck passes
            bool isPrePassed = subTotalPreCheck();
            if (isPrePassed == true)
            {
                subtotal = basePrice + package + tradeIn;
                label10.Text = ("$" +subtotal.ToString());

                //get percentage for tax (8.4%) and updates
                double salesTax = (8.4 / 100) * subtotal;
                label11.Text = System.Convert.ToString("$" + salesTax);

                //adds subtotal and tax for total
                totalPrice = salesTax + subtotal;
                label12.Text = System.Convert.ToString("$" + totalPrice);
                
                // reset booleans
                resetCheckTriggers();
            }

            else
            {
                MessageBox.Show("Please make sure Name, Trade-in, Make and Package are filled in.");
                clearAll();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // checks to make sure name, radials, and trade-in are filled before subtotalling.

        private bool subTotalPreCheck()
        {

            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                isMakeChecked = true;
            }
            
            if (radioButton4.Checked == true || radioButton5.Checked == true)
            {
                isPackageChecked = true;
            }

            if (textBox1.Text != "")
            {
                isNameFilled = true;
            }

            if (textBox4.Text != "")
            {
                isTradeInFilled = true;
            }

            // checker for all checks
            if (isMakeChecked == true && isNameFilled == true && isTradeInFilled == true)
            {
                hasPreCheckPassed = true;
            }

            return hasPreCheckPassed;
        }

        private void resetCheckTriggers()
        {
            hasPreCheckPassed = false;
            isMakeChecked = false;
            isPackageChecked = false;
            isNameFilled = false;
            isTradeInFilled = false;

            // check for the check
            hasPreCheckPassed = false;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void clearAll()
        {
            resetCheckTriggers();
            textBox1.Clear();
            textBox4.Clear();
            clearAllLabels();
        }

        private void clearAllLabels()
        {
            label8.Text = "$0.00";
            label9.Text = "$0.00";
            label10.Text = "$0.00";
            label11.Text = "$0.00";
            label12.Text = "$0.00";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
