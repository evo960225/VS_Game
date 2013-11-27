namespace 簡易RPG {
    partial class FormLoad {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.butLoad1 = new System.Windows.Forms.Button();
            this.butLoad2 = new System.Windows.Forms.Button();
            this.butLoad3 = new System.Windows.Forms.Button();
            this.labName1 = new System.Windows.Forms.Label();
            this.labName2 = new System.Windows.Forms.Label();
            this.labName3 = new System.Windows.Forms.Label();
            this.rolenameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new 簡易RPG.Data.DatabaseDataSet();
            this.role_nameTableAdapter = new 簡易RPG.Data.DatabaseDataSetTableAdapters.role_nameTableAdapter();
            this.roledataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.role_dataTableAdapter = new 簡易RPG.Data.DatabaseDataSetTableAdapters.role_dataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rolenameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roledataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // butLoad1
            // 
            this.butLoad1.Location = new System.Drawing.Point(298, 33);
            this.butLoad1.Name = "butLoad1";
            this.butLoad1.Size = new System.Drawing.Size(73, 24);
            this.butLoad1.TabIndex = 0;
            this.butLoad1.Tag = "0";
            this.butLoad1.Text = "選擇";
            this.butLoad1.UseVisualStyleBackColor = true;
            this.butLoad1.Visible = false;
            this.butLoad1.Click += new System.EventHandler(this.butLoad_Click);
            // 
            // butLoad2
            // 
            this.butLoad2.Location = new System.Drawing.Point(298, 90);
            this.butLoad2.Name = "butLoad2";
            this.butLoad2.Size = new System.Drawing.Size(70, 23);
            this.butLoad2.TabIndex = 1;
            this.butLoad2.Tag = "1";
            this.butLoad2.Text = "選擇";
            this.butLoad2.UseVisualStyleBackColor = true;
            this.butLoad2.Visible = false;
            this.butLoad2.Click += new System.EventHandler(this.butLoad_Click);
            // 
            // butLoad3
            // 
            this.butLoad3.Location = new System.Drawing.Point(298, 150);
            this.butLoad3.Name = "butLoad3";
            this.butLoad3.Size = new System.Drawing.Size(73, 21);
            this.butLoad3.TabIndex = 2;
            this.butLoad3.Tag = "2";
            this.butLoad3.Text = "選擇";
            this.butLoad3.UseVisualStyleBackColor = true;
            this.butLoad3.Visible = false;
            this.butLoad3.Click += new System.EventHandler(this.butLoad_Click);
            // 
            // labName1
            // 
            this.labName1.AutoSize = true;
            this.labName1.Location = new System.Drawing.Point(36, 33);
            this.labName1.Name = "labName1";
            this.labName1.Size = new System.Drawing.Size(0, 12);
            this.labName1.TabIndex = 3;
            // 
            // labName2
            // 
            this.labName2.AutoSize = true;
            this.labName2.Location = new System.Drawing.Point(36, 94);
            this.labName2.Name = "labName2";
            this.labName2.Size = new System.Drawing.Size(0, 12);
            this.labName2.TabIndex = 3;
            // 
            // labName3
            // 
            this.labName3.AutoSize = true;
            this.labName3.Location = new System.Drawing.Point(36, 152);
            this.labName3.Name = "labName3";
            this.labName3.Size = new System.Drawing.Size(0, 12);
            this.labName3.TabIndex = 3;
            // 
            // rolenameBindingSource
            // 
            this.rolenameBindingSource.DataMember = "role_name";
            this.rolenameBindingSource.DataSource = this.databaseDataSet;
            this.rolenameBindingSource.CurrentChanged += new System.EventHandler(this.rolenameBindingSource_CurrentChanged);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // role_nameTableAdapter
            // 
            this.role_nameTableAdapter.ClearBeforeFill = true;
            // 
            // roledataBindingSource1
            // 
            this.roledataBindingSource1.DataMember = "role_data";
            this.roledataBindingSource1.DataSource = this.databaseDataSet;
            // 
            // role_dataTableAdapter
            // 
            this.role_dataTableAdapter.ClearBeforeFill = true;
            // 
            // FormLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 202);
            this.Controls.Add(this.labName3);
            this.Controls.Add(this.labName2);
            this.Controls.Add(this.labName1);
            this.Controls.Add(this.butLoad3);
            this.Controls.Add(this.butLoad2);
            this.Controls.Add(this.butLoad1);
            this.Name = "FormLoad";
            this.Text = "FormLoad";
            this.Load += new System.EventHandler(this.FormLoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolenameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roledataBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butLoad1;
        private System.Windows.Forms.Button butLoad2;
        private System.Windows.Forms.Button butLoad3;
        private System.Windows.Forms.Label labName1;
        private System.Windows.Forms.Label labName2;
        private System.Windows.Forms.Label labName3;
        private Data.DatabaseDataSet databaseDataSet;
        private Data.DatabaseDataSetTableAdapters.role_nameTableAdapter role_nameTableAdapter;
        public System.Windows.Forms.BindingSource rolenameBindingSource;
        private Data.DatabaseDataSetTableAdapters.role_dataTableAdapter role_dataTableAdapter;
        public System.Windows.Forms.BindingSource roledataBindingSource1;

    }
}