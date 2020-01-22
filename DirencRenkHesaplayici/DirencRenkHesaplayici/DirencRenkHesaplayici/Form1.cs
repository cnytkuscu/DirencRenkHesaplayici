using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirencRenkHesaplayici
{
    public partial class Form1 : Form
    {
        Color[] renkler = new Color[10] { Color.Black, Color.Brown, Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Purple, Color.Gray, Color.White };

        Color[] carpanRenk = new Color[10] { Color.Black, Color.Brown, Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Purple, Color.Gold, Color.Silver };
        Color[] toleransRenk = new Color[9] { Color.Brown, Color.Red, Color.Green, Color.Blue, Color.Purple, Color.Gray, Color.Gold,Color.Silver,Color.Transparent };

        double[] multiplier = new double[10] { 1,10,100,1000,10000,100000,1000000,10000000,0.1,0.01 };
        double[] tolerance = new double[9] { 1, 2, 0.5, 0.25, 0.1, 0.05, 5, 10, 20 };
        double[] tempretureConstant = new double[7] { 100, 50, 15, 25, 10, 5, 1 };
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            //Minor bugx fixed.
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double resistorValue = Convert.ToDouble(((comboBox1.SelectedIndex * 10) + (comboBox2.SelectedIndex * 1)) *  multiplier[comboBox7.SelectedIndex]);

            label16.Text = resistorValue + " Ω ";
            double highToleranceGap = resistorValue + (resistorValue * tolerance[comboBox5.SelectedIndex]) / 100;
            double lowToleranceGap = resistorValue - (resistorValue * tolerance[comboBox5.SelectedIndex] / 100);
            label19.Text = "Tolerance Between " + highToleranceGap + " <---> " + lowToleranceGap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double resistorValue = Convert.ToDouble(((comboBox4.SelectedIndex * 100) + (comboBox3.SelectedIndex * 10) + (comboBox6.SelectedIndex * 1)) * multiplier[comboBox9.SelectedIndex]);

            label17.Text = resistorValue + " Ω ";
            double highToleranceGap = resistorValue + (resistorValue * tolerance[comboBox8.SelectedIndex]) / 100;
            double lowToleranceGap = resistorValue - (resistorValue * tolerance[comboBox8.SelectedIndex] / 100);
            label20.Text = "Tolerance Between " + highToleranceGap + " <---> " + lowToleranceGap;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double resistorValue = Convert.ToDouble(((comboBox14.SelectedIndex * 100) + (comboBox13.SelectedIndex * 10) + (comboBox12.SelectedIndex * 1)) *  multiplier[comboBox11.SelectedIndex]);

            label18.Text = resistorValue + " Ω ";
            double highToleranceGap = resistorValue + (resistorValue * tolerance[comboBox10.SelectedIndex]) / 100;
            double lowToleranceGap = resistorValue - (resistorValue * tolerance[comboBox10.SelectedIndex] / 100);
            label21.Text = "Tolerance Between " + highToleranceGap + " <---> " + lowToleranceGap;
            label22.Text = "Tempreture Constant is : " + tempretureConstant[comboBox15.SelectedIndex] + " PPM ";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.BackColor = renkler[comboBox1.SelectedIndex];
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.BackColor = renkler[comboBox2.SelectedIndex];
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel3.BackColor = carpanRenk[comboBox7.SelectedIndex];
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel4.BackColor = toleransRenk[comboBox5.SelectedIndex];
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel5.BackColor = renkler[comboBox4.SelectedIndex];
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel6.BackColor = renkler[comboBox3.SelectedIndex];
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel7.BackColor = renkler[comboBox6.SelectedIndex];
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel8.BackColor = carpanRenk[comboBox9.SelectedIndex];
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel9.BackColor = toleransRenk[comboBox8.SelectedIndex];
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
