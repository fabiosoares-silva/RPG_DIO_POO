namespace RPG_DIO.src.Entities
{
	public class Black : Hero
	{
		public Black(string Name, int Level, string HeroType)
		{
			this.Name = Name;
			this.Level = Level;
			this.HeroType = HeroType;
		}
		public override string Attack()
		{
			return this.Name + " Lançou magia com fumaça mortal";
		}
	}
}