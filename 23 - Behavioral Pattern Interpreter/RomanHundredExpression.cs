using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter {
    // 900 = CM
    // 800 = DCCC
    // 700 = DCC
    // 600 = DC
    // 500 = D
    // 400 = CD
    // 300 = CCC
    // 200 = CC
    // 100 = C

    // simplifed - each combination is reachable with subraction and these 4:
    // 900 = CM
    // 500 = D
    // 400 = CD
    // 100 = C


    /// <summary>
    /// RomanHundredExpression
    /// </summary>
    public class RomanHundredExpression : RomanExpression {
        //public override void Interpret(RomanContext value) {
        //    while ((value.Input - 900) >=0) {
        //        value.Output += "CM";
        //        value.Input -= 900;
        //    }
        //    while ((value.Input - 800) >= 0) {
        //        value.Output += "DCCC";
        //        value.Input -= 800;
        //    }
        //    while ((value.Input - 700) >= 0) {
        //        value.Output += "DCC";
        //        value.Input -= 700;
        //    }
        //    while ((value.Input - 600) >= 0) {
        //        value.Output += "DC";
        //        value.Input -= 600;
        //    }

        //    while ((value.Input - 500) >= 0) {
        //        value.Output += "D";
        //        value.Input -= 500;
        //    }

        //    while ((value.Input - 400) >= 0) {
        //        value.Output += "CD";
        //        value.Input -= 400;
        //    }
        //    while ((value.Input - 300) >= 0) {
        //        value.Output += "CCC";
        //        value.Input -= 300;
        //    }
        //    while ((value.Input - 200) >= 0) {
        //        value.Output += "CC";
        //        value.Input -= 200;
        //    }
        //    while ((value.Input - 100) >= 0) {
        //        value.Output += "C";
        //        value.Input -= 100;
        //    }
        //}
        public override void Interpret(RomanContext value) {
            while ((value.Input - 900) >= 0) {
                value.Output += "DOKUZYÜZ";
                value.Input -= 900;
            }
            while ((value.Input - 800) >= 0) {
                value.Output += "SEKİZYÜZ";
                value.Input -= 800;
            }
            while ((value.Input - 700) >= 0) {
                value.Output += "YEDİYÜZ";
                value.Input -= 700;
            }
            while ((value.Input - 600) >= 0) {
                value.Output += "ALTIYÜZ";
                value.Input -= 600;
            }

            while ((value.Input - 500) >= 0) {
                value.Output += "BEŞYÜZ";
                value.Input -= 500;
            }

            while ((value.Input - 400) >= 0) {
                value.Output += "DÖRTYÜZ";
                value.Input -= 400;
            }
            while ((value.Input - 300) >= 0) {
                value.Output += "ÜÇYÜZ";
                value.Input -= 300;
            }
            while ((value.Input - 200) >= 0) {
                value.Output += "İKİYÜZ";
                value.Input -= 200;
            }
            while ((value.Input - 100) >= 0) {
                value.Output += "YÜZ";
                value.Input -= 100;
            }
        }
    }
}
