using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Plugin.FeatureDiscovery.Forms
{
    public class FeatureDiscoverySequence : View
    {
        public IList<FeatureDiscoveryTarget> Targets { get; private set; }

        public FeatureDiscoverySequence()
        {
            Targets = new List<FeatureDiscoveryTarget>();
        }

        public void Show()
        {
            ShowAction?.Invoke();
        }

        public Action ShowAction { get; set; }
    }

}
