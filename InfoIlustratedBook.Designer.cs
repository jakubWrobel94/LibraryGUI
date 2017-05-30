namespace Library
{
    partial class InfoIlustratedBook
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIlustrator = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ilustrator : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxIlustrator
            // 
            this.textBoxIlustrator.Location = new System.Drawing.Point(123, 164);
            this.textBoxIlustrator.Name = "textBoxIlustrator";
            this.textBoxIlustrator.ReadOnly = true;
            this.textBoxIlustrator.Size = new System.Drawing.Size(245, 20);
            this.textBoxIlustrator.TabIndex = 13;
            // 
            // InfoIlustratedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 262);
            this.Controls.Add(this.textBoxIlustrator);
            this.Controls.Add(this.label5);
            this.Name = "InfoIlustratedBook";
            this.Text = "Informacje";
            this.Controls.SetChildIndex(this.labelTittle, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBoxtTitle, 0);
            this.Controls.SetChildIndex(this.textBoxAuthor, 0);
            this.Controls.SetChildIndex(this.textBoxGenre, 0);
            this.Controls.SetChildIndex(this.textBoxYear, 0);
            this.Controls.SetChildIndex(this.textBoxCopies, 0);
            this.Controls.SetChildIndex(this.buttonNextBook, 0);
            this.Controls.SetChildIndex(this.buttonPrevBook, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBoxIlustrator, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIlustrator;
    }
}