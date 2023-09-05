namespace Challenge_.NET_Mechanic_s_WorkShop.Models;

public class Defect
{
    public int Id { get; set; }
    string Description { get; set; }
    int LaborCost { get; set; }
    DateTime EstimatedDate { get; set; }
    List<SparePart> SpareParts { get; set; }
}