using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Copy_Master.Models
{
    public class MainViewsCounter
    {
        public int Id { get; set; }
        public String Email { get; set; }
        public String Pagetype { get; set; }
        public int Viewscurrentmonth { get; set; }
        public int Viewspreviousmonth { get; set; }
        public int refreshdatadate { get; set; }

    }
}
