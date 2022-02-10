using System;

namespace AdvancedMathLibrary {

    public static class Math {

    public static int Add(int a, int b) {
            return a + b;
        }
    public static int Subtract(int a, int b) {
            return a - b;
        }
    public static int Multiply(int a, int b) {
            return a * b;
        }
    public static int Divide(int a , int b) {
            return a / b;
        }
        public static int AbsoluteValue(int x) {
            return (x < 0) ? -x : x;
        }

       

    }
}
