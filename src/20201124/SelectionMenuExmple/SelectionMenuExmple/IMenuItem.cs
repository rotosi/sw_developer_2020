namespace SelectionMenuExmple
{  
    public interface IMenuItem
    {
      string Description { get; }// kein implementierung, es immer public in clase abstract
      char Code { get; }


      void Display(int width);
    }
  }
