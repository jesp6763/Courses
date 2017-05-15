namespace BookManagerProject
{
    partial class AddBookForm
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
            this.doneBtn = new System.Windows.Forms.Button();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isbnTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.authorTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.isPaperbackCB = new System.Windows.Forms.CheckBox();
            this.amountNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amountNum)).BeginInit();
            this.SuspendLayout();
            // 
            // doneBtn
            // 
            this.doneBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.doneBtn.Location = new System.Drawing.Point(105, 138);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 0;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(61, 12);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(211, 20);
            this.titleTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ISBN";
            // 
            // isbnTB
            // 
            this.isbnTB.Location = new System.Drawing.Point(61, 38);
            this.isbnTB.MaxLength = 13;
            this.isbnTB.Name = "isbnTB";
            this.isbnTB.Size = new System.Drawing.Size(211, 20);
            this.isbnTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author";
            // 
            // authorTB
            // 
            this.authorTB.Location = new System.Drawing.Point(61, 64);
            this.authorTB.Name = "authorTB";
            this.authorTB.Size = new System.Drawing.Size(211, 20);
            this.authorTB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount";
            // 
            // isPaperbackCB
            // 
            this.isPaperbackCB.AutoSize = true;
            this.isPaperbackCB.Location = new System.Drawing.Point(15, 116);
            this.isPaperbackCB.Name = "isPaperbackCB";
            this.isPaperbackCB.Size = new System.Drawing.Size(89, 17);
            this.isPaperbackCB.TabIndex = 11;
            this.isPaperbackCB.Text = "Is Paperback";
            this.isPaperbackCB.UseVisualStyleBackColor = true;
            // 
            // amountNum
            // 
            this.amountNum.Location = new System.Drawing.Point(60, 90);
            this.amountNum.Name = "amountNum";
            this.amountNum.Size = new System.Drawing.Size(212, 20);
            this.amountNum.TabIndex = 12;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 173);
            this.Controls.Add(this.amountNum);
            this.Controls.Add(this.isPaperbackCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authorTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isbnTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.doneBtn);
            this.Name = "AddBookForm";
            this.Text = "New book";
            ((System.ComponentModel.ISupportInitialize)(this.amountNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox isbnTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox authorTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox isPaperbackCB;
        private System.Windows.Forms.NumericUpDown amountNum;
    }
}