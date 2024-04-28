using System.Transactions;

internal class Program
{
    // --------------------------------------------- STATE-BASED ---------------------------------------------
    private enum StudentState { TERDAFTAR, CUTI, AKTIF, LULUS};
    private enum Trigger { MENGAJUKAN_CUTI, MENYELESAIKAN_CUTI, CETAK_KSM, LULUS };

    class Mahasiswa
    {
        private class Transition
        {
            public StudentState stateAwal;
            public StudentState stateAkhir;
            public Trigger trigger;

            private Transition(StudentState stateAwakm, StudentState stateAkhir, Trigger trigger)
            {
                this.stateAwal = stateAwal;
                this.stateAkhir = stateAkhir;
                this.trigger = trigger;
            }

            Transition[] transiSI =
            {
            new Transition(StudentState.TERDAFTAR, StudentState.CUTI, Trigger.MENGAJUKAN_CUTI),
            new Transition(StudentState.TERDAFTAR, StudentState.AKTIF, Trigger.CETAK_KSM),
            new Transition(StudentState.CUTI, StudentState.TERDAFTAR, Trigger.MENYELESAIKAN_CUTI),
            new Transition(StudentState.AKTIF, StudentState.LULUS, Trigger.LULUS)
            };
        }
    }
}

private static void Main(string[] args) { 
    {
        Console.WriteLine("Hello, World!");
    }
}