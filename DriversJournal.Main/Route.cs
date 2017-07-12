using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DriversJournal.Main.Enums;

namespace DriversJournal.Main
{
    public class Route
    {
        private string origin;

        public string Origin
        {
            get { return origin; }
            private set { origin = value; }
        }

        public string Destination { get; private set; }

        public int MilageOrigin { get; private set; }

        public int MilageDestination { get; private set; }

        public JourneyTypeEnum JourneyType { get; set; }

        public Route()
        {
        }

        public Route(int milageOrigin, int milageDestination, string origin, string destination, JourneyTypeEnum journeyTypeEnum = JourneyTypeEnum.Work)
        {
            this.Origin = origin;
            this.Destination = destination;
            this.MilageOrigin = milageOrigin;
            this.MilageDestination = milageDestination;
            this.JourneyType = journeyTypeEnum;
        }


        public int CalculateRouteDistance()
        {
            return this.MilageDestination - this.MilageOrigin;
        }

        public RouteSummary SummorizeRoute()
        {
            var journeyType = "Work";
            if (JourneyType == JourneyTypeEnum.Private) journeyType = "Private";
            var summary = new RouteSummary(
                                this.MilageOrigin,
                                this.MilageDestination,
                                this.Origin,
                                this.Destination,
                                journeyType,
                                CalculateRouteDistance()
                                );
            return summary;
        }

    }
}
 