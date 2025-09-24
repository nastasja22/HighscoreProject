using HighscoreProject.Console;
using Xunit;

public class PlayerTests
{
    [Fact]
    public void TestPlayerCreation_ValidEmail_ShouldCreatePlayer()
    {
        // Arrange
        string firstName = "John";
        string lastName = "Doe";
        string username = "johndoe";
        string email = "johndoe1@gmail.com";
        // Act
        Player player = new Player(firstName, lastName, username, email);
        // Assert
        Assert.Equal(email, player.GetEmail());
    }

    [Fact]
    public void TestPlayerCreation_NonValidEmail_ShouldThrowArgumentException()
    {
        // Arrange
        string firstName = "John";
        string lastName = "Doe";
        string username = "johndoe";
        string email = "johndoe1gmail.com";

        // Assert
        Assert.Throws<ArgumentException>(() => new Player(firstName, lastName, username, email));
    }

    [Fact]
    public void TestSetEmail_ValidEmail_ShouldUpdateEmail()
    {
        // Arrange
        string firstName = "John";
        string lastName = "Doe";
        string username = "johndoe";
        string email = "johndoe1@gmail.com";
        string email2 = "johndoe2@gmail.com";

        // Act
        Player player = new Player(firstName, lastName, username, email);

        player.SetEmail(email2);
        // Assert
        Assert.Equal(email2, player.GetEmail());
    }

    [Fact]
    public void TestSetEmail_NonValidEmail_ShouldThrowArgumentException()
    {
        // Arrange
        string firstName = "John";
        string lastName = "Doe";
        string username = "johndoe";
        string email = "johndoe1@gmail.com";
        string email2 = "johndoe2gmail.com";

        Player player = new Player(firstName, lastName, username, email);

        // Assert
        Assert.Throws<ArgumentException>(() => player.SetEmail(email2));
    }
}