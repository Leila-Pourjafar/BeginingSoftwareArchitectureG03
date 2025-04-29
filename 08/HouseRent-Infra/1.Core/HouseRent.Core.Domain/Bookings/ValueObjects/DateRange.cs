using HouseRent.Core.Domain.Framework;

namespace HouseRent.Core.Domain.Bookings.ValueObjects;

public record DateRange
{
    private DateRange()
    {
    }

    public DateOnly Start { get; init; }

    public DateOnly End { get; init; }

    public int LengthInDays => End.DayNumber - Start.DayNumber;

    public static DateRange Create(DateOnly start, DateOnly end)
    {
        if (start > end)
        {
            //Exception اختصاصی بررسی شود
            throw new DomainValidationException("تاریخ پایان از شروع کوچکتر است");
        }

        return new DateRange
        {
            Start = start,
            End = end
        };
    }

    public bool IsInProgressAt(DateOnly date) => IsStartedAt(date) && date < End;
    public bool IsNotStartedAt(DateOnly date) => date < Start;
    public bool IsStartedAt(DateOnly date) => date >= Start;

    public bool IsFinishedAt(DateOnly date) => date > End;

}