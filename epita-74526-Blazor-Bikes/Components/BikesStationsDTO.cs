namespace test.models
{
    public class Stations
    {
        public int number { get; set; }
        public string contract_name { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        //public Position position { get; set; }
        public bool banking { get; set; }
        public bool bonus { get; set; }
        public int bike_stands { get; set; }
        public int available_bike_stands { get; set; }
        public int available_bikes { get; set; }
        public string status { get; set; }
        public long last_update { get; set; }
    }

    public  static class AllStations {
        private static Stations[]? _stations;

        public static void setStations(Stations[] forecasts)
        {
            _stations = forecasts;
        }
        public static Stations[]? getStations()
        {
            return _stations;
        }
    }
    
}
