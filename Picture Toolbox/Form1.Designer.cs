
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel1.Controls.Add(this.Status, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.Statusx, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.resize, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.SelectedDir, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.DirSelect, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.API, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ValidateAPI, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.s1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.s2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 290);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Status, 2);
            this.Status.Dock = System.Windows.Forms.DockStyle.Top;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Status.ForeColor = System.Drawing.Color.Silver;
            this.Status.Location = new System.Drawing.Point(96, 261);
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
            this.Statusx.ForeColor = System.Drawing.Color.Silver;
            this.Statusx.Location = new System.Drawing.Point(3, 261);
            this.Statusx.Name = "Statusx";
            this.Statusx.Size = new System.Drawing.Size(87, 29);
            this.Statusx.TabIndex = 1;
            this.Statusx.Text = "Status";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tableLayoutPanel1.SetColumnSpan(this.progressBar1, 3);
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.progressBar1.Location = new System.Drawing.Point(3, 228);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(308, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(3, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resize";
            // 
            // resize
            // 
            this.resize.AutoSize = true;
            this.resize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.resize.Location = new System.Drawing.Point(96, 134);
            this.resize.Name = "resize";
            this.resize.Size = new System.Drawing.Size(57, 25);
            this.resize.TabIndex = 7;
            this.resize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resize.UseVisualStyleBackColor = true;
            this.resize.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SelectedDir
            // 
            this.SelectedDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SelectedDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.SelectedDir, 3);
            this.SelectedDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedDir.ForeColor = System.Drawing.Color.Silver;
            this.SelectedDir.Location = new System.Drawing.Point(3, 107);
            this.SelectedDir.Name = "SelectedDir";
            this.SelectedDir.ReadOnly = true;
            this.SelectedDir.Size = new System.Drawing.Size(308, 20);
            this.SelectedDir.TabIndex = 5;
            // 
            // DirSelect
            // 
            this.DirSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tableLayoutPanel1.SetColumnSpan(this.DirSelect, 2);
            this.DirSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.DirSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DirSelect.ForeColor = System.Drawing.Color.Silver;
            this.DirSelect.Location = new System.Drawing.Point(96, 78);
            this.DirSelect.Name = "DirSelect";
            this.DirSelect.Size = new System.Drawing.Size(215, 21);
            this.DirSelect.TabIndex = 4;
            this.DirSelect.Text = "Select";
            this.DirSelect.UseVisualStyleBackColor = false;
            this.DirSelect.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "API Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Directory";
            // 
            // API
            // 
            this.API.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.API.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.API, 3);
            this.API.Dock = System.Windows.Forms.DockStyle.Fill;
            this.API.ForeColor = System.Drawing.Color.Silver;
            this.API.Location = new System.Drawing.Point(3, 50);
            this.API.Name = "API";
            this.API.Size = new System.Drawing.Size(308, 20);
            this.API.TabIndex = 1;
            // 
            // ValidateAPI
            // 
            this.ValidateAPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tableLayoutPanel1.SetColumnSpan(this.ValidateAPI, 2);
            this.ValidateAPI.Dock = System.Windows.Forms.DockStyle.Top;
            this.ValidateAPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValidateAPI.ForeColor = System.Drawing.Color.Silver;
            this.ValidateAPI.Location = new System.Drawing.Point(96, 23);
            this.ValidateAPI.Name = "ValidateAPI";
            this.ValidateAPI.Size = new System.Drawing.Size(215, 21);
            this.ValidateAPI.TabIndex = 2;
            this.ValidateAPI.Text = "Validate";
            this.ValidateAPI.UseVisualStyleBackColor = false;
            this.ValidateAPI.Click += new System.EventHandler(this.ValidateAPI_Click);
            // 
            // s1
            // 
            this.s1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tableLayoutPanel1.SetColumnSpan(this.s1, 2);
            this.s1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.s1.Enabled = false;
            this.s1.ForeColor = System.Drawing.Color.Silver;
            this.s1.Location = new System.Drawing.Point(3, 165);
            this.s1.Maximum = new decimal(new int[] {
            2555,
            0,
            0,
            0});
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(150, 20);
            this.s1.TabIndex = 8;
            // 
            // s2
            // 
            this.s2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.s2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.s2.Enabled = false;
            this.s2.ForeColor = System.Drawing.Color.Silver;
            this.s2.Location = new System.Drawing.Point(159, 165);
            this.s2.Maximum = new decimal(new int[] {
            2555,
            0,
            0,
            0});
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(152, 20);
            this.s2.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tableLayoutPanel1.SetColumnSpan(this.button3, 3);
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(3, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(308, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "START";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.Silver;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "fit",
            "cover",
            "thumb"});
            this.comboBox1.Location = new System.Drawing.Point(159, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "cover";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.linkLabel1, 3);
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.LinkColor = System.Drawing.Color.Lime;
            this.linkLabel1.Location = new System.Drawing.Point(3, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(308, 20);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub @UrekD";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(314, 290);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
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
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

