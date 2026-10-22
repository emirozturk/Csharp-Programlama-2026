class Ogrenci(string Ad, string Soyad, string Bolum, string Sehir, string Numara, int Sinif) : IComparable
{
    public string Numara { get; set; } = Numara;
    public string Ad { get; set; } = Ad;
    public string Soyad { get; set; } = Soyad;
    public string Bolum { get; set; } = Bolum;
    public string Sehir { get; set; } = Sehir;
    public int Sinif { get; set; } = Sinif;

    public int CompareTo(object? obj)
    {

        if (obj != null)
        {
            var ogrenci = (Ogrenci)obj;
            if (ogrenci.Sinif < Sinif) return 1;
            else if (ogrenci.Sinif > Sinif) return -1;
        }
        return 0;
    }
    public override string ToString()
    {
        return $"{Numara,14} {Ad,15} {Soyad,20} {Bolum} {Sehir,10} {Sinif}";
    }
}
