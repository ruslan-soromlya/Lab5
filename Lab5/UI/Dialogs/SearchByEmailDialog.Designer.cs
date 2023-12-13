namespace Lab5.UI.Dialogs
{
    partial class SearchByEmailDialog
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
            label1 = new Label();
            txtSearchByEmail = new TextBox();
            btnSetSearchedEmail = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Імейл для пошуку";
            // 
            // txtSearchByEmail
            // 
            txtSearchByEmail.Location = new Point(12, 27);
            txtSearchByEmail.Name = "txtSearchByEmail";
            txtSearchByEmail.Size = new Size(249, 23);
            txtSearchByEmail.TabIndex = 1;
            // 
            // btnSetSearchedEmail
            // 
            btnSetSearchedEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSetSearchedEmail.Location = new Point(84, 56);
            btnSetSearchedEmail.Name = "btnSetSearchedEmail";
            btnSetSearchedEmail.Size = new Size(75, 23);
            btnSetSearchedEmail.TabIndex = 2;
            btnSetSearchedEmail.Text = "Знайти";
            btnSetSearchedEmail.UseVisualStyleBackColor = true;
            btnSetSearchedEmail.Click += btnSetSearchedEmail_Click;
            // 
            // SearchByEmailDialog
            // 
            AcceptButton = btnSetSearchedEmail;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 89);
            Controls.Add(btnSetSearchedEmail);
            Controls.Add(txtSearchByEmail);
            Controls.Add(label1);
            Name = "SearchByEmailDialog";
            Text = "Пошук по імейлу";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearchByEmail;
        private Button btnSetSearchedEmail;
    }
}