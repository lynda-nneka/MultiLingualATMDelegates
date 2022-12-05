using System;
namespace MultiATM
{
	public class TransferManager
	{
		public delegate void OnTransferComplete(int remainingAmount, string accountNumber);
		public delegate void OnTransferFailure();

		public OnTransferComplete transferComplete;
		public OnTransferFailure transferFailure;

		public void TransferOperation(int transferAmount, int userCash, string accountNumber)
		{
			if (transferAmount > userCash)
			{
				transferFailure.Invoke();
			}
			else
			{
				int amountLeft = userCash - transferAmount;
				transferComplete.Invoke(amountLeft, accountNumber);
			}
		}
	}
}

