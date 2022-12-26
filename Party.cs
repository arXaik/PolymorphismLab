
namespace PolymorphismLab
{
    internal class Party
    {
        private string name;
        private int size;
        private double lastVotes;

        public string Name { get => name; set => name = value; }
        public int Size
        {
            get => size;
            set
            {
                if (value >= 0)
                {
                    size = value;
                }
            }
        }
        public double LastVotes
        {
            get => lastVotes;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    lastVotes = value;
                }
                
            }
        }

        public Party(string name, int size, double lastVotes)
        {
            this.name = name;
            this.size = size;
            this.lastVotes = lastVotes;
        }

        public virtual double Quality()
        {
            return 0.3 * size + 0.7 * lastVotes;
        }
    }
}
