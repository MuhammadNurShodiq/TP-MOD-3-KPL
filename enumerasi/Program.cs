internal class Program
{
    // --------------------------------------------- ENUM ---------------------------------------------
    enum EnumGender
    {
        Pria,
        Wanita
    }
    private static void printGender(EnumGender InputGender)
    {
        if (InputGender == EnumGender.Pria) 
        {
            Console.WriteLine("Anda adalah Pria");
        } else if (InputGender == EnumGender.Wanita) 
        {
            Console.WriteLine("Anda adalah Wanita");
        } else
        {
            Console.WriteLine("Gender tidak ada");
        }
    }

    // --------------------------------------------- TABLE-DRIVEN --------------------------------------------- 
    private enum Month { Januari, Februari, Maret, April, May, June, Juli, Agustus, September, Oktober, November, Desember }

    private static int GetDays(Month month)
    {
        int[] dayPerMonth = { 31, 28, 31, 30, 31, 31, 30, 31, 30, 31, 30, 31 };
        return dayPerMonth[(int)month];
        // Jika terdapat return, maka program setelahnya tidak akan bisa dijalankan
    }


    private static void Main(string[] args)
    {
        // GENDER
        EnumGender enumGender = EnumGender.Pria;
        printGender(enumGender);

        // TAHUN
        Month month = Month.Januari;
        int days = GetDays(month);
        Console.WriteLine("Bulan Januari terdapat " + days + " hari");

        Month month2 = Month.Februari;
        Console.WriteLine("Bulan " + month2 + " adalah bulan valentine");
    }
}