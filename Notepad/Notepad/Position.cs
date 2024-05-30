namespace Notepad
{
	public class Position
	{
		public int Line;
		public int Col;
		public int Pos;

		public Position(int line, int col, int position)
		{
			this.Line = line;
			this.Col = col;
			this.Pos = position;
		}
	}
}