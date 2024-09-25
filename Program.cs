using System;
class program
{
    static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa1 = new Singa("Singa Asia", 5, 4);
        kebunBinatang.TambahHewan(singa1);
        //singa1.Suara();
        //singa1.Mengaum();
        singa1.InfoMamal();
        Gajah gajah1 = new Gajah("Gajah Thailand", 10, 4);
        kebunBinatang.TambahHewan(gajah1);
        gajah1.Suara();

        Ular ular1 = new Ular("Ular sawah", 6, 6);
        kebunBinatang.TambahHewan(ular1);
        //ular1.Suara();
        ular1.Merayap();

        Buaya buaya1 = new Buaya("Buaya Muara", 10, 5);
        kebunBinatang.TambahHewan(buaya1);
        buaya1.Suara();
        Reptil reptil = buaya1;
        reptil.Suara();

        Console.WriteLine("Daftar hewan di kebun binatang:");
        kebunBinatang.DaftarHewan();

    }
}

public class Hewan
{
    public string nama;
    public int umur;
    public Hewan(string nama, int umur)
    {
        this.nama = nama;
        this.umur = umur;
    }

    public virtual void Suara()
    {
        Console.WriteLine($"Hewan ini bersuara");
    }

    public void InfoHewan()
    {
        Console.WriteLine($"Nama Hewan: {nama}");
        Console.WriteLine($"Umur Hewan: {umur}");
    }
}

class Mamalia : Hewan
{
    public int jumlahKaki;
    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        this.jumlahKaki = jumlahKaki;
    }

    public void InfoMamal()
    {
        InfoHewan();
        Console.WriteLine($"Jumlah Kaki: {jumlahKaki}");
    }
}

class Reptil : Hewan
{
    public int panjangTubuh;
    public Reptil(string nama, int umur, int panjangTubuh) : base(nama, umur)
    {
        this.panjangTubuh = panjangTubuh;
    }
}

class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki) : base (nama, umur, jumlahKaki) { }

    public override void Suara()
    {
        Console.WriteLine("ngauumm");
    }

    public void Mengaum()
    {
        Console.WriteLine("Singa mengaum dengan kencang!!!");
    }
}

class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

    public override void Suara()
    {
        Console.WriteLine("teretteteettt");
    }
    
}

class Ular : Reptil
{
    public Ular(string nama, int umur, int panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override void Suara()
    {
        Console.WriteLine("stttstttttsttt");
    }

    public void Merayap()
    {
        Console.WriteLine("ular itu merayap kesini!!!!");
    }
}

class Buaya : Reptil
{
    public Buaya(string nama, int umur, int panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override void Suara()
    {
        Console.WriteLine("rawrr");
    }

}

class KebunBinatang
{
    public Hewan[] koleksiHewan = new Hewan[20];
    public int index = 0;

    public void TambahHewan(Hewan hewan)
    {
        if (index < 10)
        {
            koleksiHewan[index] = hewan;
            index++;
        }
    }

    public void DaftarHewan()
    {
        for (int i = 0; i < index; i++)
        {
            koleksiHewan[i].InfoHewan();
        }
    }
}


