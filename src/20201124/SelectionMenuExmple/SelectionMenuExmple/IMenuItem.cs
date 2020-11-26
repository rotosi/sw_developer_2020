namespace SelectionMenuExmple
{  
    public interface IMenuItem
    {
      string Description { get; }
      char Code { get; }


      void Display(int width);
    }
  }
