
namespace 이미지_캡쳐_및_전송_클라이언트
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
            this.tbox_ip = new System.Windows.Forms.TextBox();
            this.btn_ip_input = new System.Windows.Forms.Button();
            this.pb_captureimg = new System.Windows.Forms.PictureBox();
            this.btn_img_send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbar_bottom = new System.Windows.Forms.TrackBar();
            this.tbar_right = new System.Windows.Forms.TrackBar();
            this.tbar_top = new System.Windows.Forms.TrackBar();
            this.tbar_left = new System.Windows.Forms.TrackBar();
            this.richtbox_event = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_captureimg)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_left)).BeginInit();
            this.SuspendLayout();
            // 
            // tbox_ip
            // 
            this.tbox_ip.Location = new System.Drawing.Point(55, 17);
            this.tbox_ip.Name = "tbox_ip";
            this.tbox_ip.Size = new System.Drawing.Size(137, 23);
            this.tbox_ip.TabIndex = 0;
            // 
            // btn_ip_input
            // 
            this.btn_ip_input.Location = new System.Drawing.Point(212, 12);
            this.btn_ip_input.Name = "btn_ip_input";
            this.btn_ip_input.Size = new System.Drawing.Size(75, 38);
            this.btn_ip_input.TabIndex = 1;
            this.btn_ip_input.Text = "입력";
            this.btn_ip_input.UseVisualStyleBackColor = true;
            this.btn_ip_input.Click += new System.EventHandler(this.btn_ip_input_Click);
            // 
            // pb_captureimg
            // 
            this.pb_captureimg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pb_captureimg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_captureimg.Location = new System.Drawing.Point(409, 46);
            this.pb_captureimg.Name = "pb_captureimg";
            this.pb_captureimg.Size = new System.Drawing.Size(379, 231);
            this.pb_captureimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_captureimg.TabIndex = 6;
            this.pb_captureimg.TabStop = false;
            // 
            // btn_img_send
            // 
            this.btn_img_send.Location = new System.Drawing.Point(14, 244);
            this.btn_img_send.Name = "btn_img_send";
            this.btn_img_send.Size = new System.Drawing.Size(365, 33);
            this.btn_img_send.TabIndex = 7;
            this.btn_img_send.Text = "화면 캡쳐 및 이미지 전송";
            this.btn_img_send.UseVisualStyleBackColor = true;
            this.btn_img_send.Click += new System.EventHandler(this.btn_img_send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "서버에게 전송할 이미지";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbar_bottom);
            this.groupBox1.Controls.Add(this.tbar_right);
            this.groupBox1.Controls.Add(this.tbar_top);
            this.groupBox1.Controls.Add(this.tbar_left);
            this.groupBox1.Location = new System.Drawing.Point(14, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 178);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Bottom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Right";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Top";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Left";
            // 
            // tbar_bottom
            // 
            this.tbar_bottom.Location = new System.Drawing.Point(198, 137);
            this.tbar_bottom.Name = "tbar_bottom";
            this.tbar_bottom.Size = new System.Drawing.Size(156, 45);
            this.tbar_bottom.TabIndex = 16;
            this.tbar_bottom.Scroll += new System.EventHandler(this.tbar_bottom_Scroll);
            // 
            // tbar_right
            // 
            this.tbar_right.Location = new System.Drawing.Point(6, 137);
            this.tbar_right.Name = "tbar_right";
            this.tbar_right.Size = new System.Drawing.Size(156, 45);
            this.tbar_right.TabIndex = 15;
            this.tbar_right.Scroll += new System.EventHandler(this.tbar_right_Scroll);
            // 
            // tbar_top
            // 
            this.tbar_top.Location = new System.Drawing.Point(198, 56);
            this.tbar_top.Name = "tbar_top";
            this.tbar_top.Size = new System.Drawing.Size(156, 45);
            this.tbar_top.TabIndex = 14;
            this.tbar_top.Scroll += new System.EventHandler(this.tbar_top_Scroll);
            // 
            // tbar_left
            // 
            this.tbar_left.Location = new System.Drawing.Point(6, 56);
            this.tbar_left.Name = "tbar_left";
            this.tbar_left.Size = new System.Drawing.Size(156, 45);
            this.tbar_left.TabIndex = 13;
            this.tbar_left.Scroll += new System.EventHandler(this.tbar_left_Scroll);
            // 
            // richtbox_event
            // 
            this.richtbox_event.Location = new System.Drawing.Point(14, 295);
            this.richtbox_event.Name = "richtbox_event";
            this.richtbox_event.Size = new System.Drawing.Size(774, 263);
            this.richtbox_event.TabIndex = 15;
            this.richtbox_event.Text = "";
            this.richtbox_event.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richtbox_event_KeyDown);
            this.richtbox_event.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richtbox_event_KeyUp);
            this.richtbox_event.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richtbox_event_MouseDown);
            this.richtbox_event.MouseMove += new System.Windows.Forms.MouseEventHandler(this.richtbox_event_MouseMove);
            this.richtbox_event.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richtbox_event_MouseUp);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.richtbox_event);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_img_send);
            this.Controls.Add(this.pb_captureimg);
            this.Controls.Add(this.btn_ip_input);
            this.Controls.Add(this.tbox_ip);
            this.Name = "Mainform";
            this.Text = "이미지 _ 이벤트 전송 클라이언트 (by https://jeongkyun-it.tistory.com/)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_captureimg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_left)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_ip;
        private System.Windows.Forms.Button btn_ip_input;
        private System.Windows.Forms.PictureBox pb_captureimg;
        private System.Windows.Forms.Button btn_img_send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbar_bottom;
        private System.Windows.Forms.TrackBar tbar_right;
        private System.Windows.Forms.TrackBar tbar_top;
        private System.Windows.Forms.TrackBar tbar_left;
        private System.Windows.Forms.RichTextBox richtbox_event;
    }
}

