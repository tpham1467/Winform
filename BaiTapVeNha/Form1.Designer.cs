
namespace BaiTapVeNha
{
    partial class Form1
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
            Write_File();
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
            this.textBox_SecurityCode = new System.Windows.Forms.TextBox();
            this.label_SecurityPanel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_AccessLog = new System.Windows.Forms.ListBox();
            this.button_NumberZero = new System.Windows.Forms.Button();
            this.button_NumberNine = new System.Windows.Forms.Button();
            this.button_NumberEight = new System.Windows.Forms.Button();
            this.button_NumberSeven = new System.Windows.Forms.Button();
            this.button_NumberAcept = new System.Windows.Forms.Button();
            this.button_NumberSix = new System.Windows.Forms.Button();
            this.button_NumberFive = new System.Windows.Forms.Button();
            this.button_NumberFour = new System.Windows.Forms.Button();
            this.button_NumberClear = new System.Windows.Forms.Button();
            this.button_NumberThree = new System.Windows.Forms.Button();
            this.button_NumberTwo = new System.Windows.Forms.Button();
            this.button_NumberOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_SecurityCode
            // 
            this.textBox_SecurityCode.Enabled = false;
            this.textBox_SecurityCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SecurityCode.Location = new System.Drawing.Point(222, 43);
            this.textBox_SecurityCode.Multiline = true;
            this.textBox_SecurityCode.Name = "textBox_SecurityCode";
            this.textBox_SecurityCode.PasswordChar = '*';
            this.textBox_SecurityCode.Size = new System.Drawing.Size(224, 22);
            this.textBox_SecurityCode.TabIndex = 0;
            this.textBox_SecurityCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_SecurityPanel
            // 
            this.label_SecurityPanel.AutoSize = true;
            this.label_SecurityPanel.Location = new System.Drawing.Point(105, 46);
            this.label_SecurityPanel.Name = "label_SecurityPanel";
            this.label_SecurityPanel.Size = new System.Drawing.Size(99, 17);
            this.label_SecurityPanel.TabIndex = 1;
            this.label_SecurityPanel.Text = "Security Panel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Access Log :";
            // 
            // listBox_AccessLog
            // 
            this.listBox_AccessLog.FormattingEnabled = true;
            this.listBox_AccessLog.ItemHeight = 16;
            this.listBox_AccessLog.Location = new System.Drawing.Point(6, 254);
            this.listBox_AccessLog.Margin = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.listBox_AccessLog.Name = "listBox_AccessLog";
            this.listBox_AccessLog.Size = new System.Drawing.Size(498, 212);
            this.listBox_AccessLog.TabIndex = 4;
            // 
            // button_NumberZero
            // 
            this.button_NumberZero.Location = new System.Drawing.Point(351, 167);
            this.button_NumberZero.Name = "button_NumberZero";
            this.button_NumberZero.Size = new System.Drawing.Size(75, 23);
            this.button_NumberZero.TabIndex = 9;
            this.button_NumberZero.Text = "0";
            this.button_NumberZero.UseVisualStyleBackColor = true;
            // 
            // button_NumberNine
            // 
            this.button_NumberNine.Location = new System.Drawing.Point(270, 167);
            this.button_NumberNine.Name = "button_NumberNine";
            this.button_NumberNine.Size = new System.Drawing.Size(75, 23);
            this.button_NumberNine.TabIndex = 8;
            this.button_NumberNine.Text = "9";
            this.button_NumberNine.UseVisualStyleBackColor = true;
            // 
            // button_NumberEight
            // 
            this.button_NumberEight.Location = new System.Drawing.Point(189, 167);
            this.button_NumberEight.Name = "button_NumberEight";
            this.button_NumberEight.Size = new System.Drawing.Size(75, 23);
            this.button_NumberEight.TabIndex = 7;
            this.button_NumberEight.Text = "8";
            this.button_NumberEight.UseVisualStyleBackColor = true;
            // 
            // button_NumberSeven
            // 
            this.button_NumberSeven.Location = new System.Drawing.Point(108, 167);
            this.button_NumberSeven.Name = "button_NumberSeven";
            this.button_NumberSeven.Size = new System.Drawing.Size(75, 23);
            this.button_NumberSeven.TabIndex = 6;
            this.button_NumberSeven.Text = "7";
            this.button_NumberSeven.UseVisualStyleBackColor = true;
            // 
            // button_NumberAcept
            // 
            this.button_NumberAcept.Location = new System.Drawing.Point(351, 109);
            this.button_NumberAcept.Name = "button_NumberAcept";
            this.button_NumberAcept.Size = new System.Drawing.Size(75, 23);
            this.button_NumberAcept.TabIndex = 11;
            this.button_NumberAcept.Text = "A";
            this.button_NumberAcept.UseVisualStyleBackColor = true;
            // 
            // button_NumberSix
            // 
            this.button_NumberSix.Location = new System.Drawing.Point(270, 138);
            this.button_NumberSix.Name = "button_NumberSix";
            this.button_NumberSix.Size = new System.Drawing.Size(75, 23);
            this.button_NumberSix.TabIndex = 5;
            this.button_NumberSix.Text = "6";
            this.button_NumberSix.UseVisualStyleBackColor = true;
            // 
            // button_NumberFive
            // 
            this.button_NumberFive.Location = new System.Drawing.Point(189, 138);
            this.button_NumberFive.Name = "button_NumberFive";
            this.button_NumberFive.Size = new System.Drawing.Size(75, 23);
            this.button_NumberFive.TabIndex = 4;
            this.button_NumberFive.Text = "5";
            this.button_NumberFive.UseVisualStyleBackColor = true;
            // 
            // button_NumberFour
            // 
            this.button_NumberFour.Location = new System.Drawing.Point(108, 138);
            this.button_NumberFour.Name = "button_NumberFour";
            this.button_NumberFour.Size = new System.Drawing.Size(75, 23);
            this.button_NumberFour.TabIndex = 3;
            this.button_NumberFour.Text = "4";
            this.button_NumberFour.UseVisualStyleBackColor = true;
            // 
            // button_NumberClear
            // 
            this.button_NumberClear.Location = new System.Drawing.Point(351, 138);
            this.button_NumberClear.Name = "button_NumberClear";
            this.button_NumberClear.Size = new System.Drawing.Size(75, 23);
            this.button_NumberClear.TabIndex = 10;
            this.button_NumberClear.Text = "C";
            this.button_NumberClear.UseVisualStyleBackColor = true;
            // 
            // button_NumberThree
            // 
            this.button_NumberThree.Location = new System.Drawing.Point(270, 109);
            this.button_NumberThree.Name = "button_NumberThree";
            this.button_NumberThree.Size = new System.Drawing.Size(75, 23);
            this.button_NumberThree.TabIndex = 2;
            this.button_NumberThree.Text = "3";
            this.button_NumberThree.UseVisualStyleBackColor = true;
            // 
            // button_NumberTwo
            // 
            this.button_NumberTwo.Location = new System.Drawing.Point(189, 109);
            this.button_NumberTwo.Name = "button_NumberTwo";
            this.button_NumberTwo.Size = new System.Drawing.Size(75, 23);
            this.button_NumberTwo.TabIndex = 1;
            this.button_NumberTwo.Text = "2";
            this.button_NumberTwo.UseVisualStyleBackColor = true;
            // 
            // button_NumberOne
            // 
            this.button_NumberOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_NumberOne.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button_NumberOne.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_NumberOne.FlatAppearance.BorderSize = 3;
            this.button_NumberOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_NumberOne.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_NumberOne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_NumberOne.Location = new System.Drawing.Point(108, 109);
            this.button_NumberOne.Name = "button_NumberOne";
            this.button_NumberOne.Size = new System.Drawing.Size(75, 23);
            this.button_NumberOne.TabIndex = 0;
            this.button_NumberOne.Text = "1";
            this.button_NumberOne.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 479);
            this.Controls.Add(this.listBox_AccessLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_NumberOne);
            this.Controls.Add(this.button_NumberTwo);
            this.Controls.Add(this.button_NumberThree);
            this.Controls.Add(this.button_NumberFour);
            this.Controls.Add(this.button_NumberFive);
            this.Controls.Add(this.button_NumberSix);
            this.Controls.Add(this.button_NumberSeven);
            this.Controls.Add(this.button_NumberEight);
            this.Controls.Add(this.button_NumberNine);
            this.Controls.Add(this.button_NumberZero);
            this.Controls.Add(this.label_SecurityPanel);
            this.Controls.Add(this.textBox_SecurityCode);
            this.Controls.Add(this.button_NumberAcept);
            this.Controls.Add(this.button_NumberClear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_SecurityCode;
        private System.Windows.Forms.Label label_SecurityPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_AccessLog;
        private System.Windows.Forms.Button button_NumberZero;
        private System.Windows.Forms.Button button_NumberNine;
        private System.Windows.Forms.Button button_NumberEight;
        private System.Windows.Forms.Button button_NumberSeven;
        private System.Windows.Forms.Button button_NumberAcept;
        private System.Windows.Forms.Button button_NumberSix;
        private System.Windows.Forms.Button button_NumberFive;
        private System.Windows.Forms.Button button_NumberFour;
        private System.Windows.Forms.Button button_NumberClear;
        private System.Windows.Forms.Button button_NumberThree;
        private System.Windows.Forms.Button button_NumberTwo;
        private System.Windows.Forms.Button button_NumberOne;
    }
}

