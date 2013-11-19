namespace 簡易RPG
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butLoad = new System.Windows.Forms.Button();
            this.butOptions = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "RPG";
            // 
            // butLoad
            // 
            this.butLoad.Location = new System.Drawing.Point(144, 147);
            this.butLoad.Name = "butLoad";
            this.butLoad.Size = new System.Drawing.Size(75, 23);
            this.butLoad.TabIndex = 0;
            this.butLoad.Text = "Load";
            this.butLoad.UseVisualStyleBackColor = true;
            this.butLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // butOptions
            // 
            this.butOptions.Location = new System.Drawing.Point(144, 176);
            this.butOptions.Name = "butOptions";
            this.butOptions.Size = new System.Drawing.Size(75, 23);
            this.butOptions.TabIndex = 0;
            this.butOptions.Text = "Options";
            this.butOptions.UseVisualStyleBackColor = true;
            this.butOptions.Click += new System.EventHandler(this.button1_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(144, 205);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(75, 23);
            this.butExit.TabIndex = 0;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butOptions);
            this.Controls.Add(this.butLoad);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butLoad;
        private System.Windows.Forms.Button butOptions;
        private System.Windows.Forms.Button butExit;
    }
}

