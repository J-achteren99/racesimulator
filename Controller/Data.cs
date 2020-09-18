using System;
using Model;

namespace Controller
{
    public static class Data
    {
        public static Competition competition { get; set; }
        public static Race CurrentRace;


        public static void Init()
        {
            competition = new Competition();
            AddParticipant();
            AddTrack();
        }


        public static void NextRace()
        {
            Track newTrack = competition.NextTrack();

            if (newTrack != null)
            {
                CurrentRace = new Race(newTrack, competition.Participants);
            }
            
        }

        public static void AddParticipant()
        {
            //Racekast Jelmar
            competition.Participants.Add(new Driver()
            {
                Name = "Jelmar",
                Points = 0,
                Equipment = new Car()
                {
                    Quality = 100,
                    IsBroken = false,
                    Performance = 100,
                    Speed = 30
                },
                TeamColor = TeamColors.Yellow
            });

            //Raceplank Jan
            competition.Participants.Add(new Driver()
            {
                Name = "Jan",
                Points = 0,
                Equipment = new Car()
                {
                    Quality = 120,
                    IsBroken = false,
                    Performance = 110,
                    Speed = 25
                },
                TeamColor = TeamColors.Blue
            });
        }

        public static void AddTrack()
        {
            SectionTypes[] FranksEmpire = {
                SectionTypes.StartGrid,
                SectionTypes.RightCorner,
                SectionTypes.LeftCorner,
                SectionTypes.Finish
            };
            competition.Tracks.Enqueue(new Track("FranksRoad", FranksEmpire));

            SectionTypes[] FranksEmpire2 = {
                SectionTypes.StartGrid,
                SectionTypes.RightCorner,
                SectionTypes.RightCorner,
                SectionTypes.Finish
            };
            competition.Tracks.Enqueue(new Track("FranksHighway", FranksEmpire2));

        }
    }
}
