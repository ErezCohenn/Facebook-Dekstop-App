using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class PostPanel : Panel
    {
        private PictureBox m_PostImage;
        private Label m_Headline;
        private Label m_CreatedTime;
        private TextBox m_Content;

        public PostPanel(Post i_Post)
        {
            initializeComponents();
            if (i_Post.IconURL != null)
            {
                m_PostImage.LoadAsync(i_Post.IconURL);
            }
            if (i_Post.Caption != null)
            {
                m_Headline.Text = i_Post.Caption;
            }
            if (i_Post.Message != null)
            {
                m_Content.Text = i_Post.Message;
            }
            if (i_Post.CreatedTime != null)
            {
                m_CreatedTime.Text = i_Post.CreatedTime.ToString();
            }
        }

        private void initializeComponents()
        {
            this.m_PostImage = new System.Windows.Forms.PictureBox();
            this.m_Headline = new System.Windows.Forms.Label();
            this.m_CreatedTime = new System.Windows.Forms.Label();
            this.m_Content = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_PostImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.Controls.Add(this.m_Content);
            this.Controls.Add(this.m_Headline);
            this.Controls.Add(this.m_PostImage);
            this.Location = new System.Drawing.Point(70, 37);
            this.Name = "panel";
            this.Size = new System.Drawing.Size(750, 214);
            this.TabIndex = 1;
            // 
            // m_PostImage
            // 
            this.m_PostImage.Location = new System.Drawing.Point(15, 15);
            this.m_PostImage.Name = "m_PostImage";
            this.m_PostImage.Size = new System.Drawing.Size(100, 60);
            this.m_PostImage.TabIndex = 0;
            this.m_PostImage.TabStop = false;
            // 
            // m_Headline
            // 
            this.m_Headline.AutoSize = true;
            this.m_Headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_Headline.Location = new System.Drawing.Point(138, 26);
            this.m_Headline.Name = "m_Headline";
            this.m_Headline.Size = new System.Drawing.Size(93, 32);
            this.m_Headline.TabIndex = 1;
            this.m_Headline.Text = "There is no headline in this post";
            // 
            // m_CreatedTime
            // 
            this.m_CreatedTime.AutoSize = true;
            this.m_CreatedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_CreatedTime.Location = new System.Drawing.Point(138, 60);
            this.m_CreatedTime.Name = "m_Headline";
            this.m_CreatedTime.Size = new System.Drawing.Size(93, 20);
            this.m_CreatedTime.TabIndex = 1;
            this.m_CreatedTime.Text = "N/A";
            // 
            // m_Content
            // 
            this.m_Content.Location = new System.Drawing.Point(15, 95);
            this.m_Content.Name = "m_Content";
            this.m_Content.Size = new System.Drawing.Size(455, 96);
            this.m_Content.TabIndex = 2;
            this.m_Content.Text = "There is no any content in this post";
            this.m_Content.Enabled = false;
            this.ResumeLayout(false);
            this.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            this.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PostImage)).EndInit();
        }
    }
}
