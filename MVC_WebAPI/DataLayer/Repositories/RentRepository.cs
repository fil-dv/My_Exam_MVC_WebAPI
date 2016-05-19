using DataLayer.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DataLayer.Repositories
{
    public class RentRepository : GenericRepository<Rent>
    {
        public RentRepository(RentDBModel context)
            : base(context)
        { }

        protected override DbSet<Rent> dbSet
        {
            get { return context.Rents; }
        }
    }
}