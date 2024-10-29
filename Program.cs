class Program
{
    static void Main(string[] args)
    {
        Transaction transaction = new Transaction("Rafael", "Thamires", 10000);

        //converter a transacao para uma string (em uma aplicacao real, isso seria feito de forma mais sofisticada)
        string transactionData = $"{transaction.Sender} -> {transaction.Recipient} : {transaction.Amount}";

        int nonce = ProofOfWork.FindNonce(transactionData, "00");

        Console.WriteLine($"Nonce encontrado: {nonce}");
    }
}
