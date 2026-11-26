namespace Deneme;

public class Login
{
    List<Kisi> liste;
    public Login()
    {
        liste = new List<Kisi>()
        {
            new Kisi("Emir","Öztürk","123",46),
            new Kisi("Muratcan","Kara","1234",22),
            new Kisi("Esat","Tufan","12345",17),
        };
    }
    public int CheckLogin(Kisi kisi)
    {
        return Convert.ToInt32(liste.FirstOrDefault(x => x.Ad == kisi.Ad &&
                             x.Soyad == kisi.Soyad &&
                             x.Yas >= 18 &&
                             x.Sifre == kisi.Sifre) != null);
        /*
        if (kisi.Ad != null && kisi.Soyad != null)
        {
            if (kisi.Yas >= 18)
            {
                var bulunan = liste.FirstOrDefault(x => x.Ad == kisi.Ad && x.Soyad == kisi.Soyad);
                if (bulunan.Sifre == kisi.Sifre) return 1;
                else return 0;
            }
            else if (kisi.Yas < 18)
            {
                return 0;
            }
        }
        else
        {
            return 0;
        }
        return -1;
        */
    }
}