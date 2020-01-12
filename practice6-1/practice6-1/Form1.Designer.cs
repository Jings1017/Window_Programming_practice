namespace practice6_1
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
            this.ball = new System.Windows.Forms.PictureBox();
            this.board = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.enemyTmr = new System.Windows.Forms.Timer(this.components);
            this.ballTmr = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.easy = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.Button();
            this.standard = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.Location = new System.Drawing.Point(206, 382);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(100, 30);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.Color.Gray;
            this.board.Location = new System.Drawing.Point(170, 450);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(150, 40);
            this.board.TabIndex = 1;
            this.board.TabStop = false;
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.Color.Gray;
            this.enemy.Location = new System.Drawing.Point(150, 275);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(100, 40);
            this.enemy.TabIndex = 2;
            this.enemy.TabStop = false;
            this.enemy.Click += new System.EventHandler(this.barrier_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.enemy);
            this.panel1.Controls.Add(this.board);
            this.panel1.Controls.Add(this.ball);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 3;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.board_move);
            // 
            // enemyTmr
            // 
            this.enemyTmr.Tick += new System.EventHandler(this.enemyTmr_Tick);
            // 
            // ballTmr
            // 
            this.ballTmr.Tick += new System.EventHandler(this.ballTmr_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "score";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 540);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // easy
            // 
            this.easy.Location = new System.Drawing.Point(539, 54);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(75, 23);
            this.easy.TabIndex = 5;
            this.easy.Text = "easy";
            this.easy.UseVisualStyleBackColor = true;
            this.easy.Click += new System.EventHandler(this.easy_Click);
            // 
            // hard
            // 
            this.hard.Location = new System.Drawing.Point(539, 143);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(75, 23);
            this.hard.TabIndex = 6;
            this.hard.Text = "hard";
            this.hard.UseVisualStyleBackColor = true;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // standard
            // 
            this.standard.Location = new System.Drawing.Point(539, 99);
            this.standard.Name = "standard";
            this.standard.Size = new System.Drawing.Size(75, 23);
            this.standard.TabIndex = 7;
            this.standard.Text = "standard";
            this.standard.UseVisualStyleBackColor = true;
            this.standard.Click += new System.EventHandler(this.standard_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "level";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.standard);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "來打我啊";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox board;
        private System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer enemyTmr;
        private System.Windows.Forms.Timer ballTmr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.Button standard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

