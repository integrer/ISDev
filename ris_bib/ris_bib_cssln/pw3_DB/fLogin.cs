using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pw3_DB
{
	struct FStyle {
		Font font;
		Color color;

		public FStyle(Font font, Color color) {
			this.font = font;
			this.color = color;
		}

		public void change_tb_style (TextBox obj) {
			obj.Font = font;
			obj.ForeColor = color;
		}
	}

	public partial class fLogin : Form
	{
		FStyle not_edited;
		FStyle edited;

		public fLogin() {
			not_edited = new FStyle(new Font(TextBox.DefaultFont, FontStyle.Italic), Color.Gray);
			edited = new FStyle(TextBox.DefaultFont, TextBox.DefaultForeColor);
			InitializeComponent();
		}

		private void fLogin_Load(object sender, EventArgs e)
		{

		}

		private void bLogin_Click(object sender, EventArgs e) {
			string connectionString = "server = \"" + tbServPass.Text + "\"; user = \"" + tbUserName.Text + "\"; database = \"" + tbDBName.Text + "\"; password = \"" + tbPassword.Text + "\";";
			MySqlConnection conn = new MySqlConnection(connectionString);
			try {
				conn.Open();
				MessageBox.Show("Sucsess!");
				conn.Close();
			}
			catch (Exception _ex) {
				MessageBox.Show(_ex.Message);
			}
		}

		private void tb_Enter(object sender, EventArgs e) {
			if (sender.GetType() != Type.GetType("TextBox")) {
				MessageBox.Show(this, String.Format("This handler can not handle event from object \'{0}\'", sender.ToString()), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

		}
	}
}
