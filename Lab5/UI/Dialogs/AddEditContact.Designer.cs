namespace Lab5.UI.Dialogs
{
    partial class AddEditContact
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblId = new Label();
            txtEmailPhone = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label13 = new Label();
            label11 = new Label();
            label9 = new Label();
            label7 = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            ID = new Label();
            btnConfirm = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblId, 1, 0);
            tableLayoutPanel1.Controls.Add(txtEmailPhone, 1, 6);
            tableLayoutPanel1.Controls.Add(txtPhone, 1, 5);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 4);
            tableLayoutPanel1.Controls.Add(txtAddress, 1, 3);
            tableLayoutPanel1.Controls.Add(txtLastName, 1, 2);
            tableLayoutPanel1.Controls.Add(txtFirstName, 1, 1);
            tableLayoutPanel1.Controls.Add(label13, 0, 6);
            tableLayoutPanel1.Controls.Add(label11, 0, 5);
            tableLayoutPanel1.Controls.Add(label9, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(lblLastName, 0, 2);
            tableLayoutPanel1.Controls.Add(lblFirstName, 0, 1);
            tableLayoutPanel1.Controls.Add(ID, 0, 0);
            tableLayoutPanel1.Controls.Add(btnConfirm, 0, 7);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 20, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(256, 211);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(131, 5);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 15);
            lblId.TabIndex = 20;
            // 
            // txtEmailPhone
            // 
            txtEmailPhone.Location = new Point(131, 158);
            txtEmailPhone.Name = "txtEmailPhone";
            txtEmailPhone.Size = new Size(100, 23);
            txtEmailPhone.TabIndex = 19;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(131, 133);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(131, 108);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 17;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(131, 83);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 16;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(131, 58);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 15;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(131, 33);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(8, 155);
            label13.Name = "label13";
            label13.Size = new Size(72, 25);
            label13.TabIndex = 12;
            label13.Text = "Мобільний Телефон";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 130);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 10;
            label11.Text = "Телефон";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 105);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 8;
            label9.Text = "Пошта";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 80);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 6;
            label7.Text = "Адреса";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(8, 55);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(61, 15);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Прізвище";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(8, 30);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(28, 15);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "Ім'я";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(8, 5);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 0;
            ID.Text = "ID";
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(btnConfirm, 2);
            btnConfirm.Location = new Point(90, 183);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 20);
            btnConfirm.TabIndex = 21;
            btnConfirm.Text = "Зберегти";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // AddEditContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 211);
            Controls.Add(tableLayoutPanel1);
            Name = "AddEditContact";
            Text = "Додати новий контакт";
            Load += AddEditContact_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label13;
        private Label label11;
        private Label label9;
        private Label label7;
        private Label lblLastName;
        private Label lblFirstName;
        private Label ID;
        private Label lblId;
        private TextBox txtEmailPhone;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnConfirm;
    }
}