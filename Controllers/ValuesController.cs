using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        //[Route("GetValue")]
        [HttpGet]
        public IList<Books> Get()
        {
            //return new string[] { "value1", "value2" };
            IList<Books> values = new List<Books>
            {
                new Books(){Id = 1, BookName ="RC"},
                new Books(){Id = 2, BookName ="Mountains"}
            };
            return values;
        }

        //public void ImageAnalysis()
        //{
        //    string endpoint = "https://cognitiveservice-prac.cognitiveservices.azure.com/";
        //    string key = "1eadayer7bMRJNueSAb4fBH2SI0G0n5xMRQfeEuqZpCiKpTvMzDOJQQJ99BCAC3pKaRXJ3w3AAAEACOGa7VA";

        //    // Create an Image Analysis client.
        //    ImageAnalysisClient client = new ImageAnalysisClient(
        //        new Uri(endpoint),
        //        new AzureKeyCredential(key));
        //}

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
