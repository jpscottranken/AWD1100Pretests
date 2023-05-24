namespace Pretest2_2GGGUI
{
    partial class frmGGGUI
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCurrentGuess = new System.Windows.Forms.Label();
            this.lblGuessStatus = new System.Windows.Forms.Label();
            this.lblRanking = new System.Windows.Forms.Label();
            this.txtCurrentGuess = new System.Windows.Forms.TextBox();
            this.txtGuessStatus = new System.Windows.Forms.TextBox();
            this.txtRanking = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(40, 348);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(166, 64);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(225, 348);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(166, 64);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(409, 348);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 64);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(601, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 64);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCurrentGuess
            // 
            this.lblCurrentGuess.BackColor = System.Drawing.Color.Yellow;
            this.lblCurrentGuess.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentGuess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCurrentGuess.Location = new System.Drawing.Point(49, 41);
            this.lblCurrentGuess.Name = "lblCurrentGuess";
            this.lblCurrentGuess.Size = new System.Drawing.Size(219, 47);
            this.lblCurrentGuess.TabIndex = 7;
            this.lblCurrentGuess.Text = "Current Guess:";
            this.lblCurrentGuess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGuessStatus
            // 
            this.lblGuessStatus.BackColor = System.Drawing.Color.Yellow;
            this.lblGuessStatus.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessStatus.Location = new System.Drawing.Point(49, 144);
            this.lblGuessStatus.Name = "lblGuessStatus";
            this.lblGuessStatus.Size = new System.Drawing.Size(219, 47);
            this.lblGuessStatus.TabIndex = 8;
            this.lblGuessStatus.Text = "Guess Status:";
            this.lblGuessStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRanking
            // 
            this.lblRanking.BackColor = System.Drawing.Color.Yellow;
            this.lblRanking.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRanking.Location = new System.Drawing.Point(49, 249);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(219, 47);
            this.lblRanking.TabIndex = 9;
            this.lblRanking.Text = "Ranking:";
            this.lblRanking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCurrentGuess
            // 
            this.txtCurrentGuess.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentGuess.Location = new System.Drawing.Point(322, 41);
            this.txtCurrentGuess.Name = "txtCurrentGuess";
            this.txtCurrentGuess.Size = new System.Drawing.Size(253, 44);
            this.txtCurrentGuess.TabIndex = 0;
            this.txtCurrentGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGuessStatus
            // 
            this.txtGuessStatus.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuessStatus.Location = new System.Drawing.Point(322, 141);
            this.txtGuessStatus.Name = "txtGuessStatus";
            this.txtGuessStatus.ReadOnly = true;
            this.txtGuessStatus.Size = new System.Drawing.Size(253, 44);
            this.txtGuessStatus.TabIndex = 5;
            this.txtGuessStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRanking
            // 
            this.txtRanking.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRanking.Location = new System.Drawing.Point(322, 246);
            this.txtRanking.Name = "txtRanking";
            this.txtRanking.ReadOnly = true;
            this.txtRanking.Size = new System.Drawing.Size(253, 44);
            this.txtRanking.TabIndex = 6;
            this.txtRanking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmGGGUI
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRanking);
            this.Controls.Add(this.txtGuessStatus);
            this.Controls.Add(this.txtCurrentGuess);
            this.Controls.Add(this.lblRanking);
            this.Controls.Add(this.lblGuessStatus);
            this.Controls.Add(this.lblCurrentGuess);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnNewGame);
            this.Name = "frmGGGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWD1100 - C# Pretest #2 - Guessing Game App";
            this.Load += new System.EventHandler(this.frmGGGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCurrentGuess;
        private System.Windows.Forms.Label lblGuessStatus;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.TextBox txtCurrentGuess;
        private System.Windows.Forms.TextBox txtGuessStatus;
        private System.Windows.Forms.TextBox txtRanking;
    }
}

