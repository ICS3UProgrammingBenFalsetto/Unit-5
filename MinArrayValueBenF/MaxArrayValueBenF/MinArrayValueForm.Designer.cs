﻿namespace MaxArrayValueBenF
{
    partial class frmMinArrayValue
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lblMinVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(134, 61);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(111, 124);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(120, 95);
            this.lstNumbers.TabIndex = 1;
            // 
            // lblMinVal
            // 
            this.lblMinVal.AutoSize = true;
            this.lblMinVal.Location = new System.Drawing.Point(108, 251);
            this.lblMinVal.Name = "lblMinVal";
            this.lblMinVal.Size = new System.Drawing.Size(87, 13);
            this.lblMinVal.TabIndex = 2;
            this.lblMinVal.Text = "The min value is:";
            this.lblMinVal.Visible = false;
            // 
            // frmMinArrayValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 303);
            this.Controls.Add(this.lblMinVal);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMinArrayValue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Min Array Value Benjamin Falsetto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Label lblMinVal;
    }
}

