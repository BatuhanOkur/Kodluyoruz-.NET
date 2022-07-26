Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString()); // 25 Haziran 2022 Cumartesi
Console.WriteLine(DateTime.Now.ToShortDateString()); // 25.06.2022
Console.WriteLine(DateTime.Now.ToShortTimeString()); // hour minute
Console.WriteLine(DateTime.Now.ToLongTimeString()); //hour minute sec

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(2));
Console.WriteLine(DateTime.Now.AddSeconds(2));
Console.WriteLine(DateTime.Now.AddMonths(2));
Console.WriteLine(DateTime.Now.AddYears(2));
Console.WriteLine(DateTime.Now.AddMilliseconds(50));

//DateTime Formats

Console.WriteLine(DateTime.Now.ToString("dd")); // 25
Console.WriteLine(DateTime.Now.ToString("ddd")); // Cmt
Console.WriteLine(DateTime.Now.ToString("dddd")); // Cumartesi

Console.WriteLine(DateTime.Now.ToString("MM")); // 06
Console.WriteLine(DateTime.Now.ToString("MMM")); // Haz
Console.WriteLine(DateTime.Now.ToString("MMMM")); // Haziran

Console.WriteLine(DateTime.Now.ToString("yy")); // 22
Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2022

// Math

Console.WriteLine(Math.Abs(-2));
Console.WriteLine(Math.Sin(10));
Console.WriteLine(Math.Tan(10));
Console.WriteLine(Math.Cos(10));

Console.WriteLine(Math.Ceiling(22.3)); // büyük en küçük tam sayı
Console.WriteLine(Math.Round(22.3)); // hangisine daha yakınsa
Console.WriteLine(Math.Floor(22.7)); // küçük en büyük tam sayı

Console.WriteLine(Math.Max(10,5));
Console.WriteLine(Math.Min(10,5));

Console.WriteLine(Math.Pow(10,5));
Console.WriteLine(Math.Sqrt(9));
Console.WriteLine(Math.Log(9)); // log e tabanında 
Console.WriteLine(Math.Log10(9)); // log 10 tabanında
Console.WriteLine(Math.Exp(9)); // e üzeri 9
