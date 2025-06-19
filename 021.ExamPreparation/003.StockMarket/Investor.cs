using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace StockMarket;

public class Investor
{
    private string fullName;
    private string emailAddress;
    private decimal moneyToInvest;
    private string brokerName;
    private List<Stock> portfolio;

    public string FullName { get; set; }
    public string EmailAddress { get; set; }
    public decimal MoneyToInvest { get; set; }
    public string BrokerName { get; set; }
    public List<Stock> Portfolio { get; set; }
    public int Count
    {
        get { return portfolio.Count; }
    }

    public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
    {
        this.FullName = fullName;
        this.EmailAddress = emailAddress;
        this.MoneyToInvest = moneyToInvest;
        this.BrokerName = brokerName;
        this.portfolio = new List<Stock>();
    }

    public void BuyStock(Stock stock)
    {
        if(stock.MarketCapitalization >= 10000 && this.MoneyToInvest >= stock.PricePerShare)
        {
            this.MoneyToInvest -= stock.PricePerShare;
            this.portfolio.Add(stock);
        }
    }

    public string SellStock(string companyName, decimal sellPrice)
    {
        foreach (var item in this.portfolio)
        {
            if(item.CompanyName == companyName)
            {
                if(sellPrice < item.PricePerShare)
                {
                    return $"Cannot sell {companyName}.";
                }
                else
                {
                    this.portfolio.Remove(item);
                    this.MoneyToInvest += sellPrice;
                    return $"{companyName} was sold.";
                }
            }
        }

        return $"{companyName} does not exist.";
    }

    public Stock FindStock(string companyName)
    {
        foreach(var item in this.portfolio)
        {
            if(companyName == item.CompanyName)
            {
                return item;
            }
        }

        return null;
    }

    public Stock FindBiggestCompany()
    {
        return this.portfolio.OrderBy(x => -x.MarketCapitalization).FirstOrDefault();
    }

    public string InvestorInformation()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"The investor {this.FullName} with a broker {this.BrokerName} has stocks:");

        foreach(var item in this.portfolio)
        {
            sb.AppendLine(item.ToString());
        }

        return sb.ToString();
    }
}