namespace FastFoodRandomizerApp
{
    partial class MainPage
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
            this.FastFoodRandomizer = new System.Windows.Forms.Button();
            this.AddLocation = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // FastFoodRandomizer
            // 
            this.FastFoodRandomizer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FastFoodRandomizer.Location = new System.Drawing.Point(300, 200);
            this.FastFoodRandomizer.Name = "FastFoodRandomizer";
            this.FastFoodRandomizer.Size = new System.Drawing.Size(200, 75);
            this.FastFoodRandomizer.TabIndex = 0;
            this.FastFoodRandomizer.Text = "Fast Food Randomizer";
            this.FastFoodRandomizer.UseVisualStyleBackColor = true;
            this.FastFoodRandomizer.Click += new System.EventHandler(this.FastFoodRandomizer_Click);
            // 
            // AddLocation
            // 
            this.AddLocation.Location = new System.Drawing.Point(12, 400);
            this.AddLocation.Name = "AddLocation";
            this.AddLocation.Size = new System.Drawing.Size(125, 38);
            this.AddLocation.TabIndex = 1;
            this.AddLocation.Text = "Add Location";
            this.AddLocation.UseVisualStyleBackColor = true;
            this.AddLocation.Click += new System.EventHandler(this.AddLocation_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(337, 279);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(129, 17);
            this.Result.TabIndex = 2;
            this.Result.TabStop = true;
            this.Result.Text = "Fast Food Location";
            this.Result.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Result_LinkClicked);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.AddLocation);
            this.Controls.Add(this.FastFoodRandomizer);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Food Randomizer Button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FastFoodRandomizer;
        private System.Windows.Forms.Button AddLocation;
        public System.Windows.Forms.LinkLabel Result;
    }
}

