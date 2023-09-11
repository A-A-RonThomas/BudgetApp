using BudgetApp.Models;
using BudgetApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Commands
{
    public class AddItemCommand : CommandBase
    {
        private readonly BudgetCategoryViewModel _viewModel;
        private readonly ObservableCollection<Expense> _list;

        public override void Execute(object? parameter)
        {
            _viewModel.Expenses.Add(new Expense
            {
                ID = "Name",
                Planned = 0.00
            }) ;
        }

        public AddItemCommand(BudgetCategoryViewModel viewModel)
        {
            _viewModel = viewModel;
            _list = new ObservableCollection<Expense>();
        }
    }
}
