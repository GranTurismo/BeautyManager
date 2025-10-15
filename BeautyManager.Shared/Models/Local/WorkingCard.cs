namespace BeautyManager.Shared.Models.Local;

public class WorkingCard
{
    public int Id { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
    public bool IsBooked { get; set; }

    public static IEnumerable<WorkingCard> GetCardsForDay(DateTime startDate)
    {
        int totalCardWorkingMinutes = Constants.CardWorkingTime.Hour * 60 + Constants.CardWorkingTime.Minute;
        DateTime endDate = startDate.Add(Constants.ClosingTime - Constants.OpeningTime);
        while (startDate < endDate)
        {
            yield return new()
            {
                StartDate = startDate,
                EndDate = startDate.AddMinutes(totalCardWorkingMinutes),
                IsBooked = false
            };
            startDate = startDate.AddMinutes(totalCardWorkingMinutes);
        }
    }
}