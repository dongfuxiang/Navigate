using NavigateByWinForm.Controls;
using NavigateByWinForm.Properties;
using NavigateByWinForm.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigateByWinForm
{
    public partial class Form1 : Form
    {

        private ViewLogin viewLogin { get; set; } = new ViewLogin();
        public Form1()
        {
            InitializeComponent();
            LoadViews();
        }


        /// <summary>
        /// 加载页面
        /// </summary>
        private void LoadViews()
        {
            viewLogin.FormBorderStyle = FormBorderStyle.None;
            viewLogin.TopLevel = false;
            viewLogin.Dock = DockStyle.Fill;
            pnlViewHost.Controls.Add(viewLogin);

            Assembly entryAssembly = Assembly.GetEntryAssembly();
            Type[] types = entryAssembly.GetTypes();
            List<ViewBase> ListViews = new List<ViewBase>();
            foreach (Type type in types)
            {
                //bool res = { TypeA }.IsAssignableFrom({ TypeB}) ;
                //如果TypeA和TypeB类型一样则返回true；
                //如果TypeA是TypeB的父类则返回true;
                //如果TypeB实现了接口TypeA则返回true;

                //筛选出ViewBase的子类
                if (type != typeof(ViewBase) && typeof(ViewBase).IsAssignableFrom(type))
                {
                    ViewBase item = (ViewBase)entryAssembly.CreateInstance(type.FullName, true);
                    ListViews.Add(item);
                }
            }
            //根据ViewIndex排序
            ListViews = ListViews.OrderBy(p => p.ViewIndex).ToList();

            foreach (var item in ListViews)
            {
                item.FormBorderStyle = FormBorderStyle.None;
                item.TopLevel = false;
                item.Dock = DockStyle.Fill;
                pnlViewHost.Controls.Add(item);
            }
            foreach (ViewBase item in ListViews)
            {
                item.FormBorderStyle = FormBorderStyle.None;
                item.Dock = DockStyle.Fill;

                NavigateButton navigateButton = new NavigateButton();
                navigateButton.Image = new ResourceManager(typeof(Resource)).GetObject("radiobutton_16") as Bitmap;
                navigateButton.Text = item.Text;
                navigateButton.Tag = item.Name;
                navigateButton.Enabled = !item.IsStartupDisabled;
                navigateButton.Dock = DockStyle.Top;
                navigateButton.Appearance = Appearance.Button;
                navigateButton.Font = new Font("华文楷体", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                navigateButton.Size = new Size(200, 45);
                navigateButton.Margin = new Padding(100);
                navigateButton.Padding = new Padding(3);
                navigateButton.BackColor = Color.LightGray;
                navigateButton.FlatAppearance.BorderColor = Color.Gray;
                navigateButton.FlatAppearance.BorderSize = 0;
                navigateButton.FlatAppearance.CheckedBackColor = Color.Snow;
                navigateButton.FlatStyle = FlatStyle.Flat;
                navigateButton.ForeColor = Color.Black;
                navigateButton.ImageAlign = ContentAlignment.MiddleLeft;
                navigateButton.TextAlign = ContentAlignment.MiddleRight;
                navigateButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                pnlNavigate.Controls.Add(navigateButton);
                pnlNavigate.Controls.SetChildIndex(navigateButton, 0);
            }

            foreach (Control control in pnlNavigate.Controls)
            {
                if (control is RadioButton)
                {
                    (control as RadioButton).CheckedChanged += Navigate_CheckedChanged;
                }
            }

            foreach (Control control in pnlViewHost.Controls)
            {
                if (control is ViewBase)
                {
                    ViewBase viewBase = control as ViewBase;
                    if (viewBase.IsNeedLogin)
                    {
                        //RegisterControlEvent(viewBase3);
                    }
                }
            }


        }

        private void Navigate_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                foreach (Control control in pnlViewHost.Controls)
                {
                    if (!(control is ViewBase))
                    {
                        continue;
                    }
                    ViewBase viewBase = control as ViewBase;
                    if (viewBase.Text == radioButton.Text)
                    {
                        if (viewBase.IsNeedLogin)
                        {
                            viewLogin.Show();
                            viewLogin.UpdateView();
                        }
                        else
                        {
                            viewLogin.Hide();
                        }
                        viewBase.Show();
                    }
                    else
                    {
                        viewBase.Hide();
                    }
                }
            }
        }
    }
}
