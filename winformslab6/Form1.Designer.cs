namespace winformslab6
{
    partial class SerForm
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
            this.ser_btn = new System.Windows.Forms.Button();
            this.des_btn = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.surname_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.surname_textBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.massege_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ser_btn
            // 
            this.ser_btn.Location = new System.Drawing.Point(50, 288);
            this.ser_btn.Name = "ser_btn";
            this.ser_btn.Size = new System.Drawing.Size(305, 23);
            this.ser_btn.TabIndex = 0;
            this.ser_btn.Text = "serialize";
            this.ser_btn.UseVisualStyleBackColor = true;
            this.ser_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // des_btn
            // 
            this.des_btn.Location = new System.Drawing.Point(50, 343);
            this.des_btn.Name = "des_btn";
            this.des_btn.Size = new System.Drawing.Size(305, 23);
            this.des_btn.TabIndex = 1;
            this.des_btn.Text = "deserialize";
            this.des_btn.UseVisualStyleBackColor = true;
            this.des_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(47, 61);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(45, 17);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Name";
            // 
            // surname_label
            // 
            this.surname_label.AutoSize = true;
            this.surname_label.Location = new System.Drawing.Point(47, 118);
            this.surname_label.Name = "surname_label";
            this.surname_label.Size = new System.Drawing.Size(65, 17);
            this.surname_label.TabIndex = 3;
            this.surname_label.Text = "Surname";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(47, 183);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(38, 17);
            this.date_label.TabIndex = 4;
            this.date_label.Text = "Date";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(155, 61);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(200, 22);
            this.name_textBox.TabIndex = 5;
            // 
            // surname_textBox
            // 
            this.surname_textBox.Location = new System.Drawing.Point(155, 118);
            this.surname_textBox.Name = "surname_textBox";
            this.surname_textBox.Size = new System.Drawing.Size(200, 22);
            this.surname_textBox.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // massege_label
            // 
            this.massege_label.AutoSize = true;
            this.massege_label.Location = new System.Drawing.Point(421, 118);
            this.massege_label.Name = "massege_label";
            this.massege_label.Size = new System.Drawing.Size(65, 17);
            this.massege_label.TabIndex = 8;
            this.massege_label.Text = "Massege";
            this.massege_label.Visible = false;
            // 
            // SerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 389);
            this.Controls.Add(this.massege_label);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.surname_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.surname_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.des_btn);
            this.Controls.Add(this.ser_btn);
            this.Name = "SerForm";
            this.Text = "Serializing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ser_btn;
        private System.Windows.Forms.Button des_btn;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label surname_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox surname_textBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label massege_label;
    }
}

