using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //class : referans tipi
    //IEntity: ıentity olabilir veya ıentity implemente edebilir
    //new(): newlenebilir olabiliir
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //filtre yazabilmemizi sağlayacak(Expression)
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter); 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
