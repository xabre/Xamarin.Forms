using System;
using System.Runtime.CompilerServices;

namespace Xamarin.Forms.Xaml
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public sealed class XamlFilePathAttribute : Attribute
	{
		public XamlFilePathAttribute([CallerFilePath] string filePath = "")
		{
		}
	}
}