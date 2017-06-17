using VkMirea.Model.ElementsParameters;

namespace VkMirea.Model.Elements
{
    public interface IElement
    {
        string Key { get; set; }
        InteractiveType InteractiveType { get; set; }
        int PosX { get; set; }
        int PosY { get; set; }
        int Width { get; set; }
        int Height { get; set; }
    }
}