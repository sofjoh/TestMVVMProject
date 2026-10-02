using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Xml.Linq;
using TestMVVMProject.ViewModels;
namespace TestMVVMProject;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        //Det här är en central koppling: View → DataContext → ViewModel.
        //När MainWindow startar och DataContext är satt till MainShellViewModel så hamnar man i den MainShellViewModelns konstruktor.
        //Det betyder typ: MainWindow ska använda MainShellViewModel som sin källa för data och logik.
        //När du sedan använder databinding i MainWindow.xaml, letar WPF efter egenskaper i MainShellViewModel.
        //Alltså om du skriver: <TextBlock Text="{Binding Name}" />
        //Då letar WPF efter Name i MainShellViewModel.
        DataContext = new MainShellViewModel();
    }
}



