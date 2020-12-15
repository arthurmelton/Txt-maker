using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace txt_maker
{
    public partial class Form1 : Form
    {

        string Location1 = Application.StartupPath + "\\numbers.txt";
        List<string> lines = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text == "")
            {
                MessageBox.Show("Please write a number");
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Please write a number");
            }

            if (textBox1.Text != "" && checkBox1.Checked == true && textBox2.Text != "")
            {
                int howManyTimes = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + 1;

                if (File.Exists(Location1))
                {
                    File.Delete(Location1);
                }

                lines.Clear();

                for (int i = int.Parse(textBox2.Text) + 1; i < howManyTimes ; i++)
                {
                    lines.Add(i.ToString());
                }

                File.WriteAllLines(Location1, lines);

                MessageBox.Show("Created File!");
            }
            if (textBox1.Text != "" && checkBox2.Checked == true && textBox2.Text != "")
            {
                int howManyTimes = (int.Parse(textBox1.Text) * 2) + int.Parse(textBox2.Text);

                if (File.Exists(Location1))
                {
                    File.Delete(Location1);
                }

                lines.Clear();

                for (int i = int.Parse(textBox2.Text) + 1; i < howManyTimes; i+=2)
                {
                    if (i % 2 == 0)
                    {
                        i++;
                        howManyTimes++;
                    }

                    lines.Add(i.ToString());
                }

                File.WriteAllLines(Location1, lines);

                MessageBox.Show("Created File!");
            }
            if (textBox1.Text != "" && checkBox3.Checked == true && textBox2.Text != "")
            {
                int howManyTimes = (int.Parse(textBox1.Text) * 2) + int.Parse(textBox2.Text);

                if (File.Exists(Location1))
                {
                    File.Delete(Location1);
                }

                lines.Clear();

                for (int i = int.Parse(textBox2.Text) + 1; i < howManyTimes; i += 2)
                {
                    if(Math.Abs(i)%2 == 1)
                    {
                        i++;
                        howManyTimes++;
                    }

                    lines.Add(i.ToString());
                }

                File.WriteAllLines(Location1, lines);

                MessageBox.Show("Created File!");
            }

            if (textBox1.Text != "" && checkBox4.Checked == true && textBox2.Text != "")
            {
                int howManyTimes = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + 1;

                if (File.Exists(Location1))
                {
                    File.Delete(Location1);
                }

                lines.Clear();

                for (int i = int.Parse(textBox2.Text) + 1; i < howManyTimes; i++)
                {
                    if(i < 0)
                    {
                        i = 1;

                        howManyTimes += Math.Abs(int.Parse(textBox2.Text));

                    }
                    lines.Add((i*i).ToString());
                }

                File.WriteAllLines(Location1, lines);

                MessageBox.Show("Created File!");
            }
            if (textBox1.Text != "" && checkBox5.Checked == true && textBox2.Text != "")
            {

                int howManyTimes = int.Parse(textBox1.Text) + 1;

                if (File.Exists(Location1))
                {
                    File.Delete(Location1);
                }

                lines.Clear();

                int i = 1;

                for (int b = int.Parse(textBox2.Text) + 1; i < howManyTimes; b++)
                {
                    int a = 0;
                    for (int x = 1; x <= b; x++)
                    {
                        if (b % x == 0)
                        {
                            a++;
                        }
                    }

                    if(a==2)
                    {
                        lines.Add(b.ToString());
                        i++;
                    }

                }

                File.WriteAllLines(Location1, lines);

                MessageBox.Show("Created File!");
            }

            if (textBox1.Text != "" && checkBox6.Checked == true && textBox2.Text != "")
            {

                int howManyTimes = int.Parse(textBox1.Text) + 1;

                if (File.Exists(Location1))
                {
                    File.Delete(Location1);
                }

                lines.Clear();

                int i = 1;

                for (int b = int.Parse(textBox2.Text) + 1; i < howManyTimes; b++)
                {
                    int a = 0;
                    for (int x = 1; x <= b; x++)
                    {
                        if (b % x == 0)
                        {
                            a++;
                        }
                    }

                    if (a != 2)
                    {
                        lines.Add(b.ToString());
                        i++;
                    }

                }

                File.WriteAllLines(Location1, lines);

                MessageBox.Show("Created File!");
            }

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true)
            {
                checkBox2.Checked = false;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true)
            {
                checkBox3.Checked = false;
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true)
            {
                checkBox4.Checked = false;
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true || checkBox6.Checked == true)
            {
                checkBox5.Checked = false;
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true || checkBox5.Checked == true)
            {
                checkBox6.Checked = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(!textBox2.Text.Contains("-"))
            {
                textBox2.Text = "-" + textBox2.Text;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 189)
            {
                if (!textBox2.Text.Contains("-"))
                {
                    textBox2.Text = "-" + textBox2.Text;
                }
            }
        }
    }
}
