using Deneme;

namespace DenemeTests;

public class Tests
{
    [Test]
    public void BasariliLoginTesti()
    {
        Login l = new Login();
        var sonuc = l.CheckLogin(new Kisi("Emir", "Öztürk", "123", 46));
        Assert.That(sonuc, Is.EqualTo(1));
    }
    [Test]
    public void BasarisizLoginTesti()
    {
        Login l = new Login();
        var sonuc = l.CheckLogin(new Kisi("Muratcan", "Kara", "123", 22));
        Assert.That(sonuc, Is.EqualTo(0));
    }
    [Test]
    public void NullTesti()
    {
        Login l = new Login();
        var sonuc = l.CheckLogin(new Kisi(null, "Öztürk", "123", 46));
        Assert.That(sonuc, Is.EqualTo(0));
    }
    [Test]
    public void YasTesti()
    {
        var k1 = new Kisi("Muratcan", "Kara", "1234", 22);
        var k2 = new Kisi("Esat", "Tufan", "12345", 17);
        Login l = new Login();
        var sonuc1 = l.CheckLogin(k1);
        var sonuc2 = l.CheckLogin(k2);
        Assert.That(sonuc1,Is.EqualTo(1));
        Assert.That(sonuc2,Is.EqualTo(0));
    }
}
