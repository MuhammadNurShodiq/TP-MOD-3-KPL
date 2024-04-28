using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using tpmodul10api_1302223054;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
   
namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        // GET: api/<MahasiswaController>
        //[HttpGet]

        private static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Nur Shodiq", "1302223054"),
            new Mahasiswa("Fauzein Mulya Warman", "1302223127"),
            new Mahasiswa("Iksan Oktav Risandy", "1302223042"),
            new Mahasiswa("Muhammad Dias Adani", "1302223134"),
            new Mahasiswa("Muhammad Haulul Azkiyaa", "1302223007")
        };
        [HttpGet]
        public IEnumerable<Mahasiswa> GetMahasiswa()
        {
            return dataMahasiswa;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }

        // PUT api/<MahasiswaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa value)
        {
            dataMahasiswa[id] = value;
        }

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }

}
