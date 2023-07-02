using Indexer.Data.Context;
using Indexer.Data.Entities;
using Indexer.Data.Interfaces.IRepositories;

namespace Indexer.Data.Services.Repositories
{
    public class MainTableRepository : EntityGenericRepository<MainTable>, IEntityGenericRepository, IMainTableRepository
    {
        //-----Fields-------------
        private IndexerContext db;
        //---------Methods-------------
        public MainTableRepository(IndexerContext context) : base(context)
        {
            db = context;
        }












        //----------------
    }
}
