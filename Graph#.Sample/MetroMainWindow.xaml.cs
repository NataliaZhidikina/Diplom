using System.Windows;
using GraphSharp.Sample.ViewModel;
using Xceed.Wpf.Toolkit;
using System.Windows.Media;
using GraphSharp.Sample.Model;

namespace GraphSharp.Sample
{
    public partial class MetroMainWindow
    {
        public MetroMainWindow()
        {
            InitializeComponent();

            DataContext = new LayoutAnalyzerViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

      
    }
}