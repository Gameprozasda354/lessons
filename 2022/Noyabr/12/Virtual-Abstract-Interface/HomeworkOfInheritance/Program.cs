namespace HomeworkOfInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            laptop.Brand = "Asus";
            laptop.Model = "TUF FX705gm";
            laptop.CPU = "i9";
            laptop.Ram = "16";
            laptop.GraphicCard = "AMD 6gb";
            laptop.BuyPrice = 3600M;
            laptop.SellPrice = 4500M;
            laptop.OfferPrice = 4000M;
            laptop.Barcode = "123456789";
            VirtualDatabase.NewItem(laptop);

            Laptop laptop1 = new Laptop();
            laptop1.Brand = "Asus";
            laptop1.Model = "TUF FX705gm";
            laptop1.CPU = "i9";
            laptop1.Ram = "16";
            laptop1.GraphicCard = "AMD 6gb";
            laptop1.BuyPrice = 3600M;
            laptop1.SellPrice = 4500M;
            laptop1.OfferPrice = 4000M;
            laptop1.Barcode = "123456789"; //Xeta cixacaq

            laptop.Model = "Rog";

            VirtualDatabase.UpdateItem(laptop);
            VirtualDatabase.DeleteItem(laptop);

            Laptop laptop2 = new Laptop();
            laptop2.Brand = "Asus";
            laptop2.Model = "TUF FX705gm";
            laptop2.CPU = "i9";
            laptop2.Ram = "16";
            laptop2.GraphicCard = "AMD 6gb";
            laptop2.BuyPrice = 3600M;
            laptop2.SellPrice = 4500M;
            laptop2.OfferPrice = 4000M;
            laptop2.Barcode = "123456789"; //Xeta cixmayacaq
            VirtualDatabase.NewItem(laptop2);


        }
    }
}
