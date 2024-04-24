using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ПР1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider2.Clear();
                errorProvider3.Clear();
                bool ok = true;
                double sum = 0;
                string s_sum = textBoxSum.Text;
                if (s_sum.Length > 0)
                    sum = double.Parse(textBoxSum.Text);
                string hobby_name = textBoxName.Text;
                string description = textBoxDescription.Text;
                if (string.IsNullOrEmpty(textBoxName.Text))
                {
                    errorProvider3.SetError(textBoxName, "Ошибка");
                    ok = false;
                }
                if (string.IsNullOrEmpty(textBoxDescription.Text))
                {
                    errorProvider2.SetError(textBoxDescription, "Ошибка");
                    ok = false;
                }
                if (ok)
                {
                    Form1.Arrays(sum, hobby_name, description);
                    Close();
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show("Ошибка:"+ee);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
        }
    }
}
