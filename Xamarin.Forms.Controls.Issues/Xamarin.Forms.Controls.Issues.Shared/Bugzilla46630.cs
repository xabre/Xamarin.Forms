﻿using System.Collections.Generic;
using Xamarin.Forms.CustomAttributes;
using Xamarin.Forms.Internals;

#if UITEST
using Xamarin.UITest;
using NUnit.Framework;
#endif

// Apply the default category of "Issues" to all of the tests in this assembly
// We use this as a catch-all for tests which haven't been individually categorized
#if UITEST
[assembly: NUnit.Framework.Category("Issues")]
#endif

namespace Xamarin.Forms.Controls.Issues
{
	[Preserve(AllMembers = true)]
	[Issue(IssueTracker.Bugzilla, 46630, "Issue Description", PlatformAffected.Android)]
	public class Bugzilla46630 : TestContentPage
	{
		protected override void Init()
		{
			Content = new ListView
			{
				HasUnevenRows = true,
				ItemsSource = new List<int> { 0 },
				ItemTemplate = new DataTemplate(() => new ViewCell
				{
					Height = 300,
					ContextActions =
					{
						new MenuItem {Text = "Action1"},
						new MenuItem {Text = "Action2"}
					},
					View = new StackLayout
					{
						Orientation = StackOrientation.Vertical,
						Spacing = 10,
						HorizontalOptions = LayoutOptions.FillAndExpand,
						Padding = 10,
						Children =
						{
							new Label { HeightRequest = 50, BackgroundColor = Color.Coral, Text = "Long click each cell. Input views should not display context actions."},
							new Editor { HeightRequest = 50, BackgroundColor = Color.Bisque, Text = "Editor"},
							new Entry { HeightRequest = 50, BackgroundColor = Color.Aqua, Text = "Entry"},
							new SearchBar { HeightRequest = 50, BackgroundColor = Color.CornflowerBlue, Text = "SearchBar"},
							new Grid { HeightRequest = 50, BackgroundColor = Color.PaleVioletRed}
						}
					}
				})
			};
		}
	}
}