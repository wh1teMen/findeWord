namespace Hw
{
    partial class Form1
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
            this.textBox_slovo = new System.Windows.Forms.TextBox();
            this.button_addSlovo = new System.Windows.Forms.Button();
            this.textBox_out = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_slovo
            // 
            this.textBox_slovo.Location = new System.Drawing.Point(13, 25);
            this.textBox_slovo.Name = "textBox_slovo";
            this.textBox_slovo.Size = new System.Drawing.Size(134, 20);
            this.textBox_slovo.TabIndex = 0;
            // 
            // button_addSlovo
            // 
            this.button_addSlovo.Location = new System.Drawing.Point(162, 25);
            this.button_addSlovo.Name = "button_addSlovo";
            this.button_addSlovo.Size = new System.Drawing.Size(75, 23);
            this.button_addSlovo.TabIndex = 1;
            this.button_addSlovo.Text = "Добавить";
            this.button_addSlovo.UseVisualStyleBackColor = true;
            this.button_addSlovo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_addSlovo_MouseClick);
            // 
            // textBox_out
            // 
            this.textBox_out.Enabled = false;
            this.textBox_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_out.Location = new System.Drawing.Point(13, 65);
            this.textBox_out.Multiline = true;
            this.textBox_out.Name = "textBox_out";
            this.textBox_out.Size = new System.Drawing.Size(134, 152);
            this.textBox_out.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите слова которые надо найти:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 152);
            this.button1.TabIndex = 5;
            this.button1.Text = "найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Список слов для поиска:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_out);
            this.Controls.Add(this.button_addSlovo);
            this.Controls.Add(this.textBox_slovo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_slovo;
        private System.Windows.Forms.Button button_addSlovo;
        private System.Windows.Forms.TextBox textBox_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

