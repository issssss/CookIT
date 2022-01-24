using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bank;
using NUnit.Framework;

namespace NUnitBasicTest
{
	[TestFixture]
	public class AccountTest
	{
		Account source;
		Account destination;

		[SetUp]
		public void Init()
		{
			source = new Account();
			source.Deposit(200m);

			destination = new Account();
			destination.Deposit(150m);
		}

		[Test]
		public void NUnit_TransferFundsSuccessfuly()
		{
			source.TransferFunds(destination, 100m);

			Assert.AreEqual(250m, destination.Balance);
			Assert.AreEqual(100m, source.Balance);

            Assert.That(250m, Is.EqualTo(destination.Balance));
            Assert.That(100m, Is.EqualTo(source.Balance));
		}

        /* NEKAD (prije NUnit 3.0 verzije) je provjera pojavljivanja exceptiona izgledala ovako
		[Test]
		[ExpectedException(typeof(InsufficientFundsException))]
		public void TransferWithInsufficientFunds()
		{
			source.TransferFunds(destination, 300m); 
		}
        */
        [Test]
        public void NUnit_TransferWithInsufficientFunds()
        {
            Assert.Throws<InsufficientFundsException>(
                delegate
                {
                    source.TransferFunds(destination, 300m);
                });
        }

        [Test]
		[Ignore("Decide how to implement transaction management")]
		public void NUnit_TransferWithInsufficientFundsAtomicity()
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
