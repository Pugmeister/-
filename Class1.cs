using System;
using System.Collections.Generic;
using System.Text;

namespace КурсоваяТРПО
{
   public class People
    {
        public int code; // код сотрудника
        public string fam; // фамилия
        public string pol; // пол
        public string nazot; // название отдела
        public string db; // дата рождения
        public int datepost; // дата поступления
        public string dolj; // должность
        public int oklad; // Оклад

        public People(int code, string fam, string pol, string nazot, string db, int datepost, string dolj, int oklad)
        {
            this.code = code;
            this.fam = fam;
            this.pol = pol;
            this.nazot = nazot;
            this.db = db;
            this.datepost = datepost;
            this.dolj = dolj;
            this.oklad = oklad;
        }
        public string test()
        {
            string[] s = { "Бочкарёва", "Ж", "Отдел Образовния", "12.06.1984", "2010", "Преподаватель", "15000" };
            string test = "";
            string one = string.Join(Convert.ToString(' '), s);
            test += one;
            return one;
        }
    }

}
