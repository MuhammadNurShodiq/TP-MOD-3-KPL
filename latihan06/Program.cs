using System.Text.Json;
public class Program
{

    public static void Main(string[] args)
    {
        String jsonString = File.ReadAllText("C://Praktikum/KPL/nulis.json");
        ContohClassMahasiswa mahasiswas = JsonSerializer.Deserialize<ContohClassMahasiswa>(jsonString);
        ContohClassMahasiswa mahasiswa = new ContohClassMahasiswa("ASDFG", "12345", 3.14);
        Console.WriteLine("Hello, World!");
        WriteJSON();
        ReadJSON();
    }

    class ContohClassMahasiswa
    {
        public String nama { get; set; }
        public String nim { get; set; }
        public double ipk { get; set; }
        public ContohClassMahasiswa(String nama, String nim, double ipk)
        {
            this.nama = nama;
            this.nim = nim;
            this.ipk = ipk;
        }
    }

    public static void WriteJSON()
    {
        //Contoh object yang akan ditulis dalam JSON
        ContohClassMahasiswa mahasiswa = new ContohClassMahasiswa("ASDFG", "12345", 3.14);
        //[Opsional] Merapikan format JSON
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };
        //Melakukan perubahan object menjadi string(Serialization)
        String jsonString = JsonSerializer.Serialize(mahasiswa, options);
        Console.WriteLine(jsonString);
        //Membuat file JSON yg berisi string hasil serialization
        File.WriteAllText("C://Praktikum/KPL/nulis.json", jsonString);
    }

    public static void ReadJSON()
    {
        String jsonString = File.ReadAllText("C://Praktikum/KPL/nulis.json");

        //Deserialize file json menjadi object
        ContohClassMahasiswa mahasiswa = JsonSerializer.Deserialize<ContohClassMahasiswa>(jsonString);
        Console.WriteLine("Nama :" + mahasiswa.nama);
        Console.WriteLine("NIM :" + mahasiswa.nim);
        Console.WriteLine("IPK :" + mahasiswa.ipk);
    }
}