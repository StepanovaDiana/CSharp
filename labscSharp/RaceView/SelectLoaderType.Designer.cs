
namespace RaceView
{
    partial class SelectLoaderType
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectLoaderComboBox = new System.Windows.Forms.ComboBox();
            this.agreeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберете тип погрузчика";
            // 
            // selectLoaderComboBox
            // 
            this.selectLoaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectLoaderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectLoaderComboBox.FormattingEnabled = true;
            this.selectLoaderComboBox.Location = new System.Drawing.Point(16, 33);
            this.selectLoaderComboBox.Name = "selectLoaderComboBox";
            this.selectLoaderComboBox.Size = new System.Drawing.Size(178, 28);
            this.selectLoaderComboBox.TabIndex = 1;
            this.selectLoaderComboBox.SelectedIndexChanged += new System.EventHandler(this.selectLoaderComboBox_SelectedIndexChanged);
            // 
            // agreeButton
            // 
            this.agreeButton.Enabled = false;
            this.agreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.agreeButton.Location = new System.Drawing.Point(16, 67);
            this.agreeButton.Name = "agreeButton";
            this.agreeButton.Size = new System.Drawing.Size(121, 33);
            this.agreeButton.TabIndex = 2;
            this.agreeButton.Text = "Выбрать";
            this.agreeButton.UseVisualStyleBackColor = true;
            this.agreeButton.Click += new System.EventHandler(this.agreeButton_Click);
            // 
            // SelectLoaderType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 114);
            this.Controls.Add(this.agreeButton);
            this.Controls.Add(this.selectLoaderComboBox);
            this.Controls.Add(this.label1);
            this.Name = "SelectLoaderType";
            this.Text = "Выберете тип погрузчика ";
            this.Load += new System.EventHandler(this.SelectLoaderType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectLoaderComboBox;
        private System.Windows.Forms.Button agreeButton;
    }
}