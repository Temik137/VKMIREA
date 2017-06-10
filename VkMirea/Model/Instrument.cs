using System.Windows.Controls;

namespace VkMirea.Model
{
    public class Instrument
    {
        public Instrument(string name, string imagePath)
        {
            Name = name;
            ImagePath = imagePath;
        }
        public string Name { get; set; }
        public string ImagePath { get; set; }
    }
}