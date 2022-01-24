using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using Bank;

namespace xUnitBasicTest
{
	public class AccountTest
	{
		[Fact]
		public void xUnit_TransferFundsSuccessfuly()
		{
			var source = new Account();
			source.Deposit(200m);

			var destination = new Account();
			destination.Deposit(150m);

			source.TransferFunds(destination, 100m);

			Assert.Equal(250m, destination.Balance);
			Assert.Equal(100m, source.Balance);
		}

		[Fact]
		public void xUnit_TransferWithInsufficientFunds()
		{
			var source = new Account();
			source.Deposit(200m);

			var destination = new Account();
			destination.Deposit(150m);

            // Što se desi ukoliko očekujemo krivi exception (pravi tip bačenog exceptiona je InsufficientFundsException)
			Assert.Throws<InsufficientFundsException>(
				delegate
					{
						source.TransferFunds(destination, 300m);
					});
		}

		[Fact(Skip = "Decide how to implement transaction management.")]
		public void xUnit_TransferWithInsufficientFundsAtomicity()
		{
			var source = new Account();
			source.Deposit(200m);

			var destination = new Account();
			destination.Deposit(150m);

			try
			{
				source.TransferFunds(destination, 300m);
			}
			catch (InsufficientFundsException expected)
			{
			}

			Assert.Equal(200m, source.Balance);
			Assert.Equal(150m, destination.Balance);
		}
	}
}
