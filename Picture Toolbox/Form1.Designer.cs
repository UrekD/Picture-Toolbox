
namespace Picture_Toolbox
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Status = new System.Windows.Forms.Label();
            this.Statusx = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.resize = new System.Windows.Forms.CheckBox();
            this.SelectedDir = new System.Windows.Forms.TextBox();
            this.DirSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.API = new System.Windows.Forms.TextBox();
            this.ValidateAPI = new System.Windows.Forms.Button();
            this.s1 = new System.Windows.Forms.NumericUpDown();
            this.s2 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.Controls.Add(this.Status, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.Statusx, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.resize, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.SelectedDir, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DirSelect, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.API, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ValidateAPI, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.s1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.s2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 271);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Status, 2);
            this.Status.Dock = System.Windows.Forms.DockStyle.Top;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Status.Location = new System.Drawing.Point(96, 241);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(215, 24);
            this.Status.TabIndex = 11;
            this.Status.Text = "WAITING";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Statusx
            // 
            this.Statusx.AutoSize = true;
            this.Statusx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Statusx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Statusx.Location = new System.Drawing.Point(3, 241);
            this.Statusx.Name = "Statusx";
            this.Statusx.Size = new System.Drawing.Size(87, 30);
            this.Statusx.TabIndex = 1;
            this.Statusx.Text = "Status";
            // 
            // progressBar1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.progressBar1, 3);
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(3, 208);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(308, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resize";
            // 
            // resize
            // 
            this.resize.AutoSize = true;
            this.resize.Dock = System.Windows.Forms.DockStyle.Left;
            this.resize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resize.Location = new System.Drawing.Point(96, 114);
            this.resize.Name = "resize";
            this.resize.Size = new System.Drawing.Size(15, 25);
            this.resize.TabIndex = 7;
            this.resize.UseVisualStyleBackColor = true;
            this.resize.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SelectedDir
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.SelectedDir, 3);
            this.SelectedDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedDir.Location = new System.Drawing.Point(3, 87);
            this.SelectedDir.Name = "SelectedDir";
            this.SelectedDir.ReadOnly = true;
            this.SelectedDir.Size = new System.Drawing.Size(308, 20);
            this.SelectedDir.TabIndex = 5;
            // 
            // DirSelect
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.DirSelect, 2);
            this.DirSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.DirSelect.Location = new System.Drawing.Point(96, 58);
            this.DirSelect.Name = "DirSelect";
            this.DirSelect.Size = new System.Drawing.Size(215, 21);
            this.DirSelect.TabIndex = 4;
            this.DirSelect.Text = "Select";
            this.DirSelect.UseVisualStyleBackColor = true;
            this.DirSelect.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "API Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Directory";
            // 
            // API
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.API, 3);
            this.API.Dock = System.Windows.Forms.DockStyle.Fill;
            this.API.Location = new System.Drawing.Point(3, 30);
            this.API.Name = "API";
            this.API.Size = new System.Drawing.Size(308, 20);
            this.API.TabIndex = 1;
            // 
            // ValidateAPI
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ValidateAPI, 2);
            this.ValidateAPI.Dock = System.Windows.Forms.DockStyle.Top;
            this.ValidateAPI.Location = new System.Drawing.Point(96, 3);
            this.ValidateAPI.Name = "ValidateAPI";
            this.ValidateAPI.Size = new System.Drawing.Size(215, 21);
            this.ValidateAPI.TabIndex = 2;
            this.ValidateAPI.Text = "Validate";
            this.ValidateAPI.UseVisualStyleBackColor = true;
            this.ValidateAPI.Click += new System.EventHandler(this.ValidateAPI_Click);
            // 
            // s1
            // 
            this.s1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.s1.Enabled = false;
            this.s1.Location = new System.Drawing.Point(3, 145);
            this.s1.Maximum = new decimal(new int[] {
            2555,
            0,
            0,
            0});
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(87, 20);
            this.s1.TabIndex = 8;
            // 
            // s2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.s2, 2);
            this.s2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.s2.Enabled = false;
            this.s2.Location = new System.Drawing.Point(96, 145);
            this.s2.Maximum = new decimal(new int[] {
            2555,
            0,
            0,
            0});
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(215, 20);
            this.s2.TabIndex = 9;
            // 
            // button3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button3, 3);
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(3, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(308, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Process";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "scale",
            "fit",
            "cover",
            "thumb"});
            this.comboBox1.Location = new System.Drawing.Point(136, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "cover";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 271);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Picture ToolBox - UrekD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox resize;
        private System.Windows.Forms.TextBox SelectedDir;
        private System.Windows.Forms.Button DirSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox API;
        private System.Windows.Forms.Button ValidateAPI;
        private System.Windows.Forms.NumericUpDown s1;
        private System.Windows.Forms.NumericUpDown s2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label Statusx;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

