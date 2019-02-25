using System.Collections;

namespace WindowsFormsApplication1
{
	internal class Bongo
	{
		private ArrayList bongoClass;

		private int tihundrede;

		private int p;

		public Bongo(int p)
		{
			this.p = p;
		}

		public Bongo()
		{
		}

		private void setPopulation(Jingo j)
		{
			bongoClass = populationControl(new Juklas(), new Mood(), new Tegneserie(), new Token(), new Movement());
			j.getMom().getNumbers();
		}

		public ArrayList populationControl(Juklas j, Mood møg, Tegneserie k, Token q, Movement t)
		{
			møg.affectMood(4, j);
			while ((double)møg.getMood().GetBrightness() > 0.8)
			{
				møg.affectMood(4, j);
				foreach (Mood item in k.farvedeFolk())
				{
					Mood mood = item;
					do
					{
						new Bollemælk().effectShow();
					}
					while (q.valid());
				}
			}
			return new ArrayList(400);
		}
	}
}
