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
    public partial class ViewMain : ViewBase
    {

        public ViewMain()
        {
            InitializeComponent();
            Text = "ViewMain";
            IsNeedLogin = true;
            ViewIndex = 3;
        }
    }
}
