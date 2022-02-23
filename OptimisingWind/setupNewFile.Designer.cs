
namespace OptimisingWind
{
    partial class setupNewFile
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblNoTurbines = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAreaLength = new System.Windows.Forms.TextBox();
            this.txtAreaWidth = new System.Windows.Forms.TextBox();
            this.txtNoTurbines = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(377, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(293, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create a new file";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(248, 166);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(152, 41);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "File name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLength.Location = new System.Drawing.Point(68, 243);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(332, 41);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "Length of planned area:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWidth.Location = new System.Drawing.Point(80, 317);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(320, 41);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Width of planned area:";
            this.lblWidth.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNoTurbines
            // 
            this.lblNoTurbines.AutoSize = true;
            this.lblNoTurbines.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoTurbines.Location = new System.Drawing.Point(115, 397);
            this.lblNoTurbines.Name = "lblNoTurbines";
            this.lblNoTurbines.Size = new System.Drawing.Size(285, 41);
            this.lblNoTurbines.TabIndex = 4;
            this.lblNoTurbines.Text = "Number of turbines:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(491, 166);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 47);
            this.txtName.TabIndex = 5;
            // 
            // txtAreaLength
            // 
            this.txtAreaLength.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAreaLength.Location = new System.Drawing.Point(491, 243);
            this.txtAreaLength.Name = "txtAreaLength";
            this.txtAreaLength.Size = new System.Drawing.Size(271, 47);
            this.txtAreaLength.TabIndex = 6;
            // 
            // txtAreaWidth
            // 
            this.txtAreaWidth.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAreaWidth.Location = new System.Drawing.Point(491, 317);
            this.txtAreaWidth.Name = "txtAreaWidth";
            this.txtAreaWidth.Size = new System.Drawing.Size(271, 47);
            this.txtAreaWidth.TabIndex = 7;
            // 
            // txtNoTurbines
            // 
            this.txtNoTurbines.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNoTurbines.Location = new System.Drawing.Point(491, 397);
            this.txtNoTurbines.Name = "txtNoTurbines";
            this.txtNoTurbines.Size = new System.Drawing.Size(271, 47);
            this.txtNoTurbines.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(377, 484);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(164, 44);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // setupNewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 593);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtNoTurbines);
            this.Controls.Add(this.txtAreaWidth);
            this.Controls.Add(this.txtAreaLength);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNoTurbines);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "setupNewFile";
            this.Text = "New file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblNoTurbines;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAreaLength;
        private System.Windows.Forms.TextBox txtAreaWidth;
        private System.Windows.Forms.TextBox txtNoTurbines;
        private System.Windows.Forms.Button btnCreate;
    }
}