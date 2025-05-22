namespace _2Laba
{
    class NotIncome
    {
        public string Data { get; }

        public NotIncome(string str)
        {
            Data = str;
        }

        public override string ToString()
        {
            return Data;
        }
    }
}