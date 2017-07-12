namespace DriversJournal.Main
{
    public class RouteSummary
    {
        /// <summary>
        /// Creates a route summary object.
        /// <param name="milageOrigin">Start milage</param>Journey type</param>
        /// </summary>
        public RouteSummary(int milageOrigin, int milageDestination, string origin, string destination, string journeyType, int distance)
        {
            this.MilageOrigin = milageOrigin;
            this.MilageDestination = milageDestination;
            this.Origin = origin;
            this.Destination = destination;
            this.JourneyType = journeyType;
            this.Distance = distance;
        }

        public int MilageOrigin { get; private set; }
        public int MilageDestination { get; private set; }
        public string Origin { get; private set; }
        public string Destination { get; private set; }
        public string JourneyType { get; private set; }
        public object Distance { get; private set; }

        public override string ToString() => $"{JourneyType}\r\nStart: {Origin} - km: {MilageOrigin}\r\nEnd: {Destination} - km: {MilageDestination}\r\nDistance: {Distance}";
    }
}