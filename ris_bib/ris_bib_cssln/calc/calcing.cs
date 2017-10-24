using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    
    class Calcing
    {
		const int add0 = 0;
		const int add1 = 1;
		const int add2 = 2;
		const int add3 = 3;
        const int add4 = 4;
        const int add5 = 5;
        const int add6 = 6;
        const int add7 = 7;
        const int add8 = 8;
        const int add9 = 9;
        const int addcomma = 10;
        const int plus = 11;
        const int minus = 12;
        const int mult = 13;
        const int div = 14;
        const int plmin = 15;
        const int eq = 16;
        const int onedivx = 17;
        const int perc = 18;
        const int sqrt = 19;
        const int clall = 20;
        const int clcur = 21;
        const int bckspc = 22;

		public static int Add0 => add0;
		public static int Add1 => add1;
		public static int Add2 => add2;
		public static int Add3 => add3;
		public static int Add4 => add4;
		public static int Add5 => add5;
		public static int Add6 => add6;
		public static int Add7 => add7;
		public static int Add8 => add8;
		public static int Add9 => add9;
		public static int AddComma => addcomma;
		public static int Plus => plus;
		public static int Minus => minus;
		public static int Mult => mult;
		public static int Div => div;
		public static int PlMin => plmin;
		public static int Eq => eq;
		public static int OneDivX => onedivx;
		public static int Perc => perc;
		public static int SqRt => sqrt;
		public static int ClAll => clall;
		public static int ClCur => clcur;
		public static int Bckspc => bckspc;

		public string CurNum { get => curnum; }

		public int Act (int par) {
			switch (par) {
				case add0: {
					if (!is_curnum_lock) {
						curnum = "0";
						is_curnum_lock = true;
					}
					else if (curnum != "0") curnum += "0";
					break;
				}
				case add1: {
					if (!is_curnum_lock || curnum == "0") {
						curnum = "1";
						is_curnum_lock = true;
					}
					else curnum += "1";
					break;
				}
				case add2: {
					if (!is_curnum_lock || curnum == "0") {
						curnum = "2";
						is_curnum_lock = true;
					}
					else curnum += "2";
					break;
				}
				case add3: {
					if (!is_curnum_lock || curnum == "0") {
						curnum = "3";
						is_curnum_lock = true;
					}
					else curnum += "3";
					break;
				}
				case add4: {
					if (!is_curnum_lock || curnum == "0") {
						curnum = "4";
						is_curnum_lock = true;
					}
					else curnum += "4";
					break;
				}
				case add5: {
					if (!is_curnum_lock || curnum == "0") {
						curnum = "5";
						is_curnum_lock = true;
					}
					else curnum += "5";
					break;
				}
				case add6: {
					if (!is_curnum_lock || curnum == "0") {
						curnum = "6";
						is_curnum_lock = true;
					}
					else curnum += "6";
					break;
				}
				case add7: {
					if (!is_curnum_lock || curnum == "0") {
						curnum = "7";
						is_curnum_lock = true;
					}
					else curnum += "7";
					break;
				}
				case add8: {
					if (!is_curnum_lock || curnum == "0") {
						curnum = "8";
						is_curnum_lock = true;
					}
					else curnum += "8";
					break;
				}
				case add9: {
					if (!is_curnum_lock || curnum == "0") {
						curnum = "9";
						is_curnum_lock = true;
					}
					else curnum += "9";
					break;
				}
				case addcomma: {
					if (!is_curnum_lock) {
						curnum = "0.";
						is_curnum_lock = true;
					}
					else if (!curnum.Contains("."))
						curnum += ".";
					break;
				}
				/*case bckspc:
					{
						if ()break;
					}*/
			}
			return 0;
		}

		string curnum;
		bool is_curnum_lock;

		public Calcing() => curnum = "0";
	}
}
