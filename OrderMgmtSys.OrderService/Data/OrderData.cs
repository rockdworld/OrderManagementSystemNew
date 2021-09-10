using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using OrderMgmtSys.OrderService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMgmtSys.OrderService.Data
{
    public class OrderData : IOrderData
    {
        IConfiguration configuration;
        public OrderData(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            Order order;

            string CnnString = configuration.GetValue<string>("ConnectionString:OrderDB");
            MySqlConnection Cnn = new MySqlConnection(CnnString);
            Cnn.Open();

            MySqlCommand cmd = new MySqlCommand("Select * from tbl_order", Cnn);

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                order = new Order();

                order.OrderId = Convert.ToInt32(dr[0]);
                order.CustomerName = Convert.ToString(dr[1]);
                order.Amount = Convert.ToDouble(dr[2]);

                orders.Add(order);
            }

            return orders;
        }
    }
}
