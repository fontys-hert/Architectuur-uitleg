namespace Balance3.Core;

public interface ITransactionRepository
{
    void Insert(Transaction transaction);
}

public class TransactionCollection
{
    private List<Transaction> _transactions;

    private ITransactionRepository _repository;

    public TransactionCollection(ITransactionRepository repository)
    {
        _transactions = new List<Transaction>();
        _repository = repository;
    }

    public void Add(Transaction transaction)
    {
        _repository.Insert(transaction);
    }
}
