using Microsoft.AspNetCore.Mvc;
using project_efratBatya_greenberg.Entities;
using System.Xml.Linq;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project_efratBatya_greenberg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopingListController : ControllerBase
    {
        public static readonly List<ShopingList> _list=new List<ShopingList>();
        public static int i=0;
        // GET: api/<ShopingListController>
        [HttpGet]
        public List<ShopingList> Get()
        {
            return _list;
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            ShopingList temp;
            temp = _list.Find((x) => x.Id == id);
            if(temp == null)
                return NotFound();
            return Ok(temp);
        }
        // POST api/<ShopingListController>
        [HttpPost]
        public void Post([FromBody] ShopingList value)
        {
            value.Id= i++;
            _list.Add(value);
        }

        // PUT api/<ShopingListController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ShopingList value)
        {
            ShopingList temp;
            temp = _list.Find((x) => x.Id == id);
            if (temp == null)
                return NotFound();
            temp.Name=value.Name;
            temp.Amount = value.Amount;
            return Ok(temp);

        }

        // DELETE api/<ShopingListController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            ShopingList temp;
            temp = _list.Find((x) => x.Id == id);
            if (temp == null)
                return NotFound();
            _list.Remove(temp);
            return Ok();
        }
    }
}
