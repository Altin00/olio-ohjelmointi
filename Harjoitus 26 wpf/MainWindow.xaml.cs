using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using TaskManagerApp.Models;

namespace Harjoitus_26_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }
    }
}


namespace TaskManagerApp
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Task> tasks = new ObservableCollection<Task>();

        public MainWindow()
        {
            InitializeComponent();
            TasksListBox.ItemsSource = tasks;
            TypeComboBox.SelectionChanged += TypeComboBox_SelectionChanged;
        }

        private void TypeComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (TypeComboBox.SelectedItem != null)
            {
                var selectedType = (TypeComboBox.SelectedItem as System.Windows.Controls.ComboBoxItem)?.Content.ToString();
                if (selectedType == "Work")
                {
                    ExtraInfoTextBlock.Text = "Project Name:";
                    ExtraInfoTextBlock.Visibility = Visibility.Visible;
                    ExtraInfoTextBox.Visibility = Visibility.Visible;
                }
                else if (selectedType == "Personal")
                {
                    ExtraInfoTextBlock.Text = "Location:";
                    ExtraInfoTextBlock.Visibility = Visibility.Visible;
                    ExtraInfoTextBox.Visibility = Visibility.Visible;
                }
                else
                {
                    ExtraInfoTextBlock.Visibility = Visibility.Collapsed;
                    ExtraInfoTextBox.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var title = TitleTextBox.Text;
                var description = DescriptionTextBox.Text;
                var dueDate = DueDatePicker.SelectedDate ?? DateTime.Now;
                var type = (TypeComboBox.SelectedItem as System.Windows.Controls.ComboBoxItem)?.Content.ToString();
                var extraInfo = ExtraInfoTextBox.Text;

                Task newTask = null;

                switch (type)
                {
                    case "Work":
                        newTask = new WorkTask(title, description, dueDate, extraInfo);
                        break;
                    case "Personal":
                        newTask = new PersonalTask(title, description, dueDate, extraInfo);
                        break;
                    default:
                        throw new Exception("Invalid task type");
                }

                tasks.Add(newTask);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding task: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            TitleTextBox.Clear();
            DescriptionTextBox.Clear();
            DueDatePicker.SelectedDate = null;
            TypeComboBox.SelectedItem = null;
            ExtraInfoTextBox.Clear();
            ExtraInfoTextBlock.Visibility = Visibility.Collapsed;
            ExtraInfoTextBox.Visibility = Visibility.Collapsed;
        }

        private void SaveTasksButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("tasks.json", json);
                MessageBox.Show("Tasks saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving tasks: {ex.Message}");
            }
        }

        private void LoadTasksButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (File.Exists("tasks.json"))
                {
                    var json = File.ReadAllText("tasks.json");
                    var loadedTasks = JsonSerializer.Deserialize<ObservableCollection<Task>>(json);
                    tasks.Clear();
                    foreach (var task in loadedTasks)
                    {
                        tasks.Add(task);
                    }
                    MessageBox.Show("Tasks loaded successfully.");
                }
                else
                {
                    MessageBox.Show("No saved tasks found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tasks: {ex.Message}");
            }
        }
    }
}
