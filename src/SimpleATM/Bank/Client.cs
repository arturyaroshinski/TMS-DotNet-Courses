using System;

namespace BankLib
{
    /// <summary>
    /// Клиент.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Уведомление.
        /// </summary>
        public event Action<string> Notify;
        /// <summary>
        /// Текущий баланс.
        /// </summary>
        private decimal _currBalance;
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Пополнить счет.
        /// </summary>
        /// <param name="money">Сумма.</param>
        public void Put(decimal money)
        {
            _currBalance += money;
            Notify?.Invoke($"You put {money}$, your current balance: {_currBalance}$");
        }
        /// <summary>
        /// Снять со счета.
        /// </summary>
        /// <param name="money">Сумма.</param>
        public void Take(decimal money)
        {
            _currBalance -= money;
            Notify?.Invoke($"You take { money}$, your current balance: { _currBalance}$");
        }
        /// <summary>
        /// Проверить баланс.
        /// </summary>
        public void Balance()
        {
            Console.WriteLine($"Your current balance: {_currBalance}$.");
        }
        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public Client() { }
        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="balance">Баланс.</param>
        public Client(string name, decimal balance)
        {
            Name = name;
            _currBalance += balance;
        }
    }
}
