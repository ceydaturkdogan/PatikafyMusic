
using PatikafyMusic;
using System.Numerics;

List<Singer> singers = new List<Singer>()
{
    new Singer{FullName="Ajda Pekkan", TypeOfMusic="Pop", ReleaseYear=1968,AlbumSales=20000000},
    new Singer{ FullName="Sezen Aksu",TypeOfMusic="Pop/Türk Halk Müziği",ReleaseYear=1971,AlbumSales=10000000},
    new Singer{FullName="Funda Arar", TypeOfMusic="Pop", ReleaseYear=1999,AlbumSales=3000000},
    new Singer{FullName="Sertab Erener", TypeOfMusic="Pop", ReleaseYear=1994,AlbumSales=5000000},
    new Singer{FullName="Sıla", TypeOfMusic="Pop", ReleaseYear=2009,AlbumSales=3000000}, 
    new Singer{FullName="Serdar Ortaç", TypeOfMusic="Pop", ReleaseYear=1994,AlbumSales=10000000},
    new Singer{FullName="Tarkan", TypeOfMusic="Pop", ReleaseYear=1992,AlbumSales=40000000}, 
    new Singer{FullName="Hande Yener", TypeOfMusic="Pop", ReleaseYear=1999,AlbumSales=7000000},
    new Singer{FullName="Hadise", TypeOfMusic="Pop", ReleaseYear=2005,AlbumSales=7000000},
    new Singer{FullName="Gülben Ergen", TypeOfMusic="Pop", ReleaseYear=1997,AlbumSales=10000000},
    new Singer{FullName="Neşet Ertaş", TypeOfMusic="Türk Halk Müziği/Türk Sanat Müziği", ReleaseYear=1999,AlbumSales=2000000},


};


//Adı 'S' ile başlayan şarkıcılar



var sNames =singers.Where(singerName=>singerName.FullName.StartsWith("S"))
                  .OrderBy(singerName=>singerName.FullName);

foreach (var singer in sNames)
{
    Console.WriteLine(singer.FullName);
}

//Albüm satışları 10 milyon'un üzerinde olan şarkıcılar

var albumSales = singers.Where(a => a.AlbumSales > 10000000)
                        .OrderBy(a => a.FullName);
Console.WriteLine("\nAlbüm satışları 10 milyon'un üzerinde olan şarkıcılar");
foreach (var singer in albumSales)
{
    Console.WriteLine(singer.FullName);
}

//2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.

Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.\n");

var filteredSinger = singers.Where(singer => singer.ReleaseYear < 2000 && singer.TypeOfMusic.Contains("Pop"))
                            .OrderBy(singer=>singer.FullName)
                            .GroupBy(singer=>singer.ReleaseYear);

foreach (var singer in filteredSinger)
{
    Console.WriteLine($"{singer.Key}");
    foreach(var name in singer)
    {
        Console.WriteLine(name.FullName);
    }
}


//En çok albüm satan şarkıcı


var maxSalesAlbum = singers.OrderByDescending(singer=>singer.AlbumSales).First();

Console.WriteLine($"\nEn çok albüm satan şarkıcı: {maxSalesAlbum.FullName}");


var lastSinger=singers.OrderByDescending(singer=>singer.ReleaseYear).First();


Console.WriteLine($"\nEn yeni çıkış yapan şarkıcı {lastSinger.FullName}");

var firstSinger=singers.OrderBy(singer=>singer.ReleaseYear).First();

Console.WriteLine($"\nEn eski çıkış yapan şarkıcı{firstSinger.FullName}");

