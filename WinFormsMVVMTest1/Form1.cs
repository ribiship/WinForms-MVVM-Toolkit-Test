using WinFormsMVVMTest1.ViewModels;

namespace WinFormsMVVMTest1
{

	public partial class Form1 : Form
	{
		// the viewmodel for the form
		internal PersonVM? PersonVM { get; set; }

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// the viewmodel is set in program.Main()

			if (PersonVM is null)
			{
				throw new ArgumentNullException(nameof(PersonVM), "Person view model can not be null");
			}

			// here we bind all UI elements to the ViewModel, in other frameworks this can be done declaratively

			// The DataSourceUpdateMode.OnPropertyChanged makes sure that the FullName property is immediately updated
			//   whenever the property changes (e.g. when typing in the textbox)
			_ = txtFirstName.DataBindings.Add("Text", PersonVM, "Person.FirstName", true, DataSourceUpdateMode.OnPropertyChanged);
			_ = txtLastName.DataBindings.Add("Text", PersonVM, "Person.LastName", true, DataSourceUpdateMode.OnPropertyChanged);
			_ = lblFullName.DataBindings.Add("Text", PersonVM, "Person.FullName");

			// invoke the ResetCommand on the ViewModel
			resetToolStripMenuItem.Click += (object? sender, EventArgs e) => PersonVM.ResetCommand.Execute(null);
		}

	}
}