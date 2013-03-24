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

namespace MKSK_Lahjapaja_CIM.Models
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(customer_site))]
    public partial class contact_person: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int personId
        {
            get { return _personId; }
            set
            {
                if (_personId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'personId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _personId = value;
                    OnPropertyChanged("personId");
                }
            }
        }
        private int _personId;
    
        [DataMember]
        public string fName
        {
            get { return _fName; }
            set
            {
                if (_fName != value)
                {
                    _fName = value;
                    OnPropertyChanged("fName");
                }
            }
        }
        private string _fName;
    
        [DataMember]
        public string lName
        {
            get { return _lName; }
            set
            {
                if (_lName != value)
                {
                    _lName = value;
                    OnPropertyChanged("lName");
                }
            }
        }
        private string _lName;
    
        [DataMember]
        public string email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged("email");
                }
            }
        }
        private string _email;
    
        [DataMember]
        public string phoneNo
        {
            get { return _phoneNo; }
            set
            {
                if (_phoneNo != value)
                {
                    _phoneNo = value;
                    OnPropertyChanged("phoneNo");
                }
            }
        }
        private string _phoneNo;

        #endregion
        #region Navigation Properties
    
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
            customer_site.Clear();
        }

        #endregion
        #region Association Fixup
    
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
                    item.contact_person = this;
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
                    if (ReferenceEquals(item.contact_person, this))
                    {
                        item.contact_person = null;
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