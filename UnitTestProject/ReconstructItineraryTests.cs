using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class ReconstructItineraryTests
    {
        [TestMethod]
        public void FindItineraryTests()
        {
            ReconstructItinerary obj = new ReconstructItinerary();

            IList<IList<string>> tickets = new List<IList<string>>
            {
                new List<string>{ "MUC", "LHR"},
                new List<string>{ "JFK", "MUC"},
                new List<string>{"SFO", "SJC"},
                new List<string>{ "LHR", "SFO"},
            };

            var x = obj.FindItinerary(tickets);

            tickets = new List<IList<string>>
            {
                new List<string>{"JFK","SFO"},
                new List<string>{ "JFK","ATL"},
                new List<string>{ "SFO","ATL"},
                new List<string>{"ATL","JFK" },
                 new List<string>{"ATL","SFO" },
            };
            x = obj.FindItinerary(tickets);

            tickets = new List<IList<string>>
            {
                new List<string>{"JFK","SFO"},
                new List<string>{ "JFK","ATL"},
                new List<string>{ "SFO","ATL"},
                new List<string>{"ATL","JFK" },
                 new List<string>{"ATL","SFO" },
            };
            x = obj.FindItinerary(tickets);

            tickets = new List<IList<string>>
            {
                new List<string>{"JFK","KUL"},
                new List<string>{ "JFK","NRT"},
                new List<string>{ "NRT", "JFK"},
            };
            x = obj.FindItinerary(tickets);
        }
    }
}
