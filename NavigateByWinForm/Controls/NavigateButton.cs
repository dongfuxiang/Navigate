using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigateByWinForm.Controls
{
    public partial class NavigateButton : RadioButton
    {
        /// <summary>
        /// 是否为水平方向
        /// </summary>
        public bool IsHorizontal { get; set; }

        public NavigateButton()
        {
            InitializeComponent();
            AutoSize = false;
            base.Appearance = Appearance.Button;
            base.FlatStyle = FlatStyle.Flat;
            base.FlatAppearance.BorderSize = 0;
        }

        /// <summary>
        /// 重绘
        /// </summary>
        /// <param name="pe"></param>
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (base.Checked)
            {
                Brush brush = new SolidBrush(Color.FromArgb(0, 120, 215));
                if (!IsHorizontal)
                {
                    Rectangle rect = new Rectangle(0, 3, 3, base.Height - 6);
                    pe.Graphics.FillRectangle(brush, rect);
                }
                else
                {
                    Rectangle rect2 = new Rectangle(0, base.Height - 2, base.Width, 2);
                    pe.Graphics.FillRectangle(brush, rect2);
                    ForeColor = Color.FromArgb(0, 120, 215);
                }
            }
            else
            {
                ForeColor = Color.Black;
            }
        }
    }
}
