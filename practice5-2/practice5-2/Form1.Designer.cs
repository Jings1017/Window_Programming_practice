namespace practice5_2
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
            System.Windows.Forms.RadioButton gray4;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.GroupBox();
            this.lightgray4 = new System.Windows.Forms.RadioButton();
            this.golden4 = new System.Windows.Forms.RadioButton();
            this.green4 = new System.Windows.Forms.RadioButton();
            this.blue4 = new System.Windows.Forms.RadioButton();
            this.brown4 = new System.Windows.Forms.RadioButton();
            this.red4 = new System.Windows.Forms.RadioButton();
            this.violet4 = new System.Windows.Forms.RadioButton();
            this.multiple = new System.Windows.Forms.GroupBox();
            this.lightgray3 = new System.Windows.Forms.RadioButton();
            this.golden3 = new System.Windows.Forms.RadioButton();
            this.white3 = new System.Windows.Forms.RadioButton();
            this.black3 = new System.Windows.Forms.RadioButton();
            this.gray3 = new System.Windows.Forms.RadioButton();
            this.brown3 = new System.Windows.Forms.RadioButton();
            this.violet3 = new System.Windows.Forms.RadioButton();
            this.red3 = new System.Windows.Forms.RadioButton();
            this.blue3 = new System.Windows.Forms.RadioButton();
            this.orange3 = new System.Windows.Forms.RadioButton();
            this.green3 = new System.Windows.Forms.RadioButton();
            this.yellow3 = new System.Windows.Forms.RadioButton();
            this.color2 = new System.Windows.Forms.GroupBox();
            this.white2 = new System.Windows.Forms.RadioButton();
            this.black2 = new System.Windows.Forms.RadioButton();
            this.gray2 = new System.Windows.Forms.RadioButton();
            this.brown2 = new System.Windows.Forms.RadioButton();
            this.violet2 = new System.Windows.Forms.RadioButton();
            this.red2 = new System.Windows.Forms.RadioButton();
            this.blue2 = new System.Windows.Forms.RadioButton();
            this.orange2 = new System.Windows.Forms.RadioButton();
            this.green2 = new System.Windows.Forms.RadioButton();
            this.yellow2 = new System.Windows.Forms.RadioButton();
            this.color1 = new System.Windows.Forms.GroupBox();
            this.white1 = new System.Windows.Forms.RadioButton();
            this.gray1 = new System.Windows.Forms.RadioButton();
            this.violet1 = new System.Windows.Forms.RadioButton();
            this.blue1 = new System.Windows.Forms.RadioButton();
            this.green1 = new System.Windows.Forms.RadioButton();
            this.yellow1 = new System.Windows.Forms.RadioButton();
            this.orange1 = new System.Windows.Forms.RadioButton();
            this.red1 = new System.Windows.Forms.RadioButton();
            this.brown1 = new System.Windows.Forms.RadioButton();
            this.black1 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.allClear = new System.Windows.Forms.Button();
            gray4 = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.error.SuspendLayout();
            this.multiple.SuspendLayout();
            this.color2.SuspendLayout();
            this.color1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gray4
            // 
            gray4.AutoSize = true;
            gray4.ForeColor = System.Drawing.Color.Gray;
            gray4.Location = new System.Drawing.Point(24, 234);
            gray4.Name = "gray4";
            gray4.Size = new System.Drawing.Size(43, 19);
            gray4.TabIndex = 43;
            gray4.TabStop = true;
            gray4.Text = "■";
            gray4.UseVisualStyleBackColor = true;
            gray4.CheckedChanged += new System.EventHandler(this.gray4_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 516);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.error);
            this.tabPage1.Controls.Add(this.multiple);
            this.tabPage1.Controls.Add(this.color2);
            this.tabPage1.Controls.Add(this.color1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(569, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "顏色->阻值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("新細明體", 10F);
            this.label7.Location = new System.Drawing.Point(354, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 7;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(485, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ω(ohm)";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(321, 434);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(158, 25);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(246, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "阻值：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // error
            // 
            this.error.Controls.Add(this.lightgray4);
            this.error.Controls.Add(this.golden4);
            this.error.Controls.Add(this.green4);
            this.error.Controls.Add(gray4);
            this.error.Controls.Add(this.blue4);
            this.error.Controls.Add(this.brown4);
            this.error.Controls.Add(this.red4);
            this.error.Controls.Add(this.violet4);
            this.error.ForeColor = System.Drawing.Color.White;
            this.error.Location = new System.Drawing.Point(304, 26);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(83, 358);
            this.error.TabIndex = 3;
            this.error.TabStop = false;
            this.error.Text = "誤差";
            // 
            // lightgray4
            // 
            this.lightgray4.AutoSize = true;
            this.lightgray4.ForeColor = System.Drawing.Color.Silver;
            this.lightgray4.Location = new System.Drawing.Point(24, 309);
            this.lightgray4.Name = "lightgray4";
            this.lightgray4.Size = new System.Drawing.Size(43, 19);
            this.lightgray4.TabIndex = 46;
            this.lightgray4.TabStop = true;
            this.lightgray4.Text = "■";
            this.lightgray4.UseVisualStyleBackColor = true;
            this.lightgray4.CheckedChanged += new System.EventHandler(this.lightgray4_CheckedChanged);
            // 
            // golden4
            // 
            this.golden4.AutoSize = true;
            this.golden4.ForeColor = System.Drawing.Color.Gold;
            this.golden4.Location = new System.Drawing.Point(24, 284);
            this.golden4.Name = "golden4";
            this.golden4.Size = new System.Drawing.Size(43, 19);
            this.golden4.TabIndex = 45;
            this.golden4.TabStop = true;
            this.golden4.Text = "■";
            this.golden4.UseVisualStyleBackColor = true;
            this.golden4.CheckedChanged += new System.EventHandler(this.golden4_CheckedChanged);
            // 
            // green4
            // 
            this.green4.AutoSize = true;
            this.green4.ForeColor = System.Drawing.Color.Green;
            this.green4.Location = new System.Drawing.Point(24, 159);
            this.green4.Name = "green4";
            this.green4.Size = new System.Drawing.Size(43, 19);
            this.green4.TabIndex = 40;
            this.green4.TabStop = true;
            this.green4.Text = "■";
            this.green4.UseVisualStyleBackColor = true;
            this.green4.CheckedChanged += new System.EventHandler(this.green4_CheckedChanged);
            // 
            // blue4
            // 
            this.blue4.AutoSize = true;
            this.blue4.ForeColor = System.Drawing.Color.Blue;
            this.blue4.Location = new System.Drawing.Point(24, 184);
            this.blue4.Name = "blue4";
            this.blue4.Size = new System.Drawing.Size(43, 19);
            this.blue4.TabIndex = 41;
            this.blue4.TabStop = true;
            this.blue4.Text = "■";
            this.blue4.UseVisualStyleBackColor = true;
            this.blue4.CheckedChanged += new System.EventHandler(this.blue4_CheckedChanged);
            // 
            // brown4
            // 
            this.brown4.AutoSize = true;
            this.brown4.ForeColor = System.Drawing.Color.Maroon;
            this.brown4.Location = new System.Drawing.Point(24, 59);
            this.brown4.Name = "brown4";
            this.brown4.Size = new System.Drawing.Size(43, 19);
            this.brown4.TabIndex = 36;
            this.brown4.TabStop = true;
            this.brown4.Text = "■";
            this.brown4.UseVisualStyleBackColor = true;
            this.brown4.CheckedChanged += new System.EventHandler(this.brown4_CheckedChanged);
            // 
            // red4
            // 
            this.red4.AutoSize = true;
            this.red4.ForeColor = System.Drawing.Color.Red;
            this.red4.Location = new System.Drawing.Point(24, 84);
            this.red4.Name = "red4";
            this.red4.Size = new System.Drawing.Size(43, 19);
            this.red4.TabIndex = 37;
            this.red4.TabStop = true;
            this.red4.Text = "■";
            this.red4.UseVisualStyleBackColor = true;
            this.red4.CheckedChanged += new System.EventHandler(this.red4_CheckedChanged);
            // 
            // violet4
            // 
            this.violet4.AutoSize = true;
            this.violet4.ForeColor = System.Drawing.Color.Purple;
            this.violet4.Location = new System.Drawing.Point(24, 209);
            this.violet4.Name = "violet4";
            this.violet4.Size = new System.Drawing.Size(43, 19);
            this.violet4.TabIndex = 42;
            this.violet4.TabStop = true;
            this.violet4.Text = "■";
            this.violet4.UseVisualStyleBackColor = true;
            this.violet4.CheckedChanged += new System.EventHandler(this.violet4_CheckedChanged);
            // 
            // multiple
            // 
            this.multiple.Controls.Add(this.lightgray3);
            this.multiple.Controls.Add(this.golden3);
            this.multiple.Controls.Add(this.white3);
            this.multiple.Controls.Add(this.black3);
            this.multiple.Controls.Add(this.gray3);
            this.multiple.Controls.Add(this.brown3);
            this.multiple.Controls.Add(this.violet3);
            this.multiple.Controls.Add(this.red3);
            this.multiple.Controls.Add(this.blue3);
            this.multiple.Controls.Add(this.orange3);
            this.multiple.Controls.Add(this.green3);
            this.multiple.Controls.Add(this.yellow3);
            this.multiple.ForeColor = System.Drawing.Color.White;
            this.multiple.Location = new System.Drawing.Point(200, 26);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(87, 358);
            this.multiple.TabIndex = 2;
            this.multiple.TabStop = false;
            this.multiple.Text = "倍數";
            // 
            // lightgray3
            // 
            this.lightgray3.AutoSize = true;
            this.lightgray3.ForeColor = System.Drawing.Color.Silver;
            this.lightgray3.Location = new System.Drawing.Point(23, 309);
            this.lightgray3.Name = "lightgray3";
            this.lightgray3.Size = new System.Drawing.Size(43, 19);
            this.lightgray3.TabIndex = 34;
            this.lightgray3.TabStop = true;
            this.lightgray3.Text = "■";
            this.lightgray3.UseVisualStyleBackColor = true;
            this.lightgray3.CheckedChanged += new System.EventHandler(this.lightgray3_CheckedChanged);
            // 
            // golden3
            // 
            this.golden3.AutoSize = true;
            this.golden3.ForeColor = System.Drawing.Color.Gold;
            this.golden3.Location = new System.Drawing.Point(23, 284);
            this.golden3.Name = "golden3";
            this.golden3.Size = new System.Drawing.Size(43, 19);
            this.golden3.TabIndex = 33;
            this.golden3.TabStop = true;
            this.golden3.Text = "■";
            this.golden3.UseVisualStyleBackColor = true;
            this.golden3.CheckedChanged += new System.EventHandler(this.golden3_CheckedChanged);
            // 
            // white3
            // 
            this.white3.AutoSize = true;
            this.white3.ForeColor = System.Drawing.Color.White;
            this.white3.Location = new System.Drawing.Point(23, 259);
            this.white3.Name = "white3";
            this.white3.Size = new System.Drawing.Size(43, 19);
            this.white3.TabIndex = 32;
            this.white3.TabStop = true;
            this.white3.Text = "■";
            this.white3.UseVisualStyleBackColor = true;
            this.white3.CheckedChanged += new System.EventHandler(this.white3_CheckedChanged);
            // 
            // black3
            // 
            this.black3.AutoSize = true;
            this.black3.ForeColor = System.Drawing.Color.Black;
            this.black3.Location = new System.Drawing.Point(23, 34);
            this.black3.Name = "black3";
            this.black3.Size = new System.Drawing.Size(43, 19);
            this.black3.TabIndex = 23;
            this.black3.TabStop = true;
            this.black3.Text = "■";
            this.black3.UseVisualStyleBackColor = true;
            this.black3.CheckedChanged += new System.EventHandler(this.black3_CheckedChanged);
            // 
            // gray3
            // 
            this.gray3.AutoSize = true;
            this.gray3.ForeColor = System.Drawing.Color.Gray;
            this.gray3.Location = new System.Drawing.Point(23, 234);
            this.gray3.Name = "gray3";
            this.gray3.Size = new System.Drawing.Size(43, 19);
            this.gray3.TabIndex = 31;
            this.gray3.TabStop = true;
            this.gray3.Text = "■";
            this.gray3.UseVisualStyleBackColor = true;
            this.gray3.CheckedChanged += new System.EventHandler(this.gray3_CheckedChanged);
            // 
            // brown3
            // 
            this.brown3.AutoSize = true;
            this.brown3.ForeColor = System.Drawing.Color.Maroon;
            this.brown3.Location = new System.Drawing.Point(23, 59);
            this.brown3.Name = "brown3";
            this.brown3.Size = new System.Drawing.Size(43, 19);
            this.brown3.TabIndex = 24;
            this.brown3.TabStop = true;
            this.brown3.Text = "■";
            this.brown3.UseVisualStyleBackColor = true;
            this.brown3.CheckedChanged += new System.EventHandler(this.brown3_CheckedChanged);
            // 
            // violet3
            // 
            this.violet3.AutoSize = true;
            this.violet3.ForeColor = System.Drawing.Color.Purple;
            this.violet3.Location = new System.Drawing.Point(23, 209);
            this.violet3.Name = "violet3";
            this.violet3.Size = new System.Drawing.Size(43, 19);
            this.violet3.TabIndex = 30;
            this.violet3.TabStop = true;
            this.violet3.Text = "■";
            this.violet3.UseVisualStyleBackColor = true;
            this.violet3.CheckedChanged += new System.EventHandler(this.violet3_CheckedChanged);
            // 
            // red3
            // 
            this.red3.AutoSize = true;
            this.red3.ForeColor = System.Drawing.Color.Red;
            this.red3.Location = new System.Drawing.Point(23, 84);
            this.red3.Name = "red3";
            this.red3.Size = new System.Drawing.Size(43, 19);
            this.red3.TabIndex = 25;
            this.red3.TabStop = true;
            this.red3.Text = "■";
            this.red3.UseVisualStyleBackColor = true;
            this.red3.CheckedChanged += new System.EventHandler(this.red3_CheckedChanged);
            // 
            // blue3
            // 
            this.blue3.AutoSize = true;
            this.blue3.ForeColor = System.Drawing.Color.Blue;
            this.blue3.Location = new System.Drawing.Point(23, 184);
            this.blue3.Name = "blue3";
            this.blue3.Size = new System.Drawing.Size(43, 19);
            this.blue3.TabIndex = 29;
            this.blue3.TabStop = true;
            this.blue3.Text = "■";
            this.blue3.UseVisualStyleBackColor = true;
            this.blue3.CheckedChanged += new System.EventHandler(this.blue3_CheckedChanged);
            // 
            // orange3
            // 
            this.orange3.AutoSize = true;
            this.orange3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orange3.Location = new System.Drawing.Point(23, 109);
            this.orange3.Name = "orange3";
            this.orange3.Size = new System.Drawing.Size(43, 19);
            this.orange3.TabIndex = 26;
            this.orange3.TabStop = true;
            this.orange3.Text = "■";
            this.orange3.UseVisualStyleBackColor = true;
            this.orange3.CheckedChanged += new System.EventHandler(this.orange3_CheckedChanged);
            // 
            // green3
            // 
            this.green3.AutoSize = true;
            this.green3.ForeColor = System.Drawing.Color.Green;
            this.green3.Location = new System.Drawing.Point(23, 159);
            this.green3.Name = "green3";
            this.green3.Size = new System.Drawing.Size(43, 19);
            this.green3.TabIndex = 28;
            this.green3.TabStop = true;
            this.green3.Text = "■";
            this.green3.UseVisualStyleBackColor = true;
            this.green3.CheckedChanged += new System.EventHandler(this.green3_CheckedChanged);
            // 
            // yellow3
            // 
            this.yellow3.AutoSize = true;
            this.yellow3.ForeColor = System.Drawing.Color.Yellow;
            this.yellow3.Location = new System.Drawing.Point(23, 134);
            this.yellow3.Name = "yellow3";
            this.yellow3.Size = new System.Drawing.Size(43, 19);
            this.yellow3.TabIndex = 27;
            this.yellow3.TabStop = true;
            this.yellow3.Text = "■";
            this.yellow3.UseVisualStyleBackColor = true;
            this.yellow3.CheckedChanged += new System.EventHandler(this.yellow3_CheckedChanged);
            // 
            // color2
            // 
            this.color2.Controls.Add(this.white2);
            this.color2.Controls.Add(this.black2);
            this.color2.Controls.Add(this.gray2);
            this.color2.Controls.Add(this.brown2);
            this.color2.Controls.Add(this.violet2);
            this.color2.Controls.Add(this.red2);
            this.color2.Controls.Add(this.blue2);
            this.color2.Controls.Add(this.orange2);
            this.color2.Controls.Add(this.green2);
            this.color2.Controls.Add(this.yellow2);
            this.color2.ForeColor = System.Drawing.Color.White;
            this.color2.Location = new System.Drawing.Point(107, 26);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(77, 358);
            this.color2.TabIndex = 1;
            this.color2.TabStop = false;
            this.color2.Text = "第二色";
            this.color2.Enter += new System.EventHandler(this.color2_Enter);
            // 
            // white2
            // 
            this.white2.AutoSize = true;
            this.white2.ForeColor = System.Drawing.Color.White;
            this.white2.Location = new System.Drawing.Point(16, 259);
            this.white2.Name = "white2";
            this.white2.Size = new System.Drawing.Size(43, 19);
            this.white2.TabIndex = 22;
            this.white2.TabStop = true;
            this.white2.Text = "■";
            this.white2.UseVisualStyleBackColor = true;
            this.white2.CheckedChanged += new System.EventHandler(this.white2_CheckedChanged);
            // 
            // black2
            // 
            this.black2.AutoSize = true;
            this.black2.ForeColor = System.Drawing.Color.Black;
            this.black2.Location = new System.Drawing.Point(16, 34);
            this.black2.Name = "black2";
            this.black2.Size = new System.Drawing.Size(43, 19);
            this.black2.TabIndex = 13;
            this.black2.TabStop = true;
            this.black2.Text = "■";
            this.black2.UseVisualStyleBackColor = true;
            this.black2.CheckedChanged += new System.EventHandler(this.black2_CheckedChanged);
            // 
            // gray2
            // 
            this.gray2.AutoSize = true;
            this.gray2.ForeColor = System.Drawing.Color.Gray;
            this.gray2.Location = new System.Drawing.Point(16, 234);
            this.gray2.Name = "gray2";
            this.gray2.Size = new System.Drawing.Size(43, 19);
            this.gray2.TabIndex = 21;
            this.gray2.TabStop = true;
            this.gray2.Text = "■";
            this.gray2.UseVisualStyleBackColor = true;
            this.gray2.CheckedChanged += new System.EventHandler(this.gray2_CheckedChanged);
            // 
            // brown2
            // 
            this.brown2.AutoSize = true;
            this.brown2.ForeColor = System.Drawing.Color.Maroon;
            this.brown2.Location = new System.Drawing.Point(16, 59);
            this.brown2.Name = "brown2";
            this.brown2.Size = new System.Drawing.Size(43, 19);
            this.brown2.TabIndex = 14;
            this.brown2.TabStop = true;
            this.brown2.Text = "■";
            this.brown2.UseVisualStyleBackColor = true;
            this.brown2.CheckedChanged += new System.EventHandler(this.brown2_CheckedChanged);
            // 
            // violet2
            // 
            this.violet2.AutoSize = true;
            this.violet2.ForeColor = System.Drawing.Color.Purple;
            this.violet2.Location = new System.Drawing.Point(16, 209);
            this.violet2.Name = "violet2";
            this.violet2.Size = new System.Drawing.Size(43, 19);
            this.violet2.TabIndex = 20;
            this.violet2.TabStop = true;
            this.violet2.Text = "■";
            this.violet2.UseVisualStyleBackColor = true;
            this.violet2.CheckedChanged += new System.EventHandler(this.violet2_CheckedChanged);
            // 
            // red2
            // 
            this.red2.AutoSize = true;
            this.red2.ForeColor = System.Drawing.Color.Red;
            this.red2.Location = new System.Drawing.Point(16, 84);
            this.red2.Name = "red2";
            this.red2.Size = new System.Drawing.Size(43, 19);
            this.red2.TabIndex = 15;
            this.red2.TabStop = true;
            this.red2.Text = "■";
            this.red2.UseVisualStyleBackColor = true;
            this.red2.CheckedChanged += new System.EventHandler(this.red2_CheckedChanged);
            // 
            // blue2
            // 
            this.blue2.AutoSize = true;
            this.blue2.ForeColor = System.Drawing.Color.Blue;
            this.blue2.Location = new System.Drawing.Point(16, 184);
            this.blue2.Name = "blue2";
            this.blue2.Size = new System.Drawing.Size(43, 19);
            this.blue2.TabIndex = 19;
            this.blue2.TabStop = true;
            this.blue2.Text = "■";
            this.blue2.UseVisualStyleBackColor = true;
            this.blue2.CheckedChanged += new System.EventHandler(this.blue2_CheckedChanged);
            // 
            // orange2
            // 
            this.orange2.AutoSize = true;
            this.orange2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orange2.Location = new System.Drawing.Point(16, 109);
            this.orange2.Name = "orange2";
            this.orange2.Size = new System.Drawing.Size(43, 19);
            this.orange2.TabIndex = 16;
            this.orange2.TabStop = true;
            this.orange2.Text = "■";
            this.orange2.UseVisualStyleBackColor = true;
            this.orange2.CheckedChanged += new System.EventHandler(this.orange2_CheckedChanged);
            // 
            // green2
            // 
            this.green2.AutoSize = true;
            this.green2.ForeColor = System.Drawing.Color.Green;
            this.green2.Location = new System.Drawing.Point(16, 159);
            this.green2.Name = "green2";
            this.green2.Size = new System.Drawing.Size(43, 19);
            this.green2.TabIndex = 18;
            this.green2.TabStop = true;
            this.green2.Text = "■";
            this.green2.UseVisualStyleBackColor = true;
            this.green2.CheckedChanged += new System.EventHandler(this.green2_CheckedChanged);
            // 
            // yellow2
            // 
            this.yellow2.AutoSize = true;
            this.yellow2.ForeColor = System.Drawing.Color.Yellow;
            this.yellow2.Location = new System.Drawing.Point(16, 134);
            this.yellow2.Name = "yellow2";
            this.yellow2.Size = new System.Drawing.Size(43, 19);
            this.yellow2.TabIndex = 17;
            this.yellow2.TabStop = true;
            this.yellow2.Text = "■";
            this.yellow2.UseVisualStyleBackColor = true;
            this.yellow2.CheckedChanged += new System.EventHandler(this.yellow2_CheckedChanged);
            // 
            // color1
            // 
            this.color1.Controls.Add(this.white1);
            this.color1.Controls.Add(this.gray1);
            this.color1.Controls.Add(this.violet1);
            this.color1.Controls.Add(this.blue1);
            this.color1.Controls.Add(this.green1);
            this.color1.Controls.Add(this.yellow1);
            this.color1.Controls.Add(this.orange1);
            this.color1.Controls.Add(this.red1);
            this.color1.Controls.Add(this.brown1);
            this.color1.Controls.Add(this.black1);
            this.color1.ForeColor = System.Drawing.Color.White;
            this.color1.Location = new System.Drawing.Point(15, 26);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(76, 358);
            this.color1.TabIndex = 0;
            this.color1.TabStop = false;
            this.color1.Text = "第一色";
            this.color1.Enter += new System.EventHandler(this.color1_Enter);
            // 
            // white1
            // 
            this.white1.AutoSize = true;
            this.white1.ForeColor = System.Drawing.Color.White;
            this.white1.Location = new System.Drawing.Point(15, 259);
            this.white1.Name = "white1";
            this.white1.Size = new System.Drawing.Size(43, 19);
            this.white1.TabIndex = 12;
            this.white1.TabStop = true;
            this.white1.Text = "■";
            this.white1.UseVisualStyleBackColor = true;
            this.white1.CheckedChanged += new System.EventHandler(this.white1_CheckedChanged);
            // 
            // gray1
            // 
            this.gray1.AutoSize = true;
            this.gray1.ForeColor = System.Drawing.Color.Gray;
            this.gray1.Location = new System.Drawing.Point(15, 234);
            this.gray1.Name = "gray1";
            this.gray1.Size = new System.Drawing.Size(43, 19);
            this.gray1.TabIndex = 11;
            this.gray1.TabStop = true;
            this.gray1.Text = "■";
            this.gray1.UseVisualStyleBackColor = true;
            this.gray1.CheckedChanged += new System.EventHandler(this.gray1_CheckedChanged);
            // 
            // violet1
            // 
            this.violet1.AutoSize = true;
            this.violet1.ForeColor = System.Drawing.Color.Purple;
            this.violet1.Location = new System.Drawing.Point(15, 209);
            this.violet1.Name = "violet1";
            this.violet1.Size = new System.Drawing.Size(43, 19);
            this.violet1.TabIndex = 10;
            this.violet1.TabStop = true;
            this.violet1.Text = "■";
            this.violet1.UseVisualStyleBackColor = true;
            this.violet1.CheckedChanged += new System.EventHandler(this.violet1_CheckedChanged);
            // 
            // blue1
            // 
            this.blue1.AutoSize = true;
            this.blue1.ForeColor = System.Drawing.Color.Blue;
            this.blue1.Location = new System.Drawing.Point(15, 184);
            this.blue1.Name = "blue1";
            this.blue1.Size = new System.Drawing.Size(43, 19);
            this.blue1.TabIndex = 9;
            this.blue1.TabStop = true;
            this.blue1.Text = "■";
            this.blue1.UseVisualStyleBackColor = true;
            this.blue1.CheckedChanged += new System.EventHandler(this.blue1_CheckedChanged);
            // 
            // green1
            // 
            this.green1.AutoSize = true;
            this.green1.ForeColor = System.Drawing.Color.Green;
            this.green1.Location = new System.Drawing.Point(15, 159);
            this.green1.Name = "green1";
            this.green1.Size = new System.Drawing.Size(43, 19);
            this.green1.TabIndex = 8;
            this.green1.TabStop = true;
            this.green1.Text = "■";
            this.green1.UseVisualStyleBackColor = true;
            this.green1.CheckedChanged += new System.EventHandler(this.green1_CheckedChanged);
            // 
            // yellow1
            // 
            this.yellow1.AutoSize = true;
            this.yellow1.ForeColor = System.Drawing.Color.Yellow;
            this.yellow1.Location = new System.Drawing.Point(15, 134);
            this.yellow1.Name = "yellow1";
            this.yellow1.Size = new System.Drawing.Size(43, 19);
            this.yellow1.TabIndex = 7;
            this.yellow1.TabStop = true;
            this.yellow1.Text = "■";
            this.yellow1.UseVisualStyleBackColor = true;
            this.yellow1.CheckedChanged += new System.EventHandler(this.yellow1_CheckedChanged);
            // 
            // orange1
            // 
            this.orange1.AutoSize = true;
            this.orange1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orange1.Location = new System.Drawing.Point(15, 109);
            this.orange1.Name = "orange1";
            this.orange1.Size = new System.Drawing.Size(43, 19);
            this.orange1.TabIndex = 6;
            this.orange1.TabStop = true;
            this.orange1.Text = "■";
            this.orange1.UseVisualStyleBackColor = true;
            this.orange1.CheckedChanged += new System.EventHandler(this.orange1_CheckedChanged);
            // 
            // red1
            // 
            this.red1.AutoSize = true;
            this.red1.ForeColor = System.Drawing.Color.Red;
            this.red1.Location = new System.Drawing.Point(15, 84);
            this.red1.Name = "red1";
            this.red1.Size = new System.Drawing.Size(43, 19);
            this.red1.TabIndex = 5;
            this.red1.TabStop = true;
            this.red1.Text = "■";
            this.red1.UseVisualStyleBackColor = true;
            this.red1.CheckedChanged += new System.EventHandler(this.red1_CheckedChanged);
            // 
            // brown1
            // 
            this.brown1.AutoSize = true;
            this.brown1.ForeColor = System.Drawing.Color.Maroon;
            this.brown1.Location = new System.Drawing.Point(15, 59);
            this.brown1.Name = "brown1";
            this.brown1.Size = new System.Drawing.Size(43, 19);
            this.brown1.TabIndex = 4;
            this.brown1.TabStop = true;
            this.brown1.Text = "■";
            this.brown1.UseVisualStyleBackColor = true;
            this.brown1.CheckedChanged += new System.EventHandler(this.brown1_CheckedChanged);
            // 
            // black1
            // 
            this.black1.AutoSize = true;
            this.black1.ForeColor = System.Drawing.Color.Black;
            this.black1.Location = new System.Drawing.Point(15, 34);
            this.black1.Name = "black1";
            this.black1.Size = new System.Drawing.Size(43, 19);
            this.black1.TabIndex = 0;
            this.black1.TabStop = true;
            this.black1.Text = "■";
            this.black1.UseVisualStyleBackColor = true;
            this.black1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.allClear);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.plus);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(569, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "串聯/並聯計算";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(123, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(123, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 10F);
            this.label6.Location = new System.Drawing.Point(246, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ω(ohm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 10F);
            this.label5.Location = new System.Drawing.Point(246, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ω(ohm)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 25);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 25);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 10F);
            this.label4.Location = new System.Drawing.Point(3, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "並聯 Parallel :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10F);
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "串聯 Serial :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(69, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "計算 Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Gainsboro;
            this.plus.Location = new System.Drawing.Point(16, 23);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(38, 39);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // allClear
            // 
            this.allClear.Location = new System.Drawing.Point(192, 23);
            this.allClear.Name = "allClear";
            this.allClear.Size = new System.Drawing.Size(117, 39);
            this.allClear.TabIndex = 10;
            this.allClear.Text = "清除 AC";
            this.allClear.UseVisualStyleBackColor = true;
            this.allClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 533);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "工具人的工具";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.error.ResumeLayout(false);
            this.error.PerformLayout();
            this.multiple.ResumeLayout(false);
            this.multiple.PerformLayout();
            this.color2.ResumeLayout(false);
            this.color2.PerformLayout();
            this.color1.ResumeLayout(false);
            this.color1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox error;
        private System.Windows.Forms.GroupBox multiple;
        private System.Windows.Forms.GroupBox color2;
        private System.Windows.Forms.GroupBox color1;
        private System.Windows.Forms.RadioButton white1;
        private System.Windows.Forms.RadioButton gray1;
        private System.Windows.Forms.RadioButton violet1;
        private System.Windows.Forms.RadioButton blue1;
        private System.Windows.Forms.RadioButton green1;
        private System.Windows.Forms.RadioButton yellow1;
        private System.Windows.Forms.RadioButton orange1;
        private System.Windows.Forms.RadioButton red1;
        private System.Windows.Forms.RadioButton brown1;
        private System.Windows.Forms.RadioButton black1;
        private System.Windows.Forms.RadioButton white2;
        private System.Windows.Forms.RadioButton black2;
        private System.Windows.Forms.RadioButton gray2;
        private System.Windows.Forms.RadioButton brown2;
        private System.Windows.Forms.RadioButton violet2;
        private System.Windows.Forms.RadioButton red2;
        private System.Windows.Forms.RadioButton blue2;
        private System.Windows.Forms.RadioButton orange2;
        private System.Windows.Forms.RadioButton green2;
        private System.Windows.Forms.RadioButton yellow2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton lightgray4;
        private System.Windows.Forms.RadioButton golden4;
        private System.Windows.Forms.RadioButton green4;
        private System.Windows.Forms.RadioButton blue4;
        private System.Windows.Forms.RadioButton brown4;
        private System.Windows.Forms.RadioButton red4;
        private System.Windows.Forms.RadioButton violet4;
        private System.Windows.Forms.RadioButton lightgray3;
        private System.Windows.Forms.RadioButton golden3;
        private System.Windows.Forms.RadioButton white3;
        private System.Windows.Forms.RadioButton black3;
        private System.Windows.Forms.RadioButton gray3;
        private System.Windows.Forms.RadioButton brown3;
        private System.Windows.Forms.RadioButton violet3;
        private System.Windows.Forms.RadioButton red3;
        private System.Windows.Forms.RadioButton blue3;
        private System.Windows.Forms.RadioButton orange3;
        private System.Windows.Forms.RadioButton green3;
        private System.Windows.Forms.RadioButton yellow3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button allClear;
    }
}

