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

      [Test]
      public void GetTitle()
      {
        //todo test debe tener esta estructura arrange, act, assert
        //arrange
        // se usa @para que interprete el \ o se hace con doble
        _fixture = new Mp3Item(@"C:\Users\user\Pictures\TestMediaFiles\001 - Bruno Mars - Grenade.mp3");

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
        _fixture = new Mp3Item(@"C:\Users\user\Pictures\TestMediaFiles\001 - Bruno Mars - Grenade.mp3");

        //act
        var duration = _fixture.Duration;

        //assert                
        Assert.That(duration, Is.EqualTo(TimeSpan.FromSeconds(222.188)));
      }

      [Test]
      public void GetTitle_FilePathIsNull()
      {
        //todo test debe tener esta estructura arrange, act, assert
        //arrange
        // se usa @para que interprete el \ o se hace con doble
        _fixture = new Mp3Item(null);

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
        _fixture = new Mp3Item(@"C:\Users\user\TestMediaFiles\001 - Bruno Mars - Grenade.mp3");

        //act
        var title = _fixture.Title;

        //assert                
        Assert.That(title, Is.EqualTo("--[File not found]--"));
      }
    }
  }
}
