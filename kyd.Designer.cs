namespace RestoranrFinal
{
    partial class kyd
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
            this.lstVeri = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstVeri
            // 
            this.lstVeri.FormattingEnabled = true;
            this.lstVeri.ItemHeight = 16;
            this.lstVeri.Location = new System.Drawing.Point(136, 36);
            this.lstVeri.Name = "lstVeri";
            this.lstVeri.Size = new System.Drawing.Size(357, 340);
            this.lstVeri.TabIndex = 0;
            // 
            // kyd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstVeri);
            this.Name = "kyd";
            this.Text = "kyd";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lstVeri;
    }
}