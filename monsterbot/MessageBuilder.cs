namespace monsterbot
{
  using NetCord;
  using NetCord.Rest;

  public static class MessageBuilder
  {
    public static string CreateSaleMessage()
    {
      var data = KupiData.GetMonsterSales();

      string saleText = "";

      for (int i = 0; i <= data.Shops.Count - 1; i++)
      {
        saleText += $" \n - {data.Shops[i]} {data.Prices[i]}, {data.Amounts[i]}, {data.Validities[i]} "; 
      }
      
      return saleText;
    }
  }
}
