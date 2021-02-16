using static Core.Entities.Industry;

namespace Core.Entities
{
   public class IsIndustryMonitoredMapList
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public IndustryStatuses IsActive { get; set; }
      public int? ProvinceId { get; set; }
      public string Province { get; set; }
      public int? StateId { get; set; }
      public string State { get; set; }
      public int? EstablishmentGroupingId { get; set; }
      public string EstablishmentGrouping { get; set; }
      public bool HasMonitoring { get; set; }
      public string Latitude { get; set; }
      public string Longitude { get; set; }
   }
}
