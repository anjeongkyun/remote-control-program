
namespace 원격제어_프로그램
{
    partial class Mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbox_ip = new System.Windows.Forms.TextBox();
            this.tbox_controller_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_send_img = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.noti = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbox_ip
            // 
            this.tbox_ip.Location = new System.Drawing.Point(121, 29);
            this.tbox_ip.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_ip.Name = "tbox_ip";
            this.tbox_ip.Size = new System.Drawing.Size(98, 23);
            this.tbox_ip.TabIndex = 0;
            // 
            // tbox_controller_ip
            // 
            this.tbox_controller_ip.Location = new System.Drawing.Point(121, 77);
            this.tbox_controller_ip.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_controller_ip.Name = "tbox_controller_ip";
            this.tbox_controller_ip.ReadOnly = true;
            this.tbox_controller_ip.Size = new System.Drawing.Size(98, 23);
            this.tbox_controller_ip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "원격 호스트 IP";
            // 
            // timer_send_img
            // 
            this.timer_send_img.Tick += new System.EventHandler(this.timer_send_img_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "원격 컨트롤러  IP";
            // 
            // noti
            // 
            this.noti.Text = "notifyIcon1";
            this.noti.Visible = true;
            this.noti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.noti_MouseDoubleClick);
            // 
            // btn_setting
            // 
            this.btn_setting.Location = new System.Drawing.Point(240, 29);
            this.btn_setting.Margin = new System.Windows.Forms.Padding(2);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(114, 22);
            this.btn_setting.TabIndex = 4;
            this.btn_setting.Text = "설정하기";
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Enabled = false;
            this.btn_ok.Location = new System.Drawing.Point(240, 77);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(114, 22);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "원격 제어 허용";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbox_controller_ip);
            this.groupBox1.Controls.Add(this.btn_ok);
            this.groupBox1.Controls.Add(this.tbox_ip);
            this.groupBox1.Controls.Add(this.btn_setting);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 117);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 211);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Mainform";
            this.Text = "원격 제어 프로그램";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainform_FormClosed);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_ip;
        private System.Windows.Forms.TextBox tbox_controller_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_send_img;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon noti;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

