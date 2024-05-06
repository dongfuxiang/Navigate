namespace NavigateByWinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlNavigate = new System.Windows.Forms.Panel();
            this.pnlViewHost = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlNavigate
            // 
            this.pnlNavigate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlNavigate.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigate.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigate.Name = "pnlNavigate";
            this.pnlNavigate.Size = new System.Drawing.Size(200, 607);
            this.pnlNavigate.TabIndex = 0;
            // 
            // pnlViewHost
            // 
            this.pnlViewHost.BackColor = System.Drawing.Color.Snow;
            this.pnlViewHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewHost.Location = new System.Drawing.Point(200, 0);
            this.pnlViewHost.Name = "pnlViewHost";
            this.pnlViewHost.Size = new System.Drawing.Size(848, 607);
            this.pnlViewHost.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 607);
            this.Controls.Add(this.pnlViewHost);
            this.Controls.Add(this.pnlNavigate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigate;
        private System.Windows.Forms.Panel pnlViewHost;
    }
}

