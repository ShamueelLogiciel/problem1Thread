namespace problem1Thread
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnThread = new Button();
            threadText = new TextBox();
            threadRichText = new RichTextBox();
            SuspendLayout();
            // 
            // btnThread
            // 
            btnThread.Location = new Point(241, 111);
            btnThread.Name = "btnThread";
            btnThread.Size = new Size(75, 23);
            btnThread.TabIndex = 0;
            btnThread.Text = "thread";
            btnThread.UseVisualStyleBackColor = true;
            btnThread.Click += btnThread_Click;
            // 
            // threadText
            // removed thread TEXT
            // 
            // threadRichText
            // 
            threadRichText.Location = new Point(241, 244);
            threadRichText.Name = "threadRichText";
            threadRichText.Size = new Size(209, 96);
            threadRichText.TabIndex = 3;
            threadRichText.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(threadRichText);
            Controls.Add(threadText);
            Controls.Add(btnThread);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThread;
        //private TextBox threadText;
        private RichTextBox threadRichText;
    }
}
