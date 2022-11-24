using Balance3.Core;
using Balance3.DataAccess;

namespace Balance3.Tests
{
    public class TransactionRepositoryStub : ITransactionRepository
    {
        public Transaction TransactionInsertedIntoDatabase { get; private set; }
        public int AmountInserted { get; private set; }
        public void Insert(Transaction transaction)
        {
            TransactionInsertedIntoDatabase = transaction;
            AmountInserted++;
        }
    }

    public class TransactionTests
    {
        [Fact]
        public void Can_create_transaction_with_amount_bigger_than_0()
        {
            Transaction transaction = new Transaction("Bart", 10);

            Assert.NotNull(transaction);
        }

        [Fact]
        public void Can_insert_transaction_into_database()
        {
            var dummy = new TransactionRepositoryStub();
            //TransactionCollection collection = new TransactionCollection(new TransactionRepository());
            TransactionCollection collection = new TransactionCollection(dummy);

            collection.Add(new Transaction("Casper", 5));

            Assert.NotNull(dummy.TransactionInsertedIntoDatabase);
            Assert.Equal(1, dummy.AmountInserted);
        }
    }
}