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
                return;
                throw new ArgumentOutOfRangeException();
            }
        }

        public IEnumerable<Rent> Search()
        {
            IEnumerable<Rent> list = new List<Rent>();

            switch (_searchArg)
            {
                case SearchEnum.DateEnd:
                    list = from r in _context.Rents
                           where r.DateEnd.Equals(_searchStr)
                           select r;
                    break;
                case SearchEnum.dogovor:
                    list = from r in _context.Rents
                           where r.dogovor.Contains(_searchStr)
                           select r;  
                    break;
                case SearchEnum.EDRPOU:
                    list = from r in _context.Rents
                           where r.EDRPOU.Contains(_searchStr)
                           select r;
                    break;
                case SearchEnum.RentAddress:
                    list = from r in _context.Rents
                           where r.RentAddress.Contains(_searchStr)
                           select r;
                    break;
                case SearchEnum.RentName:
                    list = from r in _context.Rents
                           where r.RentName.Contains(_searchStr)
                           select r;
                    break;
            }         
            return list;
        }
    }
}
