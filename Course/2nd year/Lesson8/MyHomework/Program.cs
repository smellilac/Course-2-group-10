namespace work
{
    class Main1
    {
        public static void Main(string[] args)
        {

            double balance = 100;
            double bank_profit;
            based.interest_calculation(50, balance,out balance, out bank_profit);
            Console.WriteLine($"Баланс после снятия: {balance}, прибыль банка: {bank_profit}");

            balance = based.deposit_withdrawal(50, balance);
            Console.WriteLine($"Баланс после вклада: {balance}");

            string loan_status = based.loan_approval(balance);
            Console.WriteLine(loan_status);
            double contribution = based.calculate_compound_interest(balance,0.02,20);
            Console.WriteLine($"Ваш счет равен :{contribution}");
         }

    }
    class based
    {
        public static string loan_approval(double balance)
        {
            if (balance <= 0)
            {
                return "Кредит одобрен";
            }
            else
            {
                return "У вас достаточно средств кредит не нужен";
            }
        }

        public static void interest_calculation(int amount_to_withdraw, double balance,out double new_balance,out double bank_profit )
        {
            double interest = amount_to_withdraw * 0.05;
            new_balance = balance - interest;
            bank_profit = interest;
        }
        public static double deposit_withdrawal(double deposit,double balance)
        { 
            return balance-deposit;
        }
        public static double calculate_compound_interest(double balance,double persent, int yers )
        {
            double result =balance+((persent*balance)*yers);
            return result;
        
        }
    }

}