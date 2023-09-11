using BudgetApp.Commands;
using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetApp.ViewModels
{
    public class BudgetCategoryViewModel : ViewModelBase
    {
		private ObservableCollection<Expense> _expenses = new ObservableCollection<Expense>();
		public ObservableCollection<Expense> Expenses
		{
			get
			{
				return _expenses;
			}
			set
			{
				_expenses = value;
				OnPropertyChanged(nameof(Expenses));
			}
		}

        public ICommand AddExpense { get; }
		public BudgetCategoryViewModel() 
		{

			Expenses = new ObservableCollection<Expense>();

			AddExpense = new AddItemCommand(this);
		}
    }
}
