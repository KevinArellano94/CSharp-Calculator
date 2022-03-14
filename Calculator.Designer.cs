namespace Calculator
{
    partial class Calculator
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
            this.button_On_Off = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.textBox_Main = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_On_Off
            // 
            this.button_On_Off.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_On_Off.Location = new System.Drawing.Point(12, 415);
            this.button_On_Off.Name = "button_On_Off";
            this.button_On_Off.Size = new System.Drawing.Size(75, 23);
            this.button_On_Off.TabIndex = 0;
            this.button_On_Off.Text = "On/Off";
            this.button_On_Off.UseVisualStyleBackColor = true;
            this.button_On_Off.Click += new System.EventHandler(this.button_On_Off_Click);
            // 
            // button_0
            // 
            this.button_0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_0.Location = new System.Drawing.Point(93, 415);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(75, 23);
            this.button_0.TabIndex = 1;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // textBox_Main
            // 
            this.textBox_Main.Location = new System.Drawing.Point(12, 12);
            this.textBox_Main.Name = "textBox_Main";
            this.textBox_Main.Size = new System.Drawing.Size(776, 20);
            this.textBox_Main.TabIndex = 2;
            this.textBox_Main.TextChanged += new System.EventHandler(this.textBox_Main_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // button_1
            // 
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_1.Location = new System.Drawing.Point(93, 386);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(75, 23);
            this.button_1.TabIndex = 4;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_2
            // 
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_2.Location = new System.Drawing.Point(174, 386);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(75, 23);
            this.button_2.TabIndex = 5;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Main);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_On_Off);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_On_Off;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.TextBox textBox_Main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
    }
}

