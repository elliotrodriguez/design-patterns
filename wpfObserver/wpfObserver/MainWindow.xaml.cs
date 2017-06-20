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
using wpfObserver.Models;
using wpfObserver.Observers;

namespace wpfObserver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Person _person;
        public MainWindow()
        {
            InitializeComponent();
            _person = new Person();
            PersonPanel.DataContext = _person;
            _person.Attach(new StatusUpdater(Status));
            _person.Attach(new EmailFieldFormatter(Email));
        }
    }
}
