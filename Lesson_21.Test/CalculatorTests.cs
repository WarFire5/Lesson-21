using Lesson_21;
using System;

namespace Lesson_21.Test
{
    public class CalculatorTests
    {
        //1) ����� �������� �� ���� 3 ����� (A, B � �). ������� ������� (�������� X) ��������� ��������� ������������ ����, ��� A*X+B=C.    
        [TestCase(1, 2, 3, 1)]
        [TestCase(-1, -2, -3, 1)]
        [TestCase(1, -2, -3, -1)]
        [TestCase(1, 2, -3, -5)]
        [TestCase(-1, 2, -3, 5)]
        [TestCase(-1, 2, 3, -1)]
        [TestCase(-1, -2, 3, -5)]
        public void FindAndWriteXTest(double a, double b, double c, double expected)
        {
            double actual = Calculator.FindAndWriteX(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        //���������� ������������ ��������� 1
        [Test]
        public void Find_X_When_A_Is_Zero() 
        {
            double a = 0; 
            double b = 1; 
            double c = 2;
            Assert.Throws<ArgumentException>(() => Calculator.FindAndWriteX(a, b, c));
        }


        //2) ����� �������� �� ���� 2 ����� (A � B). ���� A ������ B, ���������� A+B, ���� A ����� B, ���������� A*B, ���� A ������ B, ���������� A-B.  
        [TestCase(1, 2, -1)]
        [TestCase(-1, -2, -3)]
        [TestCase(1, -2, -1)]
        [TestCase(-1, 2, -3)]
        [TestCase(-1, -1, 1)]
        public void CompareTest(double n1, double n2, double expected)
        {
            double actual = Calculator.Compare(n1, n2);

            Assert.AreEqual(expected, actual);
        }


        //4) ����� �������� �� ���� �����. ��������� �������� �� ��� � ���� �� ����������: �� 0 �� 10, �� 20 �� 30 ��� �� 40 �� 50. *����� ������� ��������� ����� ������� true ��� false.
        [TestCase(-1, false)]
        [TestCase(0, true)]
        [TestCase(11, false)]
        [TestCase(21, true)]
        [TestCase(31, false)]
        [TestCase(41, true)]
        [TestCase(51, false)]
        public void CheckNumberTest(double d, bool expected)
        {
            bool actual = Calculator.CheckNumber(d);

            Assert.AreEqual(expected, actual);
        }


        //5) ����� �������� �� ���� 2 ����� (A � B). ������� ����� ���� ����� �� ��������� �� A �� B, ������� ������� �� 7.
        [TestCase(-7, 0, -7)]
        [TestCase(-7, 7, 0)]
        [TestCase(-7, 14, 14)]
        public void CheckAndAddNumbersXTest(int number1, int number2, int expected)
        {
            int actual = Calculator.CheckAndAddNumbers(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //���������� ������������ ��������� 5
        [Test]
        public void Find_Sum_If_A_Equals_B()
        {
            int number1 = 0; 
            int number2 = 0;
            Assert.Throws<ArgumentException>(() => Calculator.CheckAndAddNumbers(number1, number2));
        }
        [Test]
        public void Find_Sum_If_A_More_Than_B()
        {
            int number1 = 1;
            int number2 = 0;
            Assert.Throws<ArgumentException>(() => Calculator.CheckAndAddNumbers(number1, number2));
        }
        [Test]
        public void Find_Sum_If_A_Less_B_Less_Than_7()
        {
            int number1 = 0;
            int number2 = 1;
            Assert.Throws<ArgumentException>(() => Calculator.CheckAndAddNumbers(number1, number2));
        }


        //6) ����� �������� �� ���� ������������� ����� (N). ������� N-�� ����� ���� ���������.
        [TestCase(0, 0)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        [TestCase(7, 13)]
        [TestCase(8, 21)]
        [TestCase(9, 34)]
        [TestCase(10, 55)]
        public void FindFibonachiValueTest(int Np, int expected)
        {
            int actual = Calculator.FindFibonachiValue(Np);

            Assert.AreEqual(expected, actual);
        }

        //���������� ������������ ��������� 6
        [Test]
        public void Find_Fibonachi_Value_If_Number_Less_Than_Zero()
        {
            int Np = -1;
            Assert.Throws<ArgumentException>(() => Calculator.FindFibonachiValue(Np));
        }


        //7) ����� �������� �� ���� �����. ����� ���������� �������� ���� ����� �����.
        [TestCase(1, 1)]
        [TestCase(-1, 1)]
        [TestCase(0, 0)]
        [TestCase(2, 0)]
        [TestCase(12, 1)]
        [TestCase(-12, 1)]
        [TestCase(123, 2)]
        public void FindOddTest(int valueNumber, int expected)
        {
            int actual = Calculator.FindOdd(valueNumber);

            Assert.AreEqual(expected, actual);
        }


        //8) ����� �������� �� ���� �����. ����� �����, ������� �������� ����������.
        [TestCase(12, 21)]
        [TestCase(123, 321)]
        [TestCase(13, 31)]
        public void ReverseNumericTest(int SE, int expected)
        {
            int actual = Calculator.ReverseNumeric(SE);

            Assert.AreEqual(expected, actual);
        }

        //���������� ������������ ��������� 8
        [Test]
        public void Find_Reflection_If_Number_Less_Than_Zero()
        {
            int SE = -1;
            Assert.Throws<ArgumentException>(() => Calculator.ReverseNumeric(SE));
        }        
        [Test]
        public void Find_Reflection_If_Number_Equals_Zero()
        {
            int SE = 0;
            Assert.Throws<ArgumentException>(() => Calculator.ReverseNumeric(SE));
        }        
        [Test]
        public void Find_Reflection_If_Number_More_Than_Zero_And_Less_Than_Ten()
        {
            int SE = 9;
            Assert.Throws<ArgumentException>(() => Calculator.ReverseNumeric(SE));
        }
        [Test]
        public void Find_Reflection_If_Number_Is_Round()
        {
            int SE = 10;
            Assert.Throws<ArgumentException>(() => Calculator.ReverseNumeric(SE));
        }


        //9) ����� �������� �� ���� 2 �����. ��������, ���� �� � ��������� ���� ����� ���������� �����. ��������, ��� ���� 123 � 345, ������� ����� �������� true, �, ��� ���� 500 � 999 - false.
        [TestCase(1, 2, false)]
        [TestCase(-1, -2, false)]
        [TestCase(1, -2, false)]
        [TestCase(1, 1, true)]
        [TestCase(-2, -2, true)]
        [TestCase(12, 31, true)]
        [TestCase(-23, 35, true)]
        public void CompareNumbersTest(int firstNumber, int secondNumber, bool expected)
        {
            bool actual = Calculator.CompareNumbers(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }
    }
}