namespace practice7_1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hScrollBarB = new System.Windows.Forms.HScrollBar();
            this.hScrollBarG = new System.Windows.Forms.HScrollBar();
            this.hScrollBarR = new System.Windows.Forms.HScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(42, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 596);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.stop);
            this.tabPage1.Controls.Add(this.start);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "等化器";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(605, 475);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 1;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(605, 418);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.hScrollBarB);
            this.tabPage2.Controls.Add(this.hScrollBarG);
            this.tabPage2.Controls.Add(this.hScrollBarR);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.color);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "等化器設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hScrollBarB
            // 
            this.hScrollBarB.Location = new System.Drawing.Point(112, 278);
            this.hScrollBarB.Name = "hScrollBarB";
            this.hScrollBarB.Size = new System.Drawing.Size(207, 21);
            this.hScrollBarB.TabIndex = 7;
            this.hScrollBarB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarB_Scroll);
            // 
            // hScrollBarG
            // 
            this.hScrollBarG.Location = new System.Drawing.Point(112, 236);
            this.hScrollBarG.Name = "hScrollBarG";
            this.hScrollBarG.Size = new System.Drawing.Size(207, 21);
            this.hScrollBarG.TabIndex = 6;
            this.hScrollBarG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarG_Scroll);
            // 
            // hScrollBarR
            // 
            this.hScrollBarR.Location = new System.Drawing.Point(112, 195);
            this.hScrollBarR.Name = "hScrollBarR";
            this.hScrollBarR.Size = new System.Drawing.Size(207, 21);
            this.hScrollBarR.TabIndex = 5;
            this.hScrollBarR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarR_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(36, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "藍色";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(36, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "綠色";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(36, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "紅色";
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(112, 28);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(207, 91);
            this.color.TabIndex = 1;
            this.color.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "顏色設定";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "獅子王";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "awaken";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(496, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 39);
            this.button3.TabIndex = 10;
            this.button3.Text = "我現在要出征";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "音樂設定";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 685);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.HScrollBar hScrollBarR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hScrollBarB;
        private System.Windows.Forms.HScrollBar hScrollBarG;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

