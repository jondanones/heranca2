using exercHeranca2.Entities;

List<TaxPayer> taxPayers = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data:");
    Console.Write("Individual or company (i/c)? ");
    char type = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine());
    if (type == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine());
        taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
    }
    else
    {
        Console.Write("Number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine());
        taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
    }
}
Console.WriteLine();
double sum = 0.0;

Console.WriteLine("TAXES PAID:");
foreach (TaxPayer t in taxPayers)
{
    double tax = t.Tax();
    Console.WriteLine(t.Name + ": $ " + tax.ToString("F2"));
    sum += tax;
}

Console.WriteLine();
Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2"));