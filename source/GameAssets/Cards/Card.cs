using System;

namespace AmaruCommon.GameAssets.Cards
{
    [Serializable]
    public abstract class Card
    {
        // Static stuff for auto id
        private static int _absoluteId = 0;
        private static int NextId { get => _absoluteId++;}

        // Properties
        public int Id { get; private set; }
        public int Cost { get; private set; }
        public string Name { get; private set; }

        protected Card (int id, string name, int cost)
        {
            if (id < 0)
                this.Id = NextId;
            else
                this.Id = id;
            this.Cost = cost;
            this.Name = name;
        }
    }
}
