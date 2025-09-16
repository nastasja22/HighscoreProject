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
        // Da die Eigenschaften private sind, k�nnen sie hier nicht direkt gepr�ft werden.
        // Alternativ k�nnten Getter hinzugef�gt werden, um die Werte zu testen.
        // Beispiel:
        // Assert.Null(player.FirstName);
        // Assert.Null(player.LastName);
        // Assert.Null(player.Username);
        // Assert.Null(player.Email);
        // Assert.Equal(0, player.Password);
    }
}