using Entidades;

namespace ProyectoPrueba.Services.Service_Invoice
{
    internal interface ISvInvoice
    {
        public Invoice AddInvoice(Invoice newInvoice);
        public Invoice GetInvoiceById(int invoiceId);
        public Invoice GetAllInvoices(); 

    }
}
