namespace GeographyNow
{
    internal class CountryMustHaveSingleCapitalException : Exception
    {
        public CountryMustHaveSingleCapitalException(string message) : base(string.Format("Country must have single capital: {0}", message))
        {

        }
    }
}
