using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace workour
{
	public class ValidationBehaviors
	{
		public ValidationBehaviors()
		{
		}
	}

	class ValidateEmailBehavior : Behavior<Entry>
	{

		static readonly BindablePropertyKey IsValidPropertyKey = BindableProperty.CreateReadOnly("IsValid", typeof(bool), typeof(ValidateEmailBehavior), false);

		public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

		public bool IsValid
		{

			private set
			{
				SetValue(IsValidPropertyKey, value);
			}
			get
			{
				return (bool)GetValue(IsValidProperty);
			}
		}

		protected override void OnAttachedTo(Entry entry)
		{
			base.OnAttachedTo(entry);
			entry.TextChanged += OnEntryFieldTextchanged;
		}

		protected override void OnDetachingFrom(Entry entry)
		{
			base.OnDetachingFrom(entry);
			entry.TextChanged += OnEntryFieldTextchanged;
		}
		void OnEntryFieldTextchanged(object sender, TextChangedEventArgs e)
		{
			Entry entry = (Entry)sender;
			IsValid = IsValidEmail(entry.Text);
			entry.TextColor = IsValidEmail(entry.Text) ? Color.FromHex("#b5b3b5") : Color.Red;
		}
		public bool IsValidEmail(string strIn)
		{
			if (string.IsNullOrEmpty(strIn))
			{
				return false;
			}
			try
			{
				return Regex.IsMatch(strIn,
			 @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
			 @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
			 RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));

			}
			catch (RegexMatchTimeoutException)
			{
				return false;
			}
		}

	}
}
