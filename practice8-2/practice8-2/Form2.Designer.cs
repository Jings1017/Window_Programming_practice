namespace practice8_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.start_ctrl_state = new System.Windows.Forms.ToolStripMenuItem();
            this.stop_ctrl_state = new System.Windows.Forms.ToolStripMenuItem();
            this.ter_ctrl_state = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.start_ctrl_state,
            this.stop_ctrl_state,
            this.ter_ctrl_state});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 23);
            this.toolStripMenuItem1.Text = "狀態";
            // 
            // start_ctrl_state
            // 
            this.start_ctrl_state.Name = "start_ctrl_state";
            this.start_ctrl_state.Size = new System.Drawing.Size(164, 26);
            this.start_ctrl_state.Text = "開始 Ctrl+Z";
            this.start_ctrl_state.Click += new System.EventHandler(this.start_ctrl_state_click);
            // 
            // stop_ctrl_state
            // 
            this.stop_ctrl_state.Name = "stop_ctrl_state";
            this.stop_ctrl_state.Size = new System.Drawing.Size(164, 26);
            this.stop_ctrl_state.Text = "暫停 Ctrl+X";
            this.stop_ctrl_state.Click += new System.EventHandler(this.stop_ctrl_state_click);
            // 
            // ter_ctrl_state
            // 
            this.ter_ctrl_state.Name = "ter_ctrl_state";
            this.ter_ctrl_state.Size = new System.Drawing.Size(164, 26);
            this.ter_ctrl_state.Text = "結束 Ctrl+C";
            this.ter_ctrl_state.Click += new System.EventHandler(this.ter_ctrl_state_click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(115, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "分數 : ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem start_ctrl_state;
        private System.Windows.Forms.ToolStripMenuItem stop_ctrl_state;
        private System.Windows.Forms.ToolStripMenuItem ter_ctrl_state;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}