namespace FastFoodRandomizerApp
{
    partial class AddLocationPage
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
            this.AddLocationTextBox = new System.Windows.Forms.TextBox();
            this.SaveLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddLocationTextBox
            // 
            this.AddLocationTextBox.Location = new System.Drawing.Point(102, 100);
            this.AddLocationTextBox.Name = "AddLocationTextBox";
            this.AddLocationTextBox.Size = new System.Drawing.Size(125, 22);
            this.AddLocationTextBox.TabIndex = 0;
            // 
            // SaveLocation
            // 
            this.SaveLocation.Location = new System.Drawing.Point(102, 128);
            this.SaveLocation.Name = "SaveLocation";
            this.SaveLocation.Size = new System.Drawing.Size(125, 38);
            this.SaveLocation.TabIndex = 1;
            this.SaveLocation.Text = "Save Location";
            this.SaveLocation.UseVisualStyleBackColor = true;
            this.SaveLocation.Click += new System.EventHandler(this.SaveLocation_Click);
            // 
            // AddLocationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 206);
            this.Controls.Add(this.SaveLocation);
            this.Controls.Add(this.AddLocationTextBox);
            this.Name = "AddLocationPage";
            this.Text = "Add Location Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddLocationTextBox;
        private System.Windows.Forms.Button SaveLocation;
    }
}