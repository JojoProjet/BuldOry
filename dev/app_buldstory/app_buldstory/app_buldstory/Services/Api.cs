using app_buldstory.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace app_buldstory.Services
{
    public class Api
    {
        /*
        public async static IEnumerable GetMonumentHistory(string query = null)
        {
            var client = HttpService.GetInstance();
            var result = await client.GetAsync($"https://data.culture.gouv.fr/api/records/1.0/search/?dataset=liste-des-immeubles-proteges-au-titre-des-monuments-historiques&q=&rows=20&facet=region&facet=departement");
            var serializedResponse = await result.Content.ReadAsStringAsync();
            var monumentHistorys = JsonConvert.DeserializeObject<MonumentHistory>(serializedResponse);
            return monumentHistorys;
        }
        */
    }
}
