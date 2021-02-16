using System.Collections.Generic;
namespace Core.Contracts
{
   public interface IDataClaim
   {
      bool _Skip_industry { get; }
      List<int?> Industry_id { get; set; }
      List<int?> Industry_province { get; set; }
      List<int?> Industry_state { get; set; }
      List<int?> Industry_isic2 { get; set; }
      List<int?> Industry_isic4 { get; set; }

      bool _Skip_lab { get; }
      List<int?> Lab_id { get; set; }
      List<int?> Lab_province { get; set; }
      List<int?> Lab_state { get; set; }

      bool _Skip_user { get; }
      List<int?> User_id { get; set; }
      List<int?> User_province { get; set; }
      List<int?> User_state { get; set; }

      bool _Skip_wastetransfer { get; }
      List<int?> Wastetransfer_sender_province { get; set; }
      List<int?> Wastetransfer_receiver_province { get; set; }
      List<int?> Wastetransfer_sender_state { get; set; }
      List<int?> Wastetransfer_receiver_state { get; set; }

      bool _Skip_greenindustry { get; }
      List<int?> Greenindustry_province { get; set; }

      bool _Skip_river { get; }
      List<int> River_province { get; set; }

      bool _Skip_waterqualitymonitoringstation { get; }
      List<int?> Waterqualitymonitoringstation_province { get; set; }

      bool _Skip_hunter { get; }
      List<int> Hunter_id { get; set; }
      List<int?> Hunter_province { get; set; }
      List<int?> Hunter_state { get; set; }

      List<int?> Ticket_type { get; set; }
      List<int?> Ticket_deputy { get; set; }
      List<int?> Ticket_office { get; set; }
      List<int?> Ticket_province { get; set; }
      List<int?> Ticket_state { get; set; }

      List<int?> Invoice_province { get; set; }
      List<int?> Invoice_state { get; set; }

      bool _Skip_Knowledgebase { get; }
      List<int?> Knowledgebase_group { get; set; }

      bool _Skip_HuntInstruction { get; }
      List<int?> HuntInstruction_province { get; set; }
   }
}
