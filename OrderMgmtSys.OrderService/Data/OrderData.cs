using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
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
        //ILogger<OrderData> logger;
      
        public OrderData(IConfiguration configuration)
        {
            this.configuration = configuration;
            //this.logger = logger;
           
        }
        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            Order order;
            string CnnString;
            MySqlConnection Cnn=null;

            try
            {
                CnnString = configuration["DatabaseSettings:ConnectionString"];
                Cnn = new MySqlConnection(CnnString);
                Cnn.Open();
                //logger.LogInformation("Database connection established successfully");
            }
            catch (Exception ex)
            {
                //logger.LogError("Failed to stablish database connection");
                //logger.LogError(ex.Message);
            }


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
