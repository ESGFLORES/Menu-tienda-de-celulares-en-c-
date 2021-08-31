
namespace Formulario_MenuStrip
{
    partial class Sucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sucursales));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblusu = new System.Windows.Forms.Label();
            this.lblsanm = new System.Windows.Forms.Label();
            this.lblsansa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "¡ Retira gratis tus pedidos\r\n  en nuestras sucursales!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(317, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ver sucursales";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblusu
            // 
            this.lblusu.AutoSize = true;
            this.lblusu.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusu.ForeColor = System.Drawing.Color.White;
            this.lblusu.Location = new System.Drawing.Point(299, 285);
            this.lblusu.Name = "lblusu";
            this.lblusu.Size = new System.Drawing.Size(154, 25);
            this.lblusu.TabIndex = 3;
            this.lblusu.Text = "Cede Usulutan ";
            this.lblusu.Visible = false;
            this.lblusu.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblsanm
            // 
            this.lblsanm.AutoSize = true;
            this.lblsanm.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsanm.ForeColor = System.Drawing.Color.White;
            this.lblsanm.Location = new System.Drawing.Point(299, 326);
            this.lblsanm.Name = "lblsanm";
            this.lblsanm.Size = new System.Drawing.Size(170, 25);
            this.lblsanm.TabIndex = 4;
            this.lblsanm.Text = "Cede San Miguel";
            this.lblsanm.Visible = false;
            // 
            // lblsansa
            // 
            this.lblsansa.AutoSize = true;
            this.lblsansa.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsansa.ForeColor = System.Drawing.Color.White;
            this.lblsansa.Location = new System.Drawing.Point(299, 363);
            this.lblsansa.Name = "lblsansa";
            this.lblsansa.Size = new System.Drawing.Size(186, 25);
            this.lblsansa.TabIndex = 5;
            this.lblsansa.Text = "Cede San Salvador";
            this.lblsansa.Visible = false;
            // 
            // Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsansa);
            this.Controls.Add(this.lblsanm);
            this.Controls.Add(this.lblusu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Sucursales";
            this.Text = "Sucursales";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblusu;
        private System.Windows.Forms.Label lblsanm;
        private System.Windows.Forms.Label lblsansa;
    }
}