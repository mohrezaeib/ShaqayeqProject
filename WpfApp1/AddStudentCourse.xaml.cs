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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AddStudentCourse.xaml
    /// </summary>
    public partial class AddStudentCourse : Window
    {
        private IMainWindowModel _model;

        public AddStudentCourse(IMainWindowModel model)
        {
            _model = model;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int stid;
            int csid;
            if (int.TryParse(CSID.Text, out csid) && int.TryParse(STID.Text, out stid))
            {
                _model.AddStudentsCourse(stid, csid);
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }
    }
}
