using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_is
{
    public class CompanySalaryModel
    {
        public double CalculateAverage(List<double> salaries)
        {
            if (salaries == null || salaries.Count == 0)
                return 0;

            return salaries.Average();
        }
    }
}
