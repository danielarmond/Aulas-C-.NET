using System;


namespace AulaOO.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            string sep = ", ";
            return Id + sep + Moment + sep + Status;
        }
    }
}
