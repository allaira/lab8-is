using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    public class SalaryPresenter
    {
        private readonly ISalaryView _view;
        private readonly ISalaryModel _model;

        public SalaryPresenter(ISalaryView view, ISalaryModel model)
        {
            _view = view;   // Виправлено: присвоюємо значення полю _view, а не view = view
            _model = model; // Виправлено: присвоюємо значення полю _model, а не model = model
        }

        public void CalculateAverage()
        {
            try
            {
                var salaries = _view.SalariesInput
                    .Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => Convert.ToDouble(s.Trim()))
                    .ToList();

                double avg = _model.CalculateAverage(salaries);
                _view.SetResult(avg);
            }
            catch
            {
                _view.ShowError("Помилка введення даних!");
            }
        }
    }
}
