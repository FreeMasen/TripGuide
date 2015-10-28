namespace tripPlanner
{
    partial class Travelguide
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
            this.cboDestination = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpInterests = new System.Windows.Forms.GroupBox();
            this.rdoMuseums = new System.Windows.Forms.RadioButton();
            this.rdoActivities = new System.Windows.Forms.RadioButton();
            this.rdoLandmarks = new System.Windows.Forms.RadioButton();
            this.lstInterests = new System.Windows.Forms.ListBox();
            this.lblInterests = new System.Windows.Forms.Label();
            this.grpInterests.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDestination
            // 
            this.cboDestination.FormattingEnabled = true;
            this.cboDestination.Location = new System.Drawing.Point(53, 70);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(121, 21);
            this.cboDestination.TabIndex = 0;
            this.cboDestination.SelectedIndexChanged += new System.EventHandler(this.cboDestination_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destination";
            // 
            // grpInterests
            // 
            this.grpInterests.Controls.Add(this.rdoLandmarks);
            this.grpInterests.Controls.Add(this.rdoActivities);
            this.grpInterests.Controls.Add(this.rdoMuseums);
            this.grpInterests.Location = new System.Drawing.Point(56, 120);
            this.grpInterests.Name = "grpInterests";
            this.grpInterests.Size = new System.Drawing.Size(154, 100);
            this.grpInterests.TabIndex = 2;
            this.grpInterests.TabStop = false;
            this.grpInterests.Text = "What are you interested in?";
            // 
            // rdoMuseums
            // 
            this.rdoMuseums.AutoSize = true;
            this.rdoMuseums.Location = new System.Drawing.Point(23, 20);
            this.rdoMuseums.Name = "rdoMuseums";
            this.rdoMuseums.Size = new System.Drawing.Size(70, 17);
            this.rdoMuseums.TabIndex = 0;
            this.rdoMuseums.TabStop = true;
            this.rdoMuseums.Text = "Museums";
            this.rdoMuseums.UseVisualStyleBackColor = true;
            this.rdoMuseums.CheckedChanged += new System.EventHandler(this.rdoMuseums_CheckedChanged);
            // 
            // rdoActivities
            // 
            this.rdoActivities.AutoSize = true;
            this.rdoActivities.Location = new System.Drawing.Point(23, 44);
            this.rdoActivities.Name = "rdoActivities";
            this.rdoActivities.Size = new System.Drawing.Size(67, 17);
            this.rdoActivities.TabIndex = 1;
            this.rdoActivities.TabStop = true;
            this.rdoActivities.Text = "Activities";
            this.rdoActivities.UseVisualStyleBackColor = true;
            this.rdoActivities.CheckedChanged += new System.EventHandler(this.rdoMuseums_CheckedChanged);
            // 
            // rdoLandmarks
            // 
            this.rdoLandmarks.AutoSize = true;
            this.rdoLandmarks.Location = new System.Drawing.Point(23, 68);
            this.rdoLandmarks.Name = "rdoLandmarks";
            this.rdoLandmarks.Size = new System.Drawing.Size(77, 17);
            this.rdoLandmarks.TabIndex = 2;
            this.rdoLandmarks.TabStop = true;
            this.rdoLandmarks.Text = "Landmarks";
            this.rdoLandmarks.UseVisualStyleBackColor = true;
            this.rdoLandmarks.CheckedChanged += new System.EventHandler(this.rdoMuseums_CheckedChanged);
            // 
            // lstInterests
            // 
            this.lstInterests.FormattingEnabled = true;
            this.lstInterests.Location = new System.Drawing.Point(240, 120);
            this.lstInterests.Name = "lstInterests";
            this.lstInterests.Size = new System.Drawing.Size(120, 95);
            this.lstInterests.TabIndex = 3;
            this.lstInterests.SelectedIndexChanged += new System.EventHandler(this.lstInterests_SelectedIndexChanged);
            // 
            // lblInterests
            // 
            this.lblInterests.AutoSize = true;
            this.lblInterests.Location = new System.Drawing.Point(240, 101);
            this.lblInterests.Name = "lblInterests";
            this.lblInterests.Size = new System.Drawing.Size(62, 13);
            this.lblInterests.TabIndex = 4;
            this.lblInterests.Text = "placeholder";
            // 
            // Travelguide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 422);
            this.Controls.Add(this.lblInterests);
            this.Controls.Add(this.lstInterests);
            this.Controls.Add(this.grpInterests);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDestination);
            this.Name = "Travelguide";
            this.Text = "Travel Guide";
            this.Load += new System.EventHandler(this.Travelguide_Load);
            this.grpInterests.ResumeLayout(false);
            this.grpInterests.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpInterests;
        private System.Windows.Forms.RadioButton rdoLandmarks;
        private System.Windows.Forms.RadioButton rdoActivities;
        private System.Windows.Forms.RadioButton rdoMuseums;
        private System.Windows.Forms.ListBox lstInterests;
        private System.Windows.Forms.Label lblInterests;
    }
}

