using Balance3.Core;

namespace Balance3.DataAccess
{
    public class TransactionRepository : ITransactionRepository
    {
        public void Insert(Transaction transaction)
        {
            Console.WriteLine("hehe, opgeslagen!");
        }
    }
}