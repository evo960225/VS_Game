namespace RPGControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscPanel));
            this.butContinue = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.butOption = new System.Windows.Forms.Button();
            this.labTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.DarkRed;
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(0, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(193, 24);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "選單";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labTitle_MouseDown);
            this.labTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labTitle_MouseMove);
            this.labTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labTitle_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.labExit);
            // 
            // EscPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.butOption);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butContinue);
            this.Name = "EscPanel";
            this.Size = new System.Drawing.Size(193, 209);
            this.Load += new System.EventHandler(this.EscPanel_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.EscPanel_DragDrop);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butContinue;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butOption;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label label1;
    }
}
