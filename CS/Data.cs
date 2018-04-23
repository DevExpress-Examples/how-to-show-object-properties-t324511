using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DXSample {
    public class ViewModel {
        public List<Contact> Items { get; set; }
        public ViewModel() {
            Items = new List<Contact>() {
                new Contact() {
                    FirstName = "Carolyn",
                    LastName = "Baker",
                    Email = "carolyn.baker@example.com", 
                    Phone = "(555)349-3010",
                    Address = "1198 Theresa Cir", 
                    City = "Whitinsville", 
                    State = "MA", 
                    Zip = "01582"
                },
                new Contact() {
                    FirstName = "Amber",
                    LastName = "Seaman",
                    Phone = "(555)698-4285",
                    Address = "28700 S Main St", 
                    City = "Wilsonville", 
                    State = "AL", 
                    Zip = "35188"
                },
                new Contact() {
                    FirstName = "Annie",
                    LastName = "Vicars",
                    Email = "annie.vicars@example.com", 
                    Phone = "(555)922-1349",
                    Address = "7267 New York Ave", 
                    City = "Jersey City", 
                    State = "NJ", 
                    Zip = "07306"
                },
                new Contact() {
                    FirstName = "Darlene",
                    LastName = "Catto",
                    Email = "darlene.catto@example.com", 
                    Phone = "(555)752-0582",
                    Address = "32125 4th St NW #210", 
                    City = "Washington", 
                    State = "DC", 
                    Zip = "20001"
                },
                new Contact() {
                    FirstName = "Angela",
                    LastName = "Gross",
                    Email = "angela.gross@example.com", 
                    Phone = "(555)247-1252",
                    Address = "8723 Chicago Ave", 
                    City = "Nederland", 
                    State = "TX", 
                    Zip = "77620"
                }
            };
        }
    }
    public class Contact : BindableBase {
        string _FirstName;
        public string FirstName {
            get { return _FirstName; }
            set {
                _FirstName = value;
                RaisePropertyChanged(() => FirstName);
            }
        }

        string _LastName;
        public string LastName {
            get { return _LastName; }
            set {
                _LastName = value;
                RaisePropertyChanged(() => LastName);
            }
        }

        string _Email;
        public string Email {
            get { return _Email; }
            set {
                _Email = value;
                RaisePropertyChanged(() => Email);
            }
        }

        string _Phone;
        public string Phone {
            get { return _Phone; }
            set {
                _Phone = value;
                RaisePropertyChanged(() => Phone);
            }
        }

        string _Address;
        public string Address {
            get { return _Address; }
            set {
                _Address = value;
                RaisePropertyChanged(() => Address);
            }
        }

        string _City;
        public string City {
            get { return _City; }
            set {
                _City = value;
                RaisePropertyChanged(() => City);
            }
        }

        string _State;
        public string State {
            get { return _State; }
            set {
                _State = value;
                RaisePropertyChanged(() => State);
            }
        }

        string _Zip;
        public string Zip {
            get { return _Zip; }
            set {
                _Zip = value;
                RaisePropertyChanged(() => Zip);
            }
        }
    }
}