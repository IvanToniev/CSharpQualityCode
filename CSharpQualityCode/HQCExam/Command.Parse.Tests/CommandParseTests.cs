using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Command;

namespace Command.Parse.Tests
{
    [TestClass]
    public class CommandParseTests
    {
        [TestMethod]
        public void AddEventByDateTitleCommandNameTest()
        {
            string command = "AddEvent 2012-01-21T20:00:00 | party Viki";
            CalendarSystem.Command commandToAssert;
            commandToAssert.CommandName = "AddEvent";
            commandToAssert.CommandArguments = new string[] { "2012-01-21T20:00:00", "party Viki"};
            Assert.AreEqual(commandToAssert.CommandName, CalendarSystem.Command.Parse(command).CommandName);
            
        }

        [TestMethod]
        public void AddEventByDateTitleLocationCommandNameTest()
        {
            string command = "AddEvent 2012-01-21T20:00:00 | party Viki | home";
            CalendarSystem.Command commandToAssert;
            commandToAssert.CommandName = "AddEvent";
            commandToAssert.CommandArguments = new string[] { "2012-01-21T20:00:00", "party Viki", "home" };
            Assert.AreEqual(commandToAssert.CommandName, CalendarSystem.Command.Parse(command).CommandName);
        }

        [TestMethod]
        public void AddEventByDateTitleLocationCommandArgumentsTest()
        {
            string command = "AddEvent 2012-01-21T20:00:00 | party Viki | home";
            CalendarSystem.Command commandToAssert;
            commandToAssert.CommandName = "AddEvent";
            commandToAssert.CommandArguments = new string[] { "2012-01-21T20:00:00", "party Viki", "home" };
            Assert.AreEqual(commandToAssert.CommandArguments, CalendarSystem.Command.Parse(command).CommandArguments);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void AddEventByOnlyNameOfCommandTest()
        {
            string command = "AddEvent";
            CalendarSystem.Command commandToAssert;
            commandToAssert.CommandName = "AddEvent";
            //commandToAssert.CommandArguments = new string[] {};
            Assert.AreEqual(commandToAssert.CommandName, CalendarSystem.Command.Parse(command).CommandName);
        }

        [TestMethod]
        public void EndCommandParseTest()
        {
            string command = "End";
            CalendarSystem.Command commandToAssert;
            commandToAssert.CommandName = "End";
            commandToAssert.CommandArguments = null;
            Assert.AreEqual(commandToAssert, CalendarSystem.Command.Parse(command));
        }

        [TestMethod]
        public void InvalidArgumentIndexTest()
        {
            string command = "AddEvent2012-01-21T20:00:00 | party Viki | home";
            CalendarSystem.Command commandToAssert;
            commandToAssert.CommandName = "AddEvent";
            commandToAssert.CommandArguments = new string[] { "2012-01-21T20:00:00", "party Viki", "home" };
            Assert.AreEqual(commandToAssert.CommandName, CalendarSystem.Command.Parse(command).CommandName);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void ParseNullTest()
        {
            string command = null;
            CalendarSystem.Command cmdToAssert;
            cmdToAssert.CommandName = null;
            Assert.AreEqual(cmdToAssert.CommandName, CalendarSystem.Command.Parse(command).CommandName);
        }

        [TestMethod]
        public void ParseWithInvalidDateTest()
        {
            string command = "AddEvent 2012-1-1T1:1:1 | party Viki | home";
            CalendarSystem.Command commandToAssert;
            commandToAssert.CommandName = "AddEvent";
            commandToAssert.CommandArguments = new string[] { "2012-1-1T1:1:1", "party Viki", "home" };
            Assert.AreEqual(commandToAssert.CommandArguments[0], CalendarSystem.Command.Parse(command).CommandArguments[0]);
        }
    }
}
