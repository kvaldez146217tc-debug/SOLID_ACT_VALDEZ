using SOLID_ACT_VALDEZ.Discount;
using SOLID_ACT_VALDEZ.Service;
using SOLID_ACT_VALDEZ.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ACT_VALDEZ
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var discountRegistry = new DiscountStrategyRegistry(new IDiscountStrategy[]
            {
                new NoDiscountStrategy(),
                new StudentDiscountStrategy(),
                new SeniorDiscountStrategy(),
                new BlackFridayDiscountStrategy()
            });

            IOrderCalculator orderCalculator = new OrderCalculator(discountRegistry);

            
            IOrderRepository orderRepository =
                new SqlOrderRepository("Server=localhost;Database=Orders;...");

            IInvoiceSender invoiceSender =
                new SmtpInvoiceSender("smtp.gmail.com", "store@shop.com");

            IInvoicePrinter invoicePrinter = new MessageBoxInvoicePrinter();

            var form = new Form1();
            form.Configure(orderCalculator, orderRepository, invoiceSender, invoicePrinter);

            Application.Run(form);
        }
    }
}
