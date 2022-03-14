namespace DataAccess.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DataAccess.Repositories.Abstraction;
    using Domain;
    using NHibernate;

    public class ServiceStationRepository : IRepository<ServiceStation>
    {
        public bool Create<TEntity>(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete<TEntity>(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ServiceStation> Filter(ISession session, System.Linq.Expressions.Expression<Func<ServiceStation, bool>> predicate)
        {
            return this.GetAll(session)
                .Where(predicate);
        }

        public ServiceStation Find(ISession session, System.Linq.Expressions.Expression<Func<ServiceStation, bool>> predicate)
        {
            return this.GetAll(session)
                .FirstOrDefault(predicate);
        }

        public ServiceStation Get(ISession session, int id) =>
                  session?.Get<ServiceStation>(id);

        public IQueryable<ServiceStation> GetAll(ISession session) =>
                  session?.Query<ServiceStation>();

        public bool Update<TEntity>(TEntity oldEntity, TEntity newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
