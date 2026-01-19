//Şehir rehberi uygulaması-Dizi yönetimi
string[] sehirler={"Çanakkale","Sakarya","İzmir","Balikesir","Bursa"};
/*
//Dizide eleman değiştirme
sehirler[0]="Kocaeli";
Console.WriteLine(sehirler[0]);
//Motod 2
sehirler.SetValue("Kocaeli",0);
Console.WriteLine(sehirler[0]);
//Dizide kac eleman var
Console.WriteLine(sehirler.Length);
//Dizide sıralı gösterim
Array.Sort(sehirler);
Console.WriteLine(sehirler.GetValue(0));
//Diziyi ters çevirme
Array.Reverse(sehirler);
Console.WriteLine(sehirler.GetValue(0));
*/
//Diziden eleman silme! asıl kafa karıştırıcı kısım 
Array.Clear(sehirler,0,4);
Console.WriteLine(sehirler.Length); //Hala 5 eleman var!
//Diziyi gerçekten 1 elemana düşürüyoruz.
Array.Resize(ref sehirler,1);
Console.WriteLine(sehirler.Length); //Artık 1 eleman var.




