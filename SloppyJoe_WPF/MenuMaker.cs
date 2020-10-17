using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SloppyJoe_WPF
{
    class MenuMaker
    {
        private Random random = new Random();
        private List<String> meats = new List<String>
        {
            "Roast beef", "Salami", "Turkey", "Ham", "Pastrami"
        };
        private List<String> condiments = new List<String>
        {
            "brown mustard", "honey mustard", "mayo", "relish", "french dressing"
        };
        private List<String> breads = new List<String>
        {
            "pumpernickel", "italian bread", "a roll"
        };
        public ObservableCollection<MenuItem> Menu { get; private set; }
        public DateTime GeneratedDate { get; set; }
        public int NumberOfItems { get; set; }

        public MenuMaker()
        {
            Menu = new ObservableCollection<MenuItem>();
            NumberOfItems = 10;
            UpdateMenu();
        }

        private MenuItem CreateMenuItem()
        {
            string randomMeat = meats[random.Next(meats.Count)];
            string randomCondiment = condiments[random.Next(condiments.Count)];
            string randomBread = breads[random.Next(breads.Count)];
            return new MenuItem(randomMeat, randomCondiment, randomBread);
        }

        public void UpdateMenu()
        {
            Menu.Clear();
            for (int i = 0; i < NumberOfItems; i++)
            {
                Menu.Add(CreateMenuItem());
            }
            GeneratedDate = DateTime.Now;
        }
    }
}
