namespace practice5_1
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
            this.blueberry = new System.Windows.Forms.RadioButton();
            this.matcha = new System.Windows.Forms.RadioButton();
            this.tomato = new System.Windows.Forms.RadioButton();
            this.none = new System.Windows.Forms.RadioButton();
            this.pineapple = new System.Windows.Forms.CheckBox();
            this.ham = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.make = new System.Windows.Forms.Button();
            this.pictureBread = new System.Windows.Forms.PictureBox();
            this.pictureSauce = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureIngredient = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSauce)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIngredient)).BeginInit();
            this.SuspendLayout();
            // 
            // blueberry
            // 
            this.blueberry.AutoSize = true;
            this.blueberry.Location = new System.Drawing.Point(6, 33);
            this.blueberry.Name = "blueberry";
            this.blueberry.Size = new System.Drawing.Size(118, 19);
            this.blueberry.TabIndex = 0;
            this.blueberry.TabStop = true;
            this.blueberry.Text = "藍莓 Blueberry";
            this.blueberry.UseVisualStyleBackColor = true;
            this.blueberry.CheckedChanged += new System.EventHandler(this.blueberry_CheckedChanged);
            // 
            // matcha
            // 
            this.matcha.AutoSize = true;
            this.matcha.Location = new System.Drawing.Point(6, 58);
            this.matcha.Name = "matcha";
            this.matcha.Size = new System.Drawing.Size(104, 19);
            this.matcha.TabIndex = 1;
            this.matcha.TabStop = true;
            this.matcha.Text = "抹茶 Matcha";
            this.matcha.UseVisualStyleBackColor = true;
            this.matcha.CheckedChanged += new System.EventHandler(this.matcha_CheckedChanged);
            // 
            // tomato
            // 
            this.tomato.AutoSize = true;
            this.tomato.Location = new System.Drawing.Point(6, 83);
            this.tomato.Name = "tomato";
            this.tomato.Size = new System.Drawing.Size(121, 19);
            this.tomato.TabIndex = 2;
            this.tomato.TabStop = true;
            this.tomato.Text = "番茄醬 Tomato";
            this.tomato.UseVisualStyleBackColor = true;
            this.tomato.CheckedChanged += new System.EventHandler(this.tomato_CheckedChanged);
            // 
            // none
            // 
            this.none.AutoSize = true;
            this.none.Location = new System.Drawing.Point(6, 108);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(107, 19);
            this.none.TabIndex = 3;
            this.none.TabStop = true;
            this.none.Text = "不加醬 None";
            this.none.UseVisualStyleBackColor = true;
            this.none.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pineapple
            // 
            this.pineapple.AutoSize = true;
            this.pineapple.Location = new System.Drawing.Point(6, 24);
            this.pineapple.Name = "pineapple";
            this.pineapple.Size = new System.Drawing.Size(118, 19);
            this.pineapple.TabIndex = 8;
            this.pineapple.Text = "鳳梨 Pineapple";
            this.pineapple.UseVisualStyleBackColor = true;
            this.pineapple.CheckedChanged += new System.EventHandler(this.pineapple_CheckedChanged);
            // 
            // ham
            // 
            this.ham.AutoSize = true;
            this.ham.Location = new System.Drawing.Point(6, 58);
            this.ham.Name = "ham";
            this.ham.Size = new System.Drawing.Size(90, 19);
            this.ham.TabIndex = 9;
            this.ham.Text = "火腿 Ham";
            this.ham.UseVisualStyleBackColor = true;
            this.ham.CheckedChanged += new System.EventHandler(this.ham_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 25);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 25);
            this.textBox2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "片 Piece(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "片 Piece(s)";
            // 
            // make
            // 
            this.make.Location = new System.Drawing.Point(436, 340);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(275, 60);
            this.make.TabIndex = 14;
            this.make.Text = "生成 Make";
            this.make.UseVisualStyleBackColor = true;
            this.make.Click += new System.EventHandler(this.make_Click);
            // 
            // pictureBread
            // 
            this.pictureBread.Location = new System.Drawing.Point(39, 63);
            this.pictureBread.Name = "pictureBread";
            this.pictureBread.Size = new System.Drawing.Size(298, 296);
            this.pictureBread.TabIndex = 15;
            this.pictureBread.TabStop = false;
            // 
            // pictureSauce
            // 
            this.pictureSauce.Location = new System.Drawing.Point(26, 21);
            this.pictureSauce.Name = "pictureSauce";
            this.pictureSauce.Size = new System.Drawing.Size(254, 255);
            this.pictureSauce.TabIndex = 16;
            this.pictureSauce.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blueberry);
            this.groupBox1.Controls.Add(this.matcha);
            this.groupBox1.Controls.Add(this.tomato);
            this.groupBox1.Controls.Add(this.none);
            this.groupBox1.Location = new System.Drawing.Point(436, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 145);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "醬料 Sauce";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pineapple);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ham);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(436, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "配料 Ingredient";
            // 
            // pictureIngredient
            // 
            this.pictureIngredient.Location = new System.Drawing.Point(62, 80);
            this.pictureIngredient.Name = "pictureIngredient";
            this.pictureIngredient.Size = new System.Drawing.Size(254, 255);
            this.pictureIngredient.TabIndex = 19;
            this.pictureIngredient.TabStop = false;
            this.pictureIngredient.Click += new System.EventHandler(this.pictureIngredient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 492);
            this.Controls.Add(this.pictureIngredient);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureSauce);
            this.Controls.Add(this.pictureBread);
            this.Controls.Add(this.make);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSauce)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIngredient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton blueberry;
        private System.Windows.Forms.RadioButton matcha;
        private System.Windows.Forms.RadioButton tomato;
        private System.Windows.Forms.RadioButton none;
        private System.Windows.Forms.CheckBox pineapple;
        private System.Windows.Forms.CheckBox ham;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button make;
        private System.Windows.Forms.PictureBox pictureBread;
        private System.Windows.Forms.PictureBox pictureSauce;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureIngredient;
    }
}

