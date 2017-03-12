using System.Drawing;

namespace GameClient
{
    partial class XO
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_xo9 = new System.Windows.Forms.Button();
            this.btn_xo8 = new System.Windows.Forms.Button();
            this.btn_xo7 = new System.Windows.Forms.Button();
            this.btn_xo6 = new System.Windows.Forms.Button();
            this.btn_xo5 = new System.Windows.Forms.Button();
            this.btn_xo4 = new System.Windows.Forms.Button();
            this.btn_xo3 = new System.Windows.Forms.Button();
            this.btn_xo2 = new System.Windows.Forms.Button();
            this.btn_xo1 = new System.Windows.Forms.Button();
            this.turn_text = new System.Windows.Forms.Label();
            this.status_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_xo9
            // 
            this.btn_xo9.Location = new System.Drawing.Point(228, 176);
            this.btn_xo9.Name = "btn_xo9";
            this.btn_xo9.Size = new System.Drawing.Size(102, 52);
            this.btn_xo9.TabIndex = 17;
            this.btn_xo9.Tag = "8";
            this.btn_xo9.UseVisualStyleBackColor = true;
            this.btn_xo9.Click += new System.EventHandler(this.btn_xo_Click);
            // 
            // btn_xo8
            // 
            this.btn_xo8.Location = new System.Drawing.Point(120, 176);
            this.btn_xo8.Name = "btn_xo8";
            this.btn_xo8.Size = new System.Drawing.Size(102, 52);
            this.btn_xo8.TabIndex = 16;
            this.btn_xo8.Tag = "7";
            this.btn_xo8.UseVisualStyleBackColor = true;
            this.btn_xo8.Click += new System.EventHandler(this.btn_xo_Click);
            // 
            // btn_xo7
            // 
            this.btn_xo7.Location = new System.Drawing.Point(12, 176);
            this.btn_xo7.Name = "btn_xo7";
            this.btn_xo7.Size = new System.Drawing.Size(102, 52);
            this.btn_xo7.TabIndex = 15;
            this.btn_xo7.Tag = "6";
            this.btn_xo7.UseVisualStyleBackColor = true;
            this.btn_xo7.Click += new System.EventHandler(this.btn_xo_Click);
            // 
            // btn_xo6
            // 
            this.btn_xo6.Location = new System.Drawing.Point(228, 118);
            this.btn_xo6.Name = "btn_xo6";
            this.btn_xo6.Size = new System.Drawing.Size(102, 52);
            this.btn_xo6.TabIndex = 14;
            this.btn_xo6.Tag = "5";
            this.btn_xo6.UseVisualStyleBackColor = true;
            this.btn_xo6.Click += new System.EventHandler(this.btn_xo_Click);
            // 
            // btn_xo5
            // 
            this.btn_xo5.Location = new System.Drawing.Point(120, 118);
            this.btn_xo5.Name = "btn_xo5";
            this.btn_xo5.Size = new System.Drawing.Size(102, 52);
            this.btn_xo5.TabIndex = 13;
            this.btn_xo5.Tag = "4";
            this.btn_xo5.UseVisualStyleBackColor = true;
            this.btn_xo5.Click += new System.EventHandler(this.btn_xo_Click);
            // 
            // btn_xo4
            // 
            this.btn_xo4.Location = new System.Drawing.Point(12, 118);
            this.btn_xo4.Name = "btn_xo4";
            this.btn_xo4.Size = new System.Drawing.Size(102, 52);
            this.btn_xo4.TabIndex = 12;
            this.btn_xo4.Tag = "3";
            this.btn_xo4.UseVisualStyleBackColor = true;
            this.btn_xo4.Click += new System.EventHandler(this.btn_xo_Click);
            // 
            // btn_xo3
            // 
            this.btn_xo3.Location = new System.Drawing.Point(228, 60);
            this.btn_xo3.Name = "btn_xo3";
            this.btn_xo3.Size = new System.Drawing.Size(102, 52);
            this.btn_xo3.TabIndex = 11;
            this.btn_xo3.Tag = "2";
            this.btn_xo3.UseVisualStyleBackColor = true;
            this.btn_xo3.Click += new System.EventHandler(this.btn_xo_Click);
            // 
            // btn_xo2
            // 
            this.btn_xo2.Location = new System.Drawing.Point(120, 60);
            this.btn_xo2.Name = "btn_xo2";
            this.btn_xo2.Size = new System.Drawing.Size(102, 52);
            this.btn_xo2.TabIndex = 10;
            this.btn_xo2.Tag = "1";
            this.btn_xo2.UseVisualStyleBackColor = true;
            this.btn_xo2.Click += new System.EventHandler(this.btn_xo_Click);
            // 
            // btn_xo1
            // 
            this.btn_xo1.Location = new System.Drawing.Point(12, 60);
            this.btn_xo1.Name = "btn_xo1";
            this.btn_xo1.Size = new System.Drawing.Size(102, 52);
            this.btn_xo1.TabIndex = 9;
            this.btn_xo1.Tag = "0";
            this.btn_xo1.UseVisualStyleBackColor = true;
            this.btn_xo1.Click += new System.EventHandler(this.btn_xo_Click);
            // 
            // turn_text
            // 
            this.turn_text.AutoSize = true;
            this.turn_text.Location = new System.Drawing.Point(47, 32);
            this.turn_text.Name = "turn_text";
            this.turn_text.Size = new System.Drawing.Size(0, 13);
            this.turn_text.TabIndex = 18;
            // 
            // status_text
            // 
            this.status_text.AutoSize = true;
            this.status_text.Location = new System.Drawing.Point(222, 32);
            this.status_text.Name = "status_text";
            this.status_text.Size = new System.Drawing.Size(0, 13);
            this.status_text.TabIndex = 19;
            // 
            // XO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.status_text);
            this.Controls.Add(this.turn_text);
            this.Controls.Add(this.btn_xo9);
            this.Controls.Add(this.btn_xo8);
            this.Controls.Add(this.btn_xo7);
            this.Controls.Add(this.btn_xo6);
            this.Controls.Add(this.btn_xo5);
            this.Controls.Add(this.btn_xo4);
            this.Controls.Add(this.btn_xo3);
            this.Controls.Add(this.btn_xo2);
            this.Controls.Add(this.btn_xo1);
            this.Name = "XO";
            this.Location = new System.Drawing.Point(24, 41);
            this.Size = new System.Drawing.Size(339, 237);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.TabIndex = 0;
        }

        #endregion

        private System.Windows.Forms.Button btn_xo9;
        private System.Windows.Forms.Button btn_xo8;
        private System.Windows.Forms.Button btn_xo7;
        private System.Windows.Forms.Button btn_xo6;
        private System.Windows.Forms.Button btn_xo5;
        private System.Windows.Forms.Button btn_xo4;
        private System.Windows.Forms.Button btn_xo3;
        private System.Windows.Forms.Button btn_xo2;
        private System.Windows.Forms.Button btn_xo1;
        public System.Windows.Forms.Label turn_text;
        public System.Windows.Forms.Label status_text;
    }
}
