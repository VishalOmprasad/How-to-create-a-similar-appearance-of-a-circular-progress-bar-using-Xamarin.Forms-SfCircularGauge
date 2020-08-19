using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;

namespace GaugeSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Timer timer = new Timer();
        public MainPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1.5), () =>
            {
                if (rangePointer.Value>=100)
                {
                    rangePointer.Value = 0;
                }
                rangePointer.Value = rangePointer.Value+20;

                 return true;
            });
        }
    }
}
