using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI__lab_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(textBox1.Text);
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {


                switch (comboBox1.SelectedItem)
                {
                    case "Paint":
                        {
                            Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Accessories\\paint");
                            break;
                        }
                    case "Windows Media Player":
                        {
                            Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Accessories\\Windows Media Player");
                            break;
                        }
                    case "WordPad":
                        {
                            Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Accessories\\WordPad");
                            break;
                        }
                    case "Блокнот":
                        {
                            Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Accessories\\notepad");
                            break;
                        }
                    default:
                        Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Accessories\\" + comboBox1.Text);
                        break;

                }

            }
            catch (Exception ex)
            {
                Form2 form2 = new Form2("Помилка! Программа не знайдена.");
                form2.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Enter a message here";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                textBox1.Visible = true;
                label1.Visible = true;
            }
            else
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                textBox1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                textBox1.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                button4.Enabled = true;
                comboBox1.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
                comboBox1.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                label2.Visible = true;
                button4.Visible = true;
                comboBox1.Visible = true;
            }
            else
            {
                label2.Visible = false;
                button4.Visible = false;
                comboBox1.Visible = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
            }
        }
    }
}
