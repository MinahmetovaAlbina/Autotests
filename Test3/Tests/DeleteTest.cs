using System.Threading;
using NUnit.Framework;

namespace Test3
{
    [TestFixture]
    class N4DeleteTest : TestBase
    {
        [Test]
        public void DeleteTest()
        {
            var note = app.Note.GetNoteTitle();
            app.Note.DeleteNote();
            Thread.Sleep(5000);

            app.Navigate.OpenMenu();
            app.Navigate.OpenTrash();
            var deletedNote = app.Note.GetNoteTitle();

            Assert.AreEqual(note, deletedNote);

            app.Navigate.OpenMenu();
            app.Navigate.OpenAllNotes();
        }
    }
}
