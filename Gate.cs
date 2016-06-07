namespace Arkham
{
	enum OtherWorld{Dreamlands};

	public class Gate
	{
		OtherWorld otherworld;
		int difficulty;
		String shape; // Should be a enum shared with Monsters
		
		public Gate(OtherWorld otherworld, int difficulty, String shape)
		{
			this.otherworld = otherworld;
			this.difficulty = difficulty;
			this.shape = shape;
		}
}
