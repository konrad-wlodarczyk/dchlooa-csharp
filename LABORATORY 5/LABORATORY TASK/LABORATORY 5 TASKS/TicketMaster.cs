using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_2
{
    internal class TicketMaster : IBuyTicket
    {
        public void BuyTicket()
        {
            Console.WriteLine("The ticket has been bought.");
        }
    }
}
