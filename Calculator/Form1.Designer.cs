﻿namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết quả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số b";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(243, 110);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(309, 53);
            this.txtA.TabIndex = 3;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(243, 283);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(309, 53);
            this.txtKetQua.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(243, 195);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(309, 53);
            this.txtB.TabIndex = 5;
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(477, 386);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(75, 60);
            this.btCong.TabIndex = 6;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btTru
            // 
            this.btTru.Location = new System.Drawing.Point(365, 386);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(75, 60);
            this.btTru.TabIndex = 7;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(946, 616);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btTru;
    }
}

