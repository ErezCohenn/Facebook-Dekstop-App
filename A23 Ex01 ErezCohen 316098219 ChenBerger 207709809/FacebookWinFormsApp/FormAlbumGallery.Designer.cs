
namespace BasicFacebookFeatures
{
    public partial class FormAlbumGallery
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
            this.flowLayoutPanelAlbumGallery = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelAlbumGallery
            // 
            this.flowLayoutPanelAlbumGallery.AutoScroll = true;
            this.flowLayoutPanelAlbumGallery.AutoSize = true;
            this.flowLayoutPanelAlbumGallery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelAlbumGallery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAlbumGallery.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelAlbumGallery.Name = "flowLayoutPanelAlbumGallery";
            this.flowLayoutPanelAlbumGallery.Size = new System.Drawing.Size(682, 453);
            this.flowLayoutPanelAlbumGallery.TabIndex = 0;
            // 
            // FormAlbumGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.flowLayoutPanelAlbumGallery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlbumGallery";
            this.Text = "AlbumGalleryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbumGallery;
    }
}