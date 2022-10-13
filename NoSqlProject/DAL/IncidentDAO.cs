﻿using Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IncidentDAO : DAO
    {
        IMongoCollection<Incident> collectionIncident;
        public IncidentDAO()
        {
            collectionIncident = Db.GetCollection<Incident>("Incidents");
        }
         
        public List<Incident> GetAllIncidents()
        {
            return collectionIncident.AsQueryable().ToList<Incident>();
        }

    }
}