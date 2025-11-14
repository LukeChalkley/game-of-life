namespace lib;

/// <summary>
/// 
/// </summary>
public class Game
{
    /// <summary>
    /// 
    /// </summary>
    private GameGrid mGameGrid;

    /// <summary>
    /// Initialises a new game with a square grid with the supplied sideLength.
    /// </summary>
    /// <param name="sideLength">The side length of square grid.</param>
    public Game(int sideLength)
    {
        if (sideLength <= 0) throw new ArgumentOutOfRangeException("sideLength", "sideLength must be positive");
        
        mGameGrid = new GameGrid(sideLength);
    }
}