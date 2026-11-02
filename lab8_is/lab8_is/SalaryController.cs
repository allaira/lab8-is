using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_is
{
    public class SalaryController
    {
        private readonly CompanySalaryModel model = new CompanySalaryModel();

        public double GetAverageSalary(List<double> salaries)
        {
            return model.CalculateAverage(salaries);
        }
    }
}
