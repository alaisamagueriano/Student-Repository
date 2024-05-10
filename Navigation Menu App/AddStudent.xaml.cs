using System;
using System.IO;
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
using System.Windows.Shapes;

namespace Navigation_Menu_App
{
    /// <summary>
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // This event is fired when text is changed in the TextBox.
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the text entered in the TextBox
            string studentName = StudentNameTextBox.Text;

            // Check if the name is not empty
            if (!string.IsNullOrEmpty(studentName))
            {
                try
                {
                    // Append the student name to the text file
                    File.AppendAllText("records.txt", studentName + Environment.NewLine);

                    // Optionally, you can clear the TextBox after saving
                    StudentNameTextBox.Clear();

                    MessageBox.Show("Student record saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while saving: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a student name.");
            }
        }
    }
}
