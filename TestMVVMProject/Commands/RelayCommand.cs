using System;
using System.Windows.Input;
namespace TestMVVMProject.Commands;

//Den här klassen implementerar ICommand och innehåller kod för två saker: vad som ska hända och, om man vill, om kommandot får köras.
//Den här koden behöver man INTE kunna skriva själv. Den kan hämtas och återanvändas. 
public class RelayCommand : ICommand
{
    private readonly Action<object> _execute;
    private readonly Func<object, bool> _canExecute;
    public RelayCommand(
        Action<object> execute,
        Func<object, bool> canExecute = null)
    {
        _execute = execute
            ?? throw new ArgumentNullException(nameof(execute));
        _canExecute = canExecute;
    }
    public bool CanExecute(object parameter)
    {
        return _canExecute?.Invoke(parameter) ?? true;
    }
    public void Execute(object parameter)
    {
        _execute(parameter);
    }
    public event EventHandler CanExecuteChanged;
}

