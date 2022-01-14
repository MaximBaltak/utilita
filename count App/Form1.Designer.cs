
namespace count_App
{
    partial class myForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myForm));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blok = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьДатуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьВремяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.RichTextBox();
            this.clear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.randomNumbers = new System.Windows.Forms.TabPage();
            this.checkRepeat = new System.Windows.Forms.CheckBox();
            this.copy = new System.Windows.Forms.Button();
            this.memaryNumbers = new System.Windows.Forms.RichTextBox();
            this.randomButton = new System.Windows.Forms.Button();
            this.maxNumberText = new System.Windows.Forms.Label();
            this.maxNumber = new System.Windows.Forms.TextBox();
            this.minNumberText = new System.Windows.Forms.Label();
            this.minNumber = new System.Windows.Forms.TextBox();
            this.rabdomText = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Bloknot = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.randomNumbers.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.blok,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // blok
            // 
            this.blok.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.blok.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вставитьДатуToolStripMenuItem,
            this.вставитьВремяToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveFile,
            this.loadFile});
            this.blok.Name = "blok";
            this.blok.Size = new System.Drawing.Size(65, 20);
            this.blok.Text = "Блокнот";
            // 
            // вставитьДатуToolStripMenuItem
            // 
            this.вставитьДатуToolStripMenuItem.Name = "вставитьДатуToolStripMenuItem";
            this.вставитьДатуToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.вставитьДатуToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.вставитьДатуToolStripMenuItem.Text = "Вставить дату";
            this.вставитьДатуToolStripMenuItem.Click += new System.EventHandler(this.вставитьДатуToolStripMenuItem_Click);
            // 
            // вставитьВремяToolStripMenuItem
            // 
            this.вставитьВремяToolStripMenuItem.Name = "вставитьВремяToolStripMenuItem";
            this.вставитьВремяToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.вставитьВремяToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.вставитьВремяToolStripMenuItem.Text = "Вставить Время";
            this.вставитьВремяToolStripMenuItem.Click += new System.EventHandler(this.вставитьВремяToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(235, 6);
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFile.Size = new System.Drawing.Size(238, 22);
            this.saveFile.Text = "Сохранить";
            this.saveFile.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // loadFile
            // 
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(238, 22);
            this.loadFile.Text = "Загрузить";
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // plus
            // 
            this.plus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(330, 66);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(48, 48);
            this.plus.TabIndex = 1;
            this.plus.TabStop = false;
            this.plus.Text = "+";
            this.plus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(330, 271);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(48, 48);
            this.minus.TabIndex = 2;
            this.minus.TabStop = false;
            this.minus.Text = "-";
            this.minus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.count.Location = new System.Drawing.Point(328, 176);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(43, 44);
            this.count.TabIndex = 5;
            this.count.Text = "0";
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(66, 176);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(127, 48);
            this.clear.TabIndex = 6;
            this.clear.TabStop = false;
            this.clear.Text = "Сброс";
            this.clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.randomNumbers);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 409);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.clear);
            this.tabPage1.Controls.Add(this.count);
            this.tabPage1.Controls.Add(this.minus);
            this.tabPage1.Controls.Add(this.plus);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(699, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Стчётчик";
            // 
            // randomNumbers
            // 
            this.randomNumbers.BackColor = System.Drawing.Color.Transparent;
            this.randomNumbers.Controls.Add(this.checkRepeat);
            this.randomNumbers.Controls.Add(this.copy);
            this.randomNumbers.Controls.Add(this.memaryNumbers);
            this.randomNumbers.Controls.Add(this.randomButton);
            this.randomNumbers.Controls.Add(this.maxNumberText);
            this.randomNumbers.Controls.Add(this.maxNumber);
            this.randomNumbers.Controls.Add(this.minNumberText);
            this.randomNumbers.Controls.Add(this.minNumber);
            this.randomNumbers.Controls.Add(this.rabdomText);
            this.randomNumbers.Location = new System.Drawing.Point(4, 24);
            this.randomNumbers.Name = "randomNumbers";
            this.randomNumbers.Padding = new System.Windows.Forms.Padding(3);
            this.randomNumbers.Size = new System.Drawing.Size(699, 381);
            this.randomNumbers.TabIndex = 1;
            this.randomNumbers.Text = "Генератор чисел";
            // 
            // checkRepeat
            // 
            this.checkRepeat.AutoSize = true;
            this.checkRepeat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkRepeat.FlatAppearance.BorderSize = 0;
            this.checkRepeat.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.checkRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkRepeat.Location = new System.Drawing.Point(502, 58);
            this.checkRepeat.Name = "checkRepeat";
            this.checkRepeat.Size = new System.Drawing.Size(110, 19);
            this.checkRepeat.TabIndex = 8;
            this.checkRepeat.Text = "Без повторений";
            this.checkRepeat.UseVisualStyleBackColor = true;
            // 
            // copy
            // 
            this.copy.BackColor = System.Drawing.Color.LightCoral;
            this.copy.FlatAppearance.BorderSize = 0;
            this.copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy.Location = new System.Drawing.Point(522, 293);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(108, 33);
            this.copy.TabIndex = 7;
            this.copy.Text = "Копировать";
            this.copy.UseVisualStyleBackColor = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // memaryNumbers
            // 
            this.memaryNumbers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memaryNumbers.Location = new System.Drawing.Point(502, 92);
            this.memaryNumbers.Name = "memaryNumbers";
            this.memaryNumbers.Size = new System.Drawing.Size(150, 181);
            this.memaryNumbers.TabIndex = 6;
            this.memaryNumbers.Text = "";
            // 
            // randomButton
            // 
            this.randomButton.BackColor = System.Drawing.Color.LightCoral;
            this.randomButton.FlatAppearance.BorderSize = 0;
            this.randomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomButton.Location = new System.Drawing.Point(246, 251);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(108, 33);
            this.randomButton.TabIndex = 5;
            this.randomButton.Text = "Сгенерироать";
            this.randomButton.UseVisualStyleBackColor = false;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // maxNumberText
            // 
            this.maxNumberText.AutoSize = true;
            this.maxNumberText.BackColor = System.Drawing.Color.Transparent;
            this.maxNumberText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maxNumberText.Location = new System.Drawing.Point(310, 58);
            this.maxNumberText.Name = "maxNumberText";
            this.maxNumberText.Size = new System.Drawing.Size(119, 19);
            this.maxNumberText.TabIndex = 4;
            this.maxNumberText.Text = "Максимальное";
            // 
            // maxNumber
            // 
            this.maxNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxNumber.Location = new System.Drawing.Point(328, 92);
            this.maxNumber.Name = "maxNumber";
            this.maxNumber.Size = new System.Drawing.Size(88, 16);
            this.maxNumber.TabIndex = 3;
            // 
            // minNumberText
            // 
            this.minNumberText.AutoSize = true;
            this.minNumberText.BackColor = System.Drawing.Color.Transparent;
            this.minNumberText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minNumberText.Location = new System.Drawing.Point(154, 58);
            this.minNumberText.Name = "minNumberText";
            this.minNumberText.Size = new System.Drawing.Size(118, 19);
            this.minNumberText.TabIndex = 2;
            this.minNumberText.Text = "Минимальное:";
            // 
            // minNumber
            // 
            this.minNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minNumber.Location = new System.Drawing.Point(170, 92);
            this.minNumber.Name = "minNumber";
            this.minNumber.Size = new System.Drawing.Size(88, 16);
            this.minNumber.TabIndex = 1;
            // 
            // rabdomText
            // 
            this.rabdomText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rabdomText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rabdomText.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rabdomText.Location = new System.Drawing.Point(221, 153);
            this.rabdomText.Name = "rabdomText";
            this.rabdomText.Size = new System.Drawing.Size(168, 41);
            this.rabdomText.TabIndex = 0;
            this.rabdomText.Text = "0";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Bloknot);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(699, 381);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Блокнот";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Bloknot
            // 
            this.Bloknot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bloknot.Location = new System.Drawing.Point(0, 0);
            this.Bloknot.Name = "Bloknot";
            this.Bloknot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bloknot.Size = new System.Drawing.Size(699, 381);
            this.Bloknot.TabIndex = 0;
            this.Bloknot.Text = "";
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 433);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "myForm";
            this.Text = "Мои утилиты";
            this.Load += new System.EventHandler(this.myForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.randomNumbers.ResumeLayout(false);
            this.randomNumbers.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.RichTextBox count;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage randomNumbers;
        private System.Windows.Forms.RichTextBox rabdomText;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.TextBox maxNumber;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.RichTextBox memaryNumbers;
        private System.Windows.Forms.CheckBox checkRepeat;
        private System.Windows.Forms.Label maxNumberText;
        private System.Windows.Forms.Label minNumberText;
        private System.Windows.Forms.TextBox minNumber;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem blok;
        private System.Windows.Forms.ToolStripMenuItem вставитьДатуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьВремяToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ToolStripMenuItem loadFile;
        private System.Windows.Forms.RichTextBox Bloknot;
    }
}

