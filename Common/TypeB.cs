namespace Common
{
    internal class TypeB
    {
        public TypeB()
        {
            TypeA typea = new TypeA();
           // typea.x = 10; //access in teir scoe only
            typea.y = 10; //access in teir scoe and the same project
            typea.z = 10; //access in teir scoe and the same project and any where

        }
    }

}
