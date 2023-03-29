using modul6_1302213039;

SayaTubeUser Rasyid = new SayaTubeUser("rasid");

SayaTubeVideo video1 = new SayaTubeVideo("John Wick 1");


SayaTubeVideo video2 = new SayaTubeVideo("John Wick 2");
SayaTubeVideo video3 = new SayaTubeVideo("John Wick 3");
SayaTubeVideo video4 = new SayaTubeVideo("John Wick 4");
SayaTubeVideo video5 = new SayaTubeVideo("John Wick 5");
SayaTubeVideo video6 = new SayaTubeVideo("John Wick 6");
SayaTubeVideo video7 = new SayaTubeVideo("John Wick 7");
SayaTubeVideo video8 = new SayaTubeVideo("John Wick 8");
SayaTubeVideo video9 = new SayaTubeVideo("John Wick 9");
SayaTubeVideo video10 = new SayaTubeVideo("John Wick 10");

Rasyid.AddVideo(video1);
Rasyid.AddVideo(video2);
Rasyid.AddVideo(video3);
Rasyid.AddVideo(video4);
Rasyid.AddVideo(video5);
Rasyid.AddVideo(video6);
Rasyid.AddVideo(video7);
Rasyid.AddVideo(video8);
Rasyid.AddVideo(video9);
Rasyid.AddVideo(video10);

Rasyid.PrintAllVideoPlaycount();

Console.WriteLine("tambah 25jt");
video1.IncreasePlayCount(25000000);
Console.WriteLine("tambah utk nyaris overflow");
for(int i =0; i<84; i++)
{
    video1.IncreasePlayCount(25000000);

}

Console.WriteLine("Overflow");
video1.IncreasePlayCount(25000000);

