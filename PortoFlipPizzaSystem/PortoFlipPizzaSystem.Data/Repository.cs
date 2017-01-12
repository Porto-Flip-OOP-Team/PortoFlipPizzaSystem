using System;
using System.Collections.Generic;
using PortoFlipPizzaSystem.Data;
using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace PortoFlipPizzaSystem.Data
{
    public class Repository
    {

        private static Repository instance = null;
        private static readonly object padlock = new object();

       // private static readonly IRestaurant Restaurant;

        private static Repository repositoryInstance;

        private Repository()
        {    
        }

        public static Repository RepositoryInstance
        {
            get
            {

                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Repository();
                    }
                    return instance;
                }
            }
        }

        //public T GetById(object id)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<T> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Add(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //  public IRestaurant Restaurant { get; private set; }
    }
}
