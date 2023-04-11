using Microsoft.AspNetCore.Identity;
using PXLPRO2023Shoppers24.Models;

namespace PXLPRO2023Shoppers24.Services
{
    public class IdentityRepositoryResult
    {
        public IEnumerable<string> Errors => errors;
        public ApplicationUser ApplicationUser { get; set; }
        public bool Succeeded { get; set; }
        public void AddError(string error)
        {
            errors.Add(error);
        }
        List<string> errors = new List<string>();
    }
}
