namespace Assignment2
{
    internal class Item
    {
        //? Files
        private const char DELIMITER = '|';
        private const string DIR = "../../../Items.txt";

        //? Variables
        private static int MaxId = 0;
        public int Id;
        public string Type;
        public string Cut;
        public string Color;
        public string Fabric;
        public string Size;
        public string Brand;
        public double BasePrice;
        public double? Surcharge;

        //? All items
        public static Dictionary<int, Item> Items = new Dictionary<int, Item>();

        //? Input
        public Item(string Type, string Cut,
                    string Color, string Fabric, string Size,
                    string Brand, double BasePrice, double? Surcharge)
        {
            Id = ++MaxId;
            this.Type = Type;
            this.Cut = Cut;
            this.Color = Color;
            this.Fabric = Fabric;
            this.Size = Size;
            this.Brand = Brand;
            this.BasePrice = BasePrice;
            this.Surcharge = Surcharge;
            Items.Add(Id, this);
        }

        //? Output
        public Item(string line)
        {
            string[] data = line.Split(DELIMITER);
            this.Id = int.Parse(data[0]);
            if (MaxId < Id) MaxId = Id;
            this.Type = data[1];
            this.Cut = data[2];
            this.Color = data[3];
            this.Fabric = data[4];
            this.Size = data[5];
            this.Brand = data[6];
            this.BasePrice = double.Parse(data[7]);
            this.Surcharge = double.Parse(data[8]);
            Items.Add(Id, this);
        }

        //? Functions
        //* Default
        public int GetId() { return Id; }
        public string GetType() { return Type; }
        public string GetCut() { return Cut; }
        public string GetColor() { return Color; }
        public string GetFabric() { return Fabric; }
        public string GetSize() { return Size; }
        public string GetBrand() { return Brand; }
        public double GetBasePrice() { return BasePrice; }
        public double GetSurcharge()
        {
            if (Surcharge == null) return 0;
            else return (double)Surcharge;
        }
        public double GetPrice()
        {
            if (Surcharge == null) return BasePrice;
            else return BasePrice + (double)Surcharge;
        }

        //* Saving and loading
        private string SaveConstruct()
        {
            return GetId().ToString() + DELIMITER + GetType() + DELIMITER + GetCut() + DELIMITER +
                 GetColor() + DELIMITER + GetFabric() + DELIMITER + GetSize() + DELIMITER +
                 GetBrand() + DELIMITER + GetBasePrice() + DELIMITER + GetSurcharge();
        }
        public static void SaveItems()
        {
            if (!File.Exists(DIR)) File.WriteAllText(Item.DIR, string.Empty);
            StreamWriter sw = new StreamWriter(DIR);
            foreach (Item item in Items.Values)
                sw.WriteLine(item.SaveConstruct());

            sw.Close();
        }
        public static void LoadItems()
        {
            if (!File.Exists(DIR)) return;
            string _ItemsReaded = File.ReadAllText(DIR);
            string[] _Items = _ItemsReaded.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in _Items)
            {
                if (string.IsNullOrEmpty(item)) continue;
                new Item(item);
            }
        }

        //* Editing
        public void Delete(int Id)
        { if (Items.ContainsKey(Id)) Items.Remove(Id); }
        public static Item GetItem(int Id)
        {
            if (Items.ContainsKey(Id)) return Items[Id];
            else return null;
        }
    }
}
