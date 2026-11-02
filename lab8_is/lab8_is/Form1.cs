using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8_is
{
    public partial class Form1 : Form
    {
        private readonly SalaryController controller = new SalaryController();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> salaries = txtSalaries.Text
                    .Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => Convert.ToDouble(s.Trim()))
                    .ToList();

                double avg = controller.GetAverageSalary(salaries);
                lblResult.Text = $"Середня зарплата = {avg:F2} грн";
            }
            catch
            {
                MessageBox.Show("Помилка введення даних! Введіть числа через кому.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
