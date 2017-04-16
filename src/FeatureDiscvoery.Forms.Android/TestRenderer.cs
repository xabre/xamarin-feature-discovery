//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using Xamarin.Forms;
//using Plugin.Mfd.Droid;
//using Xamarin.Forms.Platform.Android;
//using Plugin.Mfd;

//[assembly: ExportRenderer(typeof(FeatureDiscoveryTarget), typeof(TestRenderer))]
//namespace Plugin.Mfd.Droid
//{

//    class TestRenderer : ViewRenderer<FeatureDiscoveryTarget, Android.Views.View>
//    {
//        protected override void OnElementChanged(ElementChangedEventArgs<FeatureDiscoveryTarget> e)
//        {
//            base.OnElementChanged(e);

//            e.NewElement.ShowAction = new Action(Show);
//        }

//        private void Show()
//        {

//            var view = Element.Target;
//            Android.Views.View targetView = null;
//            if (view is ToolbarItem)
//            {
//                targetView = FindToolbarItem(MainActivity.Instance.Toolbar, view as ToolbarItem);
//            }
//            else
//            {
//                var renderer = Platform.GetRenderer((Xamarin.Forms.View)view);
//                targetView = renderer.ViewGroup;

//            }

//            if (targetView != null)
//            {
//                var target = KeepSafe.TapTarget.ForView(targetView, "Test", "Description");

//                KeepSafe.TapTargetView.ShowFor(MainActivity.Instance, target);
//            }
//        }

//        private TextView FindToolbarItem(ViewGroup toolbar, ToolbarItem item)
//        {
//            for (int i = 0; i < toolbar.ChildCount; i++)
//            {
//                var child = toolbar.GetChildAt(i);
//                if (child is TextView && ((TextView)child).Text.Equals(item.Text))
//                {
//                    return child as TextView;
//                }

//                if (child is ViewGroup)
//                {
//                    var result = FindToolbarItem((ViewGroup)child, item);
//                    if (result != null)
//                        return result;
//                }

//            }

//            return null;
//        }
//    }
//}
