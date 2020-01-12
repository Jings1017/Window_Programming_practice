namespace practice8_2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.狀態ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.start_ctrl = new System.Windows.Forms.ToolStripMenuItem();
            this.stop_ctrl = new System.Windows.Forms.ToolStripMenuItem();
            this.ter_ctrl = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.狀態ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(471, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 狀態ToolStripMenuItem
            // 
            this.狀態ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.start_ctrl,
            this.stop_ctrl,
            this.ter_ctrl});
            this.狀態ToolStripMenuItem.Name = "狀態ToolStripMenuItem";
            this.狀態ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.狀態ToolStripMenuItem.Text = "狀態";
            // 
            // start_ctrl
            // 
            this.start_ctrl.Name = "start_ctrl";
            this.start_ctrl.Size = new System.Drawing.Size(181, 26);
            this.start_ctrl.Text = "開始 Ctrl+Z";
            this.start_ctrl.Click += new System.EventHandler(this.start_ctrl_Click);
            // 
            // stop_ctrl
            // 
            this.stop_ctrl.Name = "stop_ctrl";
            this.stop_ctrl.Size = new System.Drawing.Size(181, 26);
            this.stop_ctrl.Text = "暫停 Ctrl+X";
            this.stop_ctrl.Click += new System.EventHandler(this.stop_ctrl_Click);
            // 
            // ter_ctrl
            // 
            this.ter_ctrl.Name = "ter_ctrl";
            this.ter_ctrl.Size = new System.Drawing.Size(181, 26);
            this.ter_ctrl.Text = "結束 Ctrl+C";
            this.ter_ctrl.Click += new System.EventHandler(this.ter_ctrl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(51, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 320);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 狀態ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem start_ctrl;
        private System.Windows.Forms.ToolStripMenuItem stop_ctrl;
        private System.Windows.Forms.ToolStripMenuItem ter_ctrl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

