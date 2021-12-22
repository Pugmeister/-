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
    public partial class Increase : Form
    {
        int index = 0;
        public Increase()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool isNum = true;
            int num;
            if (label5.Text != "")
                if (textBox2.Text != "" && isNum == int.TryParse(textBox2.Text, out num))
                {
                    int X = Convert.ToInt32(Form1.table_of_people[index - 1].oklad) / 100 * Int16.Parse(textBox1.Text);
                    Form1.table_of_people[index - 1].oklad = Form1.table_of_people[index - 1].oklad + X;
                    this.Close();
                }
                else
                    MessageBox.Show("Вы не задали на сколько процентов надо увеличить оклад или ввели не в правильном формате");
            else
                MessageBox.Show("Сотрудник не выбран");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bool isNum = true;
            int num;
            if (textBox2.Text != "")
                if (isNum == int.TryParse(textBox2.Text, out num))
                {
                    foreach (People item in Form1.table_of_people)
                        if (item.code == Int16.Parse(textBox2.Text))
                        {
                            label5.Text = $"{item.oklad} рублей";
                            index = item.code;
                        }
                }
                else
                    MessageBox.Show("Вы вводите не в верном формате, код может содержать только целые числа");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Increase_Load(object sender, EventArgs e)
        {

        }
    }
}
