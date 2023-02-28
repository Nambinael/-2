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

namespace Прак_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<zametkashit> zalupa = new List<zametkashit>();
        public MainWindow()
        {
            InitializeComponent();
            NoteList.DisplayMemberPath = "NoteName";
            kalendarXuyini.Text = DateTime.Now.ToString();
            NoteList.ItemsSource = null;
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NoteList.ItemsSource = null;
            zametkashit zametkashitt = new zametkashit();
            zametkashitt.NoteTime = kalendarXuyini.DisplayDate;
            zametkashitt.NoteName = NoteNamer.Text;
            zametkashitt.Description = NoteTexter.Text;
            zalupa.Add(zametkashitt);
            NoteList.ItemsSource = zalupa;
            
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (NoteList.SelectedIndex != -1)
            {
                zalupa.Remove(NoteList.SelectedItem as zametkashit);
                NoteList.ItemsSource = null;
                NoteList.ItemsSource = zalupa;
            }
        }

        private void NoteList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NoteList.SelectedIndex != -1)
            {
                NoteNamer.Text = (NoteList.SelectedItem as zametkashit).NoteName;
                NoteTexter.Text = (NoteList.SelectedItem as zametkashit).Description;
            }

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NoteList.SelectedIndex != -1)
            {
                zametkashit zametkashitt = new zametkashit();
                zametkashitt.NoteTime = kalendarXuyini.DisplayDate;
                zametkashitt.NoteName = NoteNamer.Text;
                zametkashitt.Description = NoteTexter.Text;
                zalupa.Add(zametkashitt);

                zalupa.Remove(NoteList.SelectedItem as zametkashit);
                NoteList.ItemsSource = null;
                NoteList.ItemsSource = zalupa;
            }
        }
    }

}

