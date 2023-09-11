using BudgetApp.Commands;
using BudgetApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;

namespace BudgetApp.ViewModels
{
	public class MainViewModel : ViewModelBase
    {
        private string _month;
        public string Month
        {
            get
            {
                return _month;
            }
            set
            {
                _month = value;
                OnPropertyChanged(nameof(Month));
            }
        }

        private ObservableCollection<BudgetCategoryView> _items;
        public ObservableCollection<BudgetCategoryView> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                OnPropertyChanged(nameof(Items));
            }
        }

        public ICommand AddCategory { get; }
        public MainViewModel() 
        {
            Month = DateTime.Now.ToString("Y");
            Items = new ObservableCollection<BudgetCategoryView>();

            AddCategory = new AddCategory(this);
        }
    }
}
