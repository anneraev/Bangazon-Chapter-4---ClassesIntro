using System;
using System.Collections.Generic;

namespace Planner {
    public class City {
        private string _name;
        private string _mayor;
        private DateTime _est;

        public List<Building> Buildings = new List<Building> { };

        public void addBuilding(Building building) {
            Buildings.Add(building);
        }
        public string Mayor(){
            return this._mayor;
        }
        public string Name(){
            return this._name;
        }
    }
}