using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointCalculator
{
    public partial class Form1 : Form
    {
        public static double datefrombox1;
        public static double datefrombox2;
        public static double datefrombox3;
        public static double datefrombox4;
        public static double datefrombox5;
        public static double datefrombox6;
        public static double datefrombox7;
        public static double datefrombox8;
        public static double datefrombox9;
       
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Button1_Click(object sender, EventArgs e)
        {
            bool exept=false;
            try
            {
                datefrombox1 = Convert.ToDouble(textBox1.Text);
                datefrombox2 = Convert.ToDouble(textBox2.Text);
                datefrombox3 = Convert.ToDouble(textBox3.Text);
                datefrombox4 = Convert.ToDouble(textBox4.Text);
                datefrombox5 = Convert.ToDouble(textBox5.Text);
                datefrombox6 = Convert.ToDouble(textBox6.Text);
                datefrombox7 = Convert.ToDouble(textBox7.Text);
                datefrombox8 = Convert.ToDouble(textBox8.Text);
                datefrombox9 = Convert.ToDouble(textBox9.Text);
            }
            catch (FormatException)
            {
                exept = true;
                switch(choose)
                {
                    case '2': radioButton1.Checked = false; break;
                    case '3': radioButton2.Checked = false; break;
                    case '4': radioButton3.Checked = false; break;
                    case '5': radioButton4.Checked = false; break;
                }
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                MessageBox.Show("Format is wrong");
                
            }
            if (exept == false)
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                MessageBox.Show("Date accepted");
            }
        }
        char choose;
        Form2 Selected_Value = new Form2();
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            choose = '2';
            Selected_Value.Show();           
            if (radioButton1.Checked==false)
            { Selected_Value.Hide(); }
        }

        Form3 Another_Point = new Form3();
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            choose = '3';
            Another_Point.Show();
            if (radioButton2.Checked==false)
            { Another_Point.Hide(); }
        }
        Form4 Between_two_points = new Form4();
        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            choose = '4';
            Between_two_points.Show();
            if (radioButton3.Checked==false)
            { Between_two_points.Hide(); }
        }
        Form5 To_origin = new Form5();
        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            choose = '5';
            To_origin.Show();
            if (radioButton4.Checked==false)
            { To_origin.Hide(); }
        }
    }
}
