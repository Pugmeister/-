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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            int num;
            int Num;
            bool isNum = true;
            if ((isNum == int.TryParse(textBox5.Text, out num)) && (isNum == int.TryParse(textBox7.Text, out Num)))
            {
                foreach (People item in Form1.table_of_people)
                {
                    if (item.code - index < 2)
                        index = item.code;
                }
                index++;

                People people = new People(index, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text), textBox6.Text, Convert.ToInt32(textBox7.Text));
                Form1.table_of_people.Add(people);
                this.Close();
            }
            else
                MessageBox.Show("В поле 'Дата поступления' должнен быть только год, а в поле '' только числа");
        }

        private void Add_Load(object sender, EventArgs e)
        {

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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
