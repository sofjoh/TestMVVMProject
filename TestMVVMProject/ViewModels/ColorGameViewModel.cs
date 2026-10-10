using PropertyChanged;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Text;
using TestMVVMProject.Commands;
using System.Windows.Input;
namespace TestMVVMProject.ViewModels;

[AddINotifyPropertyChangedInterface]
public class ColorGameViewModel
{
    public bool IsClicked { get; set; }

    public ICommand IsClickedCommand { get; private set; }

    public ColorGameViewModel()
    {
        IsClicked = false;
        IsClickedCommand = new RelayCommand(_ => ToggleIsClicked());
    }

    private void ToggleIsClicked()
    {
        IsClicked = !IsClicked;

    }
}
