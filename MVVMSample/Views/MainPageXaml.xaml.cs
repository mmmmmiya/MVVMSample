using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MVVMSample.Views
{
	public partial class MainPageXaml : ContentPage
	{
		public MainPageXaml()
		{
			InitializeComponent();

			var viewModel = new MVVMSample.ViewModels.MainPageViewModels();
			this.BindingContext = viewModel;
		}
	}
}
