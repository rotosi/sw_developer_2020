using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.Items.Tests
{
    public class Mp3ItemTests
    {
        [TestFixture]

        public class Mp3ItemTest
        {

            private IPlaylistItems _fixture;

            [SetUp]
            public void TestInit()
            {
                _fixture = new Mp3Item(@"C:\Users\user\Documents\TestMediaFiles\001 - Bruno Mars - Grenade.mp3");
            }

            [Test]
            public void GetTitle()
            {
                //todo test debe tener esta estructura arrange, act, assert
                //arrange
                // se usa @para que interprete el \ o se hace con doble\\
               // _fixture = new Mp3Item(@"C:\Users\user\Documents\TestMediaFiles\001 - Bruno Mars - Grenade.mp3"); tenemos el SetUp

                //act
                var title = _fixture.Title;

                //assert
                Assert.That(title, Is.Not.Null);
                Assert.That(title, Is.EqualTo("Grenade"));
            }

            [Test]
            public void GetDuration()
            {
                //todo test debe tener esta estructura arrange, act, assert
                //arrange
                // se usa @para que interprete el \ o se hace con doble
                //_fixture = new Mp3Item(@"C:\Users\user\Documents\TestMediaFiles\001 - Bruno Mars - Grenade.mp3"); tenemos el SetUp

                //act
                var duration = _fixture.Duration;

                //assert                
                Assert.That(duration, Is.EqualTo(TimeSpan.FromSeconds(222.188)));
            }

            [Test]
            public void GetArtist()
            {
                //todo test debe tener esta estructura arrange, act, assert
                //arrange
                // se usa @para que interprete el \ o se hace con doble
                // _fixture = new Mp3Item(@"C:\Users\user\Documents\TestMediaFiles\001 - Bruno Mars - Grenade.mp3"); tenemos el SetUp

                //act
                var artist = _fixture.Artist;

                //assert                
                Assert.That(artist, Is.EqualTo("Bruno Mars"));
            }

            [Test]
            public void GetPath()
            {
                //todo test debe tener esta estructura arrange, act, assert
                //arrange
                // se usa @para que interprete el \ o se hace con doble
                var demoMp3Path = @"C:\Users\user\Documents\TestMediaFiles\001 - Bruno Mars - Grenade.mp3";
                _fixture = new Mp3Item(demoMp3Path);
                //act
                var path = _fixture.Path;

                //assert                
                Assert.That(path, Is.EqualTo(demoMp3Path));
            }


            [Test]
            public void GetThumbnail()
            {
                //todo test debe tener esta estructura arrange, act, assert
                //arrange
                // se usa @para que interprete el \ o se hace con doble
                var demoMp3Path = @"C:\Users\user\Documents\TestMediaFiles\001 - Bruno Mars - Grenade.mp3";
                _fixture = new Mp3Item(demoMp3Path);
                //act
                var thumbnail = _fixture.Thumbnail;

                //assert                
                Assert.That(thumbnail, Is.Not.Null);
            }


            [Test]
            public void GetThumbnail_WithMp3FileWitNoImage()
            {
                //todo test debe tener esta estructura arrange, act, assert
                //arrange
                // se usa @para que interprete el \ o se hace con doble
                var demoMp3Path = @"C:\Users\user\Documents\TestMediaFiles\001 - Bruno Mars - Grenade.mp3";
                _fixture = new Mp3Item(demoMp3Path);
                //act
                var thumbnail = _fixture.Thumbnail;

                //assert                
                Assert.That(thumbnail, Is.Null);
            }


            [Test]
            public void GetTitle_FilePathIsNull()
            {
                //todo test debe tener esta estructura arrange, act, assert
                //arrange
                // se usa @para que interprete el \ o se hace con doble
                _fixture = new Mp3Item(String.Empty);

                //act
                var title = _fixture.Title;

                //assert                
                Assert.That(title, Is.EqualTo("--[File not found]--"));
            }

            [Test]
            public void GetTitle_FilePathNotExists()
            {
                //todo test debe tener esta estructura arrange, act, assert
                //arrange
                // se usa @para que interprete el \ o se hace con doble
                _fixture = new Mp3Item(@"C:\Users\user\TestMediaFiles\001 - Bruno Mars - Grenade.mp3");

                //act
                var title = _fixture.Title;

                //assert                
                Assert.That(title, Is.EqualTo("--[File not found]--"));
            }

            [Test]
            public void GetTitle_FilePathEmpty()
            {
                //todo test debe tener esta estructura arrange, act, assert
                //arrange
                // se usa @para que interprete el \ o se hace con doble
                _fixture = new Mp3Item(@"C:\Users\user\Documents\TestMediaFiles\001 - Bruno Mars - Grenade.mp3");

                //act
                var title = _fixture.Title;

                //assert                
                Assert.That(title, Is.EqualTo("--[File not found]--"));
            }
        }
    }
}
