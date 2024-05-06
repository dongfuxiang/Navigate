using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigateByWinForm.Views
{
    public class ViewBase : Form
    {

        /// <summary>
        /// 页面是否需要登录
        /// </summary>
        public bool IsNeedLogin { get; set; } = false;
        /// <summary>
        /// View的序号
        /// </summary>
        public int ViewIndex { get; set; } = 0;
        /// <summary>
        /// 程序启动时，对应的导航按钮是否禁用
        /// </summary>
        public bool IsStartupDisabled { get; set; } = false;

        public ViewBase()
        {
            //FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }

        public virtual void UpdateView()
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ViewBase
            // 
            this.ClientSize = new System.Drawing.Size(564, 415);
            this.Name = "ViewBase";
            this.ResumeLayout(false);

        }
    }
}
