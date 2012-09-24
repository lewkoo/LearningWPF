using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDKSample
{

	class MyData : INotifyPropertyChanged
	{
		private string _colorName = "red";

		public string ColorName
		{
			get { return _colorName; }
			set
			{
				if (_colorName != value)
				{
					_colorName = value;
					NotifyPropertyChanged("ColorName");
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
