namespace FantasyWrestlingGenerator.Model {
    internal class Move {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int BaseWeight { get; set; }

        public string Type { get; set; } = null!;

        public int Damage { get; set; }

        public int? Wrestler_ID { get; set; }
    }
}
