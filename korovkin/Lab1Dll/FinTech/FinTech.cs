using System;
using System.Collections.Generic;

namespace FinTech
{
    public class Client
    {
       private  string name="Untitled";
        public string Name
        {
            get { return name; }
            set
            {
                if (value != string.Empty)
                {
                    name = value;
                }
            }
        }
       private  decimal creditAmount;
        public decimal CreditAmount
        {
            get { return creditAmount; }
            set
            {
                if (value >= 0)
                {
                    creditAmount = value;
                }
            }
        }
        private double creditDuration;
        public double CreditDuration
        {
            get { return creditDuration; }
            set
            {
                if (value >= 0)
                {
                    creditDuration = value;
                }
            }
        }
      private  decimal monthPayment;
        public decimal MonthPayment
        {
            get { return monthPayment; }
            set
            {
                if (value > 0)
                {
                    monthPayment = value;
                }
            }
        }
        private List<decimal> accountList = new List<decimal>();
        public Client(string name, decimal creditAmount, double creditDuration, decimal monthPayment, List<decimal> accountList)
        {
            this.name = name;
            this.creditAmount = creditAmount;
            this.creditDuration = creditDuration;
            this.monthPayment = monthPayment;
            this.accountList = accountList;
        }
        public string AccountListToString()
        {
            string output="";
            for (int i=0;  i<accountList.Count; i++)
            {
                output += "Счёт №" + ((i+1).ToString()) + ": " + accountList[i]+Environment.NewLine;
            }
            return output;
        }
        public List<decimal> GetAccountList()
        {
            return accountList;
        }
        public void ReplenishAccount(int accountNum, decimal payAmount)
        {
            if ((accountNum<=accountList.Count)&&(accountNum>0) && (payAmount > 0))
            {
                accountList[accountNum - 1] += payAmount;
            }
        }
        public void DeductAccount(int accountNum, decimal payAmount)
        {
            if ((accountNum <= accountList.Count) && (accountNum > 0)&&(payAmount>0))
            {

                accountList[accountNum - 1]  -=  payAmount;
               
            }
           
            }
        public void DeduceMonthCreditPayment()
        {
            decimal currentPayment=monthPayment;
            for (int i = 0; i < accountList.Count; i++)
            {
                if (accountList[i] > 0)
                {
                     accountList[i]-= currentPayment;
                    if (accountList[i] < 0)
                    {
                        currentPayment = accountList[i] * -1;
                        accountList[i] = 0;
                    }
                    else { return; }
                }
                if ((i + 1) == accountList.Count&&currentPayment>0)
                {
                    accountList[i] -= currentPayment;
                }
            }
        }
      public string GetClientDataText()
        {
            string s="";
            s += "ФИО клиента: " + name.ToString() + Environment.NewLine;
            s += "Сумма кредита: " + creditAmount.ToString()+ Environment.NewLine;
            s += "Продолжительность кредита: " + creditDuration.ToString() + Environment.NewLine;
            s += "Месячный платёж: " + monthPayment.ToString() + Environment.NewLine;
            s += AccountListToString();
            return s;
        }
    }
}
