// See https://aka.ms/new-console-template for more 

using HildaTugas;

class Programs
{
    public static void Main(string[] args)
    {
        mobilsedan hrv = new mobilsedan(false, "hrv", "Hilda", "white");
        hrv.printCar();
        mobiltruk elf = new mobiltruk(20, "Robicon", "Hilda", "Greem");
        elf.printCar();
        IkanBudidaya mujaer = new IkanBudidaya("Kolam", "Mujaer", "ikan", true);
        mujaer.PrintIkan();
        IkanLiar piranh = new IkanLiar(true, "piran h", "ikan", false);
        piranh.PrintIkan();
        pionPetinggi king = new pionPetinggi("Raja","HITAM",true);
        king.printCatur();
        PionBudak pawn = new PionBudak("Budak", "HITAMMMM", "queen");
        pawn.printCatur();
        nasional_bank bri = new nasional_bank(true, 2131, "Hilda", "Bri");
        bri.printBank();
        internasional_bank opensea = new internasional_bank(true, 1231, "Hilda", "opensea");
        opensea.printBank();
        sedan hr = new sedan(false, "Sedan", "Hrv");
        hr.print();
        truk el = new truk(true, "Truck", "Mitsubishi");
        el.print();
        motor mr = new motor(false, "motor", "Toyota");
    }
}