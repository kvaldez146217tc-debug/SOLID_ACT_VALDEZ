    using System;
    using System.Windows.Forms;
    using SOLID_ACT_VALDEZ.Models;
    using SOLID_ACT_VALDEZ.Service;
    using SOLID_ACT_VALDEZ.Services;
    using System.Drawing.Printing;
    using System.Net;
    using System.Net.Mail;

    namespace SOLID_ACT_VALDEZ
    {
    public partial class Form1 : Form
    {
        private IOrderCalculator orderCalculator;
        private IOrderRepository orderRepository;
        private IInvoiceSender invoiceSender;
        private IInvoicePrinter invoicePrinter;


        private decimal currentTotal;

        public Form1()
        {
            InitializeComponent();
        }

        public void Configure(
            IOrderCalculator orderCalculator,
            IOrderRepository orderRepository,
            IInvoiceSender invoiceSender,
            IInvoicePrinter invoicePrinter)
        {
            this.orderCalculator = orderCalculator;
            this.orderRepository = orderRepository;
            this.invoiceSender = invoiceSender;
            this.invoicePrinter = invoicePrinter;
        }

        private Order BuildOrderFromGrid()
        {
            var order = new Order();

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.Cells["Price"].Value == null) continue;

                order.Items.Add(new OrderItem
                {
                    Product = row.Cells["Product"].Value?.ToString(),
                    Price = Convert.ToDecimal(row.Cells["Price"].Value),
                    Quantity = Convert.ToInt32(row.Cells["Qty"].Value)
                });
            }

            return order;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Order order = BuildOrderFromGrid();
            string discount = cmbDiscountType.SelectedItem?.ToString() ?? "None";

            currentTotal = orderCalculator.CalculateTotal(order, discount);

            lblTotal.Text = currentTotal.ToString("C");
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            var order = new Order { CustomerEmail = txtCustomerEmail.Text, Total = currentTotal };
            orderRepository.Save(order);
            MessageBox.Show("  Order Saved! ");
        }

        private void btnEmailInvoice_Click(object sender, EventArgs e)
        {
            var order = new Order { CustomerEmail = txtCustomerEmail.Text, Total = currentTotal };
            invoiceSender.SendInvoice(order);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var order = new Order { CustomerEmail = txtCustomerEmail.Text, Total = currentTotal };
            invoicePrinter.Print(order);
            
        }

        private void txtCustomerEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    
