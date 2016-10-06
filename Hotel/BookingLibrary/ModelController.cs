namespace BookingLibrary
{
    //A class responsible for exchange information beetwen database and our module controllers
    public class ModelController
    {
        private static ModelController _instance;

        private ModelController()
        {
            Name = "Dupa";
            Surname = "Dupalski";
            SelectedRoom = 6;
        }

        public static ModelController Instance => _instance ?? (_instance = new ModelController());

        public string Name { get; set; }
        public string Surname { get; set; }
        public int SelectedRoom { get; set; }
    }
}