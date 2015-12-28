namespace DesktopApp
{
    public class Tennis
    {
        //public string Day { get; set; }
        public string Outlook { get; set; }
        public string Temperature { get; set; }
        public string Humidity { get; set; }
        public string Wind { get; set; }
        public string PlayTennis { get; set; }

        public Tennis(string day, string outlook, string temperature, string humidity, string wind, string playTennis)
        {
            //Day = day;
            Outlook = outlook;
            Temperature = temperature;
            Humidity = humidity;
            Wind = wind;
            PlayTennis = playTennis;
        }

    }
}
