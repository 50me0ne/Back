using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Models
{
    public class Receipt
    {
        public Receipt() { fecha = DateTime.Now; }
        public Receipt(ReceiptView rv)
        {
            fecha = DateTime.ParseExact(rv.fecha, "d", new CultureInfo("es-Mx"));
            proveedor = rv.proveedor;
            monto = rv.monto;
            moneda = rv.moneda;
            comentario = rv.comentario;
        }
        [Key]
        public int receiptId { get; set; }
        [Required]
        public string proveedor { get; set; }
        [Required]
        public double monto { get; set; }
        public string moneda { get; set; }
        public DateTime fecha { get; set; }
        public string comentario { get; set; }
    }
    public class ReceiptView
    {
        [Required]
        public string proveedor { get; set; }
        [Required]
        public double monto { get; set; }
        public string moneda { get; set; }
        public string comentario { get; set; }
        public string fecha { get; set; }
    }
}
