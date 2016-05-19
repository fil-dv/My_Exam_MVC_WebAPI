using DataLayer.DBLayer;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.ForSearch
{
    public class Searcher
    {
        IGenericRepository<Rent> _repository;

        SearchEnum _searchArg;
        string _searchStr;

        public Searcher(IGenericRepository<Rent> repository, int searchArg, string searchStr)
        {
            if (searchArg >= 1 && searchArg <= 5 && searchStr != null)
            {
                _repository = repository;
                _searchArg = (SearchEnum)searchArg;
                _searchStr = searchStr;
            }
            else
            {
                return;
                //throw new ArgumentOutOfRangeException();
            }
        }

        public IEnumerable<Rent> Search()
        {
            IEnumerable<Rent> list = new List<Rent>();

            switch (_searchArg)
            {
                case SearchEnum.DateEnd:
                    list = from r in _repository.GetAll()
                           where r.DateEnd.Equals(_searchStr)
                           select r;
                    break;
                case SearchEnum.dogovor:
                    list = from r in _repository.GetAll()
                           where r.dogovor.Contains(_searchStr)
                           select r;  
                    break;
                case SearchEnum.EDRPOU:
                    list = from r in _repository.GetAll()
                           where r.EDRPOU.Contains(_searchStr)
                           select r;
                    break;
                case SearchEnum.RentAddress:
                    list = from r in _repository.GetAll()
                           where r.RentAddress.Contains(_searchStr)
                           select r;
                    break;
                case SearchEnum.RentName:
                    list = from r in _repository.GetAll()
                           where r.RentName.Contains(_searchStr)
                           select r;
                    break;
            }         
            return list;
        }
    }
}
