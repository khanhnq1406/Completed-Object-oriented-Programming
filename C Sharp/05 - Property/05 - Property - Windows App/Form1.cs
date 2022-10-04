using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05___Property
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void name_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int birth_month_input_int = int.Parse(birth_month_input.Text);
            int birth_day_input_int = int.Parse(birth_day_input.Text);
            int birth_year_input_int = int.Parse(birth_year_input.Text);
            int hire_month_input_int = int.Parse(hire_month_input.Text);
            int hire_day_input_int = int.Parse(hire_day_input.Text);
            int hire_year_input_int = int.Parse(hire_year_input.Text);
            Employee employee = new Employee(first_name_input.Text, last_name_input.Text,
                                            birth_day_input_int, birth_month_input_int, birth_year_input_int,
                                            hire_day_input_int, hire_month_input_int, hire_year_input_int);
            if (employee.birthDate.day == -1)
                MessageBox.Show("Birthday invalid");
            if (employee.birthDate.month == -1)
                MessageBox.Show("Birthmonth invalid");
            if (employee.hireDate.month == -1)
                MessageBox.Show("Hiremonth invalid");
            if (employee.hireDate.month == -1)
                MessageBox.Show("Hiremonth invalid");
            if (employee.birthDate.day != -1 && employee.birthDate.month != -1 && employee.hireDate.day != -1 && employee.hireDate.month != -1 )
                MessageBox.Show(employee.ToEmployeeString());
        }
    }
}
