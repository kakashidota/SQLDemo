
using Microsoft.EntityFrameworkCore;
using SQLDemo.Data;
using SQLDemo.Db;
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

namespace SQLDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StudentDBContext _dbContext;
        public MainWindow()
        {
            InitializeComponent();
            _dbContext = new StudentDBContext();
            LoadStudents();
        }

        private void LoadStudents()
        {
            var students = _dbContext._Students.ToList();
            StudentListBox.ItemsSource = students;
        }

        private void AddStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            var studentName = StudentNameTextBox.Text;


            var newStudent = new Student();
            newStudent.Name = studentName;

            _dbContext._Students.Add(newStudent);
            _dbContext.SaveChanges();

            StudentNameTextBox.Text = string.Empty;
            LoadStudents();

        }

        private void DeleteStudentBtn_Click(object sender, RoutedEventArgs e)
        {

            var selectedStudent = StudentListBox.SelectedItem as Student;
            
            if(selectedStudent != null)
            {
                _dbContext._Students.Remove(selectedStudent);
                _dbContext.SaveChanges();
                LoadStudents();
            }


        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {

            var selectedStudent = StudentListBox.SelectedItem as Student;

            var studentToUpdate = _dbContext._Students.FirstOrDefault(s => s.Id == selectedStudent.Id);

            studentToUpdate.Name = "potatis";
            _dbContext.SaveChanges();
            LoadStudents();
            
        }

    }
}
