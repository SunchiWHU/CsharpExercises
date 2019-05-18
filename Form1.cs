using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox3.ReadOnly = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBox3.Text = (long.Parse(this.textBox1.Text) * long.Parse(this.textBox2.Text)).ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("该数值不是整数,"+ex.Message);
            }
        }
    }
}
