namespace SelectionMenuExample.Items
{
    public interface IMenuItemWithUpdatebleSelectable<T> : IMenuItem<T>
    {
        void UpdateSelectable(bool newValue);
    }
}