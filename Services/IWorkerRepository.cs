﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WorkersApp.Entities;

namespace WorkersApp.Services
{
    public interface IWorkerRepository
    {
        void Delete(int id);
        Worker Get(int id);
        List<Worker> GetAll();
        List<Worker> GetSubordinates(int id);
        List<Worker> GetPotentialSubordinates(int id);
        void CreateSubordinate(int workerId, int newSubId);
        void Post(Worker dataEventRecord);
        void Put(int id, [FromBody] Worker dataEventRecord);
    }
}
