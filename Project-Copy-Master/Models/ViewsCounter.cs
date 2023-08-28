using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Copy_Master.Models
{
    public class ViewsCounter
    {
        public string Email { get; set; }
        public int Id { get; set; }
        public string Pagetype1 { get; set; }

        public int ViewcurrentmonthPagetype1 { get; set; }
        public int ViewpreviousmonthPagetype1 { get; set; }
        public string Pagetype2 { get; set; }

        public int ViewcurrentmonthPagetype2 { get; set; }
        public int ViewpreviousmonthPagetype2 { get; set; }
        public string Pagetype3 { get; set; }

        public int ViewcurrentmonthPagetype3 { get; set; }
        public int ViewpreviousmonthPagetype3 { get; set; }
        public string Pagetype4 { get; set; }

        public int ViewcurrentmonthPagetype4 { get; set; }
        public int ViewpreviousmonthPagetype4 { get; set; }

        public string refreshdatadate1 { get; set; }
        public string refreshdatadate2 { get; set; }
        public string refreshdatadate3 { get; set; }
        public string refreshdatadate4 { get; set; }
        public string refreshdatadate5 { get; set; }


    }
}
