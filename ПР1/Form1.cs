using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ПР1
{
    public partial class Form1 : Form
    {
        static List<Hobby> list = new List<Hobby>() { };
        int index = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "нет";
            textBox2.Text = "нет";
            textBox3.Text = "нет";
            textBox4.Text = "нет";
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void label2_Click(object sender, EventArgs e)
        { }

        private void textBox2_TextChanged(object sender, EventArgs e)
        { }

        private void textBox3_TextChanged(object sender, EventArgs e)
        { }

        private void label3_Click(object sender, EventArgs e)
        { }

        private void label4_Click(object sender, EventArgs e)
        { }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            Reload(index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index != 0)
                index -= 1;
            else
                index = list.Count - 1;
            Reload(index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (list.Count - 1 != index)
                index += 1;
            else
                index = 0;
            Reload(index);
        }
        public static void Arrays(double sum, string hobby_name, string description)
        {
            Hobby hobby = new Hobby(sum, hobby_name, description);
            list.Add(hobby);
            Form1 f = new Form1();
        }

        private void Reload(int i)
        {
            if (list.Count != 0)
            {
                Hobby element = list[i];
                textBox1.Text = element.hobby_name;
                textBox2.Text = element.description;
                textBox3.Text = Convert.ToString(element.sum);
                textBox4.Text = element.describe;
            }
            else
            {
                textBox1.Text = "нет";
                textBox2.Text = "нет";
                textBox3.Text = "нет";
                textBox4.Text = "нет";
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.RemoveAt(index);
            Reload(index);
        }
    }
}
