using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
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

		public void Change_tbStyle (TextBox obj) {
			obj.Font = font;
			obj.ForeColor = color;
		}

		public static void Change_tbStyle2Def (TextBox obj) {
			obj.Font = TextBox.DefaultFont;
			obj.ForeColor = TextBox.DefaultForeColor;
		}
	}

	struct TB_wdeftxt {
		TextBox tb;
		string deftext;
		bool isedited;

		// Constructor
		public TB_wdeftxt(TextBox tb, string deftext = "") {
			this.tb = tb;
			this.deftext = deftext;
			this.isedited = false;
		}

		// Mutator to default value
		public void SetDefault(FStyle style) {
			tb.Text = deftext;
			style.Change_tbStyle(tb);
		}
		public string Text {
			get{ return tb.Text; }
		}

		// Clean TextBox
		public void SetEmpty() {
			tb.Text = "";
			FStyle.Change_tbStyle2Def(tb);
		}

		public bool IsEdited() {
			return isedited;
		}

		public void IsEdited(bool isedited) {
			this.isedited = isedited;
		}
	}

	public partial class fLogin : Form
	{
		FStyle defstyle;
		Dictionary<string, TB_wdeftxt> tb_dict;

		public fLogin() {
			defstyle = new FStyle(new Font(TextBox.DefaultFont, FontStyle.Italic), Color.Gray);
			tb_dict = new Dictionary<string, TB_wdeftxt>();
			InitializeComponent();
			tb_dict.Add("tbServPass", new TB_wdeftxt(tbServPass, "localhost"));
			tb_dict.Add("tbPort", new TB_wdeftxt(tbPort, "3306"));
			tb_dict.Add("tbDBName", new TB_wdeftxt(tbDBName, "sample"));
			tb_dict.Add("tbUserName", new TB_wdeftxt(tbUserName, "root"));
			foreach(KeyValuePair<string, TB_wdeftxt> iter in tb_dict) {
				iter.Value.SetDefault(defstyle);
			}
			tbPassword.Text = "";
			tbPassword.Font = new Font(tbPassword.Font, FontStyle.Bold);
			tbPassword.PasswordChar = '\x25cf';
		}

		private void bLogin_Click(object sender, EventArgs e) {
			string connectionString =
				"server = \"" + tbServPass.Text +
				(tbPort.Text == "" ? "" : "\"; port = \"" + tbPort.Text) +
				"\"; user = \"" + tbUserName.Text +
				"\"; database = \"" + tbDBName.Text +
				(tbPassword.Text == "" ? "" : "\"; password = \"" + tbPassword.Text) + "\";";
			MySqlConnection conn = new MySqlConnection(connectionString);
			try {
				conn.Open();
				MessageBox.Show("Sucsess!");
				conn.Close();
			}
			catch (MySqlException _ex) {
				MessageBox.Show(this, _ex.Message + "\nConnection string: \'" + connectionString + "\'.", "MySQL error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tb_Enter(object sender, EventArgs e) {
			tb_dict[((TextBox)sender).Name].SetEmpty();
		}

		private void tb_Leave(object sender, EventArgs e) {
			string name = ((TextBox)sender).Name;
			if (tb_dict[name].Text == "")
			{
				tb_dict[name].SetDefault(defstyle);
				tb_dict[name].IsEdited(false);
			}
			else tb_dict[name].IsEdited(true);
		}
	}
}
