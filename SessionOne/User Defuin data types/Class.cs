namespace SessionOne.User_Defuin_data_types
{
    // namespace
    //1) enum , 2) interface , 3) class , 4) stract

    // inside namespace : 2 access modifiers
    // internal[dafult , public
    internal class Class
    {
        // default acces modifer inside class ==> private
        //1) attributes [fields]
        private int x;
        //2) properties [automatic property , fully prop , indexer]
        public int Id { get; set; } 
        //3) events
        //4)function{method}
       internal void MyFun()
        {
            Console.WriteLine("Hello");
        }
    }
}
