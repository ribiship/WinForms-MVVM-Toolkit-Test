using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace WinFormsMVVMTest1.Models
{
	[INotifyPropertyChanged]
	internal partial class Person
	{
		// Note that the [ObservableProperty] attribute turns this private string _firstName field into a public string FirstName property
		//   that raises INotifyPropertyChange notifications see.
		//   Check the code in the project under Analyzers/Microsoft.Toolkit.Mvvm.SourceGenerators/Microsoft.Toolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator
		[ObservableProperty]
		[AlsoNotifyChangeFor("FullName")]
		private string _firstName = "";

		[ObservableProperty]
		[AlsoNotifyChangeFor("FullName")]
		private string _lastName = "";

		public string FullName => (_firstName + " " + _lastName).Trim();

	}
}
