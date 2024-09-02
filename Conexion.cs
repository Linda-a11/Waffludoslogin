using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfAppLogin.View;

public class Conexion
{
    public static SqlConnection conectarnos()
    {
        SqlConnection objConectar = new SqlConnection("Server=LAPTOP-O2UQOBEI\\SQLEXPRESS; Database=MVVMLoginDb;TrustServerCertificate=True; Trusted_Connection=true;");
        objConectar.Open();
        return objConectar;
    }

    public DataTable Indice()
    {
        Conectarnos();
        DataTable dataTable = new DataTable();
        string sql = "SELECT*FROM User";
        SqlCommand coman = new(sql, conectarnos());
        SqlDataAdapter adaptar = new SqlDataAdapter(coman);
        adaptar.Fill(dataTable);
        return dataTable;
    }

    private void Conectarnos()
    {
        throw new NotImplementedException();
    }

}