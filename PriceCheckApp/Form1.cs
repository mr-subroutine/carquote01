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
        protected double mazda, honda, ford;
        protected double standard, lx;


        // make radial buttons
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // form function
        }
    }
}
