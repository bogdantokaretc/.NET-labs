class ChessPiece
{
    public virtual bool CanMove(string currentPosition, string newPosition)
    {
        return false;
    }
    protected void PositionDiff(out int colDiff, out int rowDiff, string currentPosition, string newPosition)
    {
        int currentCol = currentPosition[0] - 'a';
        int currentRow = int.Parse(currentPosition[1].ToString()) - 1;

        int newCol = newPosition[0] - 'a';
        int newRow = int.Parse(newPosition[1].ToString()) - 1;

        colDiff = Math.Abs(newCol - currentCol);
        rowDiff = Math.Abs(newRow - currentRow);
    }
}

class Knight : ChessPiece
{
    public override bool CanMove(string currentPosition, string newPosition)
    {
        // Knight's move logic
        // Knights move in an L-shape: 2 squares in one direction and 1 square in the other
        PositionDiff(out int colDiff, out int rowDiff, currentPosition, newPosition);

        if ((rowDiff == 2 && colDiff == 1) || (rowDiff == 1 && colDiff == 2))
        {
            Console.WriteLine("Knight can move to the new position.");
            return true;
        }
        Console.WriteLine("Knight cannot move to the new position.");
        return false;
        
    }
}

class Bishop : ChessPiece
{
    public override bool CanMove(string currentPosition, string newPosition)
    {
        // Bishop's move logic
        // The bishop can move diagonally if the column difference equals the row difference
        PositionDiff(out int colDiff, out int rowDiff, currentPosition, newPosition);

        if (colDiff == rowDiff)
        {
            Console.WriteLine("Bishop can move to the new position.");
            return true;
        }
        Console.WriteLine("Bishop cannot move to the new position.");
        return false;
    }
}

class Rook : ChessPiece
{
    public override bool CanMove(string currentPosition, string newPosition)
    {
        // Rook's move logic
        PositionDiff(out int colDiff, out int rowDiff, currentPosition, newPosition);

        if (colDiff == 0 || rowDiff == 0)
        {
            Console.WriteLine("Rook can move to the new position.");
            return true;
        }
        Console.WriteLine("Rook cannot move to the new position.");
        return false;
        
    }
}

class Queen : ChessPiece
{
    public override bool CanMove(string currentPosition, string newPosition)
    {
        // Queen's move logic
        PositionDiff(out int colDiff, out int rowDiff, currentPosition, newPosition);

        if (colDiff == 0 || rowDiff == 0 || colDiff == rowDiff)
        {
            Console.WriteLine("Queen can move to the new position.");
            return true;
        }
        Console.WriteLine("Queen cannot move to the new position.");
        return false;

    }
}

class Program
{
    static void Main(string[] args)
    {
        ChessPiece[] pieces = new ChessPiece[]
        {
            new Knight(),
            new Bishop(),
            new Rook(),
            new Queen()
        };

        string currentPosition = "a1";
        string newPosition = "h8";
        Console.WriteLine($"Current Position:{currentPosition} New Position:{newPosition}");

        foreach (var piece in pieces)
        {
            piece.CanMove(currentPosition, newPosition);
        }
        Console.ReadKey();
    }
}
