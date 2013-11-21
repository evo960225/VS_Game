namespace WindowsFormsControlLibrary
{
    partial class EscPanel
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.butContinue = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.butOption = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butContinue
            // 
            this.butContinue.ForeColor = System.Drawing.Color.Black;
            this.butContinue.Location = new System.Drawing.Point(50, 52);
            this.butContinue.Name = "butContinue";
            this.butContinue.Size = new System.Drawing.Size(88, 32);
            this.butContinue.TabIndex = 0;
            this.butContinue.Tag = "0";
            this.butContinue.Text = "繼續遊戲";
            this.butContinue.UseVisualStyleBackColor = true;
            this.butContinue.Click += new System.EventHandler(this.butContinue_Click);
            // 
            // butExit
            // 
            this.butExit.ForeColor = System.Drawing.Color.Black;
            this.butExit.Location = new System.Drawing.Point(50, 147);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(88, 32);
            this.butExit.TabIndex = 0;
            this.butExit.Tag = "2";
            this.butExit.Text = "離開遊戲";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butOption
            // 
            this.butOption.ForeColor = System.Drawing.Color.Black;
            this.butOption.Location = new System.Drawing.Point(50, 100);
            this.butOption.Name = "butOption";
            this.butOption.Size = new System.Drawing.Size(88, 32);
            this.butOption.TabIndex = 0;
            this.butOption.Tag = "1";
            this.butOption.Text = "遊戲設定";
            this.butOption.UseVisualStyleBackColor = true;
            // 
            // EscPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butOption);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butContinue);
            this.Name = "EscPanel";
            this.Size = new System.Drawing.Size(193, 221);
            this.Load += new System.EventHandler(this.EscPanel_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.EscPanel_DragDrop);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butContinue;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butOption;
    }
}
