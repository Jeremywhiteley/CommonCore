﻿using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Xamarin.Forms.CommonCore
{
	public delegate bool FloatingTextEntryValidator(string input);

	public class FTEControl : Entry
	{
		public static FloatingTextEntryValidator EmailValidator
		{
			get
			{
				return (input) =>
				{
					var emailRegex = "[A-Z0-9a-z._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,6}";
					var isValid = Regex.Match(input, emailRegex).Success;
					return isValid;
				};
			}
		}

		public static FloatingTextEntryValidator NumericValidator
		{
			get
			{
				return (input) =>
				{
					var numRegex = "[0-9.+-]+";
					var isValid = Regex.Match(input, numRegex).Success;
					return isValid;
				};
			}
		}
		public static FloatingTextEntryValidator RequiredValidator
		{
			get
			{
				return (input) =>
				{
					return !string.IsNullOrEmpty(input);
				};
			}
		}

		public FTEControl()
		{
			this.TextColor = Color.Black;
		}

		public static readonly BindableProperty AccentColorProperty =
			BindableProperty.Create("AccentColor",
									typeof(Color),
									typeof(FTEControl),
									Color.Blue);

		public static readonly BindableProperty InactiveAccentColorProperty =
			BindableProperty.Create("InactiveAccentColor",
									typeof(Color),
									typeof(FTEControl),
									Color.Gray.MultiplyAlpha(0.54));

		public Color AccentColor
		{
			get
			{
				return (Color)GetValue(AccentColorProperty);
			}
			set
			{
				SetValue(AccentColorProperty, value);
			}
		}

		public Color InactiveAccentColor
		{
			get
			{
				return (Color)GetValue(InactiveAccentColorProperty);
			}
			set
			{
				SetValue(InactiveAccentColorProperty, value);
			}
		}

		public static readonly BindableProperty ErrorColorProperty =
			BindableProperty.Create("ErrorColor",
									typeof(Color),
									typeof(FTEControl),
									Color.Red);

		public Color ErrorColor
		{
			get
			{
				return (Color)GetValue(ErrorColorProperty);
			}
			set
			{
				SetValue(ErrorColorProperty, value);
			}
		}

		public static readonly BindableProperty ValidatorProperty =
			BindableProperty.Create("Validator",
									typeof(FloatingTextEntryValidator),
									typeof(FTEControl),
									null);

		public FloatingTextEntryValidator Validator
		{
			get
			{
				return (FloatingTextEntryValidator)GetValue(ValidatorProperty);
			}
			set
			{
				SetValue(ValidatorProperty, value);
			}
		}

		public static readonly BindableProperty ErrorTextProperty =
			BindableProperty.Create("ErrorText",
									typeof(string),
									typeof(FTEControl),
									"Error");


		public string ErrorText
		{
			get
			{
				return (string)GetValue(ErrorTextProperty);
			}
			set
			{
				SetValue(ErrorTextProperty, value);
			}
		}


		public bool IsValid
		{
			get
			{
				if (this.Validator == null)
					return true;
				return (this.Validator(this.Text));
			}
		}
	}
}
