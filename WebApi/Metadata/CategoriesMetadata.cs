using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web;

namespace WebApi.Models
{
    internal class CategoriesMetadata
    {
        public string Picture { get; set; }

        [JsonIgnore]
        public virtual ICollection<Products> Products { get; set; }
    }
}