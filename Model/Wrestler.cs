namespace FantasyWrestlingGenerator.Model {
    internal class Wrestler {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? NickName { get; set; }

        public string? WeightClass { get; set; }

        public int BaseStamina { get; set; }

        public bool IsAlive { get; set; }
    }
}
