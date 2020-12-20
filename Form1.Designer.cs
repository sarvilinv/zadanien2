
namespace zadanien2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_ok = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "На какое число будем составлять таблицу умножения?";
            // 
            // Btn_ok
            // 
            this.Btn_ok.Enabled = false;
            this.Btn_ok.Location = new System.Drawing.Point(15, 142);
            this.Btn_ok.Name = "Btn_ok";
            this.Btn_ok.Size = new System.Drawing.Size(75, 23);
            this.Btn_ok.TabIndex = 1;
            this.Btn_ok.Text = "Ок";
            this.Btn_ok.UseVisualStyleBackColor = true;
            this.Btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(177, 142);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Отмена";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(12, 106);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(231, 20);
            this.txt_number.TabIndex = 3;
            this.txt_number.TextChanged += new System.EventHandler(this.txt_number_TextChanged);
            this.txt_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Enabled = false;
            this.Btn_Clear.Location = new System.Drawing.Point(96, 142);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.Btn_Clear.TabIndex = 4;
            this.Btn_Clear.Text = "Очистить";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 177);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.Btn_ok);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Таблица умножения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Btn_ok;
        private System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Button Btn_Clear;
    }
}

