using SOLID_ACT_VALDEZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ACT_VALDEZ.Services
{
    public interface IInvoicePrinter
    {
        void Print(Order order);
    }
}

