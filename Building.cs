using System;
using System.Collections.Generic;

namespace Planner
{
    public class Building {
        public Building (string address) {
            _address = address;
        }

        public void Construct() {
            _dateConstructed = DateTime.Now;
        }

        public void Design(string designer){
            _designer = designer;
        }

        public void Purchase(string owner) {
            _owner = owner;
        }

        public string GetDesigner() {
            return _designer;
        }

        public string GetAddress() {
            return _address;
        }

        public string GetOwner() {
            return _owner;
        }

        public DateTime GetDate() {
            return _dateConstructed;
        }

        private string _designer;
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public int stories {get; set;}
        public double width {get; set;}
        public double depth {get; set;}
        public double volume {get {
            return width * depth * (3 * stories);
        }}
    }
}
