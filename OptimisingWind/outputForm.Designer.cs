
namespace OptimisingWind
{
    partial class outputForm
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
            this.lblPowerOutput = new System.Windows.Forms.Label();
            this.lblPotentialPower = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.lblTurbine = new System.Windows.Forms.Label();
            this.lblTurbineSelect = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblTurbinePower = new System.Windows.Forms.Label();
            this.lblTurbineCost = new System.Windows.Forms.Label();
            this.lblTurbinePotential = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbTurbines = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPowerOutput
            // 
            this.lblPowerOutput.AutoSize = true;
            this.lblPowerOutput.Location = new System.Drawing.Point(91, 96);
            this.lblPowerOutput.Name = "lblPowerOutput";
            this.lblPowerOutput.Size = new System.Drawing.Size(104, 20);
            this.lblPowerOutput.TabIndex = 0;
            this.lblPowerOutput.Text = "Power output: ";
            // 
            // lblPotentialPower
            // 
            this.lblPotentialPower.AutoSize = true;
            this.lblPotentialPower.Location = new System.Drawing.Point(91, 131);
            this.lblPotentialPower.Name = "lblPotentialPower";
            this.lblPotentialPower.Size = new System.Drawing.Size(168, 20);
            this.lblPotentialPower.TabIndex = 1;
            this.lblPotentialPower.Text = "Potential power output: ";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(91, 171);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(79, 20);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "Field cost: ";
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblField.Location = new System.Drawing.Point(91, 40);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(102, 28);
            this.lblField.TabIndex = 4;
            this.lblField.Text = "Field data:";
            // 
            // lblTurbine
            // 
            this.lblTurbine.AutoSize = true;
            this.lblTurbine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTurbine.Location = new System.Drawing.Point(91, 240);
            this.lblTurbine.Name = "lblTurbine";
            this.lblTurbine.Size = new System.Drawing.Size(126, 28);
            this.lblTurbine.TabIndex = 5;
            this.lblTurbine.Text = "Turbine data:";
            // 
            // lblTurbineSelect
            // 
            this.lblTurbineSelect.AutoSize = true;
            this.lblTurbineSelect.Location = new System.Drawing.Point(91, 299);
            this.lblTurbineSelect.Name = "lblTurbineSelect";
            this.lblTurbineSelect.Size = new System.Drawing.Size(102, 20);
            this.lblTurbineSelect.TabIndex = 6;
            this.lblTurbineSelect.Text = "Select tubine: ";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(410, 299);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(174, 20);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "This turbine is lcoated at:";
            // 
            // lblTurbinePower
            // 
            this.lblTurbinePower.AutoSize = true;
            this.lblTurbinePower.Location = new System.Drawing.Point(410, 335);
            this.lblTurbinePower.Name = "lblTurbinePower";
            this.lblTurbinePower.Size = new System.Drawing.Size(108, 20);
            this.lblTurbinePower.TabIndex = 8;
            this.lblTurbinePower.Text = "Turbine power:";
            // 
            // lblTurbineCost
            // 
            this.lblTurbineCost.AutoSize = true;
            this.lblTurbineCost.Location = new System.Drawing.Point(410, 412);
            this.lblTurbineCost.Name = "lblTurbineCost";
            this.lblTurbineCost.Size = new System.Drawing.Size(93, 20);
            this.lblTurbineCost.TabIndex = 9;
            this.lblTurbineCost.Text = "Turbine cost:";
            // 
            // lblTurbinePotential
            // 
            this.lblTurbinePotential.AutoSize = true;
            this.lblTurbinePotential.Location = new System.Drawing.Point(410, 373);
            this.lblTurbinePotential.Name = "lblTurbinePotential";
            this.lblTurbinePotential.Size = new System.Drawing.Size(172, 20);
            this.lblTurbinePotential.TabIndex = 10;
            this.lblTurbinePotential.Text = "Turbine potential power:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(626, 96);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 35);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbTurbines
            // 
            this.cmbTurbines.FormattingEnabled = true;
            this.cmbTurbines.Location = new System.Drawing.Point(207, 299);
            this.cmbTurbines.Name = "cmbTurbines";
            this.cmbTurbines.Size = new System.Drawing.Size(84, 28);
            this.cmbTurbines.TabIndex = 3;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(135, 373);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(102, 28);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "View data";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // outputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 494);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTurbinePotential);
            this.Controls.Add(this.lblTurbineCost);
            this.Controls.Add(this.lblTurbinePower);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblTurbineSelect);
            this.Controls.Add(this.lblTurbine);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.cmbTurbines);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblPotentialPower);
            this.Controls.Add(this.lblPowerOutput);
            this.Name = "outputForm";
            this.Text = "outputForm";
            this.Load += new System.EventHandler(this.outputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPowerOutput;
        private System.Windows.Forms.Label lblPotentialPower;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Label lblTurbine;
        private System.Windows.Forms.Label lblTurbineSelect;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblTurbinePower;
        private System.Windows.Forms.Label lblTurbineCost;
        private System.Windows.Forms.Label lblTurbinePotential;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbTurbines;
        private System.Windows.Forms.Button btnView;
    }
}