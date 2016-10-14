using System;
using System.ComponentModel;

using Xamarin.Forms;

namespace MVVMSample.ViewModels
{
	public class MainPageViewModels : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		string text,aText;
		
		public MainPageViewModels()
		{

		}

		public string Text {
			get
			{
				return text;
			}
			set 
			{
				if (text != value)
				{
					text = value;
					OnPropertyChanged("Text");
					SetText();
					OnPropertyChanged("AText");
				}
				
			}
		}

		public string AText
		{
			get
			{
				return aText;
			}
			set { }
		}

		void SetText()
		{
			aText = text;
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}

