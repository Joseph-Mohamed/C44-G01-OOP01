namespace SessionOne
{
    internal interface IMyInterface
    {
        //1) signature for method
        void MyFun(int x, int y);
        //2) signature for prop
        public int Id { get; set; }
        //3) default implementation method
      private void print()
        {
            Console.WriteLine("hello");
        }

        void helper()
        {
            print();
            Console.WriteLine(" broo");
        }

    }
}
