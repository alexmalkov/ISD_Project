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
    [KnownType(typeof(payment_disorder))]
    [KnownType(typeof(term_of_payment))]
    [KnownType(typeof(customer_site))]
    [KnownType(typeof(customer))]
    public partial class contract: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int contractId
        {
            get { return _contractId; }
            set
            {
                if (_contractId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'contractId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _contractId = value;
                    OnPropertyChanged("contractId");
                }
            }
        }
        private int _contractId;
    
        [DataMember]
        public decimal creditLimit
        {
            get { return _creditLimit; }
            set
            {
                if (_creditLimit != value)
                {
                    _creditLimit = value;
                    OnPropertyChanged("creditLimit");
                }
            }
        }
        private decimal _creditLimit;
    
        [DataMember]
        public decimal discountRate
        {
            get { return _discountRate; }
            set
            {
                if (_discountRate != value)
                {
                    _discountRate = value;
                    OnPropertyChanged("discountRate");
                }
            }
        }
        private decimal _discountRate;
    
        [DataMember]
        public Nullable<int> paymentDisorderId
        {
            get { return _paymentDisorderId; }
            set
            {
                if (_paymentDisorderId != value)
                {
                    ChangeTracker.RecordOriginalValue("paymentDisorderId", _paymentDisorderId);
                    if (!IsDeserializing)
                    {
                        if (payment_disorder != null && payment_disorder.paymentDisorderId != value)
                        {
                            payment_disorder = null;
                        }
                    }
                    _paymentDisorderId = value;
                    OnPropertyChanged("paymentDisorderId");
                }
            }
        }
        private Nullable<int> _paymentDisorderId;
    
        [DataMember]
        public Nullable<int> termOfPaymentId
        {
            get { return _termOfPaymentId; }
            set
            {
                if (_termOfPaymentId != value)
                {
                    ChangeTracker.RecordOriginalValue("termOfPaymentId", _termOfPaymentId);
                    if (!IsDeserializing)
                    {
                        if (term_of_payment != null && term_of_payment.termOfPaymentId != value)
                        {
                            term_of_payment = null;
                        }
                    }
                    _termOfPaymentId = value;
                    OnPropertyChanged("termOfPaymentId");
                }
            }
        }
        private Nullable<int> _termOfPaymentId;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public payment_disorder payment_disorder
        {
            get { return _payment_disorder; }
            set
            {
                if (!ReferenceEquals(_payment_disorder, value))
                {
                    var previousValue = _payment_disorder;
                    _payment_disorder = value;
                    Fixuppayment_disorder(previousValue);
                    OnNavigationPropertyChanged("payment_disorder");
                }
            }
        }
        private payment_disorder _payment_disorder;
    
        [DataMember]
        public term_of_payment term_of_payment
        {
            get { return _term_of_payment; }
            set
            {
                if (!ReferenceEquals(_term_of_payment, value))
                {
                    var previousValue = _term_of_payment;
                    _term_of_payment = value;
                    Fixupterm_of_payment(previousValue);
                    OnNavigationPropertyChanged("term_of_payment");
                }
            }
        }
        private term_of_payment _term_of_payment;
    
        [DataMember]
        public TrackableCollection<customer_site> customer_site
        {
            get
            {
                if (_customer_site == null)
                {
                    _customer_site = new TrackableCollection<customer_site>();
                    _customer_site.CollectionChanged += Fixupcustomer_site;
                }
                return _customer_site;
            }
            set
            {
                if (!ReferenceEquals(_customer_site, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_customer_site != null)
                    {
                        _customer_site.CollectionChanged -= Fixupcustomer_site;
                    }
                    _customer_site = value;
                    if (_customer_site != null)
                    {
                        _customer_site.CollectionChanged += Fixupcustomer_site;
                    }
                    OnNavigationPropertyChanged("customer_site");
                }
            }
        }
        private TrackableCollection<customer_site> _customer_site;
    
        [DataMember]
        public TrackableCollection<customer> customers
        {
            get
            {
                if (_customers == null)
                {
                    _customers = new TrackableCollection<customer>();
                    _customers.CollectionChanged += Fixupcustomers;
                }
                return _customers;
            }
            set
            {
                if (!ReferenceEquals(_customers, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_customers != null)
                    {
                        _customers.CollectionChanged -= Fixupcustomers;
                    }
                    _customers = value;
                    if (_customers != null)
                    {
                        _customers.CollectionChanged += Fixupcustomers;
                    }
                    OnNavigationPropertyChanged("customers");
                }
            }
        }
        private TrackableCollection<customer> _customers;

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
            payment_disorder = null;
            term_of_payment = null;
            customer_site.Clear();
            customers.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void Fixuppayment_disorder(payment_disorder previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.contracts.Contains(this))
            {
                previousValue.contracts.Remove(this);
            }
    
            if (payment_disorder != null)
            {
                if (!payment_disorder.contracts.Contains(this))
                {
                    payment_disorder.contracts.Add(this);
                }
    
                paymentDisorderId = payment_disorder.paymentDisorderId;
            }
            else if (!skipKeys)
            {
                paymentDisorderId = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("payment_disorder")
                    && (ChangeTracker.OriginalValues["payment_disorder"] == payment_disorder))
                {
                    ChangeTracker.OriginalValues.Remove("payment_disorder");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("payment_disorder", previousValue);
                }
                if (payment_disorder != null && !payment_disorder.ChangeTracker.ChangeTrackingEnabled)
                {
                    payment_disorder.StartTracking();
                }
            }
        }
    
        private void Fixupterm_of_payment(term_of_payment previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.contracts.Contains(this))
            {
                previousValue.contracts.Remove(this);
            }
    
            if (term_of_payment != null)
            {
                if (!term_of_payment.contracts.Contains(this))
                {
                    term_of_payment.contracts.Add(this);
                }
    
                termOfPaymentId = term_of_payment.termOfPaymentId;
            }
            else if (!skipKeys)
            {
                termOfPaymentId = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("term_of_payment")
                    && (ChangeTracker.OriginalValues["term_of_payment"] == term_of_payment))
                {
                    ChangeTracker.OriginalValues.Remove("term_of_payment");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("term_of_payment", previousValue);
                }
                if (term_of_payment != null && !term_of_payment.ChangeTracker.ChangeTrackingEnabled)
                {
                    term_of_payment.StartTracking();
                }
            }
        }
    
        private void Fixupcustomer_site(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (customer_site item in e.NewItems)
                {
                    item.contract = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("customer_site", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (customer_site item in e.OldItems)
                {
                    if (ReferenceEquals(item.contract, this))
                    {
                        item.contract = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("customer_site", item);
                    }
                }
            }
        }
    
        private void Fixupcustomers(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (customer item in e.NewItems)
                {
                    item.contract = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("customers", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (customer item in e.OldItems)
                {
                    if (ReferenceEquals(item.contract, this))
                    {
                        item.contract = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("customers", item);
                    }
                }
            }
        }

        #endregion
    }
}
