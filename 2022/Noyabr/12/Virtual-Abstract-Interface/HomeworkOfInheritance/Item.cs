using System;

namespace HomeworkOfInheritance
{
    public class Item : BaseClass
    {
        public string Brand { get; set; } //Sadece icaze verilen markalarin mehsullari satilmalidir
        public string Model { get; set; }

        private string _barcode;
        public string Barcode
        {
            get { return this._barcode; }
            set
            {
                bool checkBarcode = VirtualDatabase.IsBarcodeDuplicate(value);
                if (!checkBarcode)
                    _barcode = value;
                else
                    Console.WriteLine("Bu barkod daha once basqa mehsul ucun sisteme elave olunub!");
            }
        }


        private decimal _buyPrice;
        public decimal BuyPrice
        {
            get { return this._buyPrice; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Alis qiymeti 1-den kicik ola bilmez!");
                else
                    _buyPrice = value;
            }
        } //1-dan kicik ola bilmez

        private decimal _sellPrice;
        public decimal SellPrice
        {
            get { return this._sellPrice; }
            set
            {
                if (value < _buyPrice)
                    Console.WriteLine("Satis qiymeti alis qiymetinden az ola bilmez!");
                else
                    _sellPrice = value;
            }
        } // satis qiymeti alis qiymetinden kicik ola bilmez

        private decimal _offerPrice;
        public decimal OfferPrice
        {
            get { return this._offerPrice; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Kompaniya qiymeti 1-den kicik ola bilmez!");
                else
                    _sellPrice = value;
            }
        } // kompaniya qiymeti 1-den kicik ola bilmez

    }
}
