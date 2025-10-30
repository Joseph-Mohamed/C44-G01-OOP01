namespace Common
{
    public class TypeA
    {
        // x accessible in their scope ==> class
        private int x;    
        internal int y;
        public int z;
        public TypeA()
        {
            x = 1;
            y = 2; 
            z = 3;
            TypeB typeB = new TypeB();
           
        }

        void print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
