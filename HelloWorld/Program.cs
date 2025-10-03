namespace HelloWorld {
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();  // model and view "inside" controller

            controller.DoOperation();

            controller.ShowResult();
        }
    }
}
