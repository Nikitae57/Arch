using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
	public partial class LoginMenu : Form
	{
		public LoginMenu()
		{
			InitializeComponent();
		}

		private void button_connect_Click(object sender, EventArgs e)
		{
			try
			{
				Client.Client client = new Client.Client(textNickname.Text, textIP.Text, textPort.Text);

				SetVisibleCore(false);

				Chat chat = new Chat(client);
		
				chat.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					ex.Message,
					"Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error,
					MessageBoxDefaultButton.Button1,
					MessageBoxOptions.DefaultDesktopOnly);
			
			}
			
		}
	}
}
