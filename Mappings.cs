using Cassandra.Mapping;

namespace CassandraPractice
{
    public class MyMappings : Mappings
    {
        public MyMappings()
        {
            For<Person>()
                .KeyspaceName("practice")
                .TableName("person")
                .PartitionKey(p => p.Id)
                .Column(u => u.Id, cm => cm.WithName("id"))
                .Column(u => u.Name, cm => cm.WithName("name"))
                .Column(u => u.Age, cm => cm.WithName("age"));

        }
    }
}
