namespace FastFoodRandomizerApp
{
    partial class FastFoodDeatailPage
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
            this.RestaurantName = new System.Windows.Forms.Label();
            this.FlickrImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FlickrImage)).BeginInit();
            this.SuspendLayout();
            // 
            // RestaurantName
            // 
            this.RestaurantName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RestaurantName.Location = new System.Drawing.Point(125, 25);
            this.RestaurantName.Name = "RestaurantName";
            this.RestaurantName.Size = new System.Drawing.Size(243, 185);
            this.RestaurantName.TabIndex = 0;
            this.RestaurantName.Text = "Restaurant Name";
            this.RestaurantName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RestaurantName.Click += new System.EventHandler(this.RestaurantName_Click);
            // 
            // FlickrImage
            // 
            this.FlickrImage.Location = new System.Drawing.Point(50, 50);
            this.FlickrImage.Name = "FlickrImage";
            this.FlickrImage.Size = new System.Drawing.Size(400, 400);
            this.FlickrImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.FlickrImage.TabIndex = 1;
            this.FlickrImage.TabStop = false;
            this.FlickrImage.Click += new System.EventHandler(this.FlickrImage_click);
            // 
            // FastFoodDeatailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.FlickrImage);
            this.Controls.Add(this.RestaurantName);
            this.Name = "FastFoodDeatailPage";
            this.Text = "Fast Food Detail Page";
            ((System.ComponentModel.ISupportInitialize)(this.FlickrImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label RestaurantName;
        public System.Windows.Forms.PictureBox FlickrImage;
    }
}