using OrderMgmtSys.OrderService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMgmtSys.OrderService.Data
{
    public interface IOrderData
    {
        List<Order> GetOrders();
    }
}
