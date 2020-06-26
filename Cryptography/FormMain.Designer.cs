namespace Cryptography
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKeyContainer = new System.Windows.Forms.TextBox();
            this.buttonGeneratekey = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonInport = new System.Windows.Forms.Button();
            this.textBoxPlaintext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCryptogram = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "キーコンテナ名：";
            // 
            // textBoxKeyContainer
            // 
            this.textBoxKeyContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKeyContainer.Location = new System.Drawing.Point(117, 10);
            this.textBoxKeyContainer.Name = "textBoxKeyContainer";
            this.textBoxKeyContainer.Size = new System.Drawing.Size(250, 22);
            this.textBoxKeyContainer.TabIndex = 1;
            // 
            // buttonGeneratekey
            // 
            this.buttonGeneratekey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGeneratekey.Location = new System.Drawing.Point(12, 54);
            this.buttonGeneratekey.Name = "buttonGeneratekey";
            this.buttonGeneratekey.Size = new System.Drawing.Size(355, 47);
            this.buttonGeneratekey.TabIndex = 2;
            this.buttonGeneratekey.Text = "公開鍵を作成する";
            this.buttonGeneratekey.UseVisualStyleBackColor = true;
            this.buttonGeneratekey.Click += new System.EventHandler(this.buttonGeneratekey_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(12, 138);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(355, 47);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "キーコンテナから削除する";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Location = new System.Drawing.Point(12, 202);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(355, 47);
            this.buttonExport.TabIndex = 4;
            this.buttonExport.Text = "キーコンテナからエクスポートする";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonInport
            // 
            this.buttonInport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInport.Location = new System.Drawing.Point(12, 266);
            this.buttonInport.Name = "buttonInport";
            this.buttonInport.Size = new System.Drawing.Size(355, 47);
            this.buttonInport.TabIndex = 5;
            this.buttonInport.Text = "キーコンテナにインポートする";
            this.buttonInport.UseVisualStyleBackColor = true;
            this.buttonInport.Click += new System.EventHandler(this.buttonInport_Click);
            // 
            // textBoxPlaintext
            // 
            this.textBoxPlaintext.Location = new System.Drawing.Point(160, 367);
            this.textBoxPlaintext.MaxLength = 16;
            this.textBoxPlaintext.Name = "textBoxPlaintext";
            this.textBoxPlaintext.Size = new System.Drawing.Size(206, 22);
            this.textBoxPlaintext.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "平文 (16バイト以内)：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "暗号文：";
            // 
            // textBoxCryptogram
            // 
            this.textBoxCryptogram.Location = new System.Drawing.Point(85, 477);
            this.textBoxCryptogram.MaxLength = 65535;
            this.textBoxCryptogram.Name = "textBoxCryptogram";
            this.textBoxCryptogram.Size = new System.Drawing.Size(281, 22);
            this.textBoxCryptogram.TabIndex = 8;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(12, 407);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(173, 46);
            this.buttonEncrypt.TabIndex = 10;
            this.buttonEncrypt.Text = "暗号化 ↓";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(194, 407);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(173, 46);
            this.buttonDecrypt.TabIndex = 11;
            this.buttonDecrypt.Text = "復号 ↑";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 535);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCryptogram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPlaintext);
            this.Controls.Add(this.buttonInport);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonGeneratekey);
            this.Controls.Add(this.textBoxKeyContainer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(395, 236);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKeyContainer;
        private System.Windows.Forms.Button buttonGeneratekey;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonInport;
        private System.Windows.Forms.TextBox textBoxPlaintext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCryptogram;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
    }
}

