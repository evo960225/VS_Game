namespace 簡易RPG
{
    partial class FormTitle
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.butStart = new System.Windows.Forms.Button();
            this.labTitle = new System.Windows.Forms.Label();
            this.butLoad = new System.Windows.Forms.Button();
            this.butOptions = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(144, 118);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(75, 23);
            this.butStart.TabIndex = 0;
            this.butStart.TabStop = false;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(136)));
            this.labTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labTitle.Location = new System.Drawing.Point(135, 41);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(104, 50);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "RPG";
            // 
            // butLoad
            // 
            this.butLoad.Location = new System.Drawing.Point(144, 147);
            this.butLoad.Name = "butLoad";
            this.butLoad.Size = new System.Drawing.Size(75, 23);
            this.butLoad.TabIndex = 0;
            this.butLoad.TabStop = false;
            this.butLoad.Text = "Load";
            this.butLoad.UseVisualStyleBackColor = true;
            this.butLoad.Click += new System.EventHandler(this.butLoad_Click);
            // 
            // butOptions
            // 
            this.butOptions.Location = new System.Drawing.Point(144, 176);
            this.butOptions.Name = "butOptions";
            this.butOptions.Size = new System.Drawing.Size(75, 23);
            this.butOptions.TabIndex = 0;
            this.butOptions.TabStop = false;
            this.butOptions.Text = "Options";
            this.butOptions.UseVisualStyleBackColor = true;
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(144, 205);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(75, 23);
            this.butExit.TabIndex = 0;
            this.butExit.TabStop = false;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // FormTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 261);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butOptions);
            this.Controls.Add(this.butLoad);
            this.Controls.Add(this.butStart);
            this.KeyPreview = true;
            this.Name = "FormTitle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPG";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button butLoad;
        private System.Windows.Forms.Button butOptions;
        private System.Windows.Forms.Button butExit;
    }
}

