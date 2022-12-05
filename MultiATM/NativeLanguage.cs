using System;
namespace MultiATM
{
    public class NativeLanguage : ATMLanguage
    {
        public NativeLanguage()
        {
            welcomeMessage = "Barka da zuwa bankin Nneka! Bankin Masu Arziki.";
            selectOperationMessage = "Me kike so ka yi? 1. Janye 2. Duba Balance 3. Canja wurin";
            pinIncorrectMessage = "Pin ba daidai ba";
            enterATMPinMessage = "Shigar da ATM fil ɗin ku";
            enterBankNameMessage = "Shigar da Sunan Banki";
            enterAccountNumberMessage = "Shigar da Lambar Asusu";
            withdrawAmountMessage = "Nawa kuke son cirewa?";
            accountBalanceMessage = "Ma'auni na asusunku shine: ";
            insufficientFundsMessage = "Rashin isassun kuɗi!";
            successfulTransferMessage = "Canja wurin yayi nasara zuwa: ";
            amountLeftMessage = "Adadin da ya rage a cikin asusun ku: ";
            withdrawSuccessfulMessage = "Janye nasara. Da fatan za a ɗauki kuɗin ku!";
            anotherOperationMessage = "Kuna so ku sake yin wani aiki? Y/N";
            takeYourCardMessage = "Da fatan za a ɗauki katin ku! Yi rana mai kyau!";
        }
    }
}

