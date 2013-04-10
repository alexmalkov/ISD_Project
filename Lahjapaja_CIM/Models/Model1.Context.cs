﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.EntityClient;
using System.Data.Metadata.Edm;
using System.Data.Objects.DataClasses;
using System.Data.Objects;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace Lahjapaja_CIM.Models
{
    public partial class CIM_dbEntities : ObjectContext
    {
        public const string ConnectionString = "name=CIM_dbEntities";
        public const string ContainerName = "CIM_dbEntities";
    
        #region Constructors
    
        public CIM_dbEntities()
            : base(ConnectionString, ContainerName)
        {
            Initialize();
        }
    
        public CIM_dbEntities(string connectionString)
            : base(connectionString, ContainerName)
        {
            Initialize();
        }
    
        public CIM_dbEntities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            Initialize();
        }
    
        private void Initialize()
        {
            // Creating proxies requires the use of the ProxyDataContractResolver and
            // may allow lazy loading which can expand the loaded graph during serialization.
            ContextOptions.ProxyCreationEnabled = false;
            ObjectMaterialized += new ObjectMaterializedEventHandler(HandleObjectMaterialized);
        }
    
        private void HandleObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
        {
            var entity = e.Entity as IObjectWithChangeTracker;
            if (entity != null)
            {
                bool changeTrackingEnabled = entity.ChangeTracker.ChangeTrackingEnabled;
                try
                {
                    entity.MarkAsUnchanged();
                }
                finally
                {
                    entity.ChangeTracker.ChangeTrackingEnabled = changeTrackingEnabled;
                }
                this.StoreReferenceKeyValues(entity);
            }
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<address> addresses
        {
            get { return _addresses  ?? (_addresses = CreateObjectSet<address>("addresses")); }
        }
        private ObjectSet<address> _addresses;
    
        public ObjectSet<contact_person> contact_person
        {
            get { return _contact_person  ?? (_contact_person = CreateObjectSet<contact_person>("contact_person")); }
        }
        private ObjectSet<contact_person> _contact_person;
    
        public ObjectSet<contract> contracts
        {
            get { return _contracts  ?? (_contracts = CreateObjectSet<contract>("contracts")); }
        }
        private ObjectSet<contract> _contracts;
    
        public ObjectSet<customer> customers
        {
            get { return _customers  ?? (_customers = CreateObjectSet<customer>("customers")); }
        }
        private ObjectSet<customer> _customers;
    
        public ObjectSet<customer_group> customer_group
        {
            get { return _customer_group  ?? (_customer_group = CreateObjectSet<customer_group>("customer_group")); }
        }
        private ObjectSet<customer_group> _customer_group;
    
        public ObjectSet<customer_site> customer_site
        {
            get { return _customer_site  ?? (_customer_site = CreateObjectSet<customer_site>("customer_site")); }
        }
        private ObjectSet<customer_site> _customer_site;
    
        public ObjectSet<payment_disorder> payment_disorder
        {
            get { return _payment_disorder  ?? (_payment_disorder = CreateObjectSet<payment_disorder>("payment_disorder")); }
        }
        private ObjectSet<payment_disorder> _payment_disorder;
    
        public ObjectSet<term_of_delivery> term_of_delivery
        {
            get { return _term_of_delivery  ?? (_term_of_delivery = CreateObjectSet<term_of_delivery>("term_of_delivery")); }
        }
        private ObjectSet<term_of_delivery> _term_of_delivery;
    
        public ObjectSet<term_of_payment> term_of_payment
        {
            get { return _term_of_payment  ?? (_term_of_payment = CreateObjectSet<term_of_payment>("term_of_payment")); }
        }
        private ObjectSet<term_of_payment> _term_of_payment;
    
        public ObjectSet<way_of_delivery> way_of_delivery
        {
            get { return _way_of_delivery  ?? (_way_of_delivery = CreateObjectSet<way_of_delivery>("way_of_delivery")); }
        }
        private ObjectSet<way_of_delivery> _way_of_delivery;
    
        public ObjectSet<status> status
        {
            get { return _status  ?? (_status = CreateObjectSet<status>("status")); }
        }
        private ObjectSet<status> _status;

        #endregion
    }
}
