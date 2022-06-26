
namespace RaceView
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLoaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMechanicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.стартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьМеханикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПогрузчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.startToolStripMenuItem.Text = "Запуск";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.Enabled = false;
            this.addCarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(139, 25);
            this.addCarToolStripMenuItem.Text = "Добавить болид";
            this.addCarToolStripMenuItem.Click += new System.EventHandler(this.addCarToolStripMenuItem_Click);
            // 
            // addLoaderToolStripMenuItem
            // 
            this.addLoaderToolStripMenuItem.Enabled = false;
            this.addLoaderToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addLoaderToolStripMenuItem.Name = "addLoaderToolStripMenuItem";
            this.addLoaderToolStripMenuItem.Size = new System.Drawing.Size(169, 25);
            this.addLoaderToolStripMenuItem.Text = "Добавить погрузчик";
            this.addLoaderToolStripMenuItem.Click += new System.EventHandler(this.addLoaderToolStripMenuItem_Click);
            // 
            // addMechanicToolStripMenuItem
            // 
            this.addMechanicToolStripMenuItem.Enabled = false;
            this.addMechanicToolStripMenuItem.Name = "addMechanicToolStripMenuItem";
            this.addMechanicToolStripMenuItem.Size = new System.Drawing.Size(163, 25);
            this.addMechanicToolStripMenuItem.Text = "Добавить механика";
            this.addMechanicToolStripMenuItem.Click += new System.EventHandler(this.addMechanicToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 29);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.messageTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(717, 856);
            this.splitContainer1.SplitterDistance = 339;
            this.splitContainer1.TabIndex = 3;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.messageTextBox.Location = new System.Drawing.Point(0, 0);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageTextBox.Size = new System.Drawing.Size(717, 339);
            this.messageTextBox.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Gray;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(717, 513);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стартToolStripMenuItem,
            this.addCarMenuItem,
            this.добавитьМеханикаToolStripMenuItem,
            this.добавитьПогрузчикToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(717, 29);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip2";
            // 
            // стартToolStripMenuItem
            // 
            this.стартToolStripMenuItem.Name = "стартToolStripMenuItem";
            this.стартToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.стартToolStripMenuItem.Text = "Старт";
            this.стартToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // addCarMenuItem
            // 
            this.addCarMenuItem.Name = "addCarMenuItem";
            this.addCarMenuItem.Size = new System.Drawing.Size(139, 25);
            this.addCarMenuItem.Text = "Добавить болид";
            this.addCarMenuItem.Click += new System.EventHandler(this.addCarToolStripMenuItem_Click);
            // 
            // добавитьМеханикаToolStripMenuItem
            // 
            this.добавитьМеханикаToolStripMenuItem.Name = "добавитьМеханикаToolStripMenuItem";
            this.добавитьМеханикаToolStripMenuItem.Size = new System.Drawing.Size(163, 25);
            this.добавитьМеханикаToolStripMenuItem.Text = "Добавить механика";
            this.добавитьМеханикаToolStripMenuItem.Click += new System.EventHandler(this.addMechanicToolStripMenuItem_Click);
            // 
            // добавитьПогрузчикToolStripMenuItem
            // 
            this.добавитьПогрузчикToolStripMenuItem.Name = "добавитьПогрузчикToolStripMenuItem";
            this.добавитьПогрузчикToolStripMenuItem.Size = new System.Drawing.Size(169, 25);
            this.добавитьПогрузчикToolStripMenuItem.Text = "Добавить погрузчик";
            this.добавитьПогрузчикToolStripMenuItem.Click += new System.EventHandler(this.addLoaderToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 885);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Sport Competitions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLoaderToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem addMechanicToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem стартToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьМеханикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПогрузчикToolStripMenuItem;
    }
}

