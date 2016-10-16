using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Support.V4.App;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;
using MdpRight.Droid;

[assembly: ExportRenderer(typeof(MasterDetailPage), typeof(MyMasterDetailPageRenderer))]

namespace MdpRight.Droid
{
	public class MyMasterDetailPageRenderer : MasterDetailPageRenderer
	{
		protected override void OnElementChanged(VisualElement oldElement, VisualElement newElement)
		{
			base.OnElementChanged(oldElement, newElement);

			var fieldInfo = GetType().BaseType.GetField("_masterLayout", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
			var _masterLayout = (ViewGroup)fieldInfo.GetValue(this);
			var lp = new DrawerLayout.LayoutParams(_masterLayout.LayoutParameters);
			lp.Gravity = (int)GravityFlags.Right;
			_masterLayout.LayoutParameters = lp;
		}
	}
}
