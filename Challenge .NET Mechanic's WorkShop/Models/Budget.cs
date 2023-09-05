namespace Challenge_.NET_Mechanic_s_WorkShop.Models;

public class Budget
{
    private int _workShopProfit;

    public Budget(int workShopProfit)
    {
        _workShopProfit = workShopProfit;
    }

    public int Id { get; set; }
    Customer Customer { get; set; }
    List<Defect> Defects { get; set; } = new List<Defect>();
    decimal TotalRepairCost { get; set; }
    decimal ParkingCost { get; set; } = 0;



}