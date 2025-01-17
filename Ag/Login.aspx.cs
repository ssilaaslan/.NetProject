using System;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;
using Ağ.Siniflar;

namespace Ağ
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa ilk kez yüklendiğinde yapılacak işlemler (varsa)
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan email ve şifre
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Eğer email veya şifre boşsa, hata mesajı göster
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                lblErrorMessage.Text = "Lütfen tüm alanları doldurun.";
                lblErrorMessage.Visible = true;
                return;
            }

            // Veritabanı bağlantısını kontrol et
            SqlConnectionClass.CheckConnection();

            // Şifreyi SHA256 ile şifrele
            string shaPass = Sha256converter.ComputeSha256Hash(password);

            // SQL komutunu oluştur (Tablo adı Kayit_Olma olarak güncellendi)
            SqlCommand commandLogin = new SqlCommand("SELECT * FROM Kayit_Olma WHERE Email=@pmail AND Sifre=@psifre", SqlConnectionClass.connection);
            commandLogin.Parameters.AddWithValue("@pmail", email);
            commandLogin.Parameters.AddWithValue("@psifre", shaPass);  // Şifre SHA256 ile şifrelenmiş hali gönderiliyor

            // Sorgu sonuçlarını al
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandLogin);
            da.Fill(dt);

            // Sonuçları kontrol et
            if (dt.Rows.Count > 0)
            {
                // Giriş başarılı, yönlendirme veya başarı mesajı
                lblErrorMessage.Visible = false;
                Response.Redirect("Listele.aspx"); // Ana sayfaya yönlendirebilirsiniz.
            }
            else
            {
                // Hatalı giriş, hata mesajı göster
                lblErrorMessage.Text = "Geçersiz email veya şifre.";
                lblErrorMessage.Visible = true;
            }
        }
    }
}
