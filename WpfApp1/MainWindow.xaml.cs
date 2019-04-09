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
using System.Data.SQLite;
using System.IO;
using Microsoft.Win32;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SQLiteConnection m_dbConnection;

        public MainWindow()
        {
            InitializeComponent();

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();

            string lab4 = dlg.FileName;

            m_dbConnection = new SQLiteConnection("Data Source=" + lab4 + ";Version=3;");
            ////открытие соединения с базой данных
            //m_dbConnection.Open();
            ////выполнение запросов
            ////закрытие соединения с базой данных
            //m_dbConnection.Close();
        }
    }

        
}
