namespace CassandraPractice
{
    public class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Deconstruct(out long id, out string name)
        {
            id = Id;
            name = Name;
        }
    }
}
