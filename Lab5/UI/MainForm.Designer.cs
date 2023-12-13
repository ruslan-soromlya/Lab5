using System.Drawing.Printing;

namespace Lab5.UI
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            openFileMenu = new ToolStripMenuItem();
            зберегтиЗміниToolStripMenuItem = new ToolStripMenuItem();
            вПоточнийФайлToolStripMenuItem = new ToolStripMenuItem();
            вНовийФайлToolStripMenuItem = new ToolStripMenuItem();
            перестовритиБазуДанихToolStripMenuItem = new ToolStripMenuItem();
            роздрукуватиToolStripMenuItem = new ToolStripMenuItem();
            вийтиToolStripMenuItem = new ToolStripMenuItem();
            menuSearchMain = new ToolStripMenuItem();
            menuSearchByEmail = new ToolStripMenuItem();
            resetFiltersMenu = new ToolStripMenuItem();
            контактиToolStripMenuItem = new ToolStripMenuItem();
            додатиНовийКонтактToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            lblCurrentFilter = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            lblCurrentDb = new ToolStripLabel();
            saveFileDialog1 = new SaveFileDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1371, 619);
            dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, menuSearchMain, контактиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1371, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { openFileMenu, зберегтиЗміниToolStripMenuItem, перестовритиБазуДанихToolStripMenuItem, роздрукуватиToolStripMenuItem, вийтиToolStripMenuItem });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(48, 20);
            menuFile.Text = "Файл";
            // 
            // openFileMenu
            // 
            openFileMenu.Name = "openFileMenu";
            openFileMenu.ShortcutKeys = Keys.Control | Keys.O;
            openFileMenu.Size = new Size(214, 22);
            openFileMenu.Text = "Відкрити";
            openFileMenu.Click += openFileMenu_Click;
            // 
            // зберегтиЗміниToolStripMenuItem
            // 
            зберегтиЗміниToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вПоточнийФайлToolStripMenuItem, вНовийФайлToolStripMenuItem });
            зберегтиЗміниToolStripMenuItem.Name = "зберегтиЗміниToolStripMenuItem";
            зберегтиЗміниToolStripMenuItem.Size = new Size(214, 22);
            зберегтиЗміниToolStripMenuItem.Text = "Зберегти зміни";
            зберегтиЗміниToolStripMenuItem.Click += зберегтиЗміниToolStripMenuItem_Click;
            // 
            // вПоточнийФайлToolStripMenuItem
            // 
            вПоточнийФайлToolStripMenuItem.Name = "вПоточнийФайлToolStripMenuItem";
            вПоточнийФайлToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            вПоточнийФайлToolStripMenuItem.Size = new Size(222, 22);
            вПоточнийФайлToolStripMenuItem.Text = "В поточний файл";
            вПоточнийФайлToolStripMenuItem.Click += вПоточнийФайлToolStripMenuItem_Click;
            // 
            // вНовийФайлToolStripMenuItem
            // 
            вНовийФайлToolStripMenuItem.Name = "вНовийФайлToolStripMenuItem";
            вНовийФайлToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            вНовийФайлToolStripMenuItem.Size = new Size(222, 22);
            вНовийФайлToolStripMenuItem.Text = "В новий файл";
            вНовийФайлToolStripMenuItem.Click += вНовийФайлToolStripMenuItem_Click;
            // 
            // перестовритиБазуДанихToolStripMenuItem
            // 
            перестовритиБазуДанихToolStripMenuItem.Name = "перестовритиБазуДанихToolStripMenuItem";
            перестовритиБазуДанихToolStripMenuItem.Size = new Size(214, 22);
            перестовритиБазуДанихToolStripMenuItem.Text = "Перестоврити Базу даних";
            перестовритиБазуДанихToolStripMenuItem.Click += перестовритиБазуДанихToolStripMenuItem_Click;
            // 
            // роздрукуватиToolStripMenuItem
            // 
            роздрукуватиToolStripMenuItem.Name = "роздрукуватиToolStripMenuItem";
            роздрукуватиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            роздрукуватиToolStripMenuItem.Size = new Size(214, 22);
            роздрукуватиToolStripMenuItem.Text = "Роздрукувати";
            роздрукуватиToolStripMenuItem.Click += роздрукуватиToolStripMenuItem_Click;
            // 
            // вийтиToolStripMenuItem
            // 
            вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
            вийтиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            вийтиToolStripMenuItem.Size = new Size(214, 22);
            вийтиToolStripMenuItem.Text = "Вийти";
            вийтиToolStripMenuItem.Click += вийтиToolStripMenuItem_Click;
            // 
            // menuSearchMain
            // 
            menuSearchMain.DropDownItems.AddRange(new ToolStripItem[] { menuSearchByEmail, resetFiltersMenu });
            menuSearchMain.Name = "menuSearchMain";
            menuSearchMain.Size = new Size(58, 20);
            menuSearchMain.Text = "Знайти";
            // 
            // menuSearchByEmail
            // 
            menuSearchByEmail.Name = "menuSearchByEmail";
            menuSearchByEmail.ShortcutKeys = Keys.Control | Keys.F;
            menuSearchByEmail.Size = new Size(201, 22);
            menuSearchByEmail.Text = "За імейлом";
            menuSearchByEmail.Click += menuSearchByEmail_Click;
            // 
            // resetFiltersMenu
            // 
            resetFiltersMenu.Enabled = false;
            resetFiltersMenu.Name = "resetFiltersMenu";
            resetFiltersMenu.ShortcutKeys = Keys.Control | Keys.R;
            resetFiltersMenu.Size = new Size(201, 22);
            resetFiltersMenu.Text = "Скинути фільтр";
            resetFiltersMenu.Click += resetFiltersMenu_Click;
            // 
            // контактиToolStripMenuItem
            // 
            контактиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { додатиНовийКонтактToolStripMenuItem });
            контактиToolStripMenuItem.Name = "контактиToolStripMenuItem";
            контактиToolStripMenuItem.Size = new Size(69, 20);
            контактиToolStripMenuItem.Text = "Контакти";
            // 
            // додатиНовийКонтактToolStripMenuItem
            // 
            додатиНовийКонтактToolStripMenuItem.Name = "додатиНовийКонтактToolStripMenuItem";
            додатиНовийКонтактToolStripMenuItem.Size = new Size(195, 22);
            додатиНовийКонтактToolStripMenuItem.Text = "Додати новий контакт";
            додатиНовийКонтактToolStripMenuItem.Click += додатиНовийКонтактToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, lblCurrentFilter, toolStripLabel2, lblCurrentDb });
            toolStrip1.Location = new Point(0, 618);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1371, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(106, 22);
            toolStripLabel1.Text = "Поточний фільтр:";
            // 
            // lblCurrentFilter
            // 
            lblCurrentFilter.Name = "lblCurrentFilter";
            lblCurrentFilter.Size = new Size(62, 22);
            lblCurrentFilter.Text = "Не задано";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(120, 22);
            toolStripLabel2.Text = "Поточна база даних:";
            // 
            // lblCurrentDb
            // 
            lblCurrentDb.Name = "lblCurrentDb";
            lblCurrentDb.Size = new Size(0, 22);
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += new PrintPageEventHandler(PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 643);
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Записничок";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuSearchMain;
        private ToolStripMenuItem menuSearchByEmail;
        private ToolStripMenuItem resetFiltersMenu;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem openFileMenu;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem зберегтиЗміниToolStripMenuItem;
        private ToolStripMenuItem вПоточнийФайлToolStripMenuItem;
        private ToolStripMenuItem вНовийФайлToolStripMenuItem;
        private ToolStripMenuItem вийтиToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel lblCurrentFilter;
        private SaveFileDialog saveFileDialog1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel lblCurrentDb;
        private ToolStripMenuItem контактиToolStripMenuItem;
        private ToolStripMenuItem додатиНовийКонтактToolStripMenuItem;
        private ToolStripMenuItem перестовритиБазуДанихToolStripMenuItem;
        private ToolStripMenuItem роздрукуватиToolStripMenuItem;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}