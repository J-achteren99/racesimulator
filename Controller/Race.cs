using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    public class Race
    {
        private Random _random;
        private Dictionary<Section, SectionData> _positions;

        public Track Track { get; set; }
        public List<IParticipant> Participants { get; set; }
        public DateTime StartTime { get; set; }


        public Race(Track track, List<IParticipant> participants)
        {
            Track = track;
            Participants = participants;

            _random = new Random(DateTime.Now.Millisecond);
            RandomizeEquipment();
        }

        public SectionData GetSectionData(Section section)
        {
            if (_positions[section] != null)
            {
                return _positions[section];
            }
            else
            {
                return new SectionData();
            }
            
        }

        public void RandomizeEquipment()
        {
            foreach(IParticipant participant in Participants)
            {
                participant.Equipment.Quality = _random.Next(101);
                participant.Equipment.Performance = _random.Next(101);
            }
        }
    }
}
