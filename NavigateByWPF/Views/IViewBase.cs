using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigateByWPF.Views
{
    public interface IViewBase
    {
        bool IsNeedLogin { get; set; }
        int Index { get; set; }

        //void UpdateView();

    }
}
