using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КурсоваяТРПО
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = -1;
            bool isNum = true;
            int Num;
            if (textBox1.Text != "")
            {
                foreach (People item in Form1.table_of_people)
                {
                    if (item.code == Convert.ToInt32(textBox1.Text))
                    {
                        index = item.code;

                        if (textBox8.Text != "")
                        {
                            Form1.table_of_people[index - 1].fam = textBox8.Text; 
                            item.fam = textBox8.Text;
                        }

                        if (textBox2.Text != "")
                        {
                            Form1.table_of_people[index - 1].pol = textBox2.Text; 
                            item.pol = textBox2.Text;
                        }
                        if (textBox3.Text != "")
                        {
                            Form1.table_of_people[index - 1].nazot = textBox3.Text; 
                            item.nazot = textBox3.Text;
                        }
                        if (textBox6.Text != "")
                        {
                            Form1.table_of_people[index - 1].db = textBox6.Text; 
                            item.db = textBox6.Text;
                        }

                        if (textBox7.Text != "")
                        {
                            if (isNum == int.TryParse(textBox7.Text, out Num))
                            {
                                Form1.table_of_people[index - 1].datepost = Int16.Parse(textBox7.Text);
                                item.datepost = Int16.Parse(textBox7.Text);
                            }
                            else
                                MessageBox.Show("В поле должны быть только целые числа");
                        }
                        if (textBox5.Text != "")
                        {
                            Form1.table_of_people[index - 1].dolj = textBox5.Text;
                            item.dolj = textBox5.Text;
                        }

                        if (textBox4.Text != "")
                        {
                            if (int.TryParse(textBox4.Text, out Num))
                            {
                                Form1.table_of_people[index - 1].oklad = Convert.ToInt32(textBox4.Text);
                                item.oklad = Convert.ToInt32(textBox4.Text);
                            }
                            else
                                MessageBox.Show("В поле должны быть только целые числа");
                        }
                    }
                }
                this.Close();
            }
            else
                MessageBox.Show("Вы не ввели код сотрудника");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
