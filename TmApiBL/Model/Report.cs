using System.Collections.Generic;
using TmApiBL.Models;

namespace TmApiBL.Model
{
    public class Report
    {
        public string Name { get; }
        public List<Request> Requests { get; }
        public List<string> Fields { get; }

    }
}
