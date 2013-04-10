//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace Lahjapaja_CIM.Models
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(address))]
    [KnownType(typeof(contact_person))]
    [KnownType(typeof(contract))]
    [KnownType(typeof(customer))]
    [KnownType(typeof(term_of_delivery))]
    [KnownType(typeof(way_of_delivery))]
    [KnownType(typeof(status))]
    public partial class customer_site: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int customerSiteId
        {
            get { return _customerSiteId; }
            set
            {
                if (_customerSiteId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'customerSiteId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _customerSiteId = value;
                    OnPropertyChanged("customerSiteId");
                }
            }
        }
        private int _customerSiteId;
    
        [DataMember]
        public int customerId
        {
            get { return _customerId; }
            set
            {
                if (_customerId != value)
                {
                    ChangeTracker.RecordOriginalValue("customerId", _customerId);
                    if (!IsDeserializing)
                    {
                        if (customer != null && customer.customerId != value)
                        {
                            customer = null;
                        }
                    }
                    _customerId = value;
                    OnPropertyChanged("customerId");
                }
            }
        }
        private int _customerId;
    
        [DataMember]
        public int contactPersonId
        {
            get { return _contactPersonId; }
            set
            {
                if (_contactPersonId != value)
                {
                    ChangeTracker.RecordOriginalValue("contactPersonId", _contactPersonId);
                    if (!IsDeserializing)
                    {
                        if (contact_person != null && contact_person.personId != value)
                        {
                            contact_person = null;
                        }
                    }
                    _contactPersonId = value;
                    OnPropertyChanged("contactPersonId");
                }
            }
        }
        private int _contactPersonId;
    
        [DataMember]
        public int deliveryAddressId
        {
            get { return _deliveryAddressId; }
            set
            {
                if (_deliveryAddressId != value)
                {
                    ChangeTracker.RecordOriginalValue("deliveryAddressId", _deliveryAddressId);
                    if (!IsDeserializing)
                    {
                        if (address != null && address.addressId != value)
                        {
                            address = null;
                        }
                    }
                    _deliveryAddressId = value;
                    OnPropertyChanged("deliveryAddressId");
                }
            }
        }
        private int _deliveryAddressId;
    
        [DataMember]
        public int postalAddressId
        {
            get { return _postalAddressId; }
            set
            {
                if (_postalAddressId != value)
                {
                    ChangeTracker.RecordOriginalValue("postalAddressId", _postalAddressId);
                    if (!IsDeserializing)
                    {
                        if (address1 != null && address1.addressId != value)
                        {
                            address1 = null;
                        }
                    }
                    _postalAddressId = value;
                    OnPropertyChanged("postalAddressId");
                }
            }
        }
        private int _postalAddressId;
    
        [DataMember]
        public Nullable<int> contractId
        {
            get { return _contractId; }
            set
            {
                if (_contractId != value)
                {
                    ChangeTracker.RecordOriginalValue("contractId", _contractId);
                    if (!IsDeserializing)
                    {
                        if (contract != null && contract.contractId != value)
                        {
                            contract = null;
                        }
                    }
                    _contractId = value;
                    OnPropertyChanged("contractId");
                }
            }
        }
        private Nullable<int> _contractId;
    
        [DataMember]
        public Nullable<int> wayOfDeliveryId
        {
            get { return _wayOfDeliveryId; }
            set
            {
                if (_wayOfDeliveryId != value)
                {
                    ChangeTracker.RecordOriginalValue("wayOfDeliveryId", _wayOfDeliveryId);
                    if (!IsDeserializing)
                    {
                        if (way_of_delivery != null && way_of_delivery.wayOfDeliveryId != value)
                        {
                            way_of_delivery = null;
                        }
                    }
                    _wayOfDeliveryId = value;
                    OnPropertyChanged("wayOfDeliveryId");
                }
            }
        }
        private Nullable<int> _wayOfDeliveryId;
    
        [DataMember]
        public Nullable<int> termOfDeliveryId
        {
            get { return _termOfDeliveryId; }
            set
            {
                if (_termOfDeliveryId != value)
                {
                    ChangeTracker.RecordOriginalValue("termOfDeliveryId", _termOfDeliveryId);
                    if (!IsDeserializing)
                    {
                        if (term_of_delivery != null && term_of_delivery.termOfDeliveryId != value)
                        {
                            term_of_delivery = null;
                        }
                    }
                    _termOfDeliveryId = value;
                    OnPropertyChanged("termOfDeliveryId");
                }
            }
        }
        private Nullable<int> _termOfDeliveryId;
    
        [DataMember]
        public string name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("name");
                }
            }
        }
        private string _name;
    
        [DataMember]
        public string status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    ChangeTracker.RecordOriginalValue("status", _status);
                    if (!IsDeserializing)
                    {
                        if (status1 != null && status1.statusText != value)
                        {
                            status1 = null;
                        }
                    }
                    _status = value;
                    OnPropertyChanged("status");
                }
            }
        }
        private string _status;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public address address
        {
            get { return _address; }
            set
            {
                if (!ReferenceEquals(_address, value))
                {
                    var previousValue = _address;
                    _address = value;
                    Fixupaddress(previousValue);
                    OnNavigationPropertyChanged("address");
                }
            }
        }
        private address _address;
    
        [DataMember]
        public address address1
        {
            get { return _address1; }
            set
            {
                if (!ReferenceEquals(_address1, value))
                {
                    var previousValue = _address1;
                    _address1 = value;
                    Fixupaddress1(previousValue);
                    OnNavigationPropertyChanged("address1");
                }
            }
        }
        private address _address1;
    
        [DataMember]
        public contact_person contact_person
        {
            get { return _contact_person; }
            set
            {
                if (!ReferenceEquals(_contact_person, value))
                {
                    var previousValue = _contact_person;
                    _contact_person = value;
                    Fixupcontact_person(previousValue);
                    OnNavigationPropertyChanged("contact_person");
                }
            }
        }
        private contact_person _contact_person;
    
        [DataMember]
        public contract contract
        {
            get { return _contract; }
            set
            {
                if (!ReferenceEquals(_contract, value))
                {
                    var previousValue = _contract;
                    _contract = value;
                    Fixupcontract(previousValue);
                    OnNavigationPropertyChanged("contract");
                }
            }
        }
        private contract _contract;
    
        [DataMember]
        public customer customer
        {
            get { return _customer; }
            set
            {
                if (!ReferenceEquals(_customer, value))
                {
                    var previousValue = _customer;
                    _customer = value;
                    Fixupcustomer(previousValue);
                    OnNavigationPropertyChanged("customer");
                }
            }
        }
        private customer _customer;
    
        [DataMember]
        public term_of_delivery term_of_delivery
        {
            get { return _term_of_delivery; }
            set
            {
                if (!ReferenceEquals(_term_of_delivery, value))
                {
                    var previousValue = _term_of_delivery;
                    _term_of_delivery = value;
                    Fixupterm_of_delivery(previousValue);
                    OnNavigationPropertyChanged("term_of_delivery");
                }
            }
        }
        private term_of_delivery _term_of_delivery;
    
        [DataMember]
        public way_of_delivery way_of_delivery
        {
            get { return _way_of_delivery; }
            set
            {
                if (!ReferenceEquals(_way_of_delivery, value))
                {
                    var previousValue = _way_of_delivery;
                    _way_of_delivery = value;
                    Fixupway_of_delivery(previousValue);
                    OnNavigationPropertyChanged("way_of_delivery");
                }
            }
        }
        private way_of_delivery _way_of_delivery;
    
        [DataMember]
        public status status1
        {
            get { return _status1; }
            set
            {
                if (!ReferenceEquals(_status1, value))
                {
                    var previousValue = _status1;
                    _status1 = value;
                    Fixupstatus1(previousValue);
                    OnNavigationPropertyChanged("status1");
                }
            }
        }
        private status _status1;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
            address = null;
            address1 = null;
            contact_person = null;
            contract = null;
            customer = null;
            term_of_delivery = null;
            way_of_delivery = null;
            status1 = null;
        }

        #endregion
        #region Association Fixup
    
        private void Fixupaddress(address previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.customer_site.Contains(this))
            {
                previousValue.customer_site.Remove(this);
            }
    
            if (address != null)
            {
                if (!address.customer_site.Contains(this))
                {
                    address.customer_site.Add(this);
                }
    
                deliveryAddressId = address.addressId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("address")
                    && (ChangeTracker.OriginalValues["address"] == address))
                {
                    ChangeTracker.OriginalValues.Remove("address");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("address", previousValue);
                }
                if (address != null && !address.ChangeTracker.ChangeTrackingEnabled)
                {
                    address.StartTracking();
                }
            }
        }
    
        private void Fixupaddress1(address previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.customer_site1.Contains(this))
            {
                previousValue.customer_site1.Remove(this);
            }
    
            if (address1 != null)
            {
                if (!address1.customer_site1.Contains(this))
                {
                    address1.customer_site1.Add(this);
                }
    
                postalAddressId = address1.addressId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("address1")
                    && (ChangeTracker.OriginalValues["address1"] == address1))
                {
                    ChangeTracker.OriginalValues.Remove("address1");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("address1", previousValue);
                }
                if (address1 != null && !address1.ChangeTracker.ChangeTrackingEnabled)
                {
                    address1.StartTracking();
                }
            }
        }
    
        private void Fixupcontact_person(contact_person previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.customer_site.Contains(this))
            {
                previousValue.customer_site.Remove(this);
            }
    
            if (contact_person != null)
            {
                if (!contact_person.customer_site.Contains(this))
                {
                    contact_person.customer_site.Add(this);
                }
    
                contactPersonId = contact_person.personId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("contact_person")
                    && (ChangeTracker.OriginalValues["contact_person"] == contact_person))
                {
                    ChangeTracker.OriginalValues.Remove("contact_person");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("contact_person", previousValue);
                }
                if (contact_person != null && !contact_person.ChangeTracker.ChangeTrackingEnabled)
                {
                    contact_person.StartTracking();
                }
            }
        }
    
        private void Fixupcontract(contract previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.customer_site.Contains(this))
            {
                previousValue.customer_site.Remove(this);
            }
    
            if (contract != null)
            {
                if (!contract.customer_site.Contains(this))
                {
                    contract.customer_site.Add(this);
                }
    
                contractId = contract.contractId;
            }
            else if (!skipKeys)
            {
                contractId = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("contract")
                    && (ChangeTracker.OriginalValues["contract"] == contract))
                {
                    ChangeTracker.OriginalValues.Remove("contract");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("contract", previousValue);
                }
                if (contract != null && !contract.ChangeTracker.ChangeTrackingEnabled)
                {
                    contract.StartTracking();
                }
            }
        }
    
        private void Fixupcustomer(customer previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.customer_site.Contains(this))
            {
                previousValue.customer_site.Remove(this);
            }
    
            if (customer != null)
            {
                if (!customer.customer_site.Contains(this))
                {
                    customer.customer_site.Add(this);
                }
    
                customerId = customer.customerId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("customer")
                    && (ChangeTracker.OriginalValues["customer"] == customer))
                {
                    ChangeTracker.OriginalValues.Remove("customer");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("customer", previousValue);
                }
                if (customer != null && !customer.ChangeTracker.ChangeTrackingEnabled)
                {
                    customer.StartTracking();
                }
            }
        }
    
        private void Fixupterm_of_delivery(term_of_delivery previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.customer_site.Contains(this))
            {
                previousValue.customer_site.Remove(this);
            }
    
            if (term_of_delivery != null)
            {
                if (!term_of_delivery.customer_site.Contains(this))
                {
                    term_of_delivery.customer_site.Add(this);
                }
    
                termOfDeliveryId = term_of_delivery.termOfDeliveryId;
            }
            else if (!skipKeys)
            {
                termOfDeliveryId = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("term_of_delivery")
                    && (ChangeTracker.OriginalValues["term_of_delivery"] == term_of_delivery))
                {
                    ChangeTracker.OriginalValues.Remove("term_of_delivery");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("term_of_delivery", previousValue);
                }
                if (term_of_delivery != null && !term_of_delivery.ChangeTracker.ChangeTrackingEnabled)
                {
                    term_of_delivery.StartTracking();
                }
            }
        }
    
        private void Fixupway_of_delivery(way_of_delivery previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.customer_site.Contains(this))
            {
                previousValue.customer_site.Remove(this);
            }
    
            if (way_of_delivery != null)
            {
                if (!way_of_delivery.customer_site.Contains(this))
                {
                    way_of_delivery.customer_site.Add(this);
                }
    
                wayOfDeliveryId = way_of_delivery.wayOfDeliveryId;
            }
            else if (!skipKeys)
            {
                wayOfDeliveryId = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("way_of_delivery")
                    && (ChangeTracker.OriginalValues["way_of_delivery"] == way_of_delivery))
                {
                    ChangeTracker.OriginalValues.Remove("way_of_delivery");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("way_of_delivery", previousValue);
                }
                if (way_of_delivery != null && !way_of_delivery.ChangeTracker.ChangeTrackingEnabled)
                {
                    way_of_delivery.StartTracking();
                }
            }
        }
    
        private void Fixupstatus1(status previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.customer_site.Contains(this))
            {
                previousValue.customer_site.Remove(this);
            }
    
            if (status1 != null)
            {
                if (!status1.customer_site.Contains(this))
                {
                    status1.customer_site.Add(this);
                }
    
                status = status1.statusText;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("status1")
                    && (ChangeTracker.OriginalValues["status1"] == status1))
                {
                    ChangeTracker.OriginalValues.Remove("status1");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("status1", previousValue);
                }
                if (status1 != null && !status1.ChangeTracker.ChangeTrackingEnabled)
                {
                    status1.StartTracking();
                }
            }
        }

        #endregion
    }
}
