using Entidades;

namespace Services.Invoice
{
    public interface ISvInvoice
    {
        public Invoice AddInvoice(Invoice newInvoice);
        public Invoice GetInvoiceById(int invoiceId);
        public Invoice GetAllInvoices();

    }
}
