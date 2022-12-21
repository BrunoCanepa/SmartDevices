//--------------------------------------------------------------------------------
// <copyright file="TrainTests.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using AdapterExample;
using NUnit.Framework;

namespace Tests
{
    /// <summary>
    /// Clase de tests
    /// </summary>
    public class SmartDevicesTests
    {
        /// <summary>
        /// Se testea que un Plug es adaptado a ISmartDevice
        /// </summary>
        [Test]
        public void AdapterTest()
        {
            Plug plug = new Plug("1234");
            ISmartDevice SmartPlug = new Adapter(plug);
            SmartPlug.Off();
            SmartPlug.On();
            Assert.AreEqual(SmartPlug.GetStatus(), "on");
        }
    }
}