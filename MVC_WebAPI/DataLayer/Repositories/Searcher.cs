using DataLayer.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class Searcher
    {
        RentDBModel _context;
        int _searchArg;
        string _searchStr;

        public Searcher(RentDBModel context, int searchArg, string searchStr)
        {
            _context = context;
            _searchArg = searchArg;
            _searchStr = searchStr;
        }

        public IEnumerable<Rent> Search()
        {


            return null;
        }


    }
}
