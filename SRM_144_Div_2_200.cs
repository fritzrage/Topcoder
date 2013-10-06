class Time
{
    private string localTime;
    public string LocalTime
    {
        get { return localTime; }
        set { localTime = value; }
    }
    public string whatTime(int seconds)
    {
        while (seconds <= 24 * 60 * 60 - 1)
        {
            int hours, minutes, remaining_minutes, remaining_seconds;
            minutes = seconds / 60;
            remaining_seconds = seconds % 60;
            hours = minutes / 60;
            remaining_minutes = minutes % 60;
            LocalTime = hours + ":" + remaining_minutes + ":" + remaining_seconds;
            return (LocalTime);
        }
        return "0:0:0";
    }
}
