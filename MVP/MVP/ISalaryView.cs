using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    public interface ISalaryView
    {
        string SalariesInput { get; }
        void SetResult(double average);
        void ShowError(string message);
    }
}
