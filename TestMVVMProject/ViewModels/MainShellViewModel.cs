using PropertyChanged;
using TestMVVMProject.Commands;
using System.Windows.Input;
namespace TestMVVMProject.ViewModels;

//Lägger till INotifyPropertyChanged interfacet till klassen MainShellViewModel
//Detta gör att klassen kan notifiera när en egenskap ändras.
//WPF använder detta för att uppdatera UI när en egenskap ändras i vår vymodell.
[AddINotifyPropertyChangedInterface]
public class MainShellViewModel
{
    //Title är en property som view kan binda till.
    //Samma med Count.
    public string Title { get; set; }
    public int Count { get; set; }

    //IncreaseCommand är ett ICommand-objekt som View kan köra.
    //Tänk på ICommand som en koppling mellan en knapp i XAML och en metod i din ViewModel.
    public ICommand IncreaseCommand { get; private set; }
    public MainShellViewModel()
    {
        Title = "Min lilla MVVM-app";
        Count = 0;
        //Här i konstruktorn skapar vi kommandot IncreaseCommand och kopplar det till metoden IncreaseCount.
        IncreaseCommand = new RelayCommand(
            //Detta betyder att när kommandot körs, kommer metoden IncreaseCount att anropas. (_ betyder att vi inte skickar in någon parameter)
            _ => IncreaseCount());
    }
    private void IncreaseCount()
    {
        Count++;
    }
}