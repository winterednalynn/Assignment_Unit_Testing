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
    public class CheckingTests
    {
        [TestMethod()]
        public void CheckingTest()
        {
            
        }

        [TestMethod()]
        public void DepositTest()
        {


            //this test pass ✅  adding money. 
            Checking checkdeposit = new Checking(1000); // initial balance is 1000 
            double depositamount = 1000; // adding 1000 to her balance. 
            double expectedbalance = 2000; // expecting to have a total of 2000 

            checkdeposit.Deposit(depositamount);

            Assert.AreEqual(expectedbalance, checkdeposit._balance);


            //This did not run b/c of the depost of negative dollar amount. ❌
            //Checking check = new Checking(500);
            //double theAmount = -5;
            //double theBalance = 0; 
            //double therealBalance = 500 //Since the dollar amount of -5 is not accepted , the balance will stand stil as of 500. 

            //check.Deposit(theAmount);

            //Assert.AreEqual(theBalance, check._balance); 

        }

        [TestMethod()]
        public void WithdrawTest()
        {
            //This test passed ✅ Taking out money 
            Checking checkWithDraw = new Checking(1000);
            double withdrawAmount = 200;
            double postWithdraw = 800; 

            checkWithDraw.Withdraw(withdrawAmount);

            Assert.AreEqual(postWithdraw, checkWithDraw._balance);


            //Withdrawing over the balance limit. ❌
            //Checking checkWithDraw = new Checking(500);
            //double theAmount = 600; 

            //checkWithDraw.Withdraw(theAmount);

            //Assert.AreEqual(485, checkWithDraw._balance); //maybe im bad at math, but i didnt' think it would be 485 in a positve integer. I thought it would result to -115. 





        }
    }
}