
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
            this.btnRun = new System.Windows.Forms.Button();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRunSettings = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTurbineArea
            // 
            this.lblTurbineArea.AutoSize = true;
            this.lblTurbineArea.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTurbineArea.Location = new System.Drawing.Point(65, 69);
            this.lblTurbineArea.Name = "lblTurbineArea";
            this.lblTurbineArea.Size = new System.Drawing.Size(173, 38);
            this.lblTurbineArea.TabIndex = 0;
            this.lblTurbineArea.Text = "Turbine area";
            // 
            // lblUnplaced
            // 
            this.lblUnplaced.AutoSize = true;
            this.lblUnplaced.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnplaced.Location = new System.Drawing.Point(670, 101);
            this.lblUnplaced.Name = "lblUnplaced";
            this.lblUnplaced.Size = new System.Drawing.Size(171, 28);
            this.lblUnplaced.TabIndex = 1;
            this.lblUnplaced.Text = "Unplaced turbines";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(738, 435);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(165, 47);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
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
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(287, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 31);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load program";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(405, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(204, 31);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit program settings";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRunSettings
            // 
            this.btnRunSettings.Location = new System.Drawing.Point(615, 6);
            this.btnRunSettings.Name = "btnRunSettings";
            this.btnRunSettings.Size = new System.Drawing.Size(204, 31);
            this.btnRunSettings.TabIndex = 9;
            this.btnRunSettings.Text = "Edit run settings";
            this.btnRunSettings.UseVisualStyleBackColor = true;
            this.btnRunSettings.Click += new System.EventHandler(this.btnRunSettings_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(169, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 31);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save program";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(966, 509);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(108, 33);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // programForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 564);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRunSettings);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblProgramName);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblUnplaced);
            this.Controls.Add(this.lblTurbineArea);
            this.Name = "programForm";
            this.Text = "programForm";
            this.Load += new System.EventHandler(this.programForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurbineArea;
        private System.Windows.Forms.Label lblUnplaced;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRunSettings;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMenu;
    }
}