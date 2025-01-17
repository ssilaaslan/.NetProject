using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Ağ.Siniflar;


namespace Ağ
{
    public partial class Listele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandList = new SqlCommand("Select UlkeID, Sehir, Aciklama, Butce, Ulke_ID, UlkeAdi from Table_GezilecekYerler inner join  Table_UlkeId on Table_GezilecekYerler.UlkeID=Table_UlkeId.Ulke_ID ", SqlConnectionClass.connection);
            SqlConnectionClass.CheckConnection();
            commandList.Parameters.AddWithValue("@pcon", true);
            SqlDataReader dr = commandList.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();
        }
      
    }
}