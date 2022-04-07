namespace ChooseYourOwnAdventure
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titlelabel = new System.Windows.Forms.Label();
            this.leftbutton = new System.Windows.Forms.Button();
            this.rightbutton = new System.Windows.Forms.Button();
            this.specialbutton = new System.Windows.Forms.Button();
            this.outputlabel = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.Location = new System.Drawing.Point(24, 20);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(434, 78);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "Journey Through the Fourth Dimension";
            this.titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftbutton
            // 
            this.leftbutton.Location = new System.Drawing.Point(31, 287);
            this.leftbutton.Name = "leftbutton";
            this.leftbutton.Size = new System.Drawing.Size(184, 55);
            this.leftbutton.TabIndex = 1;
            this.leftbutton.UseVisualStyleBackColor = true;
            this.leftbutton.Visible = false;
            this.leftbutton.Click += new System.EventHandler(this.leftbutton_Click);
            // 
            // rightbutton
            // 
            this.rightbutton.Location = new System.Drawing.Point(268, 287);
            this.rightbutton.Name = "rightbutton";
            this.rightbutton.Size = new System.Drawing.Size(184, 55);
            this.rightbutton.TabIndex = 2;
            this.rightbutton.UseVisualStyleBackColor = true;
            this.rightbutton.Visible = false;
            this.rightbutton.Click += new System.EventHandler(this.rightbutton_Click);
            // 
            // specialbutton
            // 
            this.specialbutton.Location = new System.Drawing.Point(150, 348);
            this.specialbutton.Name = "specialbutton";
            this.specialbutton.Size = new System.Drawing.Size(184, 55);
            this.specialbutton.TabIndex = 3;
            this.specialbutton.UseVisualStyleBackColor = true;
            this.specialbutton.Visible = false;
            this.specialbutton.Click += new System.EventHandler(this.specialbutton_Click);
            // 
            // outputlabel
            // 
            this.outputlabel.Location = new System.Drawing.Point(82, 196);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(318, 110);
            this.outputlabel.TabIndex = 4;
            // 
            // startbutton
            // 
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(122, 145);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(234, 110);
            this.startbutton.TabIndex = 5;
            this.startbutton.Text = "START";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // picturebox
            // 
            this.picturebox.Location = new System.Drawing.Point(12, 12);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(460, 171);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox.TabIndex = 7;
            this.picturebox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 405);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.specialbutton);
            this.Controls.Add(this.rightbutton);
            this.Controls.Add(this.leftbutton);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.outputlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Text Adventure Game";
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Button leftbutton;
        private System.Windows.Forms.Button rightbutton;
        private System.Windows.Forms.Button specialbutton;
        private System.Windows.Forms.Label outputlabel;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.PictureBox picturebox;
    }
}

