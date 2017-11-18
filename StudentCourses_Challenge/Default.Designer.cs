namespace StudentCourses_Challenge
{
    partial class Default
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
            this.assignment1Button = new System.Windows.Forms.Button();
            this.assignment2Button = new System.Windows.Forms.Button();
            this.assignment3Button = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // assignment1Button
            // 
            this.assignment1Button.Location = new System.Drawing.Point(6, 19);
            this.assignment1Button.Name = "assignment1Button";
            this.assignment1Button.Size = new System.Drawing.Size(90, 23);
            this.assignment1Button.TabIndex = 0;
            this.assignment1Button.Text = "Assignment 1";
            this.assignment1Button.UseVisualStyleBackColor = true;
            this.assignment1Button.Click += new System.EventHandler(this.assignment1Button_Click);
            // 
            // assignment2Button
            // 
            this.assignment2Button.Location = new System.Drawing.Point(6, 48);
            this.assignment2Button.Name = "assignment2Button";
            this.assignment2Button.Size = new System.Drawing.Size(90, 23);
            this.assignment2Button.TabIndex = 1;
            this.assignment2Button.Text = "Assignment 2";
            this.assignment2Button.UseVisualStyleBackColor = true;
            this.assignment2Button.Click += new System.EventHandler(this.assignment2Button_Click);
            // 
            // assignment3Button
            // 
            this.assignment3Button.Location = new System.Drawing.Point(6, 77);
            this.assignment3Button.Name = "assignment3Button";
            this.assignment3Button.Size = new System.Drawing.Size(90, 23);
            this.assignment3Button.TabIndex = 2;
            this.assignment3Button.Text = "Assignment 3";
            this.assignment3Button.UseVisualStyleBackColor = true;
            this.assignment3Button.Click += new System.EventHandler(this.assignment3Button_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(6, 11);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 3;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(188, 313);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assignment1Button);
            this.groupBox1.Controls.Add(this.assignment2Button);
            this.groupBox1.Controls.Add(this.assignment3Button);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultLabel);
            this.groupBox2.Location = new System.Drawing.Point(13, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 172);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Click this to clear the \"Output\"after\r\neach Assignment button is pushed.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resetButton);
            this.Name = "Default";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button assignment1Button;
        private System.Windows.Forms.Button assignment2Button;
        private System.Windows.Forms.Button assignment3Button;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

