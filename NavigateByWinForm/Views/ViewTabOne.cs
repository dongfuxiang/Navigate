using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigateByWinForm.Views
{
    public class ViewTabOne : ViewBase
    {
        private System.Windows.Forms.Label label1;


        public ViewTabOne()
        {
            InitializeComponent();
            Text = "ViewTabOne";
            ViewIndex = 2;
        }
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is ViewTabOne";
            // 
            // ViewTabOne
            // 
            this.ClientSize = new System.Drawing.Size(938, 566);
            this.Controls.Add(this.label1);
            this.Name = "ViewTabOne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
