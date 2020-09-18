using Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace ControllerTest
{
    [TestFixture]
    class Model_Competition_NextTrackShould
    {
        private Competition _competition;


        [SetUp]
        public void SetUp()
        {
            _competition = new Competition();
        }

        [Test]
        public void NextTrack_EmptyQueue_ReturnNull()
        {
            Track result = _competition.NextTrack();
            Assert.IsNull(result);
        }

        [Test]
        public void NextTrack_OneInQueue_ReturnTrack()
        {
            SectionTypes[] TestTrack = {
                SectionTypes.StartGrid,
                SectionTypes.RightCorner,
                SectionTypes.LeftCorner,
                SectionTypes.Finish
            };
            Track track = new Track("Test track", TestTrack);
            _competition.Tracks.Enqueue(track);

            Track result = _competition.NextTrack();
            Assert.AreEqual(track, result);
        }

        [Test]
        public void NextTrack_OneInQueue_RemoveTrackFromQueue()
        {
            SectionTypes[] TestTrack = {
                SectionTypes.StartGrid,
                SectionTypes.RightCorner,
                SectionTypes.LeftCorner,
                SectionTypes.Finish
            };
            Track track = new Track("Test track", TestTrack);
            _competition.Tracks.Enqueue(track);
            Track result = _competition.NextTrack();
            result = _competition.NextTrack();
            Assert.IsNull(result);
        }

        [Test]
        public void NextTrack_TwoInQueue_ReturnNextTrack()
        {
            SectionTypes[] TestTrack1 = {
                SectionTypes.StartGrid,
                SectionTypes.RightCorner,
                SectionTypes.LeftCorner,
                SectionTypes.Finish
            };

            SectionTypes[] TestTrack2 = {
                SectionTypes.StartGrid,
                SectionTypes.RightCorner,
                SectionTypes.RightCorner,
                SectionTypes.LeftCorner,
                SectionTypes.Finish
            };

            Track track1 = new Track("Test track 1", TestTrack1);
            _competition.Tracks.Enqueue(track1);

            Track track2 = new Track("Test track 2", TestTrack2);
            _competition.Tracks.Enqueue(track2);

            Track result1 = _competition.NextTrack();
            Track result2 = _competition.NextTrack();

            Assert.AreEqual(result1, track1);
            Assert.AreEqual(result2, track2);
        }
    }
}
