namespace Lab2
{
    partial class frmListBox
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
            this.lst = new System.Windows.Forms.ListBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.taskBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst
            // 
            this.lst.BackColor = System.Drawing.Color.White;
            this.lst.ForeColor = System.Drawing.Color.Black;
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 16;
            this.lst.Items.AddRange(new object[] {
            "черный",
            "красный",
            "синий",
            "зеленый"});
            this.lst.Location = new System.Drawing.Point(26, 35);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(120, 84);
            this.lst.TabIndex = 0;
            this.lst.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.White;
            this.txt.ForeColor = System.Drawing.Color.Black;
            this.txt.Location = new System.Drawing.Point(26, 138);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(120, 22);
            this.txt.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(300, 138);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // taskBtn
            // 
            this.taskBtn.BackColor = System.Drawing.Color.White;
            this.taskBtn.Location = new System.Drawing.Point(412, 129);
            this.taskBtn.Name = "taskBtn";
            this.taskBtn.Size = new System.Drawing.Size(129, 48);
            this.taskBtn.TabIndex = 3;
            this.taskBtn.Text = "Контрольное задание";
            this.taskBtn.UseVisualStyleBackColor = false;
            this.taskBtn.Click += new System.EventHandler(this.taskBtn_Click);
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 210);
            this.Controls.Add(this.taskBtn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lst);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmListBox";
            this.Text = "frmListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button taskBtn;
    }
}

