namespace Pong_Game
{
    partial class pong
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
            this.player1 = new System.Windows.Forms.PictureBox();
            this.cpuPlayer = new System.Windows.Forms.PictureBox();
            this.pongBall = new System.Windows.Forms.PictureBox();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.cpuScoreLabel = new System.Windows.Forms.Label();
            this.pongTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.White;
            this.player1.Location = new System.Drawing.Point(12, 246);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(24, 166);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // cpuPlayer
            // 
            this.cpuPlayer.BackColor = System.Drawing.Color.White;
            this.cpuPlayer.Location = new System.Drawing.Point(1077, 246);
            this.cpuPlayer.Name = "cpuPlayer";
            this.cpuPlayer.Size = new System.Drawing.Size(24, 166);
            this.cpuPlayer.TabIndex = 1;
            this.cpuPlayer.TabStop = false;
            // 
            // pongBall
            // 
            this.pongBall.BackColor = System.Drawing.Color.White;
            this.pongBall.Location = new System.Drawing.Point(546, 309);
            this.pongBall.Name = "pongBall";
            this.pongBall.Size = new System.Drawing.Size(20, 20);
            this.pongBall.TabIndex = 2;
            this.pongBall.TabStop = false;
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.playerScoreLabel.Location = new System.Drawing.Point(305, 15);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(56, 61);
            this.playerScoreLabel.TabIndex = 3;
            this.playerScoreLabel.Text = "0";
            // 
            // cpuScoreLabel
            // 
            this.cpuScoreLabel.AutoSize = true;
            this.cpuScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuScoreLabel.ForeColor = System.Drawing.Color.White;
            this.cpuScoreLabel.Location = new System.Drawing.Point(844, 15);
            this.cpuScoreLabel.Name = "cpuScoreLabel";
            this.cpuScoreLabel.Size = new System.Drawing.Size(56, 61);
            this.cpuScoreLabel.TabIndex = 4;
            this.cpuScoreLabel.Text = "0";
            // 
            // pongTimer
            // 
            this.pongTimer.Enabled = true;
            this.pongTimer.Interval = 20;
            this.pongTimer.Tick += new System.EventHandler(this.pongTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(701, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(493, 605);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Space = Menu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1113, 656);
            this.Controls.Add(this.pongBall);
            this.Controls.Add(this.cpuPlayer);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.cpuScoreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "pong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox cpuPlayer;
        private System.Windows.Forms.PictureBox pongBall;
        public System.Windows.Forms.Timer pongTimer;
        public System.Windows.Forms.Label playerScoreLabel;
        public System.Windows.Forms.Label cpuScoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

