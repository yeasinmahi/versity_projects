class Sales{

		double totalSaleAmount=0;
		float saleAmount=0;
		int productCounter=0;
		float unitBuyPrice=0;
		float unitSellPrice=0;
		double totalProfit=0;

	public static void main(String arg[])
	{
		setUnitBuyPrice(375.72);
		setUnitSellPrice(415.00);
		addProduct(5);
		dosales(3);
		showBills();
		showTotalSales();
		showTotalProfit();
}
		
		




 int addProduct(int Product)
{
	productCounte+=product;
	return productCounter;
}

 int doSales(int sell)
{
	productCounter-=sell;
	totalsaleAmount+=(sell*uniteSellPrice);
}
 void setUnitBuyPrice(float buyPrice)
{
	unitBuyPrice+=buyPrice;
}
 void setUnitSellPrice(float sellPrice)
{
	unitSellPrice+=sellPrice;
}

void showBills()
{
	float bills=sell*unitSellPrice;
	System.out.println("Your Bills "+bills);
}
void showTotalSales()
{
	System.out.println("Total Sales Amount "+totalSaleAmount);
}

void showTotalProfit()
{
	totalProfit+=((unitSellPrice-unitBuyPrice)*sell);
	System.out.println("Total Profit Is"+totalProfit);
}
}