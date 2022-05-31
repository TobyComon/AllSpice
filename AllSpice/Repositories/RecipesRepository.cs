using System.Data;

namespace AllSpice.Repositories
{
    public class RecipesRepository
    {
        private readonly IDbConnection _db;
        public RecipesRepository(IDbConnection db)
        {
            _db = db;
        }

        // internal List<Recipes> Get()
        // {
        //     string sql = @"
        //     SELECT 
        //     r.*,
        //     acct.*
        //     FROM recipe r
        //     JOIN accounts acct ON r.creatorId = acct.id;
        //     ";
        //     return _db.Query<Recipe, Account, Recipe>(sql, (recipe, account) =>
        //     {
        //         recipe.Creator = account;
        //         return recipe;
        //     }).ToList();
        // }
    }
}