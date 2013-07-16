using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;
using EventMultyDict = Wintellect.PowerCollections.MultiDictionary<string, CalendarSystem.Event>;
namespace Command.Parse.Tests
{
    [TestClass]
    public class EventsManagerFastTests
    {
        #region Test AddEvent method
        [TestMethod]
        public void AddEventTestWith1Event() 
        {
            CalendarSystem.Event testEvent = new CalendarSystem.Event();
            testEvent.EventTitle = "some title";
            testEvent.EventDate = DateTime.Parse("2012-01-21T20:00:00");
            CalendarSystem.EventsManagerFast evManager = new CalendarSystem.EventsManagerFast();
            evManager.AddEvent(testEvent);
            Assert.AreEqual(1, evManager.EventsByDates.Count);
            Assert.AreEqual(1, evManager.EventsByTitles.Count);
        }


        [TestMethod]
        public void AddEventTestWith2Events()
        {
            CalendarSystem.Event testEvent = new CalendarSystem.Event();
            testEvent.EventTitle = "some title";
            testEvent.EventDate = DateTime.Parse("2012-01-21T20:00:00");
            CalendarSystem.EventsManagerFast evManager = new CalendarSystem.EventsManagerFast();
            evManager.AddEvent(testEvent);
            CalendarSystem.Event testEvent2 = new CalendarSystem.Event();
            testEvent2.EventTitle = "some other title";
            testEvent2.EventDate = DateTime.Parse("2012-01-21T20:00:00");
            evManager.AddEvent(testEvent2);
            Assert.AreEqual(2, evManager.EventsByTitles.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void AddEventNullEventNameTest()
        {
            CalendarSystem.Event testEvent = new CalendarSystem.Event();
            testEvent.EventTitle = null;
            testEvent.EventDate = DateTime.Parse("2012-01-21T20:00:00");
            CalendarSystem.EventsManagerFast evManager = new CalendarSystem.EventsManagerFast();
            evManager.AddEvent(testEvent);
            Assert.AreEqual(1, evManager.EventsByDates.Count);
            Assert.AreEqual(1, evManager.EventsByTitles.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void AddEventBadDateTest()
        {
            CalendarSystem.Event testEvent = new CalendarSystem.Event();
            testEvent.EventTitle = "some title";
            testEvent.EventDate = DateTime.Parse("2012-1-1T1:1:1");
            CalendarSystem.EventsManagerFast evManager = new CalendarSystem.EventsManagerFast();
            evManager.AddEvent(testEvent);
            Assert.AreEqual(1, evManager.EventsByDates.Count);
            Assert.AreEqual(1, evManager.EventsByTitles.Count);
        }
        #endregion
        #region Test DeleteEventsByTitle method

        [TestMethod]
        public void DeleteEventsByTitleWithOneEventTest() 
        {
            CalendarSystem.Event testEvent = new CalendarSystem.Event();
            testEvent.EventTitle = "some title";
            testEvent.EventDate = DateTime.Parse("2012-01-21T20:00:00");
            CalendarSystem.EventsManagerFast evManager = new CalendarSystem.EventsManagerFast();
            evManager.AddEvent(testEvent);
            evManager.DeleteEventsByTitle("some title");
            Assert.AreEqual(0, evManager.EventsByTitles.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void DeleteEventsByTitleWithNullTitleTest()
        {
            CalendarSystem.Event testEvent = new CalendarSystem.Event();
            testEvent.EventTitle = null;
            testEvent.EventDate = DateTime.Parse("2012-01-21T20:00:00");
            CalendarSystem.EventsManagerFast evManager = new CalendarSystem.EventsManagerFast();
            evManager.AddEvent(testEvent);
            evManager.DeleteEventsByTitle(null);
            Assert.AreEqual(0, evManager.EventsByTitles.Count);
        }
        #endregion
        #region Test ListEvents method

        [TestMethod]
        public void test()
        {
            CalendarSystem.Event testEvent = new CalendarSystem.Event();
            testEvent.EventTitle = "some title";
            testEvent.EventDate = DateTime.Parse("2012-01-21T20:00:00");
            CalendarSystem.EventsManagerFast evManager = new CalendarSystem.EventsManagerFast();
            evManager.AddEvent(testEvent);
            CalendarSystem.Event testEvent2 = new CalendarSystem.Event();
            testEvent2.EventTitle = "some other title";
            testEvent2.EventDate = DateTime.Parse("2012-01-21T20:00:00");
            evManager.AddEvent(testEvent2);
            evManager.ListEvents(DateTime.Parse("2012-01-21T20:00:00"), 2);
           // Assert.IsTrue(evManager.ListEvents(DateTime.Parse("2012-01-21T20:00:00"), 2) is )
        }

        #endregion
    }
}
