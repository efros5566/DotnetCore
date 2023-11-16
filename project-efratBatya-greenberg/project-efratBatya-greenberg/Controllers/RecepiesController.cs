using Microsoft.AspNetCore.Mvc;
using project_efratBatya_greenberg.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project_efratBatya_greenberg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecepiesController : ControllerBase
    {
        static public List<Recepies> _list1 = new List<Recepies>();
        public static int i = 0;
        // GET: api/<RecepiesController>
        [HttpGet]
        public List<Recepies> Get()
        {
            return _list1;
        }
        [HttpGet ("{id}")]
        public ActionResult Get(int id)
        {
            Recepies temp;
            temp = _list1.Find((x) => x.Id == id);
            if(temp == null)
                return NotFound();
            return Ok(temp);
        }
        // PUT api/<RecepiesController>/5
        [HttpPost]
        public void Post([FromBody] Recepies value)
        {
            value.Id = i++;
            _list1.Add(value);
        }
        // PUT api/<ShopingListController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Recepies value)
        {
            Recepies temp;
            temp = _list1.Find((x) => x.Id == id);
            if (temp == null)
                return NotFound();
            temp.Status=value.Status;
            temp.ProductsArr=value.ProductsArr;
            temp.AmountArr=value.AmountArr;
            temp.IsAvailable=temp.IsAvailable;
            temp.Level=value.Level;
            temp.Name=value.Name;
            return Ok(temp);
        }
        // DELETE api/<RecepiesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Recepies temp;
            temp = _list1.Find((x) => x.Id == id);
            if (temp == null)
                return NotFound();
            _list1.Remove(temp);
            return Ok();
        }
    }
}
