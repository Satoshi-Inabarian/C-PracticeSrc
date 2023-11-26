using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ViewPicFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnChangeDir = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.TextBox_FIleDir = new System.Windows.Forms.TextBox();
            this.TextBox_Inital = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnValueChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnChangeDir
            // 
            this.BtnChangeDir.Location = new System.Drawing.Point(670, 227);
            this.BtnChangeDir.Name = "BtnChangeDir";
            this.BtnChangeDir.Size = new System.Drawing.Size(118, 43);
            this.BtnChangeDir.TabIndex = 1;
            this.BtnChangeDir.Text = "画像パス変更";
            this.BtnChangeDir.UseVisualStyleBackColor = true;
            this.BtnChangeDir.Click += new System.EventHandler(this.BtnChangeDir_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnStart.Location = new System.Drawing.Point(605, 334);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(162, 69);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "スタート";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // TextBox_FIleDir
            // 
            this.TextBox_FIleDir.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBox_FIleDir.Location = new System.Drawing.Point(442, 184);
            this.TextBox_FIleDir.Multiline = true;
            this.TextBox_FIleDir.Name = "TextBox_FIleDir";
            this.TextBox_FIleDir.Size = new System.Drawing.Size(346, 28);
            this.TextBox_FIleDir.TabIndex = 3;
            this.TextBox_FIleDir.Text = "D:\\Program\\C#\\ViewPicFormsApp\\Image2";
            // 
            // TextBox_Inital
            // 
            this.TextBox_Inital.Location = new System.Drawing.Point(516, 75);
            this.TextBox_Inital.Name = "TextBox_Inital";
            this.TextBox_Inital.Size = new System.Drawing.Size(205, 19);
            this.TextBox_Inital.TabIndex = 4;
            this.TextBox_Inital.Text = "D:\\Program\\C#\\MixPictureApp";
            this.TextBox_Inital.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(490, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "現在の画像フォルダ";
            // 
            // BtnValueChange
            // 
            this.BtnValueChange.Location = new System.Drawing.Point(442, 334);
            this.BtnValueChange.Name = "BtnValueChange";
            this.BtnValueChange.Size = new System.Drawing.Size(107, 44);
            this.BtnValueChange.TabIndex = 6;
            this.BtnValueChange.Text = "メンバ変数変更";
            this.BtnValueChange.UseVisualStyleBackColor = true;
            this.BtnValueChange.Click += new System.EventHandler(this.BtnValueChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnValueChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Inital);
            this.Controls.Add(this.TextBox_FIleDir);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnChangeDir);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnChangeDir;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.TextBox TextBox_FIleDir;
        private System.Windows.Forms.TextBox TextBox_Inital;
        private Label label1;
        private Button BtnValueChange;
    }
}

