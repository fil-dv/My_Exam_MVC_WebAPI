using DataLayer.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.Repositories
{
    public class Searcher
    {
        RentDBModel _context;
        SearchEnum _searchArg;
        string _searchStr;

        public Searcher(RentDBModel context, int searchArg, string searchStr)
        {
            if (searchArg >= 1 && searchArg <= 5)
            {
                _context = context;
                _searchArg = (SearchEnum)searchArg;
                _searchStr = searchStr;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public IEnumerable<Rent> Search()
        {
            IEnumerable<Rent> list = new List<Rent>();

            switch (_searchArg)
            {
                case SearchEnum.DateEnd:

                    break;
                case SearchEnum.dogovor:
                    list = from r in _context.Rents
                           where r.dogovor.Contains(_searchStr)
                           select r;  
                    break;
                case SearchEnum.EDRPOU:
                    break;
                case SearchEnum.RentAddress:
                    break;
                case SearchEnum.RentName:
                    break;

            }
                       

            return null;
        }


    }
}
