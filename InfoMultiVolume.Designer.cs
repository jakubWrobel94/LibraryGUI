namespace Library
{
    partial class InfoMultiVolume
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
            this.textBoxVolumes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ilość tomów : ";
            // 
            // textBoxVolumes
            // 
            this.textBoxVolumes.Location = new System.Drawing.Point(123, 167);
            this.textBoxVolumes.Name = "textBoxVolumes";
            this.textBoxVolumes.ReadOnly = true;
            this.textBoxVolumes.Size = new System.Drawing.Size(27, 20);
            this.textBoxVolumes.TabIndex = 13;
            // 
            // InfoMultiVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 262);
            this.Controls.Add(this.textBoxVolumes);
            this.Controls.Add(this.label5);
            this.Name = "InfoMultiVolume";
            this.Text = "InfoMultiVolume";
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
            this.Controls.SetChildIndex(this.textBoxVolumes, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxVolumes;
    }
}