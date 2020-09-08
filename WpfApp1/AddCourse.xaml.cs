using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Entities.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AddCourse.xaml
    /// </summary>
    public partial class AddCourse : Window
    {
        private IMainWindowModel _model;

        public AddCourse(IMainWindowModel model)
        {
            _model = model;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          Course newCs= new Course(){CourseName =  CSName.Text};
            _model.AddCourse(newCs);
            MessageBox.Show("Course added");
        }

       
    }
}
