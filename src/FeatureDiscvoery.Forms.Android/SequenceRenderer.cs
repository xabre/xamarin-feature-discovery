using System;
using System.Collections.Generic;
using Android.Widget;
using Xamarin.Forms;
using View = Android.Views.View;
using Xamarin.Forms.Platform.Android;
using Android.Views;

[assembly: ExportRenderer(typeof(Plugin.FeatureDiscovery.Forms.FeatureDiscoverySequence), typeof(Plugin.FeatureDiscovery.Forms.Android.SequenceRenderer))]
namespace Plugin.FeatureDiscovery.Forms.Android
{
    class SequenceRenderer : ViewRenderer<FeatureDiscoverySequence, View>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<FeatureDiscoverySequence> e)
        {
            base.OnElementChanged(e);

            e.NewElement.ShowAction = new Action(Show);
        }

        private void Show()
        {
            var targets = new List<KeepSafe.TapTarget>();
            foreach (var target in Element.Targets)
            {
                var formsView = target.Target;
                View targetView = null;
                if (formsView is ToolbarItem)
                {
                    targetView = FindToolbarItem(MainActivity.Instance.Toolbar, formsView as ToolbarItem);
                }
                else
                {
                    var renderer = Platform.GetRenderer((Xamarin.Forms.View)formsView);

                    var property = renderer?.GetType().GetProperty("Control");
                    if (property != null)
                    {
                        targetView = (View)property.GetValue(renderer);

                        int[] location = new int[2];
                        targetView.GetLocationOnScreen(location);


                    }
                    else
                    {
                        targetView = renderer?.ViewGroup;
                    }

                }

                if (targetView != null)
                {
                    targets.Add(KeepSafe.TapTarget.ForView(targetView, "Test", "Description"));
                }
            }

            new KeepSafe.TapTargetSequence(MainActivity.Instance).Targets(targets).Start();

        }

        private TextView FindToolbarItem(ViewGroup toolbar, ToolbarItem item)
        {
            for (int i = 0; i < toolbar.ChildCount; i++)
            {
                var child = toolbar.GetChildAt(i);
                if (child is TextView && ((TextView)child).Text.Equals(item.Text))
                {
                    return child as TextView;
                }

                if (child is ViewGroup)
                {
                    var result = FindToolbarItem((ViewGroup)child, item);
                    if (result != null)
                        return result;
                }

            }

            return null;
        }
    }
}
