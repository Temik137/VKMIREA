using System.Windows.Controls;
using VkMirea.Model.ElementsParameters;

namespace VkMirea.Model.Elements
{
    public class VkmLamp : IElement, IOnOffElement
    {
        public string Key { get; set; }
        public InteractiveType InteractiveType { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Image ImageOn { get; set; }
        public Image ImageOff { get; set; }
    }
}