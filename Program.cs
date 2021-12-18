using System;
using Cassandra;
using Cassandra.Mapping;

namespace CassandraPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the mappings of table to model.
            MappingConfiguration.Global.Define<MyMappings>();

            var cluster = Cluster
                            .Builder()
                            .AddContactPoint("localhost")
                            .Build();

            var session = cluster.Connect();
            var mapper = new Mapper(session);

            var users = mapper.Fetch<Person>();
            foreach (var user in users)
            {
                var (id, name) = user;
                Console.WriteLine($"name: {name}, id: {id}");
            }



            Console.WriteLine("ended");
        }

        private static void CreateTableAndInsert(ISession session)
        {

        }
    }

}
