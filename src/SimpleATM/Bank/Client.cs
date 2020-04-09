using System;

namespace BankLib
{
    public class Client
    {
        public event Action<string> Notify;

        private decimal _currBalance;
        public string Name { get; set; }
        public int Id { get; set; }
        public void Put(decimal money)
        {
            _currBalance += money;
            Notify?.Invoke($"You put {money}$, your current balance: {_currBalance}$");
        }
        public void Take(decimal money)
        {
            _currBalance -= money;
            Notify?.Invoke($"You take { money}$, your current balance: { _currBalance}$");
        }
        public void Balance()
        {
            Console.WriteLine($"Your current balance: {_currBalance}.");
        }
        public Client() { }
        public Client(string name, decimal balance)
        {
            Name = name;
            _currBalance += balance;
        }
    }
}
