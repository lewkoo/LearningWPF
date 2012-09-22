using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Page_68
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //this.AddHandler(Window.MouseRightButtonDownEvent, new MouseButtonEventHandler(Window_MouseRightButtonDown), true); //Added from page 70
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Title = "Source = " + e.Source.GetType().Name + ", OriginalSource = " + e.OriginalSource.GetType().Name + " @ " + e.Timestamp;

            Control source = e.Source as Control;

            if (source != null)
            {
                if (source.BorderThickness == new Thickness(0))
                {
                    source.BorderThickness = new Thickness(5);
                    source.BorderBrush = Brushes.Black;
                }
                else
                    source.BorderThickness = new Thickness(0);
            }
        }
    }
}
