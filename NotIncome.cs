namespace Laba2
{
    public class NotIncome
    {
        public string Data { get; }

        public NotIncome(string data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data;
        }

        public override bool Equals(object obj)
        {
            if (obj is NotIncome other)
            {
                return Data == other.Data;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Data?.GetHashCode() ?? 0;
        }
    }
}