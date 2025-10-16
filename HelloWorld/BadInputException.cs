namespace Calculator
{
    /// <summary>
    /// Custom exception for bad user input.
    /// </summary>
    [Serializable]
    internal class BadInputException : Exception
    {
        public BadInputException() { }


        public BadInputException(string message) : base(message) { }
    
    
        public BadInputException(string message, Exception exception) : base(message, exception) { }
    }
}
