using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternLearnings
{
    public class FactoryPattern_Transaction
    {
        public interface ITransaction
        {
            string GetTransaction();
        }

        public class Purchase : ITransaction
        {
            public string GetTransaction()
            {
                return "Purchase";
            }
        }

        public class Redemption : ITransaction
        {
            public string GetTransaction()
            {
                return "Redemption";
            }
        }

        public class TransactionHandler
        {
            public ITransaction GetTransactionType(string TransType)
            {
                if (TransType == "Purchase")
                {
                    return new Purchase();
                }
                else if (TransType == "Redemption")
                {
                    return new Redemption();
                }
                else
                {
                    return null;
                }
            }
        }

        public class Client
        {
            public static void Start()
            {
                TransactionHandler c = new TransactionHandler();
                ITransaction transaction;
                
                transaction = c.GetTransactionType("Purchase");
                transaction.GetTransaction();


                transaction = c.GetTransactionType("Redemption");
                transaction.GetTransaction();
                
                
            }
        }
    }
}
