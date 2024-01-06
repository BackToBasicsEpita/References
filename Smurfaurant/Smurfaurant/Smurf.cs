namespace Smurfaurant
{
    public class Smurf
    {
        private string _name;
        public float Money { get; set; }

        private string[][] _favoriteMeal;

        public Smurf(string name, float money, string[] entry, string[] main, string[] dessert)
        {
            _name = name;
            Money = money;
            _favoriteMeal = new string[3][] { entry, main, dessert };
        }
    
        public string[] IsFavouriteMeal(Service service)
        {
            return _favoriteMeal[(int) service];
        }
    }
}