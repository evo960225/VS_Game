namespace 簡易RPG
{
    partial class FormNewPly
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
            this.butCreatePly = new System.Windows.Forms.Button();
            this.tetName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numA = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numHP = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numSP = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSP)).BeginInit();
            this.SuspendLayout();
            // 
            // butCreatePly
            // 
            this.butCreatePly.Location = new System.Drawing.Point(187, 168);
            this.butCreatePly.Name = "butCreatePly";
            this.butCreatePly.Size = new System.Drawing.Size(46, 32);
            this.butCreatePly.TabIndex = 0;
            this.butCreatePly.Text = "建立";
            this.butCreatePly.UseVisualStyleBackColor = true;
            this.butCreatePly.Click += new System.EventHandler(this.button1_Click);
            // 
            // tetName
            // 
            this.tetName.Location = new System.Drawing.Point(85, 33);
            this.tetName.Name = "tetName";
            this.tetName.Size = new System.Drawing.Size(121, 22);
            this.tetName.TabIndex = 1;
            this.tetName.Text = "神奇寶貝大師~宇均";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "name";
            // 
            // numA
            // 
            this.numA.Location = new System.Drawing.Point(86, 74);
            this.numA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(58, 22);
            this.numA.TabIndex = 3;
            this.numA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "攻擊";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "HP";
            // 
            // numD
            // 
            this.numD.Location = new System.Drawing.Point(86, 108);
            this.numD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numD.Name = "numD";
            this.numD.Size = new System.Drawing.Size(59, 22);
            this.numD.TabIndex = 5;
            this.numD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "防禦";
            // 
            // numHP
            // 
            this.numHP.Location = new System.Drawing.Point(86, 142);
            this.numHP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHP.Name = "numHP";
            this.numHP.Size = new System.Drawing.Size(59, 22);
            this.numHP.TabIndex = 7;
            this.numHP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "SP";
            // 
            // numSP
            // 
            this.numSP.Location = new System.Drawing.Point(86, 176);
            this.numSP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSP.Name = "numSP";
            this.numSP.Size = new System.Drawing.Size(59, 22);
            this.numSP.TabIndex = 9;
            this.numSP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormNewPly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 240);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tetName);
            this.Controls.Add(this.butCreatePly);
            this.Name = "FormNewPly";
            this.Text = "建立你的角色";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCreatePly;
        private System.Windows.Forms.TextBox tetName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numHP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSP;
    }
}