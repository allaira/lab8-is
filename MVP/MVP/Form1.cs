using System;
using System.Windows.Forms;

namespace MVP
{
    public partial class Form1 : Form, ISalaryView
    {
        private readonly SalaryPresenter presenter;

        public Form1()
        {
            InitializeComponent();
            presenter = new SalaryPresenter(this, new CompanySalaryModel());
        }

        public string SalariesInput => txtSalaries.Text;

        public void SetResult(double average)
        {
            lblResult.Text = $"Середня зарплата = {average:F2} грн";
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            presenter.CalculateAverage();
        }
    }
}