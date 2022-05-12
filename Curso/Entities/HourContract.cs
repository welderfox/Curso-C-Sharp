using System;

namespace Curso.Entities
{
    public class HourContract
    {
        //Construtores
        public HourContract() { }

        public HourContract(DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hour;
        }

        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //Metodos

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
