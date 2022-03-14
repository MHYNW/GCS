namespace GCS_MH001
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialport = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gmap = new System.Windows.Forms.Panel();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selec_btn = new System.Windows.Forms.Button();
            this.BaudBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_distance = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_eject = new System.Windows.Forms.Button();
            this.button_focus = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_yaw = new System.Windows.Forms.TextBox();
            this.textBox_pitch = new System.Windows.Forms.TextBox();
            this.textBox_roll = new System.Windows.Forms.TextBox();
            this.textBox_hdop = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_lng = new System.Windows.Forms.TextBox();
            this.textBox_lat = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Location = new System.Drawing.Point(24, 42);
            this.gmap.Name = "gmap";
            this.gmap.Size = new System.Drawing.Size(1838, 1180);
            this.gmap.TabIndex = 14;
            // 
            // PortBox
            // 
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(88, 31);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(117, 32);
            this.PortBox.TabIndex = 2;
            this.PortBox.Text = "선택";
            this.PortBox.SelectedIndexChanged += new System.EventHandler(this.PortBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Baud";
            // 
            // selec_btn
            // 
            this.selec_btn.Location = new System.Drawing.Point(225, 31);
            this.selec_btn.Name = "selec_btn";
            this.selec_btn.Size = new System.Drawing.Size(153, 81);
            this.selec_btn.TabIndex = 8;
            this.selec_btn.Text = "CONNECT";
            this.selec_btn.UseVisualStyleBackColor = true;
            this.selec_btn.Click += new System.EventHandler(this.selec_btn_Click);
            // 
            // BaudBox
            // 
            this.BaudBox.FormattingEnabled = true;
            this.BaudBox.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "111100",
            "115200",
            "500000",
            "625000",
            "921600",
            "1500000"});
            this.BaudBox.Location = new System.Drawing.Point(88, 80);
            this.BaudBox.Name = "BaudBox";
            this.BaudBox.Size = new System.Drawing.Size(117, 32);
            this.BaudBox.TabIndex = 9;
            this.BaudBox.Text = "선택";
            this.BaudBox.SelectedIndexChanged += new System.EventHandler(this.BaudBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BaudBox);
            this.groupBox1.Controls.Add(this.selec_btn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PortBox);
            this.groupBox1.Location = new System.Drawing.Point(1980, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(23, 47);
            this.vScrollBar1.Maximum = 20;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 1107);
            this.vScrollBar1.TabIndex = 15;
            this.vScrollBar1.Value = 8;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1980, 373);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(396, 729);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.button_distance);
            this.tabPage1.Controls.Add(this.button_save);
            this.tabPage1.Controls.Add(this.button_eject);
            this.tabPage1.Controls.Add(this.button_focus);
            this.tabPage1.Controls.Add(this.button_clear);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(380, 682);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control";
            // 
            // button_distance
            // 
            this.button_distance.Location = new System.Drawing.Point(109, 525);
            this.button_distance.Name = "button_distance";
            this.button_distance.Size = new System.Drawing.Size(163, 73);
            this.button_distance.TabIndex = 15;
            this.button_distance.Text = "DISTANCE";
            this.button_distance.UseVisualStyleBackColor = true;
            this.button_distance.Click += new System.EventHandler(this.button_distance_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(109, 55);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(163, 73);
            this.button_save.TabIndex = 14;
            this.button_save.Text = "CLOSE";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_eject
            // 
            this.button_eject.Location = new System.Drawing.Point(109, 411);
            this.button_eject.Name = "button_eject";
            this.button_eject.Size = new System.Drawing.Size(163, 73);
            this.button_eject.TabIndex = 13;
            this.button_eject.Text = "EJECT";
            this.button_eject.UseVisualStyleBackColor = true;
            this.button_eject.Click += new System.EventHandler(this.button_eject_Click);
            // 
            // button_focus
            // 
            this.button_focus.Location = new System.Drawing.Point(109, 305);
            this.button_focus.Name = "button_focus";
            this.button_focus.Size = new System.Drawing.Size(163, 73);
            this.button_focus.TabIndex = 12;
            this.button_focus.Text = "FOCUS";
            this.button_focus.UseVisualStyleBackColor = true;
            this.button_focus.Click += new System.EventHandler(this.button_focus_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(109, 191);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(163, 73);
            this.button_clear.TabIndex = 11;
            this.button_clear.Text = "CLEAR";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox_yaw);
            this.tabPage2.Controls.Add(this.textBox_pitch);
            this.tabPage2.Controls.Add(this.textBox_roll);
            this.tabPage2.Controls.Add(this.textBox_hdop);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(380, 682);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conditions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "Yaw";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Pitch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Roll";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "HDOP";
            // 
            // textBox_yaw
            // 
            this.textBox_yaw.Location = new System.Drawing.Point(58, 542);
            this.textBox_yaw.Name = "textBox_yaw";
            this.textBox_yaw.Size = new System.Drawing.Size(189, 35);
            this.textBox_yaw.TabIndex = 26;
            // 
            // textBox_pitch
            // 
            this.textBox_pitch.Location = new System.Drawing.Point(58, 386);
            this.textBox_pitch.Name = "textBox_pitch";
            this.textBox_pitch.Size = new System.Drawing.Size(189, 35);
            this.textBox_pitch.TabIndex = 25;
            // 
            // textBox_roll
            // 
            this.textBox_roll.Location = new System.Drawing.Point(58, 233);
            this.textBox_roll.Name = "textBox_roll";
            this.textBox_roll.Size = new System.Drawing.Size(189, 35);
            this.textBox_roll.TabIndex = 24;
            // 
            // textBox_hdop
            // 
            this.textBox_hdop.Location = new System.Drawing.Point(58, 86);
            this.textBox_hdop.Name = "textBox_hdop";
            this.textBox_hdop.Size = new System.Drawing.Size(189, 35);
            this.textBox_hdop.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vScrollBar1);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(1881, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(78, 1183);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "zoom";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox_lng);
            this.groupBox3.Controls.Add(this.textBox_lat);
            this.groupBox3.Location = new System.Drawing.Point(1985, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 159);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Coordinates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lat";
            // 
            // textBox_lng
            // 
            this.textBox_lng.Location = new System.Drawing.Point(20, 99);
            this.textBox_lng.Name = "textBox_lng";
            this.textBox_lng.Size = new System.Drawing.Size(152, 35);
            this.textBox_lng.TabIndex = 1;
            // 
            // textBox_lat
            // 
            this.textBox_lat.Location = new System.Drawing.Point(20, 46);
            this.textBox_lat.Name = "textBox_lat";
            this.textBox_lat.Size = new System.Drawing.Size(152, 35);
            this.textBox_lat.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(2250, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(126, 158);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ejection";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(48, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(28, 27);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2442, 1267);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gmap);
            this.Name = "Form1";
            this.Text = "GCS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel gmap;
        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button selec_btn;
        private System.Windows.Forms.ComboBox BaudBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_lng;
        private System.Windows.Forms.TextBox textBox_lat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_yaw;
        private System.Windows.Forms.TextBox textBox_pitch;
        private System.Windows.Forms.TextBox textBox_roll;
        private System.Windows.Forms.TextBox textBox_hdop;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_distance;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_eject;
        private System.Windows.Forms.Button button_focus;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

