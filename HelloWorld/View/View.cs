namespace Calculator.View
{
    /// <summary>
    /// Displays the data from the Model to the user and sends user inputs to the Controller. It is passive and does not
    /// directly interact with the Model. Instead, it receives data from the Model and sends user inputs to the
    /// Controller for processing.
    /// </summary>
    internal class View
    {
        public void ShowText(string text)
        {
            Console.WriteLine(text);
        }

        public string? ReadText()
        {
            return Console.ReadLine();
        }
    }
}
