internal class Program
{
    private enum Month {Januari, Februari, Maret, April, May, June, Juli, Agustus, September, Oktober, November, Desember}

    private static int GetDays(Month month)
    {
        int[] dayPerMonth = { 31, 28, 31, 30, 31, 31, 30, 31, 30, 31, 30, 31 };
        return dayPerMonth[(int)month];
    }
    private static void Main(string[] args)
    {
        Month month = Month.Januari;
        GetDays(month);
    }
}