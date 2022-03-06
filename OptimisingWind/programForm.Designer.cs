
namespace OptimisingWind
{
    partial class programForm
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
            this.lblTurbineArea = new System.Windows.Forms.Label();
            this.lblUnplaced = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRunSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTurbineArea
            // 
            this.lblTurbineArea.AutoSize = true;
            this.lblTurbineArea.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTurbineArea.Location = new System.Drawing.Point(81, 80);
            this.lblTurbineArea.Name = "lblTurbineArea";
            this.lblTurbineArea.Size = new System.Drawing.Size(173, 38);
            this.lblTurbineArea.TabIndex = 0;
            this.lblTurbineArea.Text = "Turbine area";
            // 
            // lblUnplaced
            // 
            this.lblUnplaced.AutoSize = true;
            this.lblUnplaced.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnplaced.Location = new System.Drawing.Point(853, 118);
            this.lblUnplaced.Name = "lblUnplaced";
            this.lblUnplaced.Size = new System.Drawing.Size(171, 28);
            this.lblUnplaced.TabIndex = 1;
            this.lblUnplaced.Text = "Unplaced turbines";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(832, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 170);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(81, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(531, 330);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(784, 384);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(164, 47);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(287, 505);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProgramName.Location = new System.Drawing.Point(3, 4);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(133, 28);
            this.lblProgramName.TabIndex = 6;
            this.lblProgramName.Text = "ProgamName";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(151, 6);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(226, 31);
            this.btnFile.TabIndex = 7;
            this.btnFile.Text = "File (save and load program)";
            this.btnFile.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(383, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(226, 31);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit program settings";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRunSettings
            // 
            this.btnRunSettings.Location = new System.Drawing.Point(615, 6);
            this.btnRunSettings.Name = "btnRunSettings";
            this.btnRunSettings.Size = new System.Drawing.Size(226, 31);
            this.btnRunSettings.TabIndex = 9;
            this.btnRunSettings.Text = "Edit run settings";
            this.btnRunSettings.UseVisualStyleBackColor = true;
            // 
            // programForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 593);
            this.Controls.Add(this.btnRunSettings);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.lblProgramName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUnplaced);
            this.Controls.Add(this.lblTurbineArea);
            this.Name = "programForm";
            this.Text = "programForm";
            this.Load += new System.EventHandler(this.programForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurbineArea;
        private System.Windows.Forms.Label lblUnplaced;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRunSettings;
    }
}