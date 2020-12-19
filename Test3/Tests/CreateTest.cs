using System.Threading;
using NUnit.Framework;

namespace Test3
{
    [TestFixture]
    class N2CreateTest : TestBase
    {
        [Test]
        public void CreateTest()
        {
            var note = "Заметка";
            app.Note.CreateNote();
            app.Note.WriteNote(note);
            Thread.Sleep(5000);
            
            Assert.AreEqual(note, app.Note.GetNoteTitle());
        }
    }
}
