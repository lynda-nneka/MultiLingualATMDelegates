using System;
namespace MultiATM
{
	public class WithdrawManager
	{
		public delegate void OnWithdrawalComplete(int remainingAmount);
		public delegate void OnWithdrawalFailure();

        public OnWithdrawalComplete withdrawalComplete;
        public OnWithdrawalFailure withdrawalFailure;

        public void WithdrawOperation(int amount, int userCash)
		{
            if (amount > userCash)
            {
                withdrawalFailure.Invoke();
            }
            else
            {
                int amountLeft = userCash - amount;
                withdrawalComplete.Invoke(amountLeft);
            }

        }
    }
}

