using System;
using workour;
using workour.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]

namespace workour.Droid
{
	public class MyEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				base.OnElementChanged(e);

				if (Control != null)
				{
					Control.SetBackgroundColor(global::Android.Graphics.Color.ParseColor("#00ffffff"));
					Control.InputType = Android.Text.InputTypes.TextFlagNoSuggestions;
					var h = Control.Height;

				}
			}
		}
	}
}
