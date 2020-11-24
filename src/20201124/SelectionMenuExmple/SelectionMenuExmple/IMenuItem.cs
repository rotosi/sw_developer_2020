namespace SelectionMenuExmple
{
    public class IMenuItem
    {
        string Description { get; }
        char Code{get; }

        void Display(int width);
    }
}