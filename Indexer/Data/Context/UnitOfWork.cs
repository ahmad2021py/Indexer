using Indexer.Data.Interfaces.IRepositories;
using Indexer.Data.Services.Repositories;
using System;

namespace Indexer.Data.Context
{
    public class UnitOfWork : IDisposable
    {

        //--------Fields--------------
        IndexerContext db = new IndexerContext();
        public UnitOfWork()
        {
            //db.Configuration.LazyLoadingEnabled = false;
        }

        private IMainTableRepository _MainTableRepository;

        //-----------Properties---------------
        public IMainTableRepository MainTableRepository
        {
            get
            {
                if (_MainTableRepository == null)
                {
                    _MainTableRepository = new MainTableRepository(db);
                }

                return _MainTableRepository;
            }
        }





        //---------Methods-----------------
        public void Save()
        {

            db.SaveChanges();
        }



























        public void Dispose()//if Using Method Not Use . I Could Call this Method to Dispose all Resources .   
        {


        }




        ~UnitOfWork()
        {
            Dispose();
        }
















        //---End Block of Class And Namespace------------------------
    }
}




