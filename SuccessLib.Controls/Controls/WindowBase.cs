using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SuccessWPF.Controls
{
    public class WindowBase : Window
    {
        public WindowBase()
        {
            

        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            var width = System.Windows.SystemParameters.FullPrimaryScreenWidth;
            var height = System.Windows.SystemParameters.FullPrimaryScreenHeight;
            this.Width = width * .8;
            this.Height = height *.8;
        }

        public bool IsInDesignMode
        {
            get
            {
                return System.ComponentModel.
                        DesignerProperties.GetIsInDesignMode(this);
            }
        }


    }
}
