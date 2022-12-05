using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PL.Views
{
    public class DoubleClickButton : RJButton
    {
        public DoubleClickButton()
        {
            SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
        }
    }
}
