namespace LianJia_Spider
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.panel_side = new System.Windows.Forms.Panel();
            this.btn_completed = new System.Windows.Forms.Button();
            this.btn_running = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.btn_fold = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_time = new System.Windows.Forms.Label();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panel_childForm = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(194)))));
            this.panel_menu.Controls.Add(this.panel1);
            this.panel_menu.Controls.Add(this.btn_about);
            this.panel_menu.Controls.Add(this.btn_settings);
            this.panel_menu.Controls.Add(this.panel_side);
            this.panel_menu.Controls.Add(this.btn_completed);
            this.panel_menu.Controls.Add(this.btn_running);
            this.panel_menu.Controls.Add(this.btn_new);
            this.panel_menu.Controls.Add(this.btn_home);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.ForeColor = System.Drawing.Color.White;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(215, 800);
            this.panel_menu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.panel1.Location = new System.Drawing.Point(0, 677);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 10);
            this.panel1.TabIndex = 3;
            // 
            // btn_about
            // 
            this.btn_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(194)))));
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.Image = ((System.Drawing.Image)(resources.GetObject("btn_about.Image")));
            this.btn_about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_about.Location = new System.Drawing.Point(7, 746);
            this.btn_about.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_about.Name = "btn_about";
            this.btn_about.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_about.Size = new System.Drawing.Size(208, 40);
            this.btn_about.TabIndex = 1;
            this.btn_about.Text = "  关于我们";
            this.btn_about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(194)))));
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_settings.Image")));
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.Location = new System.Drawing.Point(7, 697);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_settings.Size = new System.Drawing.Size(208, 40);
            this.btn_settings.TabIndex = 1;
            this.btn_settings.Text = "  设 置";
            this.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.Color.White;
            this.panel_side.Location = new System.Drawing.Point(0, 98);
            this.panel_side.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(7, 60);
            this.panel_side.TabIndex = 2;
            // 
            // btn_completed
            // 
            this.btn_completed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(194)))));
            this.btn_completed.FlatAppearance.BorderSize = 0;
            this.btn_completed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_completed.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_completed.Image = ((System.Drawing.Image)(resources.GetObject("btn_completed.Image")));
            this.btn_completed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_completed.Location = new System.Drawing.Point(7, 344);
            this.btn_completed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_completed.Name = "btn_completed";
            this.btn_completed.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_completed.Size = new System.Drawing.Size(208, 60);
            this.btn_completed.TabIndex = 1;
            this.btn_completed.Text = "  已完成";
            this.btn_completed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_completed.UseVisualStyleBackColor = false;
            this.btn_completed.Click += new System.EventHandler(this.btn_completed_Click);
            // 
            // btn_running
            // 
            this.btn_running.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(194)))));
            this.btn_running.FlatAppearance.BorderSize = 0;
            this.btn_running.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_running.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_running.Image = ((System.Drawing.Image)(resources.GetObject("btn_running.Image")));
            this.btn_running.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_running.Location = new System.Drawing.Point(7, 262);
            this.btn_running.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_running.Name = "btn_running";
            this.btn_running.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_running.Size = new System.Drawing.Size(208, 60);
            this.btn_running.TabIndex = 1;
            this.btn_running.Text = "  正在运行";
            this.btn_running.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_running.UseVisualStyleBackColor = false;
            this.btn_running.Click += new System.EventHandler(this.btn_running_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(194)))));
            this.btn_new.FlatAppearance.BorderSize = 0;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.Image")));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(7, 180);
            this.btn_new.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_new.Name = "btn_new";
            this.btn_new.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_new.Size = new System.Drawing.Size(208, 60);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "  新建任务";
            this.btn_new.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(194)))));
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(7, 98);
            this.btn_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_home.Size = new System.Drawing.Size(208, 60);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "  首 页";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.panel_logo.Controls.Add(this.btn_fold);
            this.panel_logo.Controls.Add(this.label1);
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(215, 80);
            this.panel_logo.TabIndex = 0;
            this.panel_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Bar_MouseDown);
            // 
            // btn_fold
            // 
            this.btn_fold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.btn_fold.FlatAppearance.BorderSize = 0;
            this.btn_fold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fold.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fold.Image = ((System.Drawing.Image)(resources.GetObject("btn_fold.Image")));
            this.btn_fold.Location = new System.Drawing.Point(149, 12);
            this.btn_fold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_fold.Name = "btn_fold";
            this.btn_fold.Size = new System.Drawing.Size(66, 55);
            this.btn_fold.TabIndex = 1;
            this.btn_fold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_fold.UseVisualStyleBackColor = false;
            this.btn_fold.Click += new System.EventHandler(this.btn_fold_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spider";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Bar_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Bar_MouseDown);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(194)))));
            this.panel_top.Controls.Add(this.label_time);
            this.panel_top.Controls.Add(this.btn_min);
            this.panel_top.Controls.Add(this.btn_close);
            this.panel_top.Controls.Add(this.btn_max);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(215, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1065, 80);
            this.panel_top.TabIndex = 1;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Bar_MouseDown);
            // 
            // label_time
            // 
            this.label_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.White;
            this.label_time.Location = new System.Drawing.Point(702, 26);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(119, 29);
            this.label_time.TabIndex = 2;
            this.label_time.Text = "HH:MM:SS";
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(194)))));
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.Location = new System.Drawing.Point(827, 0);
            this.btn_min.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(80, 80);
            this.btn_min.TabIndex = 1;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(194)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(986, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(80, 80);
            this.btn_close.TabIndex = 1;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseEnter += new System.EventHandler(this.btn_close_MouseEnter);
            this.btn_close.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(114)))), ((int)(((byte)(194)))));
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_max.Image = ((System.Drawing.Image)(resources.GetObject("btn_max.Image")));
            this.btn_max.Location = new System.Drawing.Point(906, 0);
            this.btn_max.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(80, 80);
            this.btn_max.TabIndex = 1;
            this.btn_max.UseVisualStyleBackColor = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // panel_childForm
            // 
            this.panel_childForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_childForm.Location = new System.Drawing.Point(215, 80);
            this.panel_childForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_childForm.Name = "panel_childForm";
            this.panel_childForm.Size = new System.Drawing.Size(1065, 720);
            this.panel_childForm.TabIndex = 2;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.panel_childForm);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LianjiaSpider";
            this.panel_menu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Button btn_completed;
        private System.Windows.Forms.Button btn_running;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_fold;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel panel_childForm;
    }
}

