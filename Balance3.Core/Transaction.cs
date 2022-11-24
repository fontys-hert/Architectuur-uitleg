namespace Balance3.Core
{
    public class Transaction
    {
        public string Name { get; private set; }
        public int Amount { get; private set; }

        public Transaction(string name, int amount)
        {

            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidOperationException("Hey hey, dat mag niet joh!");
            }

            if (amount == 0)
            {
                throw new InvalidOperationException("Hey hey, bedrag mag niet 0 zijn!");
            }

            Name = name;
            Amount = amount;
        }

    }
}