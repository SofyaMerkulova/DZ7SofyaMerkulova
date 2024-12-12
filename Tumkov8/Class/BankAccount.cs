using System;


namespace Tumkov8.Class
{
    internal class BankAccount
    {
        private string accountNumber;
        private decimal balance;
        private AccountType accountType;
        public enum AccountType
        {
            Текущий,
            Сберегательный
        }
        public BankAccount(string accountNumber, decimal balance, AccountType accountType)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.accountType = accountType;
        }
        public string GetAccountNumber()
        {
            return accountNumber;
        }
        public decimal GetBalance()
        {
            return balance;

        }
        public AccountType GetAccountType()
        {
            return accountType;
        }
        public void InfoAccount()
        {
            Console.WriteLine($"Ваш номер счёта: {accountNumber}");
            Console.WriteLine($"Баланс счёта до пополнения, снятия и перевода: {balance}");
            Console.WriteLine($"Тип вашего счёта: {accountType}");
        }
        public void AccountReplenishment(decimal i)
        {
            balance += i;
            Console.WriteLine($"Баланс после пополнения: {balance}");
        }
        public void WithdrawalFromTheAccount(decimal i)
        {
            if (i > balance)
            {
                Console.WriteLine("Недостаточно средств,выберете сумму меньше");
                return;
            }

            balance -= i;
            Console.WriteLine($"Баланс после снятия: {balance}");
        }
        public void TransferFromOneAccountToAnother(BankAccount savingsAccount, decimal sum)
        {
            if (sum > balance)
            {
                Console.WriteLine("Недостаточно средств,выберете сумму меньше");
                return;
            }
            balance -= sum;
            savingsAccount.balance += sum;
            Console.WriteLine($"Баланс после перевода на сумму {sum} с текущего счёта составляет: {balance}\nБаланс счёта под номером {savingsAccount.accountNumber}, на который выполнен перевод: {savingsAccount.balance} ");

        }
    }
}
