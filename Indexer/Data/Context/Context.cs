using Indexer.Data.Entities;
using System.Data.Entity;

namespace Indexer.Data.Context
{
    public class IndexerContext : DbContext
    {
        public IndexerContext() : base("name=MyConnectionString")
        {

        }
        public virtual DbSet<MainTable> MainTables { get; set; }


    }
}
