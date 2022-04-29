using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace UnitTests
{
    [TestClass]
    public class SetCurrentThermostatTests
    {
        [TestMethod]
        public void IsInPeriodTest()
        {
            var today = new DateTime(2022, 2, 20);



            Assert.IsTrue(NetDaemon3Apps.SetCurrentThermostat.IsInPeriod(
new System.DateTime(today.Year, today.Month, today.Day, 20, 10, 0), "20:10", "01:00"));

            Assert.IsTrue(NetDaemon3Apps.SetCurrentThermostat.IsInPeriod(
new System.DateTime(today.Year, today.Month, today.Day, 20, 10, 1), "20:10", "01:00"));


            Assert.IsFalse(NetDaemon3Apps.SetCurrentThermostat.IsInPeriod(
new System.DateTime(today.Year, today.Month, today.Day, 19, 59, 0), "20:10", "01:00"));

            Assert.IsFalse(NetDaemon3Apps.SetCurrentThermostat.IsInPeriod(
new System.DateTime(today.Year, today.Month, today.Day, 19, 59, 59), "20:10", "01:00"));




            Assert.IsTrue(NetDaemon3Apps.SetCurrentThermostat.IsInPeriod(
new System.DateTime(today.Year, today.Month, today.Day, 0, 59, 59), "20:10", "01:00"));

            Assert.IsFalse(NetDaemon3Apps.SetCurrentThermostat.IsInPeriod(
new System.DateTime(today.Year, today.Month, today.Day, 1, 1, 0), "20:10", "01:00"));

            Assert.IsFalse(NetDaemon3Apps.SetCurrentThermostat.IsInPeriod(
new System.DateTime(today.Year, today.Month, today.Day, 1, 1, 10), "20:10", "01:00"));

            Assert.IsFalse(NetDaemon3Apps.SetCurrentThermostat.IsInPeriod(
new System.DateTime(today.Year, today.Month, today.Day, 1, 2, 0), "20:10", "01:00"));



        }
    }
}