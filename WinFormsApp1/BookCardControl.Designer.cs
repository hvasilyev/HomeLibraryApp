namespace HomeLibrary
{
    partial class BookCardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookCardControl));
            pnlContainer = new Panel();
            lblAuthor = new Label();
            lblTitle = new Label();
            pictureBoxCover = new PictureBox();
            pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).BeginInit();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlContainer.Controls.Add(lblAuthor);
            pnlContainer.Controls.Add(lblTitle);
            pnlContainer.Controls.Add(pictureBoxCover);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(578, 150);
            pnlContainer.TabIndex = 1;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(120, 52);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(59, 25);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "label2";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(120, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(76, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "label1";
            // 
            // pictureBoxCover
            // 
            pictureBoxCover.Image = (Image)resources.GetObject("pictureBoxCover.Image");
            pictureBoxCover.Location = new Point(12, 15);
            pictureBoxCover.Name = "pictureBoxCover";
            pictureBoxCover.Size = new Size(85, 117);
            pictureBoxCover.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCover.TabIndex = 0;
            pictureBoxCover.TabStop = false;
            // 
            // BookCardControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContainer);
            Name = "BookCardControl";
            Size = new Size(578, 150);
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Label lblAuthor;
        private Label lblTitle;
        private PictureBox pictureBoxCover;
    }
}
