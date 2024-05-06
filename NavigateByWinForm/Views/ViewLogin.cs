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
    public partial class ViewLogin : Form
    {
        public ViewLogin()
        {
            InitializeComponent();
        }

        /// <summary>
		/// 更新页面
		/// </summary>
		public void UpdateView()
        {
            txtUser.Clear();
            txtUser.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
