namespace DownloadApp
{
    partial class Downloder
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
            this.BtnDL_Img = new System.Windows.Forms.Button();
            this.BtnFile_Load = new System.Windows.Forms.Button();
            this.TextBox_fromFile = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDL_Img
            // 
            this.BtnDL_Img.Location = new System.Drawing.Point(128, 202);
            this.BtnDL_Img.Name = "BtnDL_Img";
            this.BtnDL_Img.Size = new System.Drawing.Size(100, 42);
            this.BtnDL_Img.TabIndex = 0;
            this.BtnDL_Img.Text = "CSVファイルDL";
            this.BtnDL_Img.UseVisualStyleBackColor = true;
            this.BtnDL_Img.Click += new System.EventHandler(this.BtnDL_Img_Click);
            // 
            // BtnFile_Load
            // 
            this.BtnFile_Load.Location = new System.Drawing.Point(12, 202);
            this.BtnFile_Load.Name = "BtnFile_Load";
            this.BtnFile_Load.Size = new System.Drawing.Size(100, 42);
            this.BtnFile_Load.TabIndex = 1;
            this.BtnFile_Load.Text = "データをロード";
            this.BtnFile_Load.UseVisualStyleBackColor = true;
            this.BtnFile_Load.Click += new System.EventHandler(this.BtnFileLoad);
            // 
            // TextBox_fromFile
            // 
            this.TextBox_fromFile.Location = new System.Drawing.Point(12, 59);
            this.TextBox_fromFile.Multiline = true;
            this.TextBox_fromFile.Name = "TextBox_fromFile";
            this.TextBox_fromFile.Size = new System.Drawing.Size(216, 126);
            this.TextBox_fromFile.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 12);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "読み込み内容";
            // 
            // Downloder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 351);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBox_fromFile);
            this.Controls.Add(this.BtnFile_Load);
            this.Controls.Add(this.BtnDL_Img);
            this.Name = "Downloder";
            this.Text = "ダウンローダー";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDL_Img;
        private System.Windows.Forms.Button BtnFile_Load;
        private System.Windows.Forms.TextBox TextBox_fromFile;
        private System.Windows.Forms.Label Label1;
    }
}

