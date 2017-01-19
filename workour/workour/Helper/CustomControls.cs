using System;
using Xamarin.Forms;

namespace workour
{
	public class MyEntry : Entry
	{
		public MyEntry()
		{
		}
	}

	public class MyButton : Button
	{

	}

	public class BorderedText : Image
	{
	}

	public class CheckBox : Image
	{
		public bool isChecked { get; set; }

		public CheckBox()
		{
			isChecked = false;
		}
	}

	public class BackgroundIRmage : Image
	{
		public bool isTapped { get; set; }
		public BackgroundIRmage()
		{
			isTapped = false;
		}
	}

}
