using System.Drawing;

namespace PolymorphismLab
{
    internal class NextParty : Party
    {
        private int lastSize;

        public NextParty(string name, int size, double lastVotes, int lastSize) : base(name, size, lastVotes)
        {
            this.lastSize = lastSize;
        }

        public int LastSize
        {
            get => lastSize;
            set
            {
                if (value >= 0)
                {
                    lastSize = value;
                }
            }
        }

        public override double Quality()
        {
            if (Size > lastSize)
            {
                return base.Quality() * 1.2;
            } else
            {
                return base.Quality() * 0.8;
            }
            
        }
    }
}
