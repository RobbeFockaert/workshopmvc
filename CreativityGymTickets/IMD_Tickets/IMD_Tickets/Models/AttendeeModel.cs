using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMD_Tickets.Models
{
    public class AttendeeModel
    {
        private CreativityGymDataContext dc = new CreativityGymDataContext();

        public List<Ticket> selectAll()
        {
            var result = (from u in dc.Tickets
                          select u).ToList();
            return result;
        }

    }
}