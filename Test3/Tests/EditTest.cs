using System;
using System.Threading;
using NUnit.Framework;

namespace Test3
{
    [TestFixture]
    class N3EditTest : TestBase
    {
        [Test]
        public void EditTest()
        {
            var rnd = new Random(DateTime.Now.Second);
            var text = rnd.Next().ToString();
            app.Note.WriteNote(text);
            Thread.Sleep(5000);

            var actualtext = app.Note.GetNoteTitle();
            Assert.AreEqual(text, actualtext.Substring(actualtext.Length - text.Length));
        }
    }
}
