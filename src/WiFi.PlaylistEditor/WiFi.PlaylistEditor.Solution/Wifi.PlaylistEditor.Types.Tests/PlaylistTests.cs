using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.Types.Tests
{

    [TestFixture]
    public class PlaylistTests
    {
        //no olvidar ir a references del este projecto y refereciar el proyecto como se ha hecho en los otros
        private IPlaylist _fixture;

        [Test]
        public void GetCount()
        {
            //arrange
            _fixture = new Playlist("TestPlaylist", "Ganfalf", DateTime.Now);

            var mockedItem1 = new Mock<IPlaylistItems>();
            var mockedItem2 = new Mock<IPlaylistItems>();

            _fixture.Add(mockedItem1.Object); //un objeto de la clase IplaylistItems
            _fixture.Add(mockedItem2.Object);

            //act
            var count = _fixture.Count;

            //assert
            Assert.That(count, Is.EqualTo(2));
        }
        [Test]
        public void GetDuration()
        {

            //arrange
            _fixture = new Playlist("TestPlaylist", "Ganfalf", DateTime.Now);

            var mockedItem1 = new Mock<IPlaylistItems>();
            mockedItem1.Setup(x => x.Duration).Returns(TimeSpan.FromSeconds(5));//lambda expresion sirve para simular la duracion con ayuda del mocked

            var mockedItem2 = new Mock<IPlaylistItems>();
            mockedItem2.Setup(x => x.Duration).Returns(TimeSpan.FromSeconds(65));

            _fixture.Add(mockedItem1.Object); //un objeto de la clase IplaylistItems
            _fixture.Add(mockedItem2.Object);

            //act
            var duration = _fixture.Duration;

            //assert
            Assert.That(duration, Is.EqualTo(TimeSpan.FromSeconds(70)));           

        }

    }
}
