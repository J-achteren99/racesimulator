using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Track
    {
        public string Name { get; set; }
        public LinkedList<Section> Sections = new LinkedList<Section>();


        public Track(string name, SectionTypes[] sections)
        {
            Name = name;

            foreach (SectionTypes section in sections)
            {
                Sections.AddLast(new Section() { SectionType = section });
            }
        }
    }
}
