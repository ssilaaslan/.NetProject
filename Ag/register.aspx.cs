using Ağ.Siniflar;
using System;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ağ
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa yüklendiğinde yapılacak işlemler (varsa)
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string sifre = txtPassword.Text;

            // Veritabanı bağlantısını kontrol et
            SqlConnectionClass.CheckConnection();

            // Şifreyi SHA256 ile şifrele
            string hashedsifre = Sha256converter.ComputeSha256Hash(sifre);

            // SQL komutunu oluştur
            string query = "INSERT INTO Kayit_Olma (Email, Sifre) VALUES (@pmail, @psifre)";
            
            // SqlCommand nesnesini oluştur
            SqlCommand commandregister = new SqlCommand(query, SqlConnectionClass.connection);

            // Parametreleri ekle
            commandregister.Parameters.AddWithValue("@pmail", email);
            commandregister.Parameters.AddWithValue("@psifre", hashedsifre);

            try
            {
                // Sorguyu çalıştır ve kaydı gerçekleştir
                commandregister.ExecuteNonQuery();

                // Başarı mesajını JavaScript alert olarak göster
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Kayıt başarıyla tamamlandı!');", true);
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya mesaj göster
                string errorMessage = "Bir hata oluştu: " + ex.Message;
                
                
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('" + errorMessage + "');", true);

                Response.Write("<script>alert('Kayıt başarıyla tamamlandı!');</script>");

            }
        }
    }
}
