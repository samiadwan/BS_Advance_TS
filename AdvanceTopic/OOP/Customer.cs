﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTopic.OOP
{   
    //Multiple constructor example
    /*public class Order
    {

    }*/
    public class Customer
    {
        public int Id;
        public string Name;
       // public List<Order> Orders;
        public Customer()
        {
           //Orders = new List<Order>();//empty list
        }
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }
        public Customer(int id,string name)
            : this(id)
        {
            this.Id = id;
            this.Name = name;
        }

    }
}
