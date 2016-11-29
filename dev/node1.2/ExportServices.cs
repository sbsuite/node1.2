using System.Data;
using node2_1;

namespace node1_2
{
   public class ExportServices
   {
      private readonly IReportingServices _reportingServices;

      public ExportServices(IReportingServices reportingServices)
      {
         _reportingServices = reportingServices;
      }

      public bool ExportTable(DataTable table)
      {
         string file = "Bla bla";
         return _reportingServices.Report(table, file);
      }
   }
}