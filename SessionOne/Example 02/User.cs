using SessionOne.Example_01;
using SessionOne.Example_03;

namespace SessionOne.Example_02
{
    internal class User
    {
public int Id { get; set; }
        public string? Name { get; set; }
        public Gender Gender { get; set; }
        public Branch Branch { get; set; }
        public Grad Grad { get; set; }
        public Premissions Premissions { get; set; }
    }
}
