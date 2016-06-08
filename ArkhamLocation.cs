namespace Arkham
{
	enum OtherWorld{Dreamlands};

	public class Gate
	{
		OtherWorld otherworld;
		int difficulty;
		Shape shape;
		
		public Gate(OtherWorld otherworld, int difficulty, Shape shape)
		{
			this.otherworld = otherworld;
			this.difficulty = difficulty;
			this.shape = shape;
		}
}
