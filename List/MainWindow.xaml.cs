using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Security.Policy;

namespace List
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int index1 = 0;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void status_checked(object sender, EventArgs e)
        {
            if (IsActive) MessageBox.Show("Задача выполнена");
        }

        private void sozdat_click(object sender, RoutedEventArgs e)
        {
            grid_data.Visibility = Visibility.Hidden;
            grid_window.Visibility = Visibility.Visible;
        }
        private void add_click(object sender, RoutedEventArgs e)
        {
            index1++;
            TaskList tList = new TaskList()
            {
                Index = index1,
                Task = textbox.Text.ToString(),
            };
            tasksList.Items.Add(tList);
            grid_data.Visibility=Visibility.Visible;
            grid_window.Visibility=Visibility.Hidden;
        }
        private void delete_click(object sender, RoutedEventArgs e)
        {
            tasksList.Items.Remove(tasksList.SelectedIndex);
            tasksList.Items.Refresh();
        }
    }
    public class TaskList
    {
        public int Index { get; set; }
        public string Task { get; set; }

        
    }
    

}
