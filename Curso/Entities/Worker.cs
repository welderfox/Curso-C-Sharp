using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Entities
{
    public class Worker
    {
        public Worker() { }

        public Worker(string nome, WorkerLevel level, double baseSalary, Department department)
        {
            Nome = nome;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public enum WorkerLevel : short
        {
            Junior = 0,
            Intermerdiario = 1,
            Senior = 2
        }

        public string Nome { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double soma = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    soma += contract.TotalValue();
                }
            }

            return soma;
        }
    }
}
