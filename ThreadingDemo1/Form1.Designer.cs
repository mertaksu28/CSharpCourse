﻿
namespace ThreadingDemo1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcess1 = new System.Windows.Forms.Button();
            this.btnProcess2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcess1
            // 
            this.btnProcess1.Location = new System.Drawing.Point(68, 73);
            this.btnProcess1.Name = "btnProcess1";
            this.btnProcess1.Size = new System.Drawing.Size(126, 49);
            this.btnProcess1.TabIndex = 0;
            this.btnProcess1.Text = "işlem1";
            this.btnProcess1.UseVisualStyleBackColor = true;
            this.btnProcess1.Click += new System.EventHandler(this.btnProcess1_Click);
            // 
            // btnProcess2
            // 
            this.btnProcess2.Location = new System.Drawing.Point(240, 72);
            this.btnProcess2.Name = "btnProcess2";
            this.btnProcess2.Size = new System.Drawing.Size(126, 49);
            this.btnProcess2.TabIndex = 1;
            this.btnProcess2.Text = "işlem2";
            this.btnProcess2.UseVisualStyleBackColor = true;
            this.btnProcess2.Click += new System.EventHandler(this.btnProcess2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcess2);
            this.Controls.Add(this.btnProcess1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcess1;
        private System.Windows.Forms.Button btnProcess2;
    }
}

