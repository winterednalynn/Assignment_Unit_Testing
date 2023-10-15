using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_Unit_Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Unit_Testing.Tests
{
    [TestClass()]
    public class SavingsTests
    {
        [TestMethod()]
        public void SavingsTest()
        {
            
        }

        [TestMethod()]
        public void DepositTest()
        {

            //this test pass ✅  adding money.
            //Arrange 
            Savings save = new Savings(600); // In her saving , she has 600 to start 
            double addAmount = 600; // Adding 600 to the saving on top of her already have 600 
            double saveAmount = 1205; // Interest is 5.00 , 600x2 = 1200 + 5 = 1205 

            //Act
            save.Deposit(addAmount);

            //Assert 
            Assert.AreEqual(saveAmount, save._balance);

            

            //TESTING w/ negative deposit 
            //Arrange
            Savings saver = new Savings(1000);
            double getAmount = -2000;
            double expectedBalance = 1000; // when depositing a negative integer , there is no difference from balance to expected because -1000 does not exist

            //Act
            saver.Deposit(getAmount);

            //Assert 
            Assert.AreEqual(expectedBalance, saver._balance); //Queued as 1000, 1000  


        }

        [TestMethod()]
        public void WithdrawTest()
        {
            //Withdrawing money the accurate way ; This passed: ✅ 
            Savings savingOut = new Savings(1000); //Saving balance of 1000 to start
            double outAmount = 600; // Opting to take out money out of saving : 600 
            double expectedBal = 400; // 1000 - 600 = 400 

            savingOut.Withdraw(outAmount); // Taking out 600 out of the 1000 

            Assert.AreEqual(expectedBal, savingOut._balance); // 400 , 400 actual 



            //Withdrawing money in a negative way 

            Savings negativeOut = new Savings(1000);
            double negativeAmount = -5;
            double expectedResult = 1000;

            negativeOut.Withdraw(negativeAmount); 

            Assert.AreEqual(expectedResult, negativeOut._balance);


        }
    }
}