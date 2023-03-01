
namespace Stenografi
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtChepper = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbChepper = new System.Windows.Forms.PictureBox();
            this.btnChepper = new System.Windows.Forms.Button();
            this.Kaydet = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChepper)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tıklayınız";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 295);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtChepper
            // 
            this.txtChepper.Location = new System.Drawing.Point(601, 84);
            this.txtChepper.Name = "txtChepper";
            this.txtChepper.Size = new System.Drawing.Size(241, 27);
            this.txtChepper.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Şifrelenecek Metin";
            // 
            // pbChepper
            // 
            this.pbChepper.Location = new System.Drawing.Point(914, 19);
            this.pbChepper.Name = "pbChepper";
            this.pbChepper.Size = new System.Drawing.Size(383, 295);
            this.pbChepper.TabIndex = 4;
            this.pbChepper.TabStop = false;
            // 
            // btnChepper
            // 
            this.btnChepper.Location = new System.Drawing.Point(683, 142);
            this.btnChepper.Name = "btnChepper";
            this.btnChepper.Size = new System.Drawing.Size(94, 29);
            this.btnChepper.TabIndex = 5;
            this.btnChepper.Text = "Chepper";
            this.btnChepper.UseVisualStyleBackColor = true;
            this.btnChepper.Click += new System.EventHandler(this.btnChepper_Click);
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(683, 189);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(94, 29);
            this.Kaydet.TabIndex = 7;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1406, 450);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.btnChepper);
            this.Controls.Add(this.pbChepper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChepper);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChepper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtChepper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbChepper;
        private System.Windows.Forms.Button btnChepper;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

