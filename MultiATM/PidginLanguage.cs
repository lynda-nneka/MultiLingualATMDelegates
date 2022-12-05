using System;
namespace MultiATM
{
	public class PidginLanguage: ATMLanguage
	{
		public PidginLanguage()
		{
            welcomeMessage = "You don come Nneka bank. Bank of the richest!";
            selectOperationMessage = "Choose wetin you wan do \n1. Withdraw\n2. Check Balance\n3. Transfer";
            pinIncorrectMessage = "Your pin no correct. Enter better one.";
            enterATMPinMessage = "Enter ya pin";
            enterBankNameMessage = "Enter ya bank name";
            enterAccountNumberMessage = "Enter Account Number wey be your own";
            withdrawAmountMessage = "How much you wan commot?";
            accountBalanceMessage = "Your money wey remain na: ";
            insufficientFundsMessage = "Your money no reach o!";
            successfulTransferMessage = "Your money don deliver to: ";
            amountLeftMessage = "The amount wey remain for your account na: ";
            withdrawSuccessfulMessage = "Your money don commot. Abeg collect am!";
            anotherOperationMessage = "You wan do another one? Y/N";
            takeYourCardMessage = "Abeg collect your card. Make you flex your day o!";
        }
    }
}

