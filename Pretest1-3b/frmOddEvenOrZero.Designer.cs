namespace Pretest1_3b
{
    partial class frmOddEvenOrZero
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
            this.txtInputNumber = new System.Windows.Forms.TextBox();
            this.lblInputNumber = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnShowStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputNumber
            // 
            this.txtInputNumber.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputNumber.Location = new System.Drawing.Point(197, 158);
            this.txtInputNumber.Name = "txtInputNumber";
            this.txtInputNumber.Size = new System.Drawing.Size(430, 44);
            this.txtInputNumber.TabIndex = 0;
            this.txtInputNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInputNumber
            // 
            this.lblInputNumber.BackColor = System.Drawing.Color.Blue;
            this.lblInputNumber.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputNumber.ForeColor = System.Drawing.Color.White;
            this.lblInputNumber.Location = new System.Drawing.Point(194, 49);
            this.lblInputNumber.Name = "lblInputNumber";
            this.lblInputNumber.Size = new System.Drawing.Size(433, 71);
            this.lblInputNumber.TabIndex = 3;
            this.lblInputNumber.Text = "Enter A Whole Number:";
            this.lblInputNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.Color.Blue;
            this.lblAnswer.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAnswer.Location = new System.Drawing.Point(93, 330);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(614, 71);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowStatus
            // 
            this.btnShowStatus.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStatus.Location = new System.Drawing.Point(239, 235);
            this.btnShowStatus.Name = "btnShowStatus";
            this.btnShowStatus.Size = new System.Drawing.Size(342, 70);
            this.btnShowStatus.TabIndex = 1;
            this.btnShowStatus.Text = "Show Status";
            this.btnShowStatus.UseVisualStyleBackColor = true;
            this.btnShowStatus.Click += new System.EventHandler(this.btnShowStatus_Click);
            // 
            // frmOddEvenOrZero
            // 
            this.AcceptButton = this.btnShowStatus;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInputNumber);
            this.Controls.Add(this.lblInputNumber);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnShowStatus);
            this.Name = "frmOddEvenOrZero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ODD NUMBER, EVEN NUMBER, OR 0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputNumber;
        private System.Windows.Forms.Label lblInputNumber;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnShowStatus;
    }
}

