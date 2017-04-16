using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Plugin.FeatureDiscovery.Forms
{
    public class FeatureDiscoveryTarget : View
    {
        public Element Target { get; set; }

        public void Show()
        {
            ShowAction?.Invoke();
        }

        public Action ShowAction { get; set; }
    }

}
