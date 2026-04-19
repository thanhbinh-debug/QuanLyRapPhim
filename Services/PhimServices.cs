using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QuanLyRapPhim.Models; 
namespace QuanLyRapPhim.Services
{
    public class PhimServices
    {
        private string apiUrl = "YOUR_API_URL_HERE";

        public async Task<List<MPhimAPI>> LayDanhSachPhim()
        {
            List<MPhimAPI> list = new List<MPhimAPI>();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetStringAsync(apiUrl);

                    dynamic data = JsonConvert.DeserializeObject(response);

                    foreach (var item in data.results)
                    {
                        list.Add(new MPhimAPI
                        {
                            id = item.id,
                            title = item.title
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                // Debug lỗi nếu API fail
                Console.WriteLine(ex.Message);
            }

            return list;
        }
    }
}
