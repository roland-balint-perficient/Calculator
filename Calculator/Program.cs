using Calculator.Controller;


namespace Calculator {
    class Program
    {
        static void Main(string[] args)
        {
            Controller.Controller controller = new Controller.Controller();  // model and view "inside" controller

            controller.DoOperation();

            controller.ShowResult();
        }
    }
}
