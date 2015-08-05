using SuccessLib.Framework;
using SuccessWPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuccessWPF
{
    public class MainViewModel : BindableBase
    {

        public Container Container { get; private set; }

        

        public MainViewModel()
        {
            Container = new Container();
        }

    }
}
