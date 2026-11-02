using System.Collections.Generic;
using System.Linq;

namespace MVP
{
    public interface ISalaryModel
    {
        double CalculateAverage(List<double> salaries);
    }

    public class CompanySalaryModel : ISalaryModel
    {
        public double CalculateAverage(List<double> salaries)
        {
            if (salaries == null || salaries.Count == 0)
                return 0;

            return salaries.Average();
        }
    }
}