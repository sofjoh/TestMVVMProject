using PropertyChanged;
using TestMVVMProject.Commands;
using System.Windows.Input;
using TestMVVMProject.Commands;
namespace TestMVVMProject.ViewModels;

////AddINotifyPropertyChangedInterface gör att klassen kan notifiera när en egenskap ändras.
//WPF använder detta för att uppdatera UI när en egenskap ändras i vår vymodell.
[AddINotifyPropertyChangedInterface]
public class CounterGameViewModel
{
    //Count och Title är en properties som view kan binda till.
    public int Count { get; set; }
    public string Title { get; set; }

    //IncreaseCommand är ett ICommand-objekt som View kan köra.
    //Tänk på ICommand som en koppling mellan en knapp i XAML och en metod i din ViewModel.
    public ICommand IncreaseCommand { get; private set; }
    public CounterGameViewModel()
    {
        Title = "Counter Game";
        Count = 0;
        //Här i konstruktorn skapar vi kommandot IncreaseCommand och kopplar det till metoden IncreaseCount.
        IncreaseCommand = new RelayCommand(
            _ => IncreaseCount());
    }

    private void IncreaseCount()
    {
        Count++;
    }
}
