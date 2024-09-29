namespace exercHeranca2.Entities
{
    abstract class TaxPayer
    {
        public String Name { get; set; }
        public Double AnualIncome { get; set; }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
