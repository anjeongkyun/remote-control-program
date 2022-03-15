
namespace 이미지_수신_서버
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
            this.pb_receiveimg = new System.Windows.Forms.PictureBox();
            this.listbox_imgsendcnt = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listbox_event = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_receiveimg)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_receiveimg
            // 
            this.pb_receiveimg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_receiveimg.Location = new System.Drawing.Point(308, 33);
            this.pb_receiveimg.Name = "pb_receiveimg";
            this.pb_receiveimg.Size = new System.Drawing.Size(480, 214);
            this.pb_receiveimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_receiveimg.TabIndex = 0;
            this.pb_receiveimg.TabStop = false;
            // 
            // listbox_imgsendcnt
            // 
            this.listbox_imgsendcnt.FormattingEnabled = true;
            this.listbox_imgsendcnt.ItemHeight = 15;
            this.listbox_imgsendcnt.Location = new System.Drawing.Point(12, 33);
            this.listbox_imgsendcnt.Name = "listbox_imgsendcnt";
            this.listbox_imgsendcnt.Size = new System.Drawing.Size(243, 214);
            this.listbox_imgsendcnt.TabIndex = 1;
            this.listbox_imgsendcnt.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "클라이언트에게 이미지 받은 횟수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "클라이언트에게 받은 이미지";
            // 
            // listbox_event
            // 
            this.listbox_event.FormattingEnabled = true;
            this.listbox_event.ItemHeight = 15;
            this.listbox_event.Location = new System.Drawing.Point(12, 288);
            this.listbox_event.Name = "listbox_event";
            this.listbox_event.Size = new System.Drawing.Size(776, 229);
            this.listbox_event.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "클라이언트에게 받은 이벤트";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listbox_event);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox_imgsendcnt);
            this.Controls.Add(this.pb_receiveimg);
            this.Name = "Mainform";
            this.Text = "이미지 + 이벤트 전송 서버 (by https://jeongkyun-it.tistory.com/)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_receiveimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_receiveimg;
        private System.Windows.Forms.ListBox listbox_imgsendcnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listbox_event;
        private System.Windows.Forms.Label label3;
    }
}

