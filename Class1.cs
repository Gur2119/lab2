using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;


namespace CalcAppTest

{

    [TestFixture]
    class CalcTests
    {

        [Test]
        public void GetAddition_Input6point7and3point2_Returns9point9()       //1(add)
        {
            //Arrange
            double number1 = 6.7;
            double number2 = 3.2;
            double expectedresult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            double actualresult = testCalc.GetAddition();
            Assert.AreEqual(expectedresult, actualresult);

        }
        [Test]
        public void GetAddition_Input10and28_Returns38()        //2(add)
        {
            //Arrange
            int number1 = 10;
            int number2 = 28;
            int expectedresult = number1 + number2;
            Calc checkCalc = new Calc(number1, number2);
            double actualresult = checkCalc.GetAddition();
            Assert.AreEqual(expectedresult, actualresult);
        }
        [Test]
        public void GetAddition_Input2456and4567_Returns7023()  //3(add)
        {
            //Arrange
            double number1 = 2456;
            double number2 = 4567;
            double expectedresult = number1 + number2;
            Calc addCalc = new Calc(number1, number2);
            double actualresult = addCalc.GetAddition();
            Assert.AreEqual(expectedresult, actualresult);
        }
        [Test]
        public void GetSubtraction_Input21point7and9point2_Returns12point5()   //1(sub)
        {
            //Arrange
            double number1 = 21.7;
            double number2 = 9.2;
            double expectedresult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            double actualresult = testCalc.GetSubtraction();
            Assert.AreEqual(expectedresult, actualresult);
        }
        [Test]
        public void GetSubtraction_Input9and7_Returns2()  //2(sub)
        {
            //Arrange
            int number1 = 9;
            int number2 = 7;
            int expectedresult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            double actualresult = testCalc.GetSubtraction();
            Assert.AreEqual(expectedresult, actualresult);
        }
        [Test]
        public void GetSubtraction_Input678and456_Returns222()   //3(sub)
        {
            //Arrange
            double number1 = 678;
            double number2 = 456;
            double expectedresult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            double actualresult = testCalc.GetSubtraction();
            Assert.AreEqual(expectedresult, actualresult);
        }
        [Test]
        public void GetMultiplication_Input4point2and5point3_Returns22point26()  //1(multi)
        {
            //Arrange
            double number1 = 4.2;
            double number2 = 5.3;
            double expectedresult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            double actualresult = testCalc.GetMultiplication();
            Assert.AreEqual(expectedresult, actualresult);
        }
        [Test]
        public void GetMultiplication_Input25and25_Returns625()  //2(multi)
        {
            //Arrange
            int number1 = 25;
            int number2 = 25;
            double expectedresult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            double actualresult = testCalc.GetMultiplication();
            Assert.AreEqual(expectedresult, actualresult);
        }
        [Test]
        public void GetMultiplication_Input120and50_Returns6000()  //3(multi)
        {
            //Arrange
            double number1 = 120;
            double number2 = 50;
            double expectedresult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            double actualresult = testCalc.GetMultiplication();
            Assert.AreEqual(expectedresult, actualresult);
        }
        [Test]
        public void GetDivision_Input22point5and2point5_Returns9()  //1(div)
        {
            //Arrange
            double number1 = 22.5;
            double number2 = 2.5;
            double expectedresult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            double actualresult = testCalc.GetDivision();
            Assert.AreEqual(expectedresult, actualresult);
        }
        [Test]
        public void GetDivision_Input70and10_Returns7()  //2(div)
        {
            //Arrange
            int number1 = 70;
            int number2 = 10;
            double expectedresult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            double actualresult = testCalc.GetDivision();
            Assert.AreEqual(expectedresult, actualresult);
        }
        [Test]
        public void GetDivision_Input4500and90_Returns50()  //3(div)
        {
            //Arrange
            double number1 = 4500;
            double number2 = 90;
            double expectedresult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            double actualresult = testCalc.GetDivision();
            Assert.AreEqual(expectedresult, actualresult);



        }

    }
}
