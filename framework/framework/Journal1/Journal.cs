using System.Collections.Generic;

namespace framework.Journal1
{
    class Journal
    {
        string Name { get; set; }
        public Navigation Navigation;


        public Journal(string name, Navigation navigation)
        {
            name = Name;
            navigation = Navigation;
        }
        public string Name1()
        {
            return Name;
        }

    }
}
