using System;

Console.Write("Start time: ");
string startDateStr = Console.ReadLine();
Console.Write("End time: ");
string endDateStr = Console.ReadLine();

DateTime startDate = DateTime.Parse(startDateStr);
DateTime endDate = DateTime.Parse(endDateStr);

TimeSpan timeDifference = endDate - startDate;

int totalSeconds = timeDifference.Minutes * 60 + timeDifference.Seconds;

decimal peakRate = 0.30m;  
decimal offPeakRate = 0.20m;
decimal totalCost = 0m;
int peakStartHour = 9;
int peakEndHour = 22;

for (int second = 0; second <= totalSeconds; second += 20)
{
    DateTime currentTime = startDate.AddSeconds(second);
    
    int currentHour = currentTime.Hour;

    if (currentHour >= peakStartHour && currentHour < peakEndHour)
    {
        totalCost += peakRate;
    }
    else
    {
        totalCost += offPeakRate;
    }
  
}

Console.Write(totalCost);



