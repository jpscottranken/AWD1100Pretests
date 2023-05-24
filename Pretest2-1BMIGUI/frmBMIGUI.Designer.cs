namespace Pretest2_1BMIGUI
{
    partial class frmBMIGUI
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblBMIStatus = new System.Windows.Forms.Label();
            this.lblTotalObese = new System.Windows.Forms.Label();
            this.lblTotalOvers = new System.Windows.Forms.Label();
            this.lblTotalOptimal = new System.Windows.Forms.Label();
            this.lblTotalUnders = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.txtBMIStatus = new System.Windows.Forms.TextBox();
            this.txtTotalObese = new System.Windows.Forms.TextBox();
            this.txtTotalOvers = new System.Windows.Forms.TextBox();
            this.txtTotalOptimal = new System.Windows.Forms.TextBox();
            this.txtTotalUnders = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(125, 344);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 74);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(506, 344);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 74);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(924, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 74);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.BackColor = System.Drawing.Color.Blue;
            this.lblHeight.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.ForeColor = System.Drawing.Color.White;
            this.lblHeight.Location = new System.Drawing.Point(128, 22);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(203, 38);
            this.lblHeight.TabIndex = 11;
            this.lblHeight.Text = "Height:";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWeight
            // 
            this.lblWeight.BackColor = System.Drawing.Color.Blue;
            this.lblWeight.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.White;
            this.lblWeight.Location = new System.Drawing.Point(128, 116);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(203, 38);
            this.lblWeight.TabIndex = 12;
            this.lblWeight.Text = "Weight:";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBMI
            // 
            this.lblBMI.BackColor = System.Drawing.Color.Blue;
            this.lblBMI.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.ForeColor = System.Drawing.Color.White;
            this.lblBMI.Location = new System.Drawing.Point(128, 197);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(203, 38);
            this.lblBMI.TabIndex = 13;
            this.lblBMI.Text = "BMI:";
            this.lblBMI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBMIStatus
            // 
            this.lblBMIStatus.BackColor = System.Drawing.Color.Blue;
            this.lblBMIStatus.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMIStatus.ForeColor = System.Drawing.Color.White;
            this.lblBMIStatus.Location = new System.Drawing.Point(128, 282);
            this.lblBMIStatus.Name = "lblBMIStatus";
            this.lblBMIStatus.Size = new System.Drawing.Size(203, 38);
            this.lblBMIStatus.TabIndex = 14;
            this.lblBMIStatus.Text = "BMI Status:";
            this.lblBMIStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalObese
            // 
            this.lblTotalObese.BackColor = System.Drawing.Color.Blue;
            this.lblTotalObese.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalObese.ForeColor = System.Drawing.Color.White;
            this.lblTotalObese.Location = new System.Drawing.Point(707, 282);
            this.lblTotalObese.Name = "lblTotalObese";
            this.lblTotalObese.Size = new System.Drawing.Size(203, 38);
            this.lblTotalObese.TabIndex = 18;
            this.lblTotalObese.Text = "Total Obese:";
            this.lblTotalObese.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalOvers
            // 
            this.lblTotalOvers.BackColor = System.Drawing.Color.Blue;
            this.lblTotalOvers.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOvers.ForeColor = System.Drawing.Color.White;
            this.lblTotalOvers.Location = new System.Drawing.Point(707, 197);
            this.lblTotalOvers.Name = "lblTotalOvers";
            this.lblTotalOvers.Size = new System.Drawing.Size(203, 38);
            this.lblTotalOvers.TabIndex = 17;
            this.lblTotalOvers.Text = "Total Overs:";
            this.lblTotalOvers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalOptimal
            // 
            this.lblTotalOptimal.BackColor = System.Drawing.Color.Blue;
            this.lblTotalOptimal.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOptimal.ForeColor = System.Drawing.Color.White;
            this.lblTotalOptimal.Location = new System.Drawing.Point(707, 116);
            this.lblTotalOptimal.Name = "lblTotalOptimal";
            this.lblTotalOptimal.Size = new System.Drawing.Size(203, 38);
            this.lblTotalOptimal.TabIndex = 16;
            this.lblTotalOptimal.Text = "Total Optimal:";
            this.lblTotalOptimal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalUnders
            // 
            this.lblTotalUnders.BackColor = System.Drawing.Color.Blue;
            this.lblTotalUnders.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUnders.ForeColor = System.Drawing.Color.White;
            this.lblTotalUnders.Location = new System.Drawing.Point(707, 22);
            this.lblTotalUnders.Name = "lblTotalUnders";
            this.lblTotalUnders.Size = new System.Drawing.Size(203, 38);
            this.lblTotalUnders.TabIndex = 15;
            this.lblTotalUnders.Text = "Total Unders:";
            this.lblTotalUnders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(361, 22);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(293, 44);
            this.txtHeight.TabIndex = 0;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(361, 116);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(293, 44);
            this.txtWeight.TabIndex = 1;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBMI
            // 
            this.txtBMI.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMI.Location = new System.Drawing.Point(361, 197);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.ReadOnly = true;
            this.txtBMI.Size = new System.Drawing.Size(293, 44);
            this.txtBMI.TabIndex = 5;
            this.txtBMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBMIStatus
            // 
            this.txtBMIStatus.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMIStatus.Location = new System.Drawing.Point(361, 282);
            this.txtBMIStatus.Name = "txtBMIStatus";
            this.txtBMIStatus.ReadOnly = true;
            this.txtBMIStatus.Size = new System.Drawing.Size(293, 44);
            this.txtBMIStatus.TabIndex = 6;
            this.txtBMIStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalObese
            // 
            this.txtTotalObese.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalObese.Location = new System.Drawing.Point(938, 282);
            this.txtTotalObese.Name = "txtTotalObese";
            this.txtTotalObese.ReadOnly = true;
            this.txtTotalObese.Size = new System.Drawing.Size(299, 44);
            this.txtTotalObese.TabIndex = 10;
            this.txtTotalObese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalOvers
            // 
            this.txtTotalOvers.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOvers.Location = new System.Drawing.Point(938, 197);
            this.txtTotalOvers.Name = "txtTotalOvers";
            this.txtTotalOvers.ReadOnly = true;
            this.txtTotalOvers.Size = new System.Drawing.Size(299, 44);
            this.txtTotalOvers.TabIndex = 9;
            this.txtTotalOvers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalOptimal
            // 
            this.txtTotalOptimal.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOptimal.Location = new System.Drawing.Point(938, 116);
            this.txtTotalOptimal.Name = "txtTotalOptimal";
            this.txtTotalOptimal.ReadOnly = true;
            this.txtTotalOptimal.Size = new System.Drawing.Size(299, 44);
            this.txtTotalOptimal.TabIndex = 8;
            this.txtTotalOptimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalUnders
            // 
            this.txtTotalUnders.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalUnders.Location = new System.Drawing.Point(938, 22);
            this.txtTotalUnders.Name = "txtTotalUnders";
            this.txtTotalUnders.ReadOnly = true;
            this.txtTotalUnders.Size = new System.Drawing.Size(299, 44);
            this.txtTotalUnders.TabIndex = 7;
            this.txtTotalUnders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmBMIGUI
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1338, 454);
            this.Controls.Add(this.txtTotalObese);
            this.Controls.Add(this.txtTotalOvers);
            this.Controls.Add(this.txtTotalOptimal);
            this.Controls.Add(this.txtTotalUnders);
            this.Controls.Add(this.txtBMIStatus);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblTotalObese);
            this.Controls.Add(this.lblTotalOvers);
            this.Controls.Add(this.lblTotalOptimal);
            this.Controls.Add(this.lblTotalUnders);
            this.Controls.Add(this.lblBMIStatus);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmBMIGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWD1100 - C# Pretest #2 - BMI App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblBMIStatus;
        private System.Windows.Forms.Label lblTotalObese;
        private System.Windows.Forms.Label lblTotalOvers;
        private System.Windows.Forms.Label lblTotalOptimal;
        private System.Windows.Forms.Label lblTotalUnders;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.TextBox txtBMIStatus;
        private System.Windows.Forms.TextBox txtTotalObese;
        private System.Windows.Forms.TextBox txtTotalOvers;
        private System.Windows.Forms.TextBox txtTotalOptimal;
        private System.Windows.Forms.TextBox txtTotalUnders;
    }
}

