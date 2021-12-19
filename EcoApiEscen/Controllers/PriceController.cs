using System;
using courses;
using Microsoft.AspNetCore.Mvc;


namespace EcoApiEscen.Controllers

{[ApiController, Route("[controller]")]
    public class PriceController : ControllerBase
    {
        private readonly IPrice _Iprice;
        

        public PriceController(IPrice iprice)
        {
            _Iprice = iprice;
        }

        [HttpGet("getAllPricesCount")]
        
        public IActionResult GetAllPricesCount()
        {
            var result = _Iprice.GetAllPrice().Count;
            return Ok(new {message=result}) ;
        }
        
        [HttpGet("getAllPrices")]
        
        public IActionResult GetAllPrices()
        {
            var result = _Iprice.GetAllPrice();
            return Ok(new {message=result}) ;
        }
        
        [HttpPost("AddPrice")]
        
        public IActionResult AddPrice()
        {
            _Iprice.addPrice(new Price(1,Currency.Dollar));
            return Ok(new {message="Ajout du prix"}) ;
        }
        
        [HttpDelete("DeletePrice")]
        
        public IActionResult DeletePrice()
        {
            _Iprice.deletePrice(1);
            return Ok(new {message="Prix retiré"}) ;
        }
        
        [HttpPut("PutPrice")]
        
        public IActionResult PutPrice()
        {
            _Iprice.updatePrice(new Price(2,Currency.Dollar),1);
            return Ok(new {message="Prix modifié"}) ;
        }
    }
    
}