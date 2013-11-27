namespace RPGControl
{
    partial class rolePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rolePanel));
            this.label1 = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labLv = new System.Windows.Forms.Label();
            this.labSP = new System.Windows.Forms.Label();
            this.labAtk = new System.Windows.Forms.Label();
            this.labDef = new System.Windows.Forms.Label();
            this.butEnter = new System.Windows.Forms.Button();
            this.labExit = new System.Windows.Forms.Label();
            this.labHP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 187);
            this.label1.TabIndex = 0;
            this.label1.Text = "角色名稱\r\n\r\n等級\r\n\r\nHP\r\n\r\nSP\r\n\r\nATK\r\n\r\nDEF\r\n";
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(0, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(354, 27);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "角色狀態";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labTitle_MouseDown);
            this.labTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labTitle_MouseMove);
            this.labTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labTitle_MouseUp);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.ForeColor = System.Drawing.Color.White;
            this.labName.Location = new System.Drawing.Point(107, 56);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(34, 17);
            this.labName.TabIndex = 0;
            this.labName.Text = "小明";
            // 
            // labLv
            // 
            this.labLv.AutoSize = true;
            this.labLv.BackColor = System.Drawing.Color.Transparent;
            this.labLv.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLv.ForeColor = System.Drawing.Color.White;
            this.labLv.Location = new System.Drawing.Point(107, 90);
            this.labLv.Name = "labLv";
            this.labLv.Size = new System.Drawing.Size(16, 17);
            this.labLv.TabIndex = 0;
            this.labLv.Text = "1";
            // 
            // labSP
            // 
            this.labSP.AutoSize = true;
            this.labSP.BackColor = System.Drawing.Color.Transparent;
            this.labSP.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSP.ForeColor = System.Drawing.Color.White;
            this.labSP.Location = new System.Drawing.Point(107, 158);
            this.labSP.Name = "labSP";
            this.labSP.Size = new System.Drawing.Size(140, 17);
            this.labSP.TabIndex = 0;
            this.labSP.Text = "5               +0             5/5";
            // 
            // labAtk
            // 
            this.labAtk.AutoSize = true;
            this.labAtk.BackColor = System.Drawing.Color.Transparent;
            this.labAtk.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAtk.ForeColor = System.Drawing.Color.White;
            this.labAtk.Location = new System.Drawing.Point(107, 192);
            this.labAtk.Name = "labAtk";
            this.labAtk.Size = new System.Drawing.Size(126, 17);
            this.labAtk.TabIndex = 0;
            this.labAtk.Text = "5               +0             5";
            // 
            // labDef
            // 
            this.labDef.AutoSize = true;
            this.labDef.BackColor = System.Drawing.Color.Transparent;
            this.labDef.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDef.ForeColor = System.Drawing.Color.White;
            this.labDef.Location = new System.Drawing.Point(107, 226);
            this.labDef.Name = "labDef";
            this.labDef.Size = new System.Drawing.Size(126, 17);
            this.labDef.TabIndex = 0;
            this.labDef.Text = "2               +0             2";
            // 
            // butEnter
            // 
            this.butEnter.Location = new System.Drawing.Point(295, 232);
            this.butEnter.Name = "butEnter";
            this.butEnter.Size = new System.Drawing.Size(39, 22);
            this.butEnter.TabIndex = 2;
            this.butEnter.Text = "確定";
            this.butEnter.UseVisualStyleBackColor = true;
            this.butEnter.Click += new System.EventHandler(this.butEnter_Click);
            // 
            // labExit
            // 
            this.labExit.AutoSize = true;
            this.labExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labExit.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labExit.ForeColor = System.Drawing.Color.White;
            this.labExit.Location = new System.Drawing.Point(335, 2);
            this.labExit.Name = "labExit";
            this.labExit.Size = new System.Drawing.Size(17, 17);
            this.labExit.TabIndex = 3;
            this.labExit.Text = "X";
            this.labExit.Click += new System.EventHandler(this.labExit_Click);
            // 
            // labHP
            // 
            this.labHP.AutoSize = true;
            this.labHP.BackColor = System.Drawing.Color.Transparent;
            this.labHP.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labHP.ForeColor = System.Drawing.Color.White;
            this.labHP.Location = new System.Drawing.Point(107, 124);
            this.labHP.Name = "labHP";
            this.labHP.Size = new System.Drawing.Size(155, 17);
            this.labHP.TabIndex = 0;
            this.labHP.Text = "10             +0            10/10";
            // 
            // rolePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.labExit);
            this.Controls.Add(this.butEnter);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labDef);
            this.Controls.Add(this.labAtk);
            this.Controls.Add(this.labSP);
            this.Controls.Add(this.labHP);
            this.Controls.Add(this.labLv);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.label1);
            this.Name = "rolePanel";
            this.Size = new System.Drawing.Size(354, 274);
            this.Load += new System.EventHandler(this.rolePanel_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labTitle_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labTitle_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labTitle_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labLv;
        private System.Windows.Forms.Label labSP;
        private System.Windows.Forms.Label labAtk;
        private System.Windows.Forms.Label labDef;
        private System.Windows.Forms.Button butEnter;
        private System.Windows.Forms.Label labExit;
        private System.Windows.Forms.Label labHP;
    }
}
