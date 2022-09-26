using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter {

    // 9 = IX
    // 8 = VIII
    // 7 = VII
    // 6 = VI
    // 5 = V
    // 4 = IV
    // 3 = III
    // 2 = II
    // 1 = I

    // simplifed - each combination is reachable with subraction and these 4:
    // 9 = IX
    // 5 = V
    // 4 = IV
    // 1 = I


    /// <summary>
    /// TerminalExpression
    /// </summary>
    public class RomanOneExpression : RomanExpression {
        //public override void Interpret(RomanContext value) {
        //    while((value.Input -9) >=0) {
        //        value.Output += "IX";
        //        value.Input -= 9;
        //    }
        //    while ((value.Input - 8) >= 0) {
        //        value.Output += "VIII";
        //        value.Input -= 8;
        //    }
        //    while ((value.Input - 7) >= 0) {
        //        value.Output += "VII";
        //        value.Input -= 7;
        //    }
        //    while ((value.Input - 6) >= 0) {
        //        value.Output += "VI";
        //        value.Input -= 6;
        //    }
        //    while ((value.Input - 5) >= 0) {
        //        value.Output += "V";
        //        value.Input -= 5;
        //    }
        //    while ((value.Input - 4) >= 0) {
        //        value.Output += "IV";
        //        value.Input -= 4;
        //    }
        //    while ((value.Input - 3) >= 0) {
        //        value.Output += "III";
        //        value.Input -= 3;
        //    }
        //    while ((value.Input - 2) >= 0) {
        //        value.Output += "II";
        //        value.Input -= 2;
        //    }
        //    while ((value.Input - 1) >= 0) {
        //        value.Output += "I";
        //        value.Input -= 1;   
        //    }
        //}
        public override void Interpret(RomanContext value) {
            while ((value.Input - 9) >= 0) {
                value.Output += "DOKUZ";
                value.Input -= 9;
            }
            while ((value.Input - 8) >= 0) {
                value.Output += "SEKİZ";
                value.Input -= 8;
            }
            while ((value.Input - 7) >= 0) {
                value.Output += "YEDİ";
                value.Input -= 7;
            }
            while ((value.Input - 6) >= 0) {
                value.Output += "ALTI";
                value.Input -= 6;
            }
            while ((value.Input - 5) >= 0) {
                value.Output += "BEŞ";
                value.Input -= 5;
            }
            while ((value.Input - 4) >= 0) {
                value.Output += "DÖRT";
                value.Input -= 4;
            }
            while ((value.Input - 3) >= 0) {
                value.Output += "ÜÇ";
                value.Input -= 3;
            }
            while ((value.Input - 2) >= 0) {
                value.Output += "İKİ";
                value.Input -= 2;
            }
            while ((value.Input - 1) >= 0) {
                value.Output += "BİR";
                value.Input -= 1;
            }
        }
    }
}
