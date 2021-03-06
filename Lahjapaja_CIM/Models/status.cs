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
    [KnownType(typeof(customer))]
    [KnownType(typeof(customer_site))]
    public partial class status: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public string statusText
        {
            get { return _statusText; }
            set
            {
                if (_statusText != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'statusText' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _statusText = value;
                    OnPropertyChanged("statusText");
                }
            }
        }
        private string _statusText;

        #endregion
        #region Navigation Properties
    
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
            customers.Clear();
            customer_site.Clear();
        }

        #endregion
        #region Association Fixup
    
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
                    item.status1 = this;
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
                    if (ReferenceEquals(item.status1, this))
                    {
                        item.status1 = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("customers", item);
                    }
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
                    item.status1 = this;
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
                    if (ReferenceEquals(item.status1, this))
                    {
                        item.status1 = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("customer_site", item);
                    }
                }
            }
        }

        #endregion
    }
}
