namespace LianJia_Spider
{
    partial class childForm_new
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_taskName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_city = new System.Windows.Forms.ComboBox();
            this.comboBox_province = new System.Windows.Forms.ComboBox();
            this.button_done = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label_selectedCity = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_newHouse = new System.Windows.Forms.Button();
            this.label_selectedType = new System.Windows.Forms.Label();
            this.btn_rental = new System.Windows.Forms.Button();
            this.btn_secondHand = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_pageNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pageNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(34, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "任务名称：";
            // 
            // textBox_taskName
            // 
            this.textBox_taskName.BackColor = System.Drawing.Color.White;
            this.textBox_taskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_taskName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_taskName.Location = new System.Drawing.Point(160, 52);
            this.textBox_taskName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_taskName.Name = "textBox_taskName";
            this.textBox_taskName.Size = new System.Drawing.Size(276, 37);
            this.textBox_taskName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "省份/直辖市:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.label3.Location = new System.Drawing.Point(91, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "城市:";
            // 
            // comboBox_city
            // 
            this.comboBox_city.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox_city.FormattingEnabled = true;
            this.comboBox_city.Location = new System.Drawing.Point(161, 137);
            this.comboBox_city.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_city.Name = "comboBox_city";
            this.comboBox_city.Size = new System.Drawing.Size(208, 37);
            this.comboBox_city.TabIndex = 2;
            this.comboBox_city.Text = "请选择城市";
            this.comboBox_city.SelectedIndexChanged += new System.EventHandler(this.comboBox_city_SelectedIndexChanged);
            // 
            // comboBox_province
            // 
            this.comboBox_province.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_province.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox_province.FormattingEnabled = true;
            this.comboBox_province.Items.AddRange(new object[] {
            "安徽",
            "北京",
            "重庆",
            "福建",
            "广东",
            "贵州",
            "广西",
            "甘肃",
            "湖北",
            "湖南",
            "河北",
            "海南",
            "河南",
            "黑龙江",
            "江苏",
            "吉林",
            "江西",
            "辽宁",
            "内蒙古",
            "宁夏",
            "上海",
            "四川",
            "山东",
            "陕西",
            "山西",
            "天津",
            "云南",
            "浙江"});
            this.comboBox_province.Location = new System.Drawing.Point(161, 57);
            this.comboBox_province.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboBox_province.Name = "comboBox_province";
            this.comboBox_province.Size = new System.Drawing.Size(208, 37);
            this.comboBox_province.TabIndex = 3;
            this.comboBox_province.Text = "请选择省份";
            this.comboBox_province.SelectedIndexChanged += new System.EventHandler(this.comboBox_province_SelectedIndexChanged);
            // 
            // button_done
            // 
            this.button_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.button_done.FlatAppearance.BorderSize = 0;
            this.button_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_done.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_done.ForeColor = System.Drawing.Color.White;
            this.button_done.Location = new System.Drawing.Point(161, 217);
            this.button_done.Margin = new System.Windows.Forms.Padding(4);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(208, 40);
            this.button_done.TabIndex = 4;
            this.button_done.Text = "确  认";
            this.button_done.UseVisualStyleBackColor = false;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.label4.Location = new System.Drawing.Point(18, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "您选择的城市为：";
            // 
            // label_selectedCity
            // 
            this.label_selectedCity.AutoSize = true;
            this.label_selectedCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.label_selectedCity.Location = new System.Drawing.Point(219, 301);
            this.label_selectedCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_selectedCity.Name = "label_selectedCity";
            this.label_selectedCity.Size = new System.Drawing.Size(45, 29);
            this.label_selectedCity.TabIndex = 5;
            this.label_selectedCity.Text = "*无";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.comboBox_province);
            this.groupBox1.Controls.Add(this.label_selectedCity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button_done);
            this.groupBox1.Controls.Add(this.comboBox_city);
            this.groupBox1.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.groupBox1.Location = new System.Drawing.Point(97, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(436, 369);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "①.选择城市";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btn_newHouse);
            this.groupBox2.Controls.Add(this.label_selectedType);
            this.groupBox2.Controls.Add(this.btn_rental);
            this.groupBox2.Controls.Add(this.btn_secondHand);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.groupBox2.Location = new System.Drawing.Point(586, 43);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(381, 369);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "②.选择房源类型";
            // 
            // btn_newHouse
            // 
            this.btn_newHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btn_newHouse.FlatAppearance.BorderSize = 0;
            this.btn_newHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newHouse.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newHouse.ForeColor = System.Drawing.Color.White;
            this.btn_newHouse.Location = new System.Drawing.Point(55, 217);
            this.btn_newHouse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_newHouse.Name = "btn_newHouse";
            this.btn_newHouse.Size = new System.Drawing.Size(260, 40);
            this.btn_newHouse.TabIndex = 9;
            this.btn_newHouse.Text = "新 房";
            this.btn_newHouse.UseVisualStyleBackColor = false;
            this.btn_newHouse.Click += new System.EventHandler(this.btn_newHouse_Click);
            // 
            // label_selectedType
            // 
            this.label_selectedType.AutoSize = true;
            this.label_selectedType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.label_selectedType.Location = new System.Drawing.Point(265, 303);
            this.label_selectedType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_selectedType.Name = "label_selectedType";
            this.label_selectedType.Size = new System.Drawing.Size(45, 29);
            this.label_selectedType.TabIndex = 5;
            this.label_selectedType.Text = "*无";
            // 
            // btn_rental
            // 
            this.btn_rental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btn_rental.FlatAppearance.BorderSize = 0;
            this.btn_rental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rental.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rental.ForeColor = System.Drawing.Color.White;
            this.btn_rental.Location = new System.Drawing.Point(55, 137);
            this.btn_rental.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_rental.Name = "btn_rental";
            this.btn_rental.Size = new System.Drawing.Size(260, 40);
            this.btn_rental.TabIndex = 8;
            this.btn_rental.Text = "租 房";
            this.btn_rental.UseVisualStyleBackColor = false;
            this.btn_rental.Click += new System.EventHandler(this.btn_rental_Click);
            // 
            // btn_secondHand
            // 
            this.btn_secondHand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btn_secondHand.FlatAppearance.BorderSize = 0;
            this.btn_secondHand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_secondHand.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_secondHand.ForeColor = System.Drawing.Color.White;
            this.btn_secondHand.Location = new System.Drawing.Point(55, 57);
            this.btn_secondHand.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_secondHand.Name = "btn_secondHand";
            this.btn_secondHand.Size = new System.Drawing.Size(260, 40);
            this.btn_secondHand.TabIndex = 7;
            this.btn_secondHand.Text = "二手房";
            this.btn_secondHand.UseVisualStyleBackColor = false;
            this.btn_secondHand.Click += new System.EventHandler(this.btn_secondHand_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.label5.Location = new System.Drawing.Point(50, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "您选择的房源类型为:";
            // 
            // button_send
            // 
            this.button_send.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.button_send.FlatAppearance.BorderSize = 0;
            this.button_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_send.Font = new System.Drawing.Font("苹方-简", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send.Location = new System.Drawing.Point(730, 627);
            this.button_send.Margin = new System.Windows.Forms.Padding(4);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(237, 50);
            this.button_send.TabIndex = 8;
            this.button_send.Text = "确认创建任务";
            this.button_send.UseVisualStyleBackColor = false;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.label6.Location = new System.Drawing.Point(539, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "采集页数：";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.numericUpDown_pageNum);
            this.groupBox3.Controls.Add(this.textBox_taskName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("苹方-简", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.groupBox3.Location = new System.Drawing.Point(97, 440);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(870, 129);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "③.任务名称及页数";
            // 
            // numericUpDown_pageNum
            // 
            this.numericUpDown_pageNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_pageNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown_pageNum.Location = new System.Drawing.Point(682, 52);
            this.numericUpDown_pageNum.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_pageNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_pageNum.Name = "numericUpDown_pageNum";
            this.numericUpDown_pageNum.Size = new System.Drawing.Size(122, 33);
            this.numericUpDown_pageNum.TabIndex = 2;
            this.numericUpDown_pageNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // childForm_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1065, 720);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("苹方-简", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "childForm_new";
            this.Text = "childForm_new";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pageNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_taskName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_city;
        private System.Windows.Forms.ComboBox comboBox_province;
        private System.Windows.Forms.Button button_done;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_selectedCity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_newHouse;
        private System.Windows.Forms.Button btn_rental;
        private System.Windows.Forms.Button btn_secondHand;
        private System.Windows.Forms.Label label_selectedType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown_pageNum;
    }
}