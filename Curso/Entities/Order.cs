using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Entities
{
    public class Order
    {
        public Order(int id, DateTime moment, OrderStatus status)
        {
            Id = id;
            Moment = moment;
            Status = status;
        }

        /*EXEMPLO DE ENUM*/
        public enum OrderStatus : short
        {
            PedingPayment = 0,
            Processing = 1,
            Sipped = 2,
            Delivered = 3
        }

        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    }
}
