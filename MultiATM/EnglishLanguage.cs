using System;
namespace MultiATM
{
	public class EnglishLanguage: ATMLanguage
	{
		public EnglishLanguage()
		{
			welcomeMessage = "Welcome to Nneka's bank! Bank of the Rich.";
			selectOperationMessage = "What do you want to do? 1. Withdraw 2. Check Balance 3. Transfer";
			pinIncorrectMessage = "Pin incorrect";
			enterATMPinMessage = "Enter your ATM Pin";
			enterBankNameMessage = "Enter Bank Name";
            enterAccountNumberMessage = "Enter Account Number";
            withdrawAmountMessage = "How much do you want to withdraw?";
            accountBalanceMessage = "Your account balance is: ";
            insufficientFundsMessage = "Insufficient funds!";
            successfulTransferMessage = "Transfer successful to: ";
            amountLeftMessage = "Amount left in your account: ";
            withdrawSuccessfulMessage = "Withdrawal successful. Please take your cash!";
            anotherOperationMessage = "Do you want to carry out another operation? Y/N";
            takeYourCardMessage = "Please take your card! Have a lovely day!";
            enterAmountMessage = "Enter the amount";
        }
    }
}

