namespace Pretest1_1
{
    partial class frmDistanceConverter
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblInputFeet = new System.Windows.Forms.Label();
            this.txtInputFeet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(240, 214);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(342, 70);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert to yds";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.Color.Fuchsia;
            this.lblAnswer.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(94, 309);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(614, 71);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputFeet
            // 
            this.lblInputFeet.BackColor = System.Drawing.Color.Fuchsia;
            this.lblInputFeet.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputFeet.Location = new System.Drawing.Point(195, 28);
            this.lblInputFeet.Name = "lblInputFeet";
            this.lblInputFeet.Size = new System.Drawing.Size(433, 71);
            this.lblInputFeet.TabIndex = 3;
            this.lblInputFeet.Text = "Distance In Feet:";
            this.lblInputFeet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInputFeet
            // 
            this.txtInputFeet.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputFeet.Location = new System.Drawing.Point(198, 137);
            this.txtInputFeet.Name = "txtInputFeet";
            this.txtInputFeet.Size = new System.Drawing.Size(430, 44);
            this.txtInputFeet.TabIndex = 0;
            this.txtInputFeet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmDistanceConverter
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInputFeet);
            this.Controls.Add(this.lblInputFeet);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnConvert);
            this.Name = "frmDistanceConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distance Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblInputFeet;
        private System.Windows.Forms.TextBox txtInputFeet;
    }
}

