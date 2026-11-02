using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MVVM
{
    public class SalaryModel
    {
        public double CalculateAverage(List<double> salaries)
        {
            if (salaries == null || salaries.Count == 0)
                return 0;

            return salaries.Average();
        }
    }
    public class MainVM : INotifyPropertyChanged
    {
        private readonly SalaryModel _model = new SalaryModel();
        private string _salariesInput = ""; // Порожнє за замовчуванням
        private double _averageSalary;

        public string SalariesInput
        {
            get => _salariesInput;
            set
            {
                _salariesInput = value;
                OnPropertyChanged();
            }
        }

        public double AverageSalary
        {
            get => _averageSalary;
            private set
            {
                _averageSalary = value;
                OnPropertyChanged();
            }
        }

        public ICommand CalculateCommand { get; }

        public MainVM()
        {
            CalculateCommand = new RelayCommand(Calculate);
        }

        private void Calculate()
        {
            try
            {
                var list = _salariesInput
                    .Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => Convert.ToDouble(s.Trim()))
                    .ToList();

                AverageSalary = _model.CalculateAverage(list);
            }
            catch
            {
                AverageSalary = 0;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    // Клас-команда для зв'язування кнопки в MVVM
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        public RelayCommand(Action execute) => _execute = execute;
        public bool CanExecute(object? parameter) => true;
        public void Execute(object? parameter) => _execute();
        public event EventHandler? CanExecuteChanged;
    }
}