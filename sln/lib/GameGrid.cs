namespace lib;

public class GameGrid
{
    /// <summary>
    
    /// </summary>
    private int mSideLength;

    /// <summary>
    /// Gets the side length of the n*n game grid.
    /// </summary>
    public int SideLength
    {
        get { return mSideLength; }
        private set { mSideLength = value; }
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sideLength"></param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public GameGrid(int sideLength)
    {
        if (sideLength <= 0) throw new ArgumentOutOfRangeException("sideLength", "sideLength must be positive.");
        
        this.SideLength = sideLength;
    }
}