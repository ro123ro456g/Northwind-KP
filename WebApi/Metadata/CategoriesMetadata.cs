using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebApi.Models
{
    internal class CategoriesMetadata
    {
        [JsonIgnore]
        public virtual ICollection<Products> Products { get; set; }
    }
}