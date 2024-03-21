using SmallPizzaShop.Model;

namespace SmallPizzaShop.Data
{
    public class DBServices
    {
        PizzaStoreContext context;
        public DBServices(PizzaStoreContext _context) 
        {
            this.context = _context;
        }

        public List<PizzaSpecial> GetData()
        {
            return context.Specials.ToList();
        }
    }
}
