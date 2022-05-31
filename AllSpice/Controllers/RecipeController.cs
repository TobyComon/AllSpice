using System;
using System.Collections.Generic;
using AllSpice.Models;
using AllSpice.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllSpice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipeController : ControllerBase
    {
        private readonly RecipesService _recipesServ;
        private readonly CommentsService _cs;

        public RecipeController(RecipesService recipesServ, CommentsService cs)
        {
            _recipesServ = recipesServ;
            _cs = cs;
        }
        // 
        [HttpGet]
        public ActionResult<List<Recipe>> Get()
        {
            try
            {
                List<Recipe> recipe = _recipesServ.Get();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}