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
    /// Interaction logic for AddStudentd.xaml
    /// </summary>
    public partial class AddStudentd : Window
    {
        private Student _student;
        private IMainWindowModel _model;

        public AddStudentd(IMainWindowModel model)
        {
            InitializeComponent();
            _student = new Student();
            _model = model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int id;
            if (int.TryParse(UniId.Text, out id))
            {
               _student.UniId = id;
                int code;
                if (int.TryParse(StudentNational.Text, out code))
                {
                    _student.NationalCode = code;

                    // it's a valid integer => you could use the distance variable here
                }
                else
                {
                    MessageBox.Show("Intiger only ");

                }



                _student.Name = StudentName.Text;
                _student.LastName = StudentLastName.Text;
                Console.WriteLine(_student.LastName);
                Console.WriteLine(_student.UniId);
                Console.WriteLine(_student.Name);
                Console.WriteLine(_student.NationalCode);
                _model.AddStudent(_student);

                MessageBox.Show("Student added ");
            }
            else
            {
                MessageBox.Show("Intiger only ");

            }


           

        }
    }
}
