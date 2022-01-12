namespace DictionaryApp
{
    partial class Form1
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
            this.txbWord = new System.Windows.Forms.TextBox();
            this.dgwWords = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWords)).BeginInit();
            this.SuspendLayout();
            // 
            // txbWord
            // 
            this.txbWord.Location = new System.Drawing.Point(226, 146);
            this.txbWord.Margin = new System.Windows.Forms.Padding(5);
            this.txbWord.Name = "txbWord";
            this.txbWord.Size = new System.Drawing.Size(383, 22);
            this.txbWord.TabIndex = 0;
            this.txbWord.TextChanged += new System.EventHandler(this.txbWord_TextChanged);
            // 
            // dgwWords
            // 
            this.dgwWords.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgwWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwWords.Location = new System.Drawing.Point(178, 207);
            this.dgwWords.Name = "dgwWords";
            this.dgwWords.RowHeadersWidth = 51;
            this.dgwWords.RowTemplate.Height = 24;
            this.dgwWords.Size = new System.Drawing.Size(481, 224);
            this.dgwWords.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bir Kelime Giriniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwWords);
            this.Controls.Add(this.txbWord);
            this.Name = "Form1";
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbWord;
        private System.Windows.Forms.DataGridView dgwWords;
        private System.Windows.Forms.Label label1;
    }
}

