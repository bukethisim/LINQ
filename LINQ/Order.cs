using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }

        //Navigation Property
        public Customer Customer { get; set; } = new Customer();
        public List<Order> GetOrders()
        {
            List<Order> orderlist = new List<Order>();
            //veritabanından order tablosundan verileri çekip liste olarak döndürelim. 
           
            string query = @"SELECT o.CustomerID,o.EmployeeID,o.OrderID,o.OrderDate,(SELECT ContactName FROM Customers WHERE CustomerID=o.CustomerID) AS ContactName FROM Orders o";
           
            DataTable dt = GetDataTable(query);

            foreach (DataRow item in dt.Rows)
            {
                Order order = new Order();
                order.OrderID = (int)item["OrderID"];
                order.CustomerID = item["CustomerID"].ToString();
                order.EmployeeID = (int)item["EmployeeID"];
                order.OrderDate = Convert.ToDateTime(item["OrderDate"]);
                //order.Customer = new Customer(); --> ya bu şekilde nesnesini oluşturucaz .Yada Property tanımlarken
                order.Customer.ContactName = item["ContactName"].ToString();
                order.Customer.CustomerID = item["CustomerID"].ToString();
                orderlist.Add(order);
            }
            return orderlist;
        }

        private DataTable GetDataTable(string query)
        {
            string con = "Server = Wissen\\SQLEXPRESS; Database = Northwnd; User ID = Section1; Integrated Security = true; ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }
    }

    class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public List<Order> Orders { get; set; }
        public int OrderCount
        {
            get
            {
                return Orders.Count;
            }
        }
    }
}
