namespace Library
{
    partial class Biblioteka
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
            this.ButtonShowInfoWindow = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonShowInfoWindow
            // 
            this.ButtonShowInfoWindow.Location = new System.Drawing.Point(57, 53);
            this.ButtonShowInfoWindow.Name = "ButtonShowInfoWindow";
            this.ButtonShowInfoWindow.Size = new System.Drawing.Size(107, 44);
            this.ButtonShowInfoWindow.TabIndex = 0;
            this.ButtonShowInfoWindow.Text = "Przeglądaj katalog";
            this.ButtonShowInfoWindow.UseVisualStyleBackColor = true;
            this.ButtonShowInfoWindow.Click += new System.EventHandler(this.ButtonShowInfoWindow_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(57, 141);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(107, 44);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Wyszukaj w katalogu";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Biblioteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 243);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.ButtonShowInfoWindow);
            this.Name = "Biblioteka";
            this.Text = "Biblioteka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonShowInfoWindow;
        private System.Windows.Forms.Button buttonSearch;
    }
}

