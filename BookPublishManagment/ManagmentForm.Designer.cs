namespace BookPublishManagment
{
    partial class ManagmentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Kindle = new System.Windows.Forms.Button();
            this.Publish = new System.Windows.Forms.Button();
            this.Books = new System.Windows.Forms.Button();
            this.Arcticle = new System.Windows.Forms.Button();
            this.Authors = new System.Windows.Forms.Button();
            this.AuthorsPanel = new System.Windows.Forms.Panel();
            this.SearchAuthor = new System.Windows.Forms.Button();
            this.BookName = new System.Windows.Forms.TextBox();
            this.AuthorsDataGridView = new System.Windows.Forms.DataGridView();
            this.ArcticlePanel = new System.Windows.Forms.Panel();
            this.ArcticleDataGridView = new System.Windows.Forms.DataGridView();
            this.ArcticleDateTime = new System.Windows.Forms.DateTimePicker();
            this.SearchArcticle = new System.Windows.Forms.Button();
            this.ArcticleTitle = new System.Windows.Forms.TextBox();
            this.KindlePanel = new System.Windows.Forms.Panel();
            this.KindleDate = new System.Windows.Forms.DateTimePicker();
            this.SeachEBook = new System.Windows.Forms.Button();
            this.KindleTitle = new System.Windows.Forms.TextBox();
            this.KindleDataGridView = new System.Windows.Forms.DataGridView();
            this.PublishPanel = new System.Windows.Forms.Panel();
            this.PublishEBook = new System.Windows.Forms.Button();
            this.PublishArcticle = new System.Windows.Forms.Button();
            this.PublishBook = new System.Windows.Forms.Button();
            this.BooksPanel = new System.Windows.Forms.Panel();
            this.BookPublicationDate = new System.Windows.Forms.DateTimePicker();
            this.SearchBook = new System.Windows.Forms.Button();
            this.BookDataGridView = new System.Windows.Forms.DataGridView();
            this.BookTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.AuthorsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataGridView)).BeginInit();
            this.ArcticlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArcticleDataGridView)).BeginInit();
            this.KindlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KindleDataGridView)).BeginInit();
            this.PublishPanel.SuspendLayout();
            this.BooksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.Kindle);
            this.panel1.Controls.Add(this.Publish);
            this.panel1.Controls.Add(this.Books);
            this.panel1.Controls.Add(this.Arcticle);
            this.panel1.Controls.Add(this.Authors);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 472);
            this.panel1.TabIndex = 0;
            // 
            // Kindle
            // 
            this.Kindle.FlatAppearance.BorderSize = 0;
            this.Kindle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kindle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kindle.ForeColor = System.Drawing.Color.White;
            this.Kindle.Location = new System.Drawing.Point(-2, 281);
            this.Kindle.Name = "Kindle";
            this.Kindle.Size = new System.Drawing.Size(163, 79);
            this.Kindle.TabIndex = 13;
            this.Kindle.Text = "EBooks";
            this.Kindle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Kindle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Kindle.UseVisualStyleBackColor = true;
            this.Kindle.Click += new System.EventHandler(this.PanelMenu);
            // 
            // Publish
            // 
            this.Publish.FlatAppearance.BorderSize = 0;
            this.Publish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Publish.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publish.ForeColor = System.Drawing.Color.White;
            this.Publish.Location = new System.Drawing.Point(0, 356);
            this.Publish.Name = "Publish";
            this.Publish.Size = new System.Drawing.Size(163, 79);
            this.Publish.TabIndex = 2;
            this.Publish.Text = "Publish";
            this.Publish.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Publish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Publish.UseVisualStyleBackColor = true;
            this.Publish.Click += new System.EventHandler(this.PanelMenu);
            // 
            // Books
            // 
            this.Books.FlatAppearance.BorderSize = 0;
            this.Books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Books.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Books.ForeColor = System.Drawing.Color.White;
            this.Books.Location = new System.Drawing.Point(0, 196);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(163, 79);
            this.Books.TabIndex = 1;
            this.Books.Text = "Books";
            this.Books.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Books.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Books.UseVisualStyleBackColor = true;
            this.Books.Click += new System.EventHandler(this.PanelMenu);
            // 
            // Arcticle
            // 
            this.Arcticle.FlatAppearance.BorderSize = 0;
            this.Arcticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Arcticle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arcticle.ForeColor = System.Drawing.Color.White;
            this.Arcticle.Location = new System.Drawing.Point(0, 111);
            this.Arcticle.Name = "Arcticle";
            this.Arcticle.Size = new System.Drawing.Size(163, 79);
            this.Arcticle.TabIndex = 1;
            this.Arcticle.Text = "Arcticles";
            this.Arcticle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Arcticle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Arcticle.UseVisualStyleBackColor = true;
            this.Arcticle.Click += new System.EventHandler(this.PanelMenu);
            // 
            // Authors
            // 
            this.Authors.FlatAppearance.BorderSize = 0;
            this.Authors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Authors.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authors.ForeColor = System.Drawing.Color.White;
            this.Authors.Location = new System.Drawing.Point(0, 26);
            this.Authors.Name = "Authors";
            this.Authors.Size = new System.Drawing.Size(163, 79);
            this.Authors.TabIndex = 1;
            this.Authors.Text = "Authors";
            this.Authors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Authors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Authors.UseVisualStyleBackColor = true;
            this.Authors.Click += new System.EventHandler(this.PanelMenu);
            // 
            // AuthorsPanel
            // 
            this.AuthorsPanel.Controls.Add(this.SearchAuthor);
            this.AuthorsPanel.Controls.Add(this.BookName);
            this.AuthorsPanel.Controls.Add(this.AuthorsDataGridView);
            this.AuthorsPanel.Location = new System.Drawing.Point(169, 47);
            this.AuthorsPanel.Name = "AuthorsPanel";
            this.AuthorsPanel.Size = new System.Drawing.Size(743, 513);
            this.AuthorsPanel.TabIndex = 0;
            this.AuthorsPanel.Visible = false;
            // 
            // SearchAuthor
            // 
            this.SearchAuthor.Location = new System.Drawing.Point(158, 21);
            this.SearchAuthor.Name = "SearchAuthor";
            this.SearchAuthor.Size = new System.Drawing.Size(139, 38);
            this.SearchAuthor.TabIndex = 23;
            this.SearchAuthor.Text = "Search";
            this.SearchAuthor.UseVisualStyleBackColor = true;
            this.SearchAuthor.Click += new System.EventHandler(this.SearchButton);
            // 
            // BookName
            // 
            this.BookName.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.BookName.Location = new System.Drawing.Point(14, 21);
            this.BookName.Multiline = true;
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(138, 38);
            this.BookName.TabIndex = 6;
            this.BookName.Text = "BookName";
            // 
            // AuthorsDataGridView
            // 
            this.AuthorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorsDataGridView.Location = new System.Drawing.Point(10, 69);
            this.AuthorsDataGridView.Name = "AuthorsDataGridView";
            this.AuthorsDataGridView.Size = new System.Drawing.Size(721, 347);
            this.AuthorsDataGridView.TabIndex = 2;
            // 
            // ArcticlePanel
            // 
            this.ArcticlePanel.Controls.Add(this.ArcticleDataGridView);
            this.ArcticlePanel.Controls.Add(this.ArcticleDateTime);
            this.ArcticlePanel.Controls.Add(this.SearchArcticle);
            this.ArcticlePanel.Controls.Add(this.ArcticleTitle);
            this.ArcticlePanel.Location = new System.Drawing.Point(171, 47);
            this.ArcticlePanel.Name = "ArcticlePanel";
            this.ArcticlePanel.Size = new System.Drawing.Size(742, 426);
            this.ArcticlePanel.TabIndex = 0;
            this.ArcticlePanel.Visible = false;
            // 
            // ArcticleDataGridView
            // 
            this.ArcticleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArcticleDataGridView.Location = new System.Drawing.Point(13, 86);
            this.ArcticleDataGridView.Name = "ArcticleDataGridView";
            this.ArcticleDataGridView.Size = new System.Drawing.Size(716, 330);
            this.ArcticleDataGridView.TabIndex = 22;
            // 
            // ArcticleDateTime
            // 
            this.ArcticleDateTime.Font = new System.Drawing.Font("Century Gothic", 18.7F);
            this.ArcticleDateTime.Location = new System.Drawing.Point(157, 24);
            this.ArcticleDateTime.Name = "ArcticleDateTime";
            this.ArcticleDateTime.Size = new System.Drawing.Size(257, 38);
            this.ArcticleDateTime.TabIndex = 21;
            // 
            // SearchArcticle
            // 
            this.SearchArcticle.Location = new System.Drawing.Point(420, 24);
            this.SearchArcticle.Name = "SearchArcticle";
            this.SearchArcticle.Size = new System.Drawing.Size(139, 38);
            this.SearchArcticle.TabIndex = 20;
            this.SearchArcticle.Text = "Search";
            this.SearchArcticle.UseVisualStyleBackColor = true;
            this.SearchArcticle.Click += new System.EventHandler(this.SearchButton);
            // 
            // ArcticleTitle
            // 
            this.ArcticleTitle.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.ArcticleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ArcticleTitle.Location = new System.Drawing.Point(13, 24);
            this.ArcticleTitle.Multiline = true;
            this.ArcticleTitle.Name = "ArcticleTitle";
            this.ArcticleTitle.Size = new System.Drawing.Size(138, 38);
            this.ArcticleTitle.TabIndex = 18;
            this.ArcticleTitle.Text = "Title";
            // 
            // KindlePanel
            // 
            this.KindlePanel.Controls.Add(this.KindleDate);
            this.KindlePanel.Controls.Add(this.SeachEBook);
            this.KindlePanel.Controls.Add(this.KindleTitle);
            this.KindlePanel.Controls.Add(this.KindleDataGridView);
            this.KindlePanel.Location = new System.Drawing.Point(169, 27);
            this.KindlePanel.Name = "KindlePanel";
            this.KindlePanel.Size = new System.Drawing.Size(742, 446);
            this.KindlePanel.TabIndex = 0;
            this.KindlePanel.Visible = false;
            // 
            // KindleDate
            // 
            this.KindleDate.Font = new System.Drawing.Font("Century Gothic", 18.7F);
            this.KindleDate.Location = new System.Drawing.Point(155, 67);
            this.KindleDate.Name = "KindleDate";
            this.KindleDate.Size = new System.Drawing.Size(257, 38);
            this.KindleDate.TabIndex = 24;
            // 
            // SeachEBook
            // 
            this.SeachEBook.Location = new System.Drawing.Point(418, 67);
            this.SeachEBook.Name = "SeachEBook";
            this.SeachEBook.Size = new System.Drawing.Size(139, 38);
            this.SeachEBook.TabIndex = 23;
            this.SeachEBook.Text = "Search";
            this.SeachEBook.UseVisualStyleBackColor = true;
            this.SeachEBook.Click += new System.EventHandler(this.SearchButton);
            // 
            // KindleTitle
            // 
            this.KindleTitle.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.KindleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.KindleTitle.Location = new System.Drawing.Point(11, 67);
            this.KindleTitle.Multiline = true;
            this.KindleTitle.Name = "KindleTitle";
            this.KindleTitle.Size = new System.Drawing.Size(138, 38);
            this.KindleTitle.TabIndex = 22;
            this.KindleTitle.Text = "Title";
            // 
            // KindleDataGridView
            // 
            this.KindleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KindleDataGridView.Location = new System.Drawing.Point(11, 123);
            this.KindleDataGridView.Name = "KindleDataGridView";
            this.KindleDataGridView.Size = new System.Drawing.Size(721, 313);
            this.KindleDataGridView.TabIndex = 16;
            // 
            // PublishPanel
            // 
            this.PublishPanel.Controls.Add(this.PublishEBook);
            this.PublishPanel.Controls.Add(this.PublishArcticle);
            this.PublishPanel.Controls.Add(this.PublishBook);
            this.PublishPanel.Location = new System.Drawing.Point(169, 47);
            this.PublishPanel.Name = "PublishPanel";
            this.PublishPanel.Size = new System.Drawing.Size(751, 436);
            this.PublishPanel.TabIndex = 0;
            this.PublishPanel.Visible = false;
            // 
            // PublishEBook
            // 
            this.PublishEBook.Location = new System.Drawing.Point(546, 152);
            this.PublishEBook.Name = "PublishEBook";
            this.PublishEBook.Size = new System.Drawing.Size(119, 77);
            this.PublishEBook.TabIndex = 2;
            this.PublishEBook.Text = "EBook";
            this.PublishEBook.UseVisualStyleBackColor = true;
            this.PublishEBook.Click += new System.EventHandler(this.PublishByPanel);
            // 
            // PublishArcticle
            // 
            this.PublishArcticle.Location = new System.Drawing.Point(301, 152);
            this.PublishArcticle.Name = "PublishArcticle";
            this.PublishArcticle.Size = new System.Drawing.Size(119, 77);
            this.PublishArcticle.TabIndex = 1;
            this.PublishArcticle.Text = "Arcticle";
            this.PublishArcticle.UseVisualStyleBackColor = true;
            this.PublishArcticle.Click += new System.EventHandler(this.PublishByPanel);
            // 
            // PublishBook
            // 
            this.PublishBook.Location = new System.Drawing.Point(57, 152);
            this.PublishBook.Name = "PublishBook";
            this.PublishBook.Size = new System.Drawing.Size(119, 77);
            this.PublishBook.TabIndex = 0;
            this.PublishBook.Text = "Book";
            this.PublishBook.UseVisualStyleBackColor = true;
            this.PublishBook.Click += new System.EventHandler(this.PublishByPanel);
            // 
            // BooksPanel
            // 
            this.BooksPanel.Controls.Add(this.BookPublicationDate);
            this.BooksPanel.Controls.Add(this.SearchBook);
            this.BooksPanel.Controls.Add(this.BookDataGridView);
            this.BooksPanel.Controls.Add(this.BookTitle);
            this.BooksPanel.Location = new System.Drawing.Point(172, 47);
            this.BooksPanel.Name = "BooksPanel";
            this.BooksPanel.Size = new System.Drawing.Size(747, 513);
            this.BooksPanel.TabIndex = 6;
            this.BooksPanel.Visible = false;
            // 
            // BookPublicationDate
            // 
            this.BookPublicationDate.Font = new System.Drawing.Font("Century Gothic", 18.7F);
            this.BookPublicationDate.Location = new System.Drawing.Point(152, 25);
            this.BookPublicationDate.Name = "BookPublicationDate";
            this.BookPublicationDate.Size = new System.Drawing.Size(257, 38);
            this.BookPublicationDate.TabIndex = 14;
            // 
            // SearchBook
            // 
            this.SearchBook.Location = new System.Drawing.Point(415, 25);
            this.SearchBook.Name = "SearchBook";
            this.SearchBook.Size = new System.Drawing.Size(139, 38);
            this.SearchBook.TabIndex = 13;
            this.SearchBook.Text = "Search";
            this.SearchBook.UseVisualStyleBackColor = true;
            this.SearchBook.Click += new System.EventHandler(this.SearchButton);
            // 
            // BookDataGridView
            // 
            this.BookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDataGridView.Location = new System.Drawing.Point(8, 81);
            this.BookDataGridView.Name = "BookDataGridView";
            this.BookDataGridView.Size = new System.Drawing.Size(721, 334);
            this.BookDataGridView.TabIndex = 12;
            // 
            // BookTitle
            // 
            this.BookTitle.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BookTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.BookTitle.Location = new System.Drawing.Point(8, 25);
            this.BookTitle.Multiline = true;
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Size = new System.Drawing.Size(138, 38);
            this.BookTitle.TabIndex = 10;
            this.BookTitle.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "ირაკლი ერაძის სახელობის გამოცემა \"ოქროყანა\"";
            // 
            // ManagmentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BooksPanel);
            this.Controls.Add(this.ArcticlePanel);
            this.Controls.Add(this.AuthorsPanel);
            this.Controls.Add(this.KindlePanel);
            this.Controls.Add(this.PublishPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.AuthorsPanel.ResumeLayout(false);
            this.AuthorsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataGridView)).EndInit();
            this.ArcticlePanel.ResumeLayout(false);
            this.ArcticlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArcticleDataGridView)).EndInit();
            this.KindlePanel.ResumeLayout(false);
            this.KindlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KindleDataGridView)).EndInit();
            this.PublishPanel.ResumeLayout(false);
            this.BooksPanel.ResumeLayout(false);
            this.BooksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Authors;
        private System.Windows.Forms.Button Books;
        private System.Windows.Forms.Button Arcticle;

        #endregion

        private System.Windows.Forms.Button Publish;
        private System.Windows.Forms.Button Kindle;
        private System.Windows.Forms.Panel AuthorsPanel;
        private System.Windows.Forms.Panel ArcticlePanel;
        private System.Windows.Forms.Panel KindlePanel;
        private System.Windows.Forms.Panel PublishPanel;
        private System.Windows.Forms.Panel BooksPanel;
        private System.Windows.Forms.DataGridView AuthorsDataGridView;
        private System.Windows.Forms.DataGridView BookDataGridView;
        private System.Windows.Forms.TextBox BookTitle;
        private System.Windows.Forms.DataGridView KindleDataGridView;
        private System.Windows.Forms.Button SearchBook;
        private System.Windows.Forms.DateTimePicker BookPublicationDate;
        private System.Windows.Forms.DateTimePicker ArcticleDateTime;
        private System.Windows.Forms.Button SearchArcticle;
        private System.Windows.Forms.TextBox ArcticleTitle;
        private System.Windows.Forms.DateTimePicker KindleDate;
        private System.Windows.Forms.Button SeachEBook;
        private System.Windows.Forms.TextBox KindleTitle;
        private System.Windows.Forms.Button SearchAuthor;
        private System.Windows.Forms.Button PublishEBook;
        private System.Windows.Forms.Button PublishArcticle;
        private System.Windows.Forms.Button PublishBook;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ArcticleDataGridView;
    }
}