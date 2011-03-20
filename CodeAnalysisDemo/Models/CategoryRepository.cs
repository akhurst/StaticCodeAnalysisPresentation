using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeAnalysisDemo.Models
{
    using DataAccess;

    public class CategoryRepository : IDisposable
    {
        // private string strConnectionString = "SomeConnectionString";
        private AdventureWorksEntities entities;

        public CategoryRepository()
        {
            entities = new AdventureWorksEntities();
        }

        public List<ProductCategory> RetrieveCategories()
        {
            return entities.ProductCategories.ToList();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        // public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (entities != null)
                {
                    entities.Dispose();
                    entities = null;
                }
            }
        }
    }
}