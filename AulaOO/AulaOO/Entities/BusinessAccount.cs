namespace AulaOO.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimmit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimmit) 
            : base( number, holder, balance)
        {
            LoanLimmit = loanLimmit;
        }

        public void Loan(double ammount) {
            if (ammount <= LoanLimmit) {
                Balance += ammount;
            }
        }
    }
}
