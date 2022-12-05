using System;
namespace MultiATM
{
	public class ATM
	{
		public int userCash = 10000;
		public string userPin = "1234";
		public OperationType operationType;
		public ATMLanguage ATMLanguage;
		public WithdrawManager withdrawManager = new WithdrawManager();
		public TransferManager transferManager = new TransferManager();

		public ATM(ATMLanguage atmLanguage)
		{
			this.ATMLanguage = atmLanguage;
			withdrawManager.withdrawalComplete += OnWithdrawalComplete;
			withdrawManager.withdrawalFailure += OnWithdrawalFailure;

			transferManager.transferComplete += OnTransferComplete;
			transferManager.transferFailure += OnTransferFailure;
		}

		public void OnTransferComplete(int remainingAmount, string accountNumber)
		{
            userCash = remainingAmount;
            Console.WriteLine(ATMLanguage.successfulTransferMessage + accountNumber);
            Console.WriteLine(ATMLanguage.accountBalanceMessage + userCash);
        }

		public void OnTransferFailure()
		{
            Console.WriteLine(ATMLanguage.insufficientFundsMessage);
			Restart();
        }

		public void OnWithdrawalComplete(int amountLeft)
		{
			userCash = amountLeft;
            Console.WriteLine(ATMLanguage.withdrawSuccessfulMessage);
            Console.WriteLine(ATMLanguage.amountLeftMessage + userCash);
            Restart();
		}

        public void OnWithdrawalFailure()
        {
            Console.WriteLine(ATMLanguage.insufficientFundsMessage);
            Restart();
        }

        public virtual void Start()
		{
			Console.WriteLine(ATMLanguage.welcomeMessage);

			var isPinCorrect = PinCheck();

			if (isPinCorrect)
			{
				Console.WriteLine(ATMLanguage.selectOperationMessage);

                var operationInput = Console.ReadLine();
                var numberSelected = Int32.Parse(operationInput);

                operationType = (OperationType)numberSelected;

                Console.WriteLine(operationType);


                switch (operationType)
                {
                    case OperationType.Withdraw:
                        Withdraw();
                        break;
                    case OperationType.CheckBalance:
                        CheckBalance();
                        break;
                    case OperationType.Transfer:
                        Transfer();
                        break;
                }
            } else
			{
				Console.WriteLine(ATMLanguage.pinIncorrectMessage);
				Restart();
			}
			
		}

		// Main Logic

		private bool PinCheck()
		{
			Console.WriteLine(ATMLanguage.enterATMPinMessage);
			var atmInput = Console.ReadLine();

			if (atmInput == userPin)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void CheckBalance()
		{
			CheckBalanceOperation();
		}

		private void Transfer()
		{
			Console.WriteLine(ATMLanguage.enterBankNameMessage);
			var bankName = Console.ReadLine();

			Console.WriteLine(ATMLanguage.enterAccountNumberMessage);
			var accountNumber = Console.ReadLine();

            Console.WriteLine(ATMLanguage.enterAmountMessage);
            var amountInput = Console.ReadLine();
			var amount = Int32.Parse(amountInput);

			transferManager.TransferOperation(amount, userCash, accountNumber);
        }

        private void Withdraw()
		{
			Console.WriteLine(ATMLanguage.withdrawAmountMessage);
			var withdrawInput = Console.ReadLine();
			var withdrawAmount = Int32.Parse(withdrawInput);

			withdrawManager.WithdrawOperation(withdrawAmount, userCash);
		}

		// Operation Logic

		private void CheckBalanceOperation()
		{
            Console.WriteLine(ATMLanguage.accountBalanceMessage + userCash);

            Restart();
        }

		private void Restart()
		{
			Console.WriteLine(ATMLanguage.anotherOperationMessage);
			var input = Console.ReadLine();

			if (input.ToUpper() == "Y")
			{
				Start();
			}
			else
			{
				Console.WriteLine(ATMLanguage.takeYourCardMessage);
			}
		}
	}

	public enum OperationType
	{
		Withdraw = 1, CheckBalance = 2, Transfer = 3 
	}
}

