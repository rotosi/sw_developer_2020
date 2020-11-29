using System;


namespace SelectionMenuExample.Items
{
    public class MenuItem : IMenuItem
    {
        private string _description;
        private ConsoleKey _code;

        public MenuItem(string description, ConsoleKey code)
        {
            _description = description;
            _code = code;
        }

        public string Description
        {
            get { return _description; }
        }

        public ConsoleKey Code
        {
            get { return _code; }
        }

        public bool Selectable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Visible { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual void Display(int width)
        {
            //Daten laden...............L
            //Program beenden...........Q
            Console.WriteLine($"{_description} {new string('.', width - _description.Length)} {_code}");
        }
    }
}

//da igual como se inicialize con este ToLower se convierte a lo que se necesita

