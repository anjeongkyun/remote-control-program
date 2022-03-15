
namespace 원격제어_프로그램
{
    partial class RemoteClientForm
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
            this.pbox_remote = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_remote)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_remote
            // 
            this.pbox_remote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_remote.Location = new System.Drawing.Point(0, 0);
            this.pbox_remote.Name = "pbox_remote";
            this.pbox_remote.Size = new System.Drawing.Size(800, 450);
            this.pbox_remote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_remote.TabIndex = 0;
            this.pbox_remote.TabStop = false;
            this.pbox_remote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbox_remote_MouseDown);
            this.pbox_remote.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbox_remote_MouseMove);
            this.pbox_remote.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbox_remote_MouseUp);
            // 
            // RemoteClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbox_remote);
            this.Name = "RemoteClientForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RemoteClientForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemoteClientForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RemoteClientForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_remote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_remote;
    }
}

