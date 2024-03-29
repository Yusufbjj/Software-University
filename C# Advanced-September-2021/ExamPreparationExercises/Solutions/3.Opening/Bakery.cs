﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> data;

        public Bakery(string name, int capacity)
        {
            this.data = new List<Employee>();
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(Employee employee)
        {
            if (data.Count < Capacity)
            {
                this.data.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            var employee = this.data.FirstOrDefault(e => e.Name == name);

            return this.data.Remove(employee);
        }

        public Employee GetOldestEmployee()
        {
            var employee = this.data.OrderByDescending(e => e.Age).First();

            return employee;
        }

        public Employee GetEmployee(string name)
        {
            var employee = this.data.FirstOrDefault(e => e.Name == name);

            return employee;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Employees working at Bakery {Name}");

            foreach (Employee employee in data)
            {
                sb.AppendLine(employee.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
