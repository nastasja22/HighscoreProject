using HighscoreProj;
using Xunit;

public class PlayerTests
{
    [Fact]
    public void DefaultConstructor_CreatesPlayerObject()
    {
        // Arrange & Act
        var player = new Player();

        // Assert
        Assert.NotNull(player);
    }

    [Fact]
    public void DefaultConstructor_PropertiesAreDefault()
    {
        // Arrange
        var player = new Player();

        // Act & Assert
        // Da die Eigenschaften private sind, können sie hier nicht direkt geprüft werden.
        // Alternativ könnten Getter hinzugefügt werden, um die Werte zu testen.
        // Beispiel:
        // Assert.Null(player.FirstName);
        // Assert.Null(player.LastName);
        // Assert.Null(player.Username);
        // Assert.Null(player.Email);
        // Assert.Equal(0, player.Password);
    }
}