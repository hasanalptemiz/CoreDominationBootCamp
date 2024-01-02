using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CoreDominationBootCamp.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]

    public class CountryController : ControllerBase
      {

        [HttpGet("getCountry")]
        public string GetCountries(int index)
        {
            string[] countries = new string[] { "TURKEY", "FRANCE", "ITALY", "SPAIN", "UNITED KINGDOM", "BRAZIL", "CANADA", "CHINA", "INDIA", "JAPAN", "MEXICO", "RUSSIA", "SOUTH AFRICA", "SWITZERLAND", "SWEDEN", "SOUTH KOREA", "AUSTRALIA", "ARGENTINA", "EGYPT" };

            if (index < 0 || index >= countries.Length)
            {
                return "Invalid index";
            }
            else
            {
                return countries[index];
            }
        }
      }

}