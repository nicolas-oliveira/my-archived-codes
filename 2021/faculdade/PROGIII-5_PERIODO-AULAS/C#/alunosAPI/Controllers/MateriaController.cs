using System.Collections.Generic;
using alunosAPI.Models;
using alunosAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace alunosAPI.Controllers
{
    [Route("api/[Controller]")] //no navegador fica assim: https://localhost:5001/api/Materia
    public class MateriaController
    {
        //Atributos:
        private readonly IMateriaRepository materiaRepository;
        //Construtor:
        public MateriaController(IMateriaRepository materiaRepository){
            this.materiaRepository = materiaRepository;
        }    
        
        [HttpGet]
        public IEnumerable<Materia> GetAll(){
            return materiaRepository.GetAll();
        }

        [HttpGet("{idmateria}", Name="GetMateria")]
        public IActionResult GetById(long idmateria){
            var materia = materiaRepository.Find(idmateria);
            if(materia == null)
                return NotFound(); //status code 404
                
            return new ObjectResult(materia);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Materia materia){
            if(materia == null)
                return BadRequest(); //status code 400
            materiaRepository.Add(materia);

            return CreatedAtRoute("Getmateria", new{idmateria = materia.idmateria},materia);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Materia materia){
            var materiaUpdate = materiaRepository.Find(materia.idmateria);
            if(materiaUpdate == null)
                return NotFound(); //404
            if(materia == null || materiaUpdate.idmateria != materia.idmateria)
                return BadRequest(); //400
            //regra de negócio:
            materiaUpdate.nome  = materia.nome;
            materiaUpdate.periodo = materia.periodo;
            materiaUpdate.carga_horaria   = materia.carga_horaria;
            materiaRepository.Update(materiaUpdate);

            return new NoContentResult(); //204
        }

        [HttpDelete("{idmateria}")]
        public IActionResult Delete(long idmateria){
            var materiaDelete = materiaRepository.Find(idmateria);
            if(materiaDelete == null)
                return NotFound(); //404
            materiaRepository.Remove(idmateria);
            return new NoContentResult(); //204
        }
    }
}