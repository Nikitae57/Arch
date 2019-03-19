namespace lab3
{
	partial class LoginMenu
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
			this.groupBox_ip = new System.Windows.Forms.GroupBox();
			this.textIP = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox_port = new System.Windows.Forms.GroupBox();
			this.textPort = new System.Windows.Forms.TextBox();
			this.groupBox_Nickname = new System.Windows.Forms.GroupBox();
			this.textNickname = new System.Windows.Forms.TextBox();
			this.button_connect = new System.Windows.Forms.Button();
			this.groupBox_ip.SuspendLayout();
			this.groupBox_port.SuspendLayout();
			this.groupBox_Nickname.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_ip
			// 
			this.groupBox_ip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_ip.Controls.Add(this.textIP);
			this.groupBox_ip.Location = new System.Drawing.Point(101, 353);
			this.groupBox_ip.Name = "groupBox_ip";
			this.groupBox_ip.Size = new System.Drawing.Size(216, 52);
			this.groupBox_ip.TabIndex = 0;
			this.groupBox_ip.TabStop = false;
			this.groupBox_ip.Text = "IP";
			// 
			// textIP
			// 
			this.textIP.Location = new System.Drawing.Point(6, 19);
			this.textIP.Name = "textIP";
			this.textIP.Size = new System.Drawing.Size(204, 20);
			this.textIP.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(133, 122);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 108);
			this.label1.TabIndex = 1;
			this.label1.Text = "Чат";
			// 
			// groupBox_port
			// 
			this.groupBox_port.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_port.Controls.Add(this.textPort);
			this.groupBox_port.Location = new System.Drawing.Point(323, 353);
			this.groupBox_port.Name = "groupBox_port";
			this.groupBox_port.Size = new System.Drawing.Size(50, 52);
			this.groupBox_port.TabIndex = 2;
			this.groupBox_port.TabStop = false;
			this.groupBox_port.Text = "Port";
			// 
			// textPort
			// 
			this.textPort.Location = new System.Drawing.Point(6, 19);
			this.textPort.Name = "textPort";
			this.textPort.Size = new System.Drawing.Size(38, 20);
			this.textPort.TabIndex = 0;
			// 
			// groupBox_Nickname
			// 
			this.groupBox_Nickname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_Nickname.Controls.Add(this.textNickname);
			this.groupBox_Nickname.Location = new System.Drawing.Point(101, 411);
			this.groupBox_Nickname.Name = "groupBox_Nickname";
			this.groupBox_Nickname.Size = new System.Drawing.Size(135, 53);
			this.groupBox_Nickname.TabIndex = 3;
			this.groupBox_Nickname.TabStop = false;
			this.groupBox_Nickname.Text = "Nickname";
			// 
			// textNickname
			// 
			this.textNickname.Location = new System.Drawing.Point(6, 20);
			this.textNickname.Name = "textNickname";
			this.textNickname.Size = new System.Drawing.Size(123, 20);
			this.textNickname.TabIndex = 0;
			// 
			// button_connect
			// 
			this.button_connect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_connect.Location = new System.Drawing.Point(260, 417);
			this.button_connect.Name = "button_connect";
			this.button_connect.Size = new System.Drawing.Size(113, 46);
			this.button_connect.TabIndex = 4;
			this.button_connect.Text = "Connect";
			this.button_connect.UseVisualStyleBackColor = true;
			this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
			// 
			// LoginMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(464, 602);
			this.Controls.Add(this.button_connect);
			this.Controls.Add(this.groupBox_Nickname);
			this.Controls.Add(this.groupBox_ip);
			this.Controls.Add(this.groupBox_port);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginMenu";
			this.Text = "Client";
			this.groupBox_ip.ResumeLayout(false);
			this.groupBox_ip.PerformLayout();
			this.groupBox_port.ResumeLayout(false);
			this.groupBox_port.PerformLayout();
			this.groupBox_Nickname.ResumeLayout(false);
			this.groupBox_Nickname.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox_ip;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textIP;
		private System.Windows.Forms.GroupBox groupBox_port;
		private System.Windows.Forms.TextBox textPort;
		private System.Windows.Forms.GroupBox groupBox_Nickname;
		private System.Windows.Forms.TextBox textNickname;
		private System.Windows.Forms.Button button_connect;
	}
}

