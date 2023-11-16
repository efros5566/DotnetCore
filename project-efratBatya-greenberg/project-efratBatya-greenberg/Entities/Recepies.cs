namespace project_efratBatya_greenberg.Entities
{
    public class Recepies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public bool IsAvailable { get; set; }
        public string Status { get; set; }
        public string[] ProductsArr { get; set; }
        public int[] AmountArr { get; set; }
    }
}
