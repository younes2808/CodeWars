public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        int hours = seconds/(60*60);
        int minutes = (seconds / 60) % 60;
        int sec = seconds % 60;
        return $"{hours:D2}:{minutes:D2}:{sec:D2}";
    }
}