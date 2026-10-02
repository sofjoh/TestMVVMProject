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
    //Här ser man att CurrentGame är en CounterGameViewModel. Alltså en annan vymodell som MainShellViewModel använder.
    //WPF kommer därför gå till App.xaml och leta efter en resurs som heter CounterGameViewModel.
    public CounterGameViewModel CurrentGame { get; set; }
    public ICommand ChangeTitleCommand { get; private set; }
    public string MainTitle { get; set; }
    public MainShellViewModel()
    {
        MainTitle = "Starttitel";
        CurrentGame = new CounterGameViewModel();
        ChangeTitleCommand = new RelayCommand(
            p => ChangeTitle(p?.ToString() ?? MainTitle));
    }

    private void ChangeTitle(string title)
    {
        MainTitle = title;
    }
}