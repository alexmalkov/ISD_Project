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
    [KnownType(typeof(contract))]
    public partial class payment_disorder: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int paymentDisorderId
        {
            get { return _paymentDisorderId; }
            set
            {
                if (_paymentDisorderId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'paymentDisorderId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _paymentDisorderId = value;
                    OnPropertyChanged("paymentDisorderId");
                }
            }
        }
        private int _paymentDisorderId;
    
        [DataMember]
        public string creditabilityCode
        {
            get { return _creditabilityCode; }
            set
            {
                if (_creditabilityCode != value)
                {
                    _creditabilityCode = value;
                    OnPropertyChanged("creditabilityCode");
                }
            }
        }
        private string _creditabilityCode;
    
        [DataMember]
        public string text
        {
            get { return _text; }
            set
            {
                if (_text != value)
                {
                    _text = value;
                    OnPropertyChanged("text");
                }
            }
        }
        private string _text;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<contract> contracts
        {
            get
            {
                if (_contracts == null)
                {
                    _contracts = new TrackableCollection<contract>();
                    _contracts.CollectionChanged += Fixupcontracts;
                }
                return _contracts;
            }
            set
            {
                if (!ReferenceEquals(_contracts, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_contracts != null)
                    {
                        _contracts.CollectionChanged -= Fixupcontracts;
                    }
                    _contracts = value;
                    if (_contracts != null)
                    {
                        _contracts.CollectionChanged += Fixupcontracts;
                    }
                    OnNavigationPropertyChanged("contracts");
                }
            }
        }
        private TrackableCollection<contract> _contracts;

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
            contracts.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void Fixupcontracts(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (contract item in e.NewItems)
                {
                    item.payment_disorder = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("contracts", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (contract item in e.OldItems)
                {
                    if (ReferenceEquals(item.payment_disorder, this))
                    {
                        item.payment_disorder = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("contracts", item);
                    }
                }
            }
        }

        #endregion
    }
}
