using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SQLitePCL;
using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IMainWindowModel _model;

        public MainWindow(IMainWindowModel model)
        {
            _model = model;
            InitializeComponent();
            //dataGrid1.ItemsSource = _main.GetStudentData();

        }
       
      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             AddStudentd addSudentWindow = new AddStudentd(_model);
            addSudentWindow.Show();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            AddCourse addCS = new AddCourse(_model);
            addCS.Show();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            AddStudentCourse stcs = new AddStudentCourse(_model);
            stcs.Show();
        }
    }
}
