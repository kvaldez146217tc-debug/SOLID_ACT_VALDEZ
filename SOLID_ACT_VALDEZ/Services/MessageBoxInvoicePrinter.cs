using SOLID_ACT_VALDEZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ACT_VALDEZ.Services
{
    public class MessageBoxInvoicePrinter : IInvoicePrinter
    {
        public void Print(Order order)
        {
            MessageBox.Show($"Invoice for {order.CustomerEmail}: {order.Total:C}");
        }
    }
}
