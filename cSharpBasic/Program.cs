var date1 = new DateTime(2015,12,25);
Console.WriteLine(date1.ToString());//// 12/25/2015 12:00:00 AM
Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.MinValue);
Console.WriteLine(DateTime.MaxValue);
Console.WriteLine(DateTime.UtcNow);//utc-> coordinate universal time

DateTime? sample1 = null;
Console.WriteLine(sample1);

var today = DateTime.Today;
Console.WriteLine($"Today is : {today}");
Console.WriteLine($"Today is (string) : {today.ToString()}");
Console.WriteLine( today.Ticks);//tric-> one ten milions of a second

Console.WriteLine("Day Of Week : "+DateTime.Now.DayOfWeek);

Console.WriteLine("Day Of year: " + DateTime.Now.DayOfYear);

Console.WriteLine("is daylight saving time? : " + DateTime.Now.IsDaylightSavingTime());

Console.WriteLine("DateTime.Now.Kind : "+DateTime.Now.Kind);

Console.WriteLine("DateTime.UtcNow.Kind : "+DateTime.UtcNow.Kind);
Console.WriteLine("DateTime.UtcNow to local: " + DateTime.UtcNow.ToLocalTime());

var sampleVar = DateTime.Now;
Console.WriteLine($"sampleVar: {sampleVar},  sampleVar+3hours : {sampleVar.AddHours(3)}");
Console.WriteLine($"sampleVar: {sampleVar},  sampleVar-3hours : {sampleVar.AddHours(-3)}");

//Timespan: represent a span of time
//days:hours:min:sec.milsec

TimeSpan ts = TimeSpan.Parse("4:15:13.12345");

Console.WriteLine(ts);
Console.WriteLine(sampleVar.Add(ts));

TimeSpan ts2 = TimeSpan.Parse("5:4:15:13.12345");
Console.WriteLine(ts2);
Console.WriteLine(sampleVar.Add(ts2));

DateTime sample3 = sampleVar.Add(ts2);
sample3.Subtract(ts);

Console.WriteLine($"{ts2.Divide(2)}");
Console.WriteLine($"{ts2.Multiply(2)}");


Console.WriteLine(ts2.Days);
Console.WriteLine(ts2.Hours);
Console.WriteLine(ts2.Minutes);
Console.WriteLine(ts2.Seconds);
Console.WriteLine(ts2.Milliseconds);
Console.WriteLine(ts2.TotalMinutes);
Console.WriteLine(ts2.Duration());

Console.WriteLine(" compare : "+DateTime.Compare(sample3,sampleVar));//output 1 means sample3 is greater, 0,-1
Console.WriteLine("short date : "+sample3.ToString(format:"d"));
Console.WriteLine("long date : " + sample3.ToString(format: "D"));
Console.WriteLine("short time : " + sample3.ToString(format: "t"));
Console.WriteLine("long time : " + sample3.ToString(format: "T"));
Console.WriteLine("Round Trip datetime : " + sample3.ToString(format: "O"));
Console.WriteLine("full short datetime : " + sample3.ToString(format: "f"));
Console.WriteLine("full long datetime : " + sample3.ToString(format: "F"));
Console.WriteLine("general short atetime : " + sample3.ToString(format: "g"));
Console.WriteLine("general long datetime : " + sample3.ToString(format: "G"));

Console.WriteLine("shortable datetime : " + sample3.ToString(format: "s"));
Console.WriteLine("universal datetime : " + sample3.ToString(format: "U"));
Console.WriteLine("month : " + sample3.ToString(format: "MMM"));
Console.WriteLine("month day, year : " + sample3.ToString(format: "MMM dd, yyyy"));
Console.WriteLine("month and date : " + sample3.ToString(format: "M"));
Console.WriteLine("month day, year h:m:s:timezone  : " + sample3.ToString(format: "MMM dd, yyyy hh: mm tt zzzz"));

DateOnly datex1 = DateOnly.FromDateTime(DateTime.Now);
TimeOnly timex1 = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine("datex1  : "+ datex1);
Console.WriteLine("timex1 : " + timex1);

Console.WriteLine(datex1.Day);
Console.WriteLine(datex1.Month);
Console.WriteLine(datex1.Year);
Console.WriteLine(datex1.AddDays(5));