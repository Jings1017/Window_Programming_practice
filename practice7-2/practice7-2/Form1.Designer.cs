namespace practice7_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.write = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.month = new System.Windows.Forms.NumericUpDown();
            this.day = new System.Windows.Forms.NumericUpDown();
            this.hour = new System.Windows.Forms.NumericUpDown();
            this.minute = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "行程";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "月";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "時";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "分";
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(595, 141);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(137, 33);
            this.write.TabIndex = 10;
            this.write.Text = "寫入行程";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(595, 207);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(137, 33);
            this.search.TabIndex = 11;
            this.search.Text = "查詢行程";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(595, 280);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(137, 33);
            this.clear.TabIndex = 12;
            this.clear.Text = "清除";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(170, 243);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(358, 290);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(194, 97);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(120, 25);
            this.month.TabIndex = 14;
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(370, 99);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(120, 25);
            this.day.TabIndex = 15;
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(194, 149);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(120, 25);
            this.hour.TabIndex = 16;
            // 
            // minute
            // 
            this.minute.Location = new System.Drawing.Point(370, 149);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(120, 25);
            this.minute.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 575);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.day);
            this.Controls.Add(this.month);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.search);
            this.Controls.Add(this.write);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown month;
        private System.Windows.Forms.NumericUpDown day;
        private System.Windows.Forms.NumericUpDown hour;
        private System.Windows.Forms.NumericUpDown minute;
    }
}

