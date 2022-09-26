using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter {
    // 90 = XC
    // 80 = LIII
    // 70 = LII
    // 60 = LI
    // 50 = L
    // 40 = XL
    // 30 = XXX
    // 20 = XX
    // 10 = X

    // simplifed - each combination is reachable with subraction and these 4:
    // 90 = XC
    // 50 = L
    // 40 = XL
    // 10 = X


    /// <summary>
    /// RomanTenExpression
    /// </summary>
    public class RomanTenExpression : RomanExpression {
        public override void Interpret(RomanContext value) {
            //while ((value.Input -90) >= 0) {
            //    value.Output += "XC";
            //    value.Input -= 90;
            //}
            //while ((value.Input - 80) >= 0) {
            //    value.Output += "LIII";
            //    value.Input -= 80;
            //}
            //while ((value.Input - 70) >= 0) {
            //    value.Output += "LII";
            //    value.Input -= 70;
            //}
            //while ((value.Input - 60) >= 0) {
            //    value.Output += "LI";
            //    value.Input -= 60;
            //}
            //while ((value.Input -50) >= 0) {
            //    value.Output += "L";
            //    value.Input -= 50;
            //}
            //while((value.Input - 40) >= 0) {
            //    value.Output += "XL";
            //    value.Input -= 40;
            //}
            //while ((value.Input - 30) >= 0) {
            //    value.Output += "XXX";
            //    value.Input -= 30;
            //}
            //while ((value.Input - 20) >= 0) {
            //    value.Output += "XX";
            //    value.Input -= 20;
            //}
            //while ((value.Input - 10) >=0) {
            //    value.Output += "X";
            //    value.Input -= 10;
            //} 

            while ((value.Input - 90) >= 0) {
                value.Output += "DOKSAN";
                value.Input -= 90;
            }
            while ((value.Input - 80) >= 0) {
                value.Output += "SEKSEN";
                value.Input -= 80;
            }
            while ((value.Input - 70) >= 0) {
                value.Output += "YETMİŞ";
                value.Input -= 70;
            }
            while ((value.Input - 60) >= 0) {
                value.Output += "ALTMIŞ";
                value.Input -= 60;
            }
            while ((value.Input - 50) >= 0) {
                value.Output += "ELLİ";
                value.Input -= 50;
            }
            while ((value.Input - 40) >= 0) {
                value.Output += "KIRK";
                value.Input -= 40;
            }
            while ((value.Input - 30) >= 0) {
                value.Output += "OTUZ";
                value.Input -= 30;
            }
            while ((value.Input - 20) >= 0) {
                value.Output += "YİRMİ";
                value.Input -= 20;
            }
            while ((value.Input - 10) >= 0) {
                value.Output += "ON";
                value.Input -= 10;
            }
        }
    }
}
