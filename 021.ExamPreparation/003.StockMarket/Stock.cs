namespace StockMarket;

public class Stock
{
    private string companyName;
    private string director;
    private decimal pricePerShare;
    private int totalNumberOfShare;
    private decimal marketCapitalization;

    public string CompanyName { get; set; }
    public string Director { get; set; }
    public decimal PricePerShare { get; set; }
    public int TotalNumberOfShare { get; set; }
    public decimal MarketCapitalization { get => marketCapitalization; set => marketCapitalization = value; }

    public Stock(string companyName, string director, decimal pricePerShare, int totalNumberOfShare)
    {
        this.CompanyName = companyName;
        this.Director = director;
        this.PricePerShare = pricePerShare;
        this.TotalNumberOfShare = totalNumberOfShare;
        this.MarketCapitalization = pricePerShare * totalNumberOfShare;
    }

    public override string ToString()
    {
        string result = $"Company: {this.CompanyName}{Environment.NewLine}"
            + $"Director: {this.Director}{Environment.NewLine}"
            + $"Price per share: ${this.PricePerShare}{Environment.NewLine}"
            + $"Market capitalization: ${this.MarketCapitalization}{Environment.NewLine}";

        return result;
    }
}