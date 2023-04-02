namespace Data.ValueObjects
{
    public class SomeUserData
    {
        public int id { get; private set; }
        public string name { get; private set; }

        public SomeUserData(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}