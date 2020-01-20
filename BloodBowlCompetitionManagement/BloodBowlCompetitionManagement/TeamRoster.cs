namespace VetryaBloodBowl.DAL
{
    internal class TeamRoster
    {
        public int ID { get; set; }
        public object Race { get; set; }
        public int RerollQuantity { get; set; }
        public int RerollCost { get; set; }
        public string SpecialRules { get; set; }
    }
}