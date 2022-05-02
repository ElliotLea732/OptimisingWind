
namespace OptimisingWind
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureTurbine = new System.Windows.Forms.PictureBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTurbine)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(245, 71);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Optimising Wind";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureTurbine
            // 
            this.pictureTurbine.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureTurbine.Image = ((System.Drawing.Image)(resources.GetObject("pictureTurbine.Image")));
            this.pictureTurbine.Location = new System.Drawing.Point(751, 12);
            this.pictureTurbine.Name = "pictureTurbine";
            this.pictureTurbine.Size = new System.Drawing.Size(411, 576);
            this.pictureTurbine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTurbine.TabIndex = 1;
            this.pictureTurbine.TabStop = false;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.Location = new System.Drawing.Point(201, 151);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(477, 28);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "A program to help with the planning of wind turbines";
            // 
            // btnNewFile
            // 
            this.btnNewFile.Location = new System.Drawing.Point(245, 281);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(131, 44);
            this.btnNewFile.TabIndex = 3;
            this.btnNewFile.Text = "New file";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(491, 281);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(131, 44);
            this.btnLoadFile.TabIndex = 4;
            this.btnLoadFile.Text = "Load file";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(345, 409);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(179, 55);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1174, 593);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnNewFile);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.pictureTurbine);
            this.Controls.Add(this.lblTitle);
            this.Name = "Menu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureTurbine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureTurbine;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnQuit;
    }
}

