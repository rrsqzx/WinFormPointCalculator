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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        char checklist1, checklist2;
        private void CheckBox1_CheckedChanged(object sender, EventArgs e) //1
        {
            checklist1 = 'a';
            checkBox2.Enabled = false; checkBox3.Enabled = false;

            if (checkBox1.Checked == false)
            {
                checkBox2.Enabled = true; checkBox3.Enabled = true;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e) //2
        {
            checklist1 = 'b';
            checkBox1.Enabled = false; checkBox3.Enabled = false;

            if (checkBox2.Checked == false)
            {
                checkBox1.Enabled = true; checkBox3.Enabled = true;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e) //3
        {
            checklist1 = 'c';
            checkBox1.Enabled = false; checkBox2.Enabled = false;

            if (checkBox3.Checked == false)
            {
                checkBox1.Enabled = true; checkBox2.Enabled = true;
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e) //4
        {
            checklist2 = 'x';
            checkBox5.Enabled = false; checkBox6.Enabled = false;

            if (checkBox4.Checked == false)
            {
                checkBox5.Enabled = true; checkBox6.Enabled = true;
            }

        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e) //5
        {
            checklist2 = 'y';
            checkBox4.Enabled = false; checkBox6.Enabled = false;

            if (checkBox5.Checked == false)
            {
                checkBox4.Enabled = true; checkBox6.Enabled = true;
            }
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e) //6
        {
            checklist2 = 'z';
            checkBox4.Enabled = false; checkBox5.Enabled = false;

            if (checkBox6.Checked == false)
            {
                checkBox4.Enabled = true; checkBox5.Enabled = true;
            }
        }

        double Value;

        private void TextBox1_TextChanged(object sender, EventArgs e)
        { }
        private void Button1_Click(object sender, EventArgs e)
        {
            Value = Convert.ToDouble(textBox1.Text); // String to double
            double answer=0;
            switch (checklist1)
            {
                case 'a':
                    switch (checklist2)
                    {
                        case 'x':
                            answer = Form1.datefrombox1 + Value;
                            break; 

                        case 'y':
                            answer = Form1.datefrombox2 + Value;
                            break;

                        case 'z':
                            answer = Form1.datefrombox3 + Value;
                            break;
                    }
                    break;

                case 'b':
                    switch (checklist2)
                    {
                        case 'x':
                            answer = Form1.datefrombox4 + Value;
                            break;

                        case 'y':
                            answer = Form1.datefrombox5 + Value;
                            break;

                        case 'z':
                            answer = Form1.datefrombox6 + Value;
                            break;
                    }
                    break;

                case 'c':
                    switch (checklist2)
                    {
                        case 'x':
                            answer = Form1.datefrombox7 + Value;
                            break;
                            
                        case 'y':
                            answer = Form1.datefrombox8 + Value;
                            break;

                        case 'z':
                            answer = Form1.datefrombox9 + Value;
                            break;
                    }
                    break;
            }
            label2.Text = "Answer:";
            label1.Text = Convert.ToString(answer);
        }
    }
}
