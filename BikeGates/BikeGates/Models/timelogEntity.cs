using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeGates.Models
{
    public class timelog
    {
        public string name { get; set; }
        public int timeStart { get; set; }
        public int timeEnd { get; set; }


    }

    public class timelogEntity : TableEntity
    {
        public timelogEntity()
        {

        }

        public timelogEntity(string name, string id)
        {
            PartitionKey = name;
            RowKey = id;
        }

        public int timeStart { get; set; }
        public int timeEnd { get; set; }

    }
}
