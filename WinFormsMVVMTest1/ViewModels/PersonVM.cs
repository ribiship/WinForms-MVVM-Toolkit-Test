using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

using System.Windows.Input;

using WinFormsMVVMTest1.Models;

namespace WinFormsMVVMTest1.ViewModels
{
	[INotifyPropertyChanged]
	internal partial class PersonVM
	{
		// the person this is the ViewModel for
		[ObservableProperty]
		private Person? _person;

		public ICommand ResetCommand { get; }

		public PersonVM()
		{
			ResetCommand = new RelayCommand(Reset);
		}

		public PersonVM(Person person) : this()
		{
			_person = person;
		}

		private void Reset()
		{
			if (_person != null)
			{
				_person.FirstName = "John";
				_person.LastName = "Doe";
			}
		}
	}
}
