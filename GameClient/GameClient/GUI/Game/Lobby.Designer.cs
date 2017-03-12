namespace GameClient
{
    partial class Lobby
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
            this.Text_name = new System.Windows.Forms.Label();
            this.games_name = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_invite = new System.Windows.Forms.Button();
            this.lst_clients = new System.Windows.Forms.ListBox();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_name
            // 
            this.Text_name.AutoSize = true;
            this.Text_name.Location = new System.Drawing.Point(14, 247);
            this.Text_name.Name = "Text_name";
            this.Text_name.Size = new System.Drawing.Size(0, 13);
            this.Text_name.TabIndex = 21;
            // 
            // games_name
            // 
            this.games_name.FormattingEnabled = true;
            this.games_name.ItemHeight = 13;
            this.games_name.Items.AddRange(new object[] {
            "XO"});
            this.games_name.Location = new System.Drawing.Point(139, 219);
            this.games_name.Name = "games_name";
            this.games_name.Size = new System.Drawing.Size(121, 21);
            this.games_name.TabIndex = 20;
            this.games_name.Tag = "";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(13, 217);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(119, 23);
            this.btn_refresh.TabIndex = 19;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_invite
            // 
            this.btn_invite.Location = new System.Drawing.Point(139, 247);
            this.btn_invite.Name = "btn_invite";
            this.btn_invite.Size = new System.Drawing.Size(120, 23);
            this.btn_invite.TabIndex = 18;
            this.btn_invite.Text = "Invite";
            this.btn_invite.UseVisualStyleBackColor = true;
            this.btn_invite.Click += new System.EventHandler(this.btn_invite_Click);
            // 
            // lst_clients
            // 
            this.lst_clients.FormattingEnabled = true;
            this.lst_clients.Location = new System.Drawing.Point(13, 12);
            this.lst_clients.Name = "lst_clients";
            this.lst_clients.Size = new System.Drawing.Size(247, 199);
            this.lst_clients.TabIndex = 17;
            // 
            // btn_log_out
            // 
            this.btn_log_out.Location = new System.Drawing.Point(139, 276);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(121, 23);
            this.btn_log_out.TabIndex = 16;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Visible = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Text_name);
            this.Controls.Add(this.games_name);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_invite);
            this.Controls.Add(this.lst_clients);
            this.Controls.Add(this.btn_log_out);
            this.Location = new System.Drawing.Point(56, 8);
            this.Name = "Lobby";
            this.Size = new System.Drawing.Size(281, 304);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.TabIndex = 0;
       
        }

        #endregion

        private System.Windows.Forms.Label Text_name;
        private System.Windows.Forms.ComboBox games_name;
        private System.Windows.Forms.Button btn_refresh;
        public System.Windows.Forms.Button btn_invite;
        public System.Windows.Forms.ListBox lst_clients;
        public System.Windows.Forms.Button btn_log_out;
    }
}
