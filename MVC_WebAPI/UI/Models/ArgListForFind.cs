using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Models
{

    public class ArgListForFind
    {
        public List<FindArgument> ArgList{ get; set; }

        public ArgListForFind()
        {
            ArgList = new List<FindArgument>();
            InitList();            
        }

        void InitList()
        {
            ArgList.Add(new FindArgument { ArgId = 1, ArgName = "По имени арендатора" } );          //RentName
            ArgList.Add(new FindArgument { ArgId = 2, ArgName = "По номеру договора" });            //dogovor
            ArgList.Add(new FindArgument { ArgId = 3, ArgName = "По ЕДРПОУ" });                     //EDRPOU
            ArgList.Add(new FindArgument { ArgId = 4, ArgName = "По адресу" });                     //RentAddress
            ArgList.Add(new FindArgument { ArgId = 5, ArgName = "По дате окончания договора" });    //DateEnd
        }
    }
}