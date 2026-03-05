namespace Bag_and_Shop_app.Domain.Entities
{
  public class Store
  {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int CampaignId { get; set; }
    public Campaign Campaign { get; set; } = null!;
    public ICollection<Campaign> MasteredCampaigns { get; set; } = new List<Campaign>();
  }
}
