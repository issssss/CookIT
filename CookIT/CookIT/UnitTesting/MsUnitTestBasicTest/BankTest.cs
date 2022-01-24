using System;
using Bank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsUnitTestBasicTest
{
    [TestClass]
    public class AccountTest
    {
        Account source;
        Account destination;

        [TestInitialize()]
        public void Init()
        {
            source = new Account();
            source.Deposit(200m);

            destination = new Account();
            destination.Deposit(150m);
        }

        [TestMethod()]
        public void MsUnit_TransferFundsSuccessfuly()
        {
            source.TransferFunds(destination, 100m);

            Assert.AreEqual(250m, destination.Balance);
            Assert.AreEqual(100m, source.Balance);
        }

        [TestMethod()]
        [ExpectedException(typeof(InsufficientFundsException), "test")]
        public void MsUnit_TransferWithInsufficientFunds()
        {
            source.TransferFunds(destination, 300m);
        }

        [TestMethod()]
        [Ignore()]
        public void MsUnit_TransferWithInsufficientFundsAtomicity()
        {
            try
            {
                source.TransferFunds(destination, 300m);
            }
            catch (InsufficientFundsException expected)
            {
            }

            Assert.AreEqual(200m, source.Balance);
            Assert.AreEqual(150m, destination.Balance);
        }
    }
}
