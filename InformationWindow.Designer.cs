namespace Library
{
    partial class InformationWindow
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
     
        public InformationWindow(Book BOOK)
        {
            InitializeComponent();
            textBoxtTitle.Text = BOOK.Title;
            textBoxAuthor.Text = BOOK.AuthorName;
            textBoxGenre.Text = BOOK.Genre;
            textBoxYear.Text = System.Convert.ToString(BOOK.RelaseYear);
            textBoxCopies.Text = System.Convert.ToString(BOOK.CopiesNumber);
            bookIndex = BOOK.index;  
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTittle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxtTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxCopies = new System.Windows.Forms.TextBox();
            this.buttonNextBook = new System.Windows.Forms.Button();
            this.buttonPrevBook = new System.Windows.Forms.Button();
            this.buttonLend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.Location = new System.Drawing.Point(79, 48);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(38, 13);
            this.labelTittle.TabIndex = 0;
            this.labelTittle.Text = "Tytuł :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gatunek :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rok wydania :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ilość egzemplarzy :";
            // 
            // textBoxtTitle
            // 
            this.textBoxtTitle.Location = new System.Drawing.Point(123, 45);
            this.textBoxtTitle.Name = "textBoxtTitle";
            this.textBoxtTitle.ReadOnly = true;
            this.textBoxtTitle.Size = new System.Drawing.Size(245, 20);
            this.textBoxtTitle.TabIndex = 5;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(123, 67);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.ReadOnly = true;
            this.textBoxAuthor.Size = new System.Drawing.Size(245, 20);
            this.textBoxAuthor.TabIndex = 6;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(123, 91);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.ReadOnly = true;
            this.textBoxGenre.Size = new System.Drawing.Size(82, 20);
            this.textBoxGenre.TabIndex = 7;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(123, 114);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.ReadOnly = true;
            this.textBoxYear.Size = new System.Drawing.Size(55, 20);
            this.textBoxYear.TabIndex = 8;
            // 
            // textBoxCopies
            // 
            this.textBoxCopies.Location = new System.Drawing.Point(123, 139);
            this.textBoxCopies.Name = "textBoxCopies";
            this.textBoxCopies.ReadOnly = true;
            this.textBoxCopies.Size = new System.Drawing.Size(42, 20);
            this.textBoxCopies.TabIndex = 9;
            // 
            // buttonNextBook
            // 
            this.buttonNextBook.Location = new System.Drawing.Point(293, 215);
            this.buttonNextBook.Name = "buttonNextBook";
            this.buttonNextBook.Size = new System.Drawing.Size(75, 23);
            this.buttonNextBook.TabIndex = 10;
            this.buttonNextBook.Text = ">>";
            this.buttonNextBook.UseVisualStyleBackColor = true;
            this.buttonNextBook.Click += new System.EventHandler(this.buttonNextBook_Click);
            // 
            // buttonPrevBook
            // 
            this.buttonPrevBook.Location = new System.Drawing.Point(24, 215);
            this.buttonPrevBook.Name = "buttonPrevBook";
            this.buttonPrevBook.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevBook.TabIndex = 11;
            this.buttonPrevBook.Text = "<<";
            this.buttonPrevBook.UseVisualStyleBackColor = true;
            this.buttonPrevBook.Click += new System.EventHandler(this.buttonPrevBook_Click);
            // 
            // buttonLend
            // 
            this.buttonLend.Location = new System.Drawing.Point(157, 188);
            this.buttonLend.Name = "buttonLend";
            this.buttonLend.Size = new System.Drawing.Size(75, 23);
            this.buttonLend.TabIndex = 12;
            this.buttonLend.Text = "Wypożycz";
            this.buttonLend.UseVisualStyleBackColor = true;
            this.buttonLend.Click += new System.EventHandler(this.buttonLend_Click);
            // 
            // InformationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 262);
            this.Controls.Add(this.buttonLend);
            this.Controls.Add(this.buttonPrevBook);
            this.Controls.Add(this.buttonNextBook);
            this.Controls.Add(this.textBoxCopies);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxtTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTittle);
            this.Name = "InformationWindow";
            this.Text = "InformationWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        static public BookCatalog catalog = new BookCatalog("catalog\\catalog.txt");
        protected int bookIndex;
        protected System.Windows.Forms.Label labelTittle;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox textBoxtTitle;
        protected System.Windows.Forms.TextBox textBoxAuthor;
        protected System.Windows.Forms.TextBox textBoxGenre;
        protected System.Windows.Forms.TextBox textBoxYear;
        protected System.Windows.Forms.TextBox textBoxCopies;
        protected System.Windows.Forms.Button buttonNextBook;
        protected System.Windows.Forms.Button buttonPrevBook;
        private System.Windows.Forms.Button buttonLend;
    }
}