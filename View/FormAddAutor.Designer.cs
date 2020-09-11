namespace View
{
    partial class FormAddAutor
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
            this.labelPaper = new System.Windows.Forms.Label();
            this.ComboBoxPaper = new System.Windows.Forms.ComboBox();
            this.textBoxPlase = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelPlase = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPaper
            // 
            this.labelPaper.AutoSize = true;
            this.labelPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPaper.Location = new System.Drawing.Point(-1, 54);
            this.labelPaper.Name = "labelPaper";
            this.labelPaper.Size = new System.Drawing.Size(54, 17);
            this.labelPaper.TabIndex = 22;
            this.labelPaper.Text = "Статья";
            // 
            // ComboBoxPaper
            // 
            this.ComboBoxPaper.FormattingEnabled = true;
            this.ComboBoxPaper.Location = new System.Drawing.Point(107, 54);
            this.ComboBoxPaper.Name = "ComboBoxPaper";
            this.ComboBoxPaper.Size = new System.Drawing.Size(268, 21);
            this.ComboBoxPaper.TabIndex = 21;
            // 
            // textBoxPlase
            // 
            this.textBoxPlase.Location = new System.Drawing.Point(107, 104);
            this.textBoxPlase.Name = "textBoxPlase";
            this.textBoxPlase.Size = new System.Drawing.Size(268, 20);
            this.textBoxPlase.TabIndex = 20;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(107, 81);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(268, 20);
            this.textBoxEmail.TabIndex = 18;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(251, 171);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.Location = new System.Drawing.Point(170, 171);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelPlase
            // 
            this.labelPlase.AutoSize = true;
            this.labelPlase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPlase.Location = new System.Drawing.Point(-1, 104);
            this.labelPlase.Name = "labelPlase";
            this.labelPlase.Size = new System.Drawing.Size(102, 17);
            this.labelPlase.TabIndex = 15;
            this.labelPlase.Text = "Место работы";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelEmail.Location = new System.Drawing.Point(-1, 82);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(74, 17);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "Эл. Почта";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelName.Location = new System.Drawing.Point(-1, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 17);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "ФИО";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(107, 27);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(268, 20);
            this.textBoxName.TabIndex = 23;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(116, 130);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(259, 20);
            this.dateTimePicker.TabIndex = 24;
            this.dateTimePicker.Value = new System.DateTime(2019, 6, 12, 0, 0, 0, 0);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDate.Location = new System.Drawing.Point(-1, 133);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(111, 17);
            this.labelDate.TabIndex = 25;
            this.labelDate.Text = "Дата рождения";
            // 
            // FormAddAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 221);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPaper);
            this.Controls.Add(this.ComboBoxPaper);
            this.Controls.Add(this.textBoxPlase);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelPlase);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Name = "FormAddAutor";
            this.Text = "FormAddAutor";
            this.Load += new System.EventHandler(this.FormAddAutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPaper;
        private System.Windows.Forms.ComboBox ComboBoxPaper;
        private System.Windows.Forms.TextBox textBoxPlase;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelPlase;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelDate;
    }
}