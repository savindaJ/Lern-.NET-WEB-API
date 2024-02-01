using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient; // Add this using directive dotnet add package MySql.Data
namespace lernApp.Pages.Customer;

public class IndexModel : PageModel
{

    public List<Customer> customers = new List<Customer>(); 

    public void OnPut()
    {
    #pragma warning disable CS8601 // Possible null reference assignment.
        Customer c1 = new Customer
                {
                    cusId = Request.Form["cus-id"],
                    cusName = Request.Form["cus-name"],
                    cusAddress = Request.Form["cus-address"],
                    cusSalary = Convert.ToDouble(Request.Form["cus-salary"])
                };
    }

    public void OnDelete()
    {
        
    }

    public void OnPost()
    {
    #pragma warning disable CS8601 // Possible null reference assignment.
        Customer c1 = new Customer
                {
                    cusId = Request.Form["cus-id"],
                    cusName = Request.Form["cus-name"],
                    cusAddress = Request.Form["cus-address"],
                    cusSalary = Convert.ToDouble(Request.Form["cus-salary"])
                };
    #pragma warning restore CS8601 // Possible null reference assignment.
        Console.WriteLine(c1.cusId);
        Console.WriteLine(c1.cusName);
        Console.WriteLine(c1.cusAddress);
        Console.WriteLine(c1.cusSalary);
        
        OnGet();
    }

    public void OnGet()
    {
        string connStr = "server=127.0.0.1;user=root;database=web_test;password=80221474;";
        MySqlConnection conn = new MySqlConnection(connStr);
        conn.Open();

        string sql = "SELECT * FROM customer";
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        using (MySqlDataReader rdr = cmd.ExecuteReader())
        {
            while (rdr.Read())
            {
                Customer c1 = new Customer
                {
                    cusId = rdr.GetString(0),
                    cusName = rdr.GetString(1),
                    cusAddress = rdr.GetString(2),
                    cusSalary = rdr.GetDouble(3)
                };

                customers.Add(c1);
            }
        }
        conn.Close();
    }
    public class Customer
    {
        public required string cusId;
        public required string cusName;
        public required string cusAddress;
        public required double cusSalary;
    }


}

