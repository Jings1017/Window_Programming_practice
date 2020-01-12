namespace _2018Q2
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
            this.pre = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pre
            // 
            this.pre.Location = new System.Drawing.Point(70, 90);
            this.pre.Name = "pre";
            this.pre.Size = new System.Drawing.Size(74, 322);
            this.pre.TabIndex = 0;
            this.pre.Text = "pre";
            this.pre.UseVisualStyleBackColor = true;
            this.pre.Click += new System.EventHandler(this.pre_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(440, 90);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(71, 322);
            this.next.TabIndex = 1;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(201, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 181);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.pre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MD);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MU);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pre;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

