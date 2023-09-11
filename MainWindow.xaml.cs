using BudgetApp.ViewModels;
using BudgetApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BudgetApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();

            this.PreviewMouseWheel += MainWindow_PreviewMouseWheel;
        }

        private void MainWindow_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            // Get the current vertical scroll position of the main content
            double currentVerticalOffset = MainScrollViewer.VerticalOffset;

            // Calculate the new vertical scroll position based on the mouse wheel delta
            double newVerticalOffset = currentVerticalOffset - e.Delta;

            // Ensure that the new offset stays within the scrollable range
            if (newVerticalOffset < 0)
            {
                newVerticalOffset = 0;
            }
            else if (newVerticalOffset > MainScrollViewer.ScrollableHeight)
            {
                newVerticalOffset = MainScrollViewer.ScrollableHeight;
            }

            // Update the vertical scroll position of the main content
            MainScrollViewer.ScrollToVerticalOffset(newVerticalOffset);

            // Mark the event as handled to prevent other elements from scrolling
            e.Handled = true;
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            //Debug.WriteLine("Clicked");
        }

        private void PlusButton_MouseEnter(object sender, MouseEventArgs e)
        {
            PlusBorder.BorderBrush = new SolidColorBrush(Colors.GreenYellow);
            PlusBorder.Background = new SolidColorBrush(Colors.Green);
        }

        private void PlusButton_MouseLeave(object sender, MouseEventArgs e)
        {
            PlusBorder.BorderBrush = new SolidColorBrush(Colors.Green);
            PlusBorder.Background = new SolidColorBrush(Colors.GreenYellow);
        }

        
    }
}
