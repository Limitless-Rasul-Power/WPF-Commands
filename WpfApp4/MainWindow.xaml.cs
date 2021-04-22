using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
using WpfApp4.Command_for_Relay_Command;
using WpfApp4.Commands;


namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region RelayCommand

        public RelayCommand MessageCommand { get; set; }
        public RelayCommand SendCommand { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            MessageCommand = new RelayCommand(Display);
            SendCommand = new RelayCommand(Send);
        }


        public void Display(object parameter = null)
        {
            MessageBox.Show("Hello World.");
        }

        public void Send(object parameter = null)
        {
            MessageBox.Show("Send Successfully.");
        }

        #endregion

        #region DelegateCommand


        //public MessageCommand MessageCommand { get; set; }
        //public SendCommand SendCommand { get; set; }
        //public MainWindow()
        //{
        //    InitializeComponent();

        //    this.DataContext = this;
        //    MessageCommand = new MessageCommand(Display);
        //    SendCommand = new SendCommand(Send);

        //}
        //public string Text { get; set; }


        //public void Display()
        //{
        //    MessageBox.Show("Hakuna Matata.");
        //}

        //public void Send()
        //{
        //    MessageBox.Show("Message was sent successfully.");
        //}

        #endregion

        #region SingleUseCommand

        //public MainWindow()
        //{
        //    InitializeComponent();
        //    this.DataContext = this;
        //}

        //public string Text { get; set; }
        //private void Help_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        //{
        //    e.CanExecute = Text?.Length > 10 ? true : false;
        //}

        //private void Help_Executed(object sender, ExecutedRoutedEventArgs e)
        //{            
        //    Process.Start("Notepad.exe");
        //}

        #endregion

    }
}
