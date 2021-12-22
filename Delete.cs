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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            People people = new People(0, "", "", "", "", 0, "", 0);
            bool isNum = true;
            int num;
            if (isNum == int.TryParse(textBox1.Text, out num))
            {
                foreach (People item in Form1.table_of_people)
                {
                    if (item.code == Convert.ToInt32(textBox1.Text))
                    {
                        people = item;
                    }
                }
                if (people.code != 0)
                {
                    Form1.table_of_people.Remove(people);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Сотрудника с данным кодом не существует");
                }
            }
            else
                MessageBox.Show("В поле 'Введите код сотрудника, который нужно удалить' должны быть только целые числа");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
