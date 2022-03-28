
namespace BaiTap07032022
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
            this.TB = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_caovoi = new System.Windows.Forms.CheckBox();
            this.checkBox_taytrang = new System.Windows.Forms.CheckBox();
            this.checkBox_chaphinhrang = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_so_rang_chap = new System.Windows.Forms.ComboBox();
            this.label_chaprang = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.button_tt = new System.Windows.Forms.Button();
            this.button1_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB
            // 
            this.TB.AutoSize = true;
            this.TB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB.Location = new System.Drawing.Point(169, 40);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(144, 17);
            this.TB.TabIndex = 0;
            this.TB.Text = "Dental Payment Form";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(227, 114);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(196, 22);
            this.TxtName.TabIndex = 1;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ten Khanh Hang";
            // 
            // checkBox_caovoi
            // 
            this.checkBox_caovoi.AutoSize = true;
            this.checkBox_caovoi.Location = new System.Drawing.Point(90, 167);
            this.checkBox_caovoi.Name = "checkBox_caovoi";
            this.checkBox_caovoi.Size = new System.Drawing.Size(79, 21);
            this.checkBox_caovoi.TabIndex = 3;
            this.checkBox_caovoi.Text = "Cao Voi";
            this.checkBox_caovoi.UseVisualStyleBackColor = true;
            // 
            // checkBox_taytrang
            // 
            this.checkBox_taytrang.AutoSize = true;
            this.checkBox_taytrang.Location = new System.Drawing.Point(90, 205);
            this.checkBox_taytrang.Name = "checkBox_taytrang";
            this.checkBox_taytrang.Size = new System.Drawing.Size(96, 21);
            this.checkBox_taytrang.TabIndex = 4;
            this.checkBox_taytrang.Text = "Tay Trang";
            this.checkBox_taytrang.UseVisualStyleBackColor = true;
            // 
            // checkBox_chaphinhrang
            // 
            this.checkBox_chaphinhrang.AutoSize = true;
            this.checkBox_chaphinhrang.Location = new System.Drawing.Point(90, 248);
            this.checkBox_chaphinhrang.Name = "checkBox_chaphinhrang";
            this.checkBox_chaphinhrang.Size = new System.Drawing.Size(134, 21);
            this.checkBox_chaphinhrang.TabIndex = 5;
            this.checkBox_chaphinhrang.Text = "Chap Hinh Rang";
            this.checkBox_chaphinhrang.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(300, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "$200,000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(288, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "$1,200,000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(300, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "$100,000";
            // 
            // comboBox_so_rang_chap
            // 
            this.comboBox_so_rang_chap.FormattingEnabled = true;
            this.comboBox_so_rang_chap.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBox_so_rang_chap.Location = new System.Drawing.Point(181, 306);
            this.comboBox_so_rang_chap.Name = "comboBox_so_rang_chap";
            this.comboBox_so_rang_chap.Size = new System.Drawing.Size(62, 24);
            this.comboBox_so_rang_chap.TabIndex = 10;
            this.comboBox_so_rang_chap.Text = "0";
            // 
            // label_chaprang
            // 
            this.label_chaprang.AutoSize = true;
            this.label_chaprang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_chaprang.Location = new System.Drawing.Point(87, 309);
            this.label_chaprang.Name = "label_chaprang";
            this.label_chaprang.Size = new System.Drawing.Size(79, 17);
            this.label_chaprang.TabIndex = 11;
            this.label_chaprang.Text = "Chap Rang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(288, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "$80,000/cai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(288, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(203, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_total.Location = new System.Drawing.Point(294, 433);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(0, 17);
            this.label_total.TabIndex = 15;
            // 
            // button_tt
            // 
            this.button_tt.Location = new System.Drawing.Point(303, 519);
            this.button_tt.Name = "button_tt";
            this.button_tt.Size = new System.Drawing.Size(75, 23);
            this.button_tt.TabIndex = 16;
            this.button_tt.Text = "Tinh Tien";
            this.button_tt.UseVisualStyleBackColor = true;
            this.button_tt.Click += new System.EventHandler(this.button_tt_Click);
            // 
            // button1_exit
            // 
            this.button1_exit.Location = new System.Drawing.Point(90, 518);
            this.button1_exit.Name = "button1_exit";
            this.button1_exit.Size = new System.Drawing.Size(75, 23);
            this.button1_exit.TabIndex = 17;
            this.button1_exit.Text = "Thoat";
            this.button1_exit.UseVisualStyleBackColor = true;
            this.button1_exit.Click += new System.EventHandler(this.button1_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 599);
            this.Controls.Add(this.button1_exit);
            this.Controls.Add(this.button_tt);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_chaprang);
            this.Controls.Add(this.comboBox_so_rang_chap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_chaphinhrang);
            this.Controls.Add(this.checkBox_taytrang);
            this.Controls.Add(this.checkBox_caovoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TB;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_caovoi;
        private System.Windows.Forms.CheckBox checkBox_taytrang;
        private System.Windows.Forms.CheckBox checkBox_chaphinhrang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_so_rang_chap;
        private System.Windows.Forms.Label label_chaprang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button button_tt;
        private System.Windows.Forms.Button button1_exit;
    }
}

