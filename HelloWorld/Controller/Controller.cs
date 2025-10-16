using Calculator.Model;
using Calculator.View;


namespace Calculator.Controller
{
    /// <summary>
    /// Acts as an intermediary between the Model and the View. It handles user input and updates the Model accordingly
    /// and updates the View to reflect changes in the Model. It contains application logic, such as input validation
    /// and data transformation.
    /// </summary>
    internal class Controller
    {
        private Model.Model model;
        private View.View view;


        public Controller()
        {
            // initialize view (need to do first, since we need to read data from view to initialize model)
            view = new View.View();

            // gather the necessary info and initialize model
            Console.WriteLine("Enter the first number:");
            int numberOne = ReadInt32();

            Console.WriteLine("Enter the second number:");
            int numberTwo = ReadInt32();

            Console.WriteLine("Enter the operation; one of: + - * /");
            Operation operation = ReadOperation();

            model = new Model.Model(numberOne, numberTwo, operation);
        }


        public void DoOperation()
        {
            model.DoOperation();
        }

        public void ShowResult()
        {
            double? result = model.Result;
            if (result == null)
            {
                view.ShowText("No result!");
                return;
            }

            view.ShowText($"The result is: {result}");  // like f-strings in Python. yay!
        }


        private int ReadInt32()
        {
            int number;
            if (!int.TryParse(view.ReadText(), out number))
            {
                throw new BadInputException();
            }
            return number;
        }


        private Operation ReadOperation()
        {
            string? operationString = view.ReadText();
            if (string.IsNullOrEmpty(operationString))
            {
                throw new BadInputException();
            }

            switch (operationString)
            {
                case "+":
                    return Operation.Add;
                case "-":
                    return Operation.Subtract;
                case "*":
                    return Operation.Multiply;
                case "/":
                    return Operation.Divide;
                default:
                    throw new BadInputException();
            }
        }
    }
}
