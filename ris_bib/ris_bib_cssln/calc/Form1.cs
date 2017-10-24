using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
		Calcing calcing;

		public Form1()
        {
            InitializeComponent();
			calcing = new Calcing();
			val.Text = calcing.CurNum;
        }
        private void refresh_fields()
        {

        }

		private void btn_Click(object sender, EventArgs e)
		{
			int act_type = -1;
			if (sender == b0) act_type = Calcing.Add0;
			if (sender == b1) act_type = Calcing.Add1;
			if (sender == b2) act_type = Calcing.Add2;
			if (sender == b3) act_type = Calcing.Add3;
			if (sender == b4) act_type = Calcing.Add4;
			if (sender == b5) act_type = Calcing.Add5;
			if (sender == b6) act_type = Calcing.Add6;
			if (sender == b7) act_type = Calcing.Add7;
			if (sender == b8) act_type = Calcing.Add8;
			if (sender == b9) act_type = Calcing.Add9;
			if (sender == bcomma) act_type = Calcing.AddComma;
			if (sender == bplus) act_type = Calcing.Plus;
			if (sender == bminus) act_type = Calcing.Minus;
			if (sender == bmult) act_type = Calcing.Mult;
			if (sender == bdiv) act_type = Calcing.Div;
			if (sender == bplmin) act_type = Calcing.PlMin;
			if (sender == beq) act_type = Calcing.Eq;
			if (sender == bonedivx) act_type = Calcing.OneDivX;
			if (sender == bperc) act_type = Calcing.Perc;
			if (sender == bsqrt) act_type = Calcing.SqRt;
			if (sender == bclall) act_type = Calcing.ClAll;
			if (sender == bclcur) act_type = Calcing.ClCur;
			if (sender == bbckspc) act_type = Calcing.Bckspc;
			if (act_type != -1) {
				calcing.Act(act_type);
				val.Text = calcing.CurNum;
			}
		}
	}
}
