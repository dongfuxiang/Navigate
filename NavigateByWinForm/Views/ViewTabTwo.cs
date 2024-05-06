using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigateByWinForm.Views
{
    public partial class ViewTabTwo : ViewBase
    {
        public ViewTabTwo()
        {
            InitializeComponent();
            IsNeedLogin = true;
            ViewIndex = 1;
        }
    }
}
