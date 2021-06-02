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
using System.Text.RegularExpressions;

namespace WpfApp_LAB4_zadanie1_w61933
{
    /// <summary>
    /// Logika interakcji dla klasy Student_Edit.xaml
    /// </summary>
    public partial class Student_Edit : Window
    {
        public Student student;
        public Student_Edit(Student student = null)
        {
            if (student != null)
            {
                tbName.Text = student.imie;
                tbSurname.Text = student.nazwisko;
                tbID.Text = student.nrIndeksu.ToString();
                tbDepart.Text = student.wydzial;
            }
            this.student = student ?? new Student();

        }
        
        public Student_Edit()
        {
            InitializeComponent();
        }

        private void bOK_Click(object sender, RoutedEventArgs e)
        {
            //if (!Regex.IsMatch(tbName.Text, @"^\p{Lu} \p{Ll}{1,12}$")
            //    || !Regex.IsMatch(tbSurname.Text, @"^\p{Lu} \p{Ll}{1,12}$")
            //    || !Regex.IsMatch(tbDepart.Text, @"^\p{Lu} \p{Ll}{1,12}$")
            //    || !Regex.IsMatch(tbID.Text, @"^[0-9]{4,10}$"))
            //{
            //    MessageBox.Show("Podano błędne dane!");
            //    return;
            //}
            //else
            //{
                student.imie = tbName.Text;
                student.nazwisko = tbSurname.Text;
                student.nrIndeksu = int.Parse(tbID.Text);
                student.wydzial = tbDepart.Text;

                this.DialogResult = true;
            

        }
    }
}
