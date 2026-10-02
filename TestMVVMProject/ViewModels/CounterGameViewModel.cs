using PropertyChanged;
using TestMVVMProject.Commands;
using System.Windows.Input;
using TestMVVMProject.Commands;
namespace TestMVVMProject.ViewModels;

[AddINotifyPropertyChangedInterface]
public class CounterGameViewModel
{
    public int Count { get; set; }
    public string Title { get; set; }
    public ICommand IncreaseCommand { get; private set; }
    public CounterGameViewModel()
    {
        Title = "Counter Game";
        Count = 0;
        IncreaseCommand = new RelayCommand(
            _ => Count++);
    }
}
