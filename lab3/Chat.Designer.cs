namespace lab3
{
	partial class Chat
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
			this.chatBox = new System.Web.Management.ReadOnlyTextBox();
			this.textMessage = new System.Windows.Forms.TextBox();
			this.button_sendMessage = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// chatBox
			// 
			this.chatBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chatBox.BackColor = System.Drawing.SystemColors.Window;
			this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.chatBox.Location = new System.Drawing.Point(12, 12);
			this.chatBox.Multiline = true;
			this.chatBox.Name = "chatBox";
			this.chatBox.ReadOnly = true;
			this.chatBox.Size = new System.Drawing.Size(440, 510);
			this.chatBox.TabIndex = 0;
			this.chatBox.TabStop = false;
			// 
			// textMessage
			// 
			this.textMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textMessage.Location = new System.Drawing.Point(12, 528);
			this.textMessage.Multiline = true;
			this.textMessage.Name = "textMessage";
			this.textMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textMessage.Size = new System.Drawing.Size(315, 62);
			this.textMessage.TabIndex = 1;
			// 
			// button_sendMessage
			// 
			this.button_sendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_sendMessage.Location = new System.Drawing.Point(333, 528);
			this.button_sendMessage.Name = "button_sendMessage";
			this.button_sendMessage.Size = new System.Drawing.Size(123, 62);
			this.button_sendMessage.TabIndex = 2;
			this.button_sendMessage.Text = "Отправить";
			this.button_sendMessage.UseVisualStyleBackColor = true;
			this.button_sendMessage.Click += new System.EventHandler(this.button_sendMessage_Click);
			// 
			// Chat
			// 
			this.AcceptButton = this.button_sendMessage;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 602);
			this.Controls.Add(this.button_sendMessage);
			this.Controls.Add(this.textMessage);
			this.Controls.Add(this.chatBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Chat";
			this.Text = "Chat";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chat_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Web.Management.ReadOnlyTextBox chatBox;
		private System.Windows.Forms.TextBox textMessage;
		private System.Windows.Forms.Button button_sendMessage;
	}
}