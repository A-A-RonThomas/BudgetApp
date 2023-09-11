using BudgetApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Commands
{
    public class AddCategory : CommandBase
    {
        private readonly MainViewModel _viewModel;

        public override void Execute(object? parameter)
        {
            _viewModel.Items.Add(new Views.BudgetCategoryView());
        }

        public AddCategory(MainViewModel viewModel)
        {
            _viewModel = viewModel;
        }
    }
}
