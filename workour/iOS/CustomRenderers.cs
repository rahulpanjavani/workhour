using System;
using UIKit;
using workour;
using workour.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
[assembly: ExportRenderer(typeof(BorderedText), typeof(TextBorder))]
namespace workour.iOS
{
	class MyEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.SpellCheckingType = UITextSpellCheckingType.No;
				Control.BorderStyle = UITextBorderStyle.None ;
			}
		}
	}

	public class TextBorder : ImageRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
		{
			base.OnElementChanged(e);

			if (UIColor.LightGray != null)
			{
				Control.Layer.BorderColor = UIColor.White.CGColor;
			}
			Control.Layer.BorderWidth = 2;
			Control.Layer.CornerRadius = 5;

		}
	}


}
