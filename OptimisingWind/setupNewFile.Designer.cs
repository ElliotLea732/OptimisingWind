
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
            this.lblLengthGuide = new System.Windows.Forms.Label();
            this.lblWidthGuide = new System.Windows.Forms.Label();
            this.lblTurbineNoGuide = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(330, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create a new file";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(226, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 30);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "File name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLength.Location = new System.Drawing.Point(80, 152);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(242, 30);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "Length of planned area:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWidth.Location = new System.Drawing.Point(89, 228);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(234, 30);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Width of planned area:";
            this.lblWidth.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNoTurbines
            // 
            this.lblNoTurbines.AutoSize = true;
            this.lblNoTurbines.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoTurbines.Location = new System.Drawing.Point(117, 301);
            this.lblNoTurbines.Name = "lblNoTurbines";
            this.lblNoTurbines.Size = new System.Drawing.Size(208, 30);
            this.lblNoTurbines.TabIndex = 4;
            this.lblNoTurbines.Text = "Number of turbines:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(430, 95);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 39);
            this.txtName.TabIndex = 5;
            // 
            // txtAreaLength
            // 
            this.txtAreaLength.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAreaLength.Location = new System.Drawing.Point(430, 152);
            this.txtAreaLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAreaLength.Name = "txtAreaLength";
            this.txtAreaLength.Size = new System.Drawing.Size(238, 39);
            this.txtAreaLength.TabIndex = 6;
            // 
            // txtAreaWidth
            // 
            this.txtAreaWidth.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAreaWidth.Location = new System.Drawing.Point(430, 228);
            this.txtAreaWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAreaWidth.Name = "txtAreaWidth";
            this.txtAreaWidth.Size = new System.Drawing.Size(238, 39);
            this.txtAreaWidth.TabIndex = 7;
            // 
            // txtNoTurbines
            // 
            this.txtNoTurbines.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNoTurbines.Location = new System.Drawing.Point(430, 301);
            this.txtNoTurbines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoTurbines.Name = "txtNoTurbines";
            this.txtNoTurbines.Size = new System.Drawing.Size(238, 39);
            this.txtNoTurbines.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(430, 386);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(144, 33);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblLengthGuide
            // 
            this.lblLengthGuide.AutoSize = true;
            this.lblLengthGuide.Location = new System.Drawing.Point(80, 190);
            this.lblLengthGuide.Name = "lblLengthGuide";
            this.lblLengthGuide.Size = new System.Drawing.Size(232, 15);
            this.lblLengthGuide.TabIndex = 10;
            this.lblLengthGuide.Text = "Enter a value between 800 and 2000 metres";
            // 
            // lblWidthGuide
            // 
            this.lblWidthGuide.AutoSize = true;
            this.lblWidthGuide.Location = new System.Drawing.Point(80, 264);
            this.lblWidthGuide.Name = "lblWidthGuide";
            this.lblWidthGuide.Size = new System.Drawing.Size(232, 15);
            this.lblWidthGuide.TabIndex = 11;
            this.lblWidthGuide.Text = "Enter a value between 800 and 2000 metres";
            this.lblWidthGuide.Click += new System.EventHandler(this.lblWidthGuide_Click);
            // 
            // lblTurbineNoGuide
            // 
            this.lblTurbineNoGuide.AutoSize = true;
            this.lblTurbineNoGuide.Location = new System.Drawing.Point(88, 337);
            this.lblTurbineNoGuide.Name = "lblTurbineNoGuide";
            this.lblTurbineNoGuide.Size = new System.Drawing.Size(237, 15);
            this.lblTurbineNoGuide.TabIndex = 12;
            this.lblTurbineNoGuide.Text = "Enter a value greater than 5 and less than 20";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(154, 386);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 33);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // setupNewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 445);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTurbineNoGuide);
            this.Controls.Add(this.lblWidthGuide);
            this.Controls.Add(this.lblLengthGuide);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label lblLengthGuide;
        private System.Windows.Forms.Label lblWidthGuide;
        private System.Windows.Forms.Label lblTurbineNoGuide;
        private System.Windows.Forms.Button btnBack;
    }
}