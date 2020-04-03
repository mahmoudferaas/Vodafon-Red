using System.Collections.Generic;

namespace BLL.Dtos
{
    public class PackagesDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Units { get; set; }
        public List<SalesDto> Sales { get; set; }
    }
}
