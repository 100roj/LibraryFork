namespace DataAccess.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using DataAccess.Repositories.Abstraction;
    using Domain;
    using NHibernate;

    public class TrafficLightRepository : IRepository<TrafficLight>
    {
        public TrafficLight Get(ISession session, int id) =>
            session?.Get<TrafficLight>(id);

        public TrafficLight Find(ISession session, Expression<Func<TrafficLight, bool>> predicate)
        {
            return this.GetAll(session).FirstOrDefault(predicate);
        }

        public IQueryable<TrafficLight> GetAll(ISession session) =>
            session?.Query<TrafficLight>();

        public IQueryable<TrafficLight> Filter(ISession session, Expression<Func<TrafficLight, bool>> predicate)
        {
            return this.GetAll(session).Where(predicate);
        }

        public bool Create<TEntity>(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete<TEntity>(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Update<TEntity>(TEntity oldEntity, TEntity newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
