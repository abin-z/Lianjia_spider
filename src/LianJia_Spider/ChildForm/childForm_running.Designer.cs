namespace LianJia_Spider
{
    partial class childForm_running
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childForm_running));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_run01 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_welcome = new System.Windows.Forms.TabPage();
            this.panel_welcome = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox_taskList = new System.Windows.Forms.CheckedListBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_welcome.SuspendLayout();
            this.panel_welcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "已创建的任务：";
            // 
            // btn_run01
            // 
            this.btn_run01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btn_run01.FlatAppearance.BorderSize = 0;
            this.btn_run01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_run01.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_run01.ForeColor = System.Drawing.Color.White;
            this.btn_run01.Location = new System.Drawing.Point(849, 130);
            this.btn_run01.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_run01.Name = "btn_run01";
            this.btn_run01.Size = new System.Drawing.Size(204, 52);
            this.btn_run01.TabIndex = 1;
            this.btn_run01.Text = "开始采集";
            this.btn_run01.UseVisualStyleBackColor = false;
            this.btn_run01.Click += new System.EventHandler(this.btn_run01_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_welcome);
            this.tabControl1.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 202);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1041, 506);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_welcome
            // 
            this.tabPage_welcome.Controls.Add(this.panel_welcome);
            this.tabPage_welcome.Location = new System.Drawing.Point(4, 38);
            this.tabPage_welcome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_welcome.Name = "tabPage_welcome";
            this.tabPage_welcome.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_welcome.Size = new System.Drawing.Size(1033, 464);
            this.tabPage_welcome.TabIndex = 1;
            this.tabPage_welcome.Text = "    欢迎页";
            this.tabPage_welcome.UseVisualStyleBackColor = true;
            // 
            // panel_welcome
            // 
            this.panel_welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel_welcome.Controls.Add(this.pictureBox2);
            this.panel_welcome.Controls.Add(this.pictureBox1);
            this.panel_welcome.Controls.Add(this.label2);
            this.panel_welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_welcome.Location = new System.Drawing.Point(3, 2);
            this.panel_welcome.Name = "panel_welcome";
            this.panel_welcome.Size = new System.Drawing.Size(1027, 460);
            this.panel_welcome.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(262, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(386, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("苹方-简", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(230, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 168);
            this.label2.TabIndex = 0;
            this.label2.Text = "· 直观 数据可视化采集\r\n· 智能 自动生成表格文件，可用Excel打开\r\n· 安全 自动写入数据库，数据更安全\r\n· 高效 多线程采集，同时采集更多数据";
            // 
            // checkedListBox_taskList
            // 
            this.checkedListBox_taskList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_taskList.CheckOnClick = true;
            this.checkedListBox_taskList.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_taskList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkedListBox_taskList.FormattingEnabled = true;
            this.checkedListBox_taskList.Location = new System.Drawing.Point(12, 54);
            this.checkedListBox_taskList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox_taskList.Name = "checkedListBox_taskList";
            this.checkedListBox_taskList.Size = new System.Drawing.Size(802, 128);
            this.checkedListBox_taskList.TabIndex = 3;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(849, 54);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(204, 50);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "删除该任务";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // childForm_running
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1065, 720);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.checkedListBox_taskList);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_run01);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "childForm_running";
            this.Text = "childForm_running";
            this.Load += new System.EventHandler(this.childForm_running_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_welcome.ResumeLayout(false);
            this.panel_welcome.ResumeLayout(false);
            this.panel_welcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_run01;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_welcome;
        private System.Windows.Forms.CheckedListBox checkedListBox_taskList;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Panel panel_welcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}