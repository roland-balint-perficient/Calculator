namespace HelloWorld
{
    enum Operation : byte { Add, Subtract, Multiply, Divide }

    /// <summary>
    /// Demonstrates the data and business logic of an application. It is responsible for managing the application's
    /// data, processing business rules, and responding to requests for information from other components, such as the
    /// View and the Controller.
    /// </summary>
    internal class Model
    {
        private int numberOne;
        private int numberTwo;
        private Operation operation;
        private double? result;


        // have a constructor with all fields in order to avoid uninitialized fields 
        public Model(int numberOne, int numberTwo, Operation operation)
        {
            this.numberOne = numberOne;
            this.numberTwo = numberTwo;
            this.operation = operation;
        }


        // getters and setters as C# properties
        public int NumberOne
        {
            get { return numberOne; }
            set { numberOne = value; }
        }

        public int NumberTwo
        {
            get { return numberTwo; }
            set { numberTwo = value; }
        }

        public Operation Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        public double? Result
        {
            get { return  result; }
        }

        
        public void DoOperation()
        {
            switch (operation)
            {
                case Operation.Add:
                    this.result = numberOne + numberTwo;
                    break;
                case Operation.Subtract:
                    this.result = numberOne - numberTwo;
                    break;
                case Operation.Multiply:
                    this.result = numberOne * numberTwo;
                    break;
                case Operation.Divide:
                    this.result = numberOne / numberTwo;
                    break;
                default:
                    this.result = null;
                    throw new NotImplementedException();
            }
        }
    }
}
