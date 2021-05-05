﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataverse.Sdk.Extensions.Tests.EarlyBoundEntities
{
    [System.Runtime.Serialization.DataContractAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
    public enum ContactState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 1,
    }

    /// <summary>
    /// Person with whom a business unit has a relationship, such as customer, supplier, and colleague.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("contact")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
    public partial class Contact : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        public static class Fields
        {
            public const string AccountId = "accountid";
            public const string AccountRoleCode = "accountrolecode";
            public const string Address1_AddressId = "address1_addressid";
            public const string Address1_AddressTypeCode = "address1_addresstypecode";
            public const string Address1_City = "address1_city";
            public const string Address1_Composite = "address1_composite";
            public const string Address1_Country = "address1_country";
            public const string Address1_County = "address1_county";
            public const string Address1_Fax = "address1_fax";
            public const string Address1_FreightTermsCode = "address1_freighttermscode";
            public const string Address1_Latitude = "address1_latitude";
            public const string Address1_Line1 = "address1_line1";
            public const string Address1_Line2 = "address1_line2";
            public const string Address1_Line3 = "address1_line3";
            public const string Address1_Longitude = "address1_longitude";
            public const string Address1_Name = "address1_name";
            public const string Address1_PostalCode = "address1_postalcode";
            public const string Address1_PostOfficeBox = "address1_postofficebox";
            public const string Address1_PrimaryContactName = "address1_primarycontactname";
            public const string Address1_ShippingMethodCode = "address1_shippingmethodcode";
            public const string Address1_StateOrProvince = "address1_stateorprovince";
            public const string Address1_Telephone1 = "address1_telephone1";
            public const string Address1_Telephone2 = "address1_telephone2";
            public const string Address1_Telephone3 = "address1_telephone3";
            public const string Address1_UPSZone = "address1_upszone";
            public const string Address1_UTCOffset = "address1_utcoffset";
            public const string Address2_AddressId = "address2_addressid";
            public const string Address2_AddressTypeCode = "address2_addresstypecode";
            public const string Address2_City = "address2_city";
            public const string Address2_Composite = "address2_composite";
            public const string Address2_Country = "address2_country";
            public const string Address2_County = "address2_county";
            public const string Address2_Fax = "address2_fax";
            public const string Address2_FreightTermsCode = "address2_freighttermscode";
            public const string Address2_Latitude = "address2_latitude";
            public const string Address2_Line1 = "address2_line1";
            public const string Address2_Line2 = "address2_line2";
            public const string Address2_Line3 = "address2_line3";
            public const string Address2_Longitude = "address2_longitude";
            public const string Address2_Name = "address2_name";
            public const string Address2_PostalCode = "address2_postalcode";
            public const string Address2_PostOfficeBox = "address2_postofficebox";
            public const string Address2_PrimaryContactName = "address2_primarycontactname";
            public const string Address2_ShippingMethodCode = "address2_shippingmethodcode";
            public const string Address2_StateOrProvince = "address2_stateorprovince";
            public const string Address2_Telephone1 = "address2_telephone1";
            public const string Address2_Telephone2 = "address2_telephone2";
            public const string Address2_Telephone3 = "address2_telephone3";
            public const string Address2_UPSZone = "address2_upszone";
            public const string Address2_UTCOffset = "address2_utcoffset";
            public const string Address3_AddressId = "address3_addressid";
            public const string Address3_AddressTypeCode = "address3_addresstypecode";
            public const string Address3_City = "address3_city";
            public const string Address3_Composite = "address3_composite";
            public const string Address3_Country = "address3_country";
            public const string Address3_County = "address3_county";
            public const string Address3_Fax = "address3_fax";
            public const string Address3_FreightTermsCode = "address3_freighttermscode";
            public const string Address3_Latitude = "address3_latitude";
            public const string Address3_Line1 = "address3_line1";
            public const string Address3_Line2 = "address3_line2";
            public const string Address3_Line3 = "address3_line3";
            public const string Address3_Longitude = "address3_longitude";
            public const string Address3_Name = "address3_name";
            public const string Address3_PostalCode = "address3_postalcode";
            public const string Address3_PostOfficeBox = "address3_postofficebox";
            public const string Address3_PrimaryContactName = "address3_primarycontactname";
            public const string Address3_ShippingMethodCode = "address3_shippingmethodcode";
            public const string Address3_StateOrProvince = "address3_stateorprovince";
            public const string Address3_Telephone1 = "address3_telephone1";
            public const string Address3_Telephone2 = "address3_telephone2";
            public const string Address3_Telephone3 = "address3_telephone3";
            public const string Address3_UPSZone = "address3_upszone";
            public const string Address3_UTCOffset = "address3_utcoffset";
            public const string Aging30 = "aging30";
            public const string Aging30_Base = "aging30_base";
            public const string Aging60 = "aging60";
            public const string Aging60_Base = "aging60_base";
            public const string Aging90 = "aging90";
            public const string Aging90_Base = "aging90_base";
            public const string Anniversary = "anniversary";
            public const string AnnualIncome = "annualincome";
            public const string AnnualIncome_Base = "annualincome_base";
            public const string AssistantName = "assistantname";
            public const string AssistantPhone = "assistantphone";
            public const string BirthDate = "birthdate";
            public const string Business2 = "business2";
            public const string Callback = "callback";
            public const string ChildrensNames = "childrensnames";
            public const string Company = "company";
            public const string ContactId = "contactid";
            public const string Id = "contactid";
            public const string CreatedBy = "createdby";
            public const string CreatedByExternalParty = "createdbyexternalparty";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreditLimit = "creditlimit";
            public const string CreditLimit_Base = "creditlimit_base";
            public const string CreditOnHold = "creditonhold";
            public const string CustomerSizeCode = "customersizecode";
            public const string CustomerTypeCode = "customertypecode";
            public const string DefaultPriceLevelId = "defaultpricelevelid";
            public const string Department = "department";
            public const string Description = "description";
            public const string DoNotBulkEMail = "donotbulkemail";
            public const string DoNotBulkPostalMail = "donotbulkpostalmail";
            public const string DoNotEMail = "donotemail";
            public const string DoNotFax = "donotfax";
            public const string DoNotPhone = "donotphone";
            public const string DoNotPostalMail = "donotpostalmail";
            public const string DoNotSendMM = "donotsendmm";
            public const string EducationCode = "educationcode";
            public const string EMailAddress1 = "emailaddress1";
            public const string EMailAddress2 = "emailaddress2";
            public const string EMailAddress3 = "emailaddress3";
            public const string EmployeeId = "employeeid";
            public const string EntityImage = "entityimage";
            public const string EntityImage_Timestamp = "entityimage_timestamp";
            public const string EntityImage_URL = "entityimage_url";
            public const string EntityImageId = "entityimageid";
            public const string ExchangeRate = "exchangerate";
            public const string ExternalUserIdentifier = "externaluseridentifier";
            public const string FamilyStatusCode = "familystatuscode";
            public const string Fax = "fax";
            public const string FirstName = "firstname";
            public const string FollowEmail = "followemail";
            public const string FtpSiteUrl = "ftpsiteurl";
            public const string FullName = "fullname";
            public const string GenderCode = "gendercode";
            public const string GovernmentId = "governmentid";
            public const string HasChildrenCode = "haschildrencode";
            public const string Home2 = "home2";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string IsBackofficeCustomer = "isbackofficecustomer";
            public const string JobTitle = "jobtitle";
            public const string LastName = "lastname";
            public const string LastOnHoldTime = "lastonholdtime";
            public const string LastUsedInCampaign = "lastusedincampaign";
            public const string LeadSourceCode = "leadsourcecode";
            public const string ManagerName = "managername";
            public const string ManagerPhone = "managerphone";
            public const string MarketingOnly = "marketingonly";
            public const string MasterId = "masterid";
            public const string Merged = "merged";
            public const string MiddleName = "middlename";
            public const string MobilePhone = "mobilephone";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByExternalParty = "modifiedbyexternalparty";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string msdyn_gdproptout = "msdyn_gdproptout";
            public const string NickName = "nickname";
            public const string NumberOfChildren = "numberofchildren";
            public const string OnHoldTime = "onholdtime";
            public const string OriginatingLeadId = "originatingleadid";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string OwnerId = "ownerid";
            public const string OwningBusinessUnit = "owningbusinessunit";
            public const string OwningTeam = "owningteam";
            public const string OwningUser = "owninguser";
            public const string Pager = "pager";
            public const string ParentContactId = "parentcontactid";
            public const string ParentCustomerId = "parentcustomerid";
            public const string ParticipatesInWorkflow = "participatesinworkflow";
            public const string PaymentTermsCode = "paymenttermscode";
            public const string PreferredAppointmentDayCode = "preferredappointmentdaycode";
            public const string PreferredAppointmentTimeCode = "preferredappointmenttimecode";
            public const string PreferredContactMethodCode = "preferredcontactmethodcode";
            public const string PreferredEquipmentId = "preferredequipmentid";
            public const string PreferredServiceId = "preferredserviceid";
            public const string PreferredSystemUserId = "preferredsystemuserid";
            public const string ProcessId = "processid";
            public const string Salutation = "salutation";
            public const string ShippingMethodCode = "shippingmethodcode";
            public const string SLAId = "slaid";
            public const string SLAInvokedId = "slainvokedid";
            public const string SpousesName = "spousesname";
            public const string StageId = "stageid";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string SubscriptionId = "subscriptionid";
            public const string Suffix = "suffix";
            public const string TeamsFollowed = "teamsfollowed";
            public const string Telephone1 = "telephone1";
            public const string Telephone2 = "telephone2";
            public const string Telephone3 = "telephone3";
            public const string TerritoryCode = "territorycode";
            public const string TimeSpentByMeOnEmailAndMeetings = "timespentbymeonemailandmeetings";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string TransactionCurrencyId = "transactioncurrencyid";
            public const string TraversedPath = "traversedpath";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string WebSiteUrl = "websiteurl";
            public const string YomiFirstName = "yomifirstname";
            public const string YomiFullName = "yomifullname";
            public const string YomiLastName = "yomilastname";
            public const string YomiMiddleName = "yomimiddlename";
            public const string business_unit_contacts = "business_unit_contacts";
            public const string contact_customer_accounts = "contact_customer_accounts";
            public const string Referencingcontact_customer_contacts = "contact_customer_contacts";
            public const string Referencingcontact_master_contact = "contact_master_contact";
            public const string contact_originating_lead = "contact_originating_lead";
            public const string contact_owning_user = "contact_owning_user";
            public const string equipment_contacts = "equipment_contacts";
            public const string lk_contact_createdonbehalfby = "lk_contact_createdonbehalfby";
            public const string lk_contact_modifiedonbehalfby = "lk_contact_modifiedonbehalfby";
            public const string lk_contactbase_createdby = "lk_contactbase_createdby";
            public const string lk_contactbase_modifiedby = "lk_contactbase_modifiedby";
            public const string lk_externalparty_contact_createdby = "lk_externalparty_contact_createdby";
            public const string lk_externalparty_contact_modifiedby = "lk_externalparty_contact_modifiedby";
            public const string manualsla_contact = "manualsla_contact";
            public const string price_level_contacts = "price_level_contacts";
            public const string processstage_contact = "processstage_contact";
            public const string service_contacts = "service_contacts";
            public const string sla_contact = "sla_contact";
            public const string system_user_contacts = "system_user_contacts";
            public const string team_contacts = "team_contacts";
            public const string transactioncurrency_contact = "transactioncurrency_contact";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Contact() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "contact";

        public const string PrimaryIdAttribute = "contactid";

        public const string PrimaryNameAttribute = "fullname";

        public const int EntityTypeCode = 2;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        [System.Diagnostics.DebuggerNonUserCode()]
        private void OnPropertyChanged(string propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        private void OnPropertyChanging(string propertyName)
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Unique identifier of the account with which the contact is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
        public Microsoft.Xrm.Sdk.EntityReference AccountId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid"); }
        }

        /// <summary>
        /// Select the contact's role within the company or sales process, such as decision maker, employee, or influencer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountrolecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue AccountRoleCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountrolecode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AccountRoleCode");
                this.SetAttributeValue("accountrolecode", value);
                this.OnPropertyChanged("AccountRoleCode");
            }
        }

        /// <summary>
        /// Unique identifier for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
        public System.Nullable<System.Guid> Address1_AddressId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_AddressId");
                this.SetAttributeValue("address1_addressid", value);
                this.OnPropertyChanged("Address1_AddressId");
            }
        }

        /// <summary>
        /// Select the primary address type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address1_AddressTypeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_AddressTypeCode");
                this.SetAttributeValue("address1_addresstypecode", value);
                this.OnPropertyChanged("Address1_AddressTypeCode");
            }
        }

        /// <summary>
        /// Type the city for the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
        public string Address1_City
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_city"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_City");
                this.SetAttributeValue("address1_city", value);
                this.OnPropertyChanged("Address1_City");
            }
        }

        /// <summary>
        /// Shows the complete primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_composite")]
        public string Address1_Composite
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_composite"); }
        }

        /// <summary>
        /// Type the country or region for the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
        public string Address1_Country
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_country"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Country");
                this.SetAttributeValue("address1_country", value);
                this.OnPropertyChanged("Address1_Country");
            }
        }

        /// <summary>
        /// Type the county for the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
        public string Address1_County
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_county"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_County");
                this.SetAttributeValue("address1_county", value);
                this.OnPropertyChanged("Address1_County");
            }
        }

        /// <summary>
        /// Type the fax number associated with the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
        public string Address1_Fax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_fax"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Fax");
                this.SetAttributeValue("address1_fax", value);
                this.OnPropertyChanged("Address1_Fax");
            }
        }

        /// <summary>
        /// Select the freight terms for the primary address to make sure shipping orders are processed correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_freighttermscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address1_FreightTermsCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_freighttermscode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_FreightTermsCode");
                this.SetAttributeValue("address1_freighttermscode", value);
                this.OnPropertyChanged("Address1_FreightTermsCode");
            }
        }

        /// <summary>
        /// Type the latitude value for the primary address for use in mapping and other applications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
        public System.Nullable<double> Address1_Latitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<double>>("address1_latitude"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Latitude");
                this.SetAttributeValue("address1_latitude", value);
                this.OnPropertyChanged("Address1_Latitude");
            }
        }

        /// <summary>
        /// Type the first line of the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
        public string Address1_Line1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_line1"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Line1");
                this.SetAttributeValue("address1_line1", value);
                this.OnPropertyChanged("Address1_Line1");
            }
        }

        /// <summary>
        /// Type the second line of the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
        public string Address1_Line2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_line2"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Line2");
                this.SetAttributeValue("address1_line2", value);
                this.OnPropertyChanged("Address1_Line2");
            }
        }

        /// <summary>
        /// Type the third line of the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
        public string Address1_Line3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_line3"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Line3");
                this.SetAttributeValue("address1_line3", value);
                this.OnPropertyChanged("Address1_Line3");
            }
        }

        /// <summary>
        /// Type the longitude value for the primary address for use in mapping and other applications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
        public System.Nullable<double> Address1_Longitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<double>>("address1_longitude"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Longitude");
                this.SetAttributeValue("address1_longitude", value);
                this.OnPropertyChanged("Address1_Longitude");
            }
        }

        /// <summary>
        /// Type a descriptive name for the primary address, such as Corporate Headquarters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
        public string Address1_Name
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_name"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Name");
                this.SetAttributeValue("address1_name", value);
                this.OnPropertyChanged("Address1_Name");
            }
        }

        /// <summary>
        /// Type the ZIP Code or postal code for the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
        public string Address1_PostalCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_postalcode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_PostalCode");
                this.SetAttributeValue("address1_postalcode", value);
                this.OnPropertyChanged("Address1_PostalCode");
            }
        }

        /// <summary>
        /// Type the post office box number of the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
        public string Address1_PostOfficeBox
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_postofficebox"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_PostOfficeBox");
                this.SetAttributeValue("address1_postofficebox", value);
                this.OnPropertyChanged("Address1_PostOfficeBox");
            }
        }

        /// <summary>
        /// Type the name of the main contact at the account's primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_primarycontactname")]
        public string Address1_PrimaryContactName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_primarycontactname"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_PrimaryContactName");
                this.SetAttributeValue("address1_primarycontactname", value);
                this.OnPropertyChanged("Address1_PrimaryContactName");
            }
        }

        /// <summary>
        /// Select a shipping method for deliveries sent to this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address1_ShippingMethodCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_ShippingMethodCode");
                this.SetAttributeValue("address1_shippingmethodcode", value);
                this.OnPropertyChanged("Address1_ShippingMethodCode");
            }
        }

        /// <summary>
        /// Type the state or province of the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
        public string Address1_StateOrProvince
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_stateorprovince"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_StateOrProvince");
                this.SetAttributeValue("address1_stateorprovince", value);
                this.OnPropertyChanged("Address1_StateOrProvince");
            }
        }

        /// <summary>
        /// Type the main phone number associated with the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
        public string Address1_Telephone1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_telephone1"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Telephone1");
                this.SetAttributeValue("address1_telephone1", value);
                this.OnPropertyChanged("Address1_Telephone1");
            }
        }

        /// <summary>
        /// Type a second phone number associated with the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
        public string Address1_Telephone2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_telephone2"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Telephone2");
                this.SetAttributeValue("address1_telephone2", value);
                this.OnPropertyChanged("Address1_Telephone2");
            }
        }

        /// <summary>
        /// Type a third phone number associated with the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
        public string Address1_Telephone3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_telephone3"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Telephone3");
                this.SetAttributeValue("address1_telephone3", value);
                this.OnPropertyChanged("Address1_Telephone3");
            }
        }

        /// <summary>
        /// Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
        public string Address1_UPSZone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_upszone"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_UPSZone");
                this.SetAttributeValue("address1_upszone", value);
                this.OnPropertyChanged("Address1_UPSZone");
            }
        }

        /// <summary>
        /// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
        public System.Nullable<int> Address1_UTCOffset
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_UTCOffset");
                this.SetAttributeValue("address1_utcoffset", value);
                this.OnPropertyChanged("Address1_UTCOffset");
            }
        }

        /// <summary>
        /// Unique identifier for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
        public System.Nullable<System.Guid> Address2_AddressId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_AddressId");
                this.SetAttributeValue("address2_addressid", value);
                this.OnPropertyChanged("Address2_AddressId");
            }
        }

        /// <summary>
        /// Select the secondary address type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address2_AddressTypeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_AddressTypeCode");
                this.SetAttributeValue("address2_addresstypecode", value);
                this.OnPropertyChanged("Address2_AddressTypeCode");
            }
        }

        /// <summary>
        /// Type the city for the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
        public string Address2_City
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_city"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_City");
                this.SetAttributeValue("address2_city", value);
                this.OnPropertyChanged("Address2_City");
            }
        }

        /// <summary>
        /// Shows the complete secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_composite")]
        public string Address2_Composite
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_composite"); }
        }

        /// <summary>
        /// Type the country or region for the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
        public string Address2_Country
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_country"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Country");
                this.SetAttributeValue("address2_country", value);
                this.OnPropertyChanged("Address2_Country");
            }
        }

        /// <summary>
        /// Type the county for the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
        public string Address2_County
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_county"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_County");
                this.SetAttributeValue("address2_county", value);
                this.OnPropertyChanged("Address2_County");
            }
        }

        /// <summary>
        /// Type the fax number associated with the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
        public string Address2_Fax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_fax"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Fax");
                this.SetAttributeValue("address2_fax", value);
                this.OnPropertyChanged("Address2_Fax");
            }
        }

        /// <summary>
        /// Select the freight terms for the secondary address to make sure shipping orders are processed correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_freighttermscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address2_FreightTermsCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_freighttermscode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_FreightTermsCode");
                this.SetAttributeValue("address2_freighttermscode", value);
                this.OnPropertyChanged("Address2_FreightTermsCode");
            }
        }

        /// <summary>
        /// Type the latitude value for the secondary address for use in mapping and other applications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
        public System.Nullable<double> Address2_Latitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<double>>("address2_latitude"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Latitude");
                this.SetAttributeValue("address2_latitude", value);
                this.OnPropertyChanged("Address2_Latitude");
            }
        }

        /// <summary>
        /// Type the first line of the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
        public string Address2_Line1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_line1"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Line1");
                this.SetAttributeValue("address2_line1", value);
                this.OnPropertyChanged("Address2_Line1");
            }
        }

        /// <summary>
        /// Type the second line of the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
        public string Address2_Line2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_line2"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Line2");
                this.SetAttributeValue("address2_line2", value);
                this.OnPropertyChanged("Address2_Line2");
            }
        }

        /// <summary>
        /// Type the third line of the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
        public string Address2_Line3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_line3"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Line3");
                this.SetAttributeValue("address2_line3", value);
                this.OnPropertyChanged("Address2_Line3");
            }
        }

        /// <summary>
        /// Type the longitude value for the secondary address for use in mapping and other applications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
        public System.Nullable<double> Address2_Longitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<double>>("address2_longitude"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Longitude");
                this.SetAttributeValue("address2_longitude", value);
                this.OnPropertyChanged("Address2_Longitude");
            }
        }

        /// <summary>
        /// Type a descriptive name for the secondary address, such as Corporate Headquarters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
        public string Address2_Name
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_name"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Name");
                this.SetAttributeValue("address2_name", value);
                this.OnPropertyChanged("Address2_Name");
            }
        }

        /// <summary>
        /// Type the ZIP Code or postal code for the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
        public string Address2_PostalCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_postalcode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_PostalCode");
                this.SetAttributeValue("address2_postalcode", value);
                this.OnPropertyChanged("Address2_PostalCode");
            }
        }

        /// <summary>
        /// Type the post office box number of the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
        public string Address2_PostOfficeBox
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_postofficebox"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_PostOfficeBox");
                this.SetAttributeValue("address2_postofficebox", value);
                this.OnPropertyChanged("Address2_PostOfficeBox");
            }
        }

        /// <summary>
        /// Type the name of the main contact at the account's secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_primarycontactname")]
        public string Address2_PrimaryContactName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_primarycontactname"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_PrimaryContactName");
                this.SetAttributeValue("address2_primarycontactname", value);
                this.OnPropertyChanged("Address2_PrimaryContactName");
            }
        }

        /// <summary>
        /// Select a shipping method for deliveries sent to this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address2_ShippingMethodCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_ShippingMethodCode");
                this.SetAttributeValue("address2_shippingmethodcode", value);
                this.OnPropertyChanged("Address2_ShippingMethodCode");
            }
        }

        /// <summary>
        /// Type the state or province of the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
        public string Address2_StateOrProvince
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_stateorprovince"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_StateOrProvince");
                this.SetAttributeValue("address2_stateorprovince", value);
                this.OnPropertyChanged("Address2_StateOrProvince");
            }
        }

        /// <summary>
        /// Type the main phone number associated with the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
        public string Address2_Telephone1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_telephone1"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Telephone1");
                this.SetAttributeValue("address2_telephone1", value);
                this.OnPropertyChanged("Address2_Telephone1");
            }
        }

        /// <summary>
        /// Type a second phone number associated with the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
        public string Address2_Telephone2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_telephone2"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Telephone2");
                this.SetAttributeValue("address2_telephone2", value);
                this.OnPropertyChanged("Address2_Telephone2");
            }
        }

        /// <summary>
        /// Type a third phone number associated with the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
        public string Address2_Telephone3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_telephone3"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Telephone3");
                this.SetAttributeValue("address2_telephone3", value);
                this.OnPropertyChanged("Address2_Telephone3");
            }
        }

        /// <summary>
        /// Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
        public string Address2_UPSZone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_upszone"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_UPSZone");
                this.SetAttributeValue("address2_upszone", value);
                this.OnPropertyChanged("Address2_UPSZone");
            }
        }

        /// <summary>
        /// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
        public System.Nullable<int> Address2_UTCOffset
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_UTCOffset");
                this.SetAttributeValue("address2_utcoffset", value);
                this.OnPropertyChanged("Address2_UTCOffset");
            }
        }

        /// <summary>
        /// Unique identifier for address 3.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_addressid")]
        public System.Nullable<System.Guid> Address3_AddressId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("address3_addressid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_AddressId");
                this.SetAttributeValue("address3_addressid", value);
                this.OnPropertyChanged("Address3_AddressId");
            }
        }

        /// <summary>
        /// Select the third address type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_addresstypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address3_AddressTypeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address3_addresstypecode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_AddressTypeCode");
                this.SetAttributeValue("address3_addresstypecode", value);
                this.OnPropertyChanged("Address3_AddressTypeCode");
            }
        }

        /// <summary>
        /// Type the city for the 3rd address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_city")]
        public string Address3_City
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address3_city"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_City");
                this.SetAttributeValue("address3_city", value);
                this.OnPropertyChanged("Address3_City");
            }
        }

        /// <summary>
        /// Shows the complete third address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_composite")]
        public string Address3_Composite
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address3_composite"); }
        }

        /// <summary>
        /// the country or region for the 3rd address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_country")]
        public string Address3_Country
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address3_country"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Country");
                this.SetAttributeValue("address3_country", value);
                this.OnPropertyChanged("Address3_Country");
            }
        }

        /// <summary>
        /// Type the county for the third address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_county")]
        public string Address3_County
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address3_county"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_County");
                this.SetAttributeValue("address3_county", value);
                this.OnPropertyChanged("Address3_County");
            }
        }

        /// <summary>
        /// Type the fax number associated with the third address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_fax")]
        public string Address3_Fax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address3_fax"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Fax");
                this.SetAttributeValue("address3_fax", value);
                this.OnPropertyChanged("Address3_Fax");
            }
        }

        /// <summary>
        /// Select the freight terms for the third address to make sure shipping orders are processed correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_freighttermscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address3_FreightTermsCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address3_freighttermscode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_FreightTermsCode");
                this.SetAttributeValue("address3_freighttermscode", value);
                this.OnPropertyChanged("Address3_FreightTermsCode");
            }
        }

        /// <summary>
        /// Type the latitude value for the third address for use in mapping and other applications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_latitude")]
        public System.Nullable<double> Address3_Latitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<double>>("address3_latitude"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Latitude");
                this.SetAttributeValue("address3_latitude", value);
                this.OnPropertyChanged("Address3_Latitude");
            }
        }

        /// <summary>
        /// the first line of the 3rd address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_line1")]
        public string Address3_Line1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address3_line1"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Line1");
                this.SetAttributeValue("address3_line1", value);
                this.OnPropertyChanged("Address3_Line1");
            }
        }

        /// <summary>
        /// the second line of the 3rd address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_line2")]
        public string Address3_Line2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address3_line2"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Line2");
                this.SetAttributeValue("address3_line2", value);
                this.OnPropertyChanged("Address3_Line2");
            }
        }

        /// <summary>
        /// the third line of the 3rd address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_line3")]
        public string Address3_Line3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address3_line3"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Line3");
                this.SetAttributeValue("address3_line3", value);
                this.OnPropertyChanged("Address3_Line3");
            }
        }

        /// <summary>
        /// Type the longitude value for the third address for use in mapping and other applications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_longitude")]
        public System.Nullable<double> Address3_Longitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<double>>("address3_longitude"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Longitude");
                this.SetAttributeValue("address3_longitude", value);
                this.OnPropertyChanged("Address3_Longitude");
            }
        }

        /// <summary>
        /// Type a descriptive name for the third address, such as Corporate Headquarters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_name")]
        public string Address3_Name
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address3_name"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Name");
                this.SetAttributeValue("address3_name", value);
                this.OnPropertyChanged("Address3_Name");
            }
        }

        /// <summary>
        /// the ZIP Code or postal code for the 3rd address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_postalcode")]
        public string Address3_PostalCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address3_postalcode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_PostalCode");
                this.SetAttributeValue("address3_postalcode", value);
                this.OnPropertyChanged("Address3_PostalCode");
            }
        }

        /// <summary>
        /// the post office box number of the 3rd address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_postofficebox")]
        public string Address3_PostOfficeBox
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address3_postofficebox"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_PostOfficeBox");
                this.SetAttributeValue("address3_postofficebox", value);
                this.OnPropertyChanged("Address3_PostOfficeBox");
            }
        }

        /// <summary>
        /// Type the name of the main contact at the account's third address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_primarycontactname")]
        public string Address3_PrimaryContactName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address3_primarycontactname"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_PrimaryContactName");
                this.SetAttributeValue("address3_primarycontactname", value);
                this.OnPropertyChanged("Address3_PrimaryContactName");
            }
        }

        /// <summary>
        /// Select a shipping method for deliveries sent to this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address3_ShippingMethodCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address3_shippingmethodcode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_ShippingMethodCode");
                this.SetAttributeValue("address3_shippingmethodcode", value);
                this.OnPropertyChanged("Address3_ShippingMethodCode");
            }
        }

        /// <summary>
        /// the state or province of the third address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_stateorprovince")]
        public string Address3_StateOrProvince
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address3_stateorprovince"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_StateOrProvince");
                this.SetAttributeValue("address3_stateorprovince", value);
                this.OnPropertyChanged("Address3_StateOrProvince");
            }
        }

        /// <summary>
        /// Type the main phone number associated with the third address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_telephone1")]
        public string Address3_Telephone1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address3_telephone1"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Telephone1");
                this.SetAttributeValue("address3_telephone1", value);
                this.OnPropertyChanged("Address3_Telephone1");
            }
        }

        /// <summary>
        /// Type a second phone number associated with the third address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_telephone2")]
        public string Address3_Telephone2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address3_telephone2"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Telephone2");
                this.SetAttributeValue("address3_telephone2", value);
                this.OnPropertyChanged("Address3_Telephone2");
            }
        }

        /// <summary>
        /// Type a third phone number associated with the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_telephone3")]
        public string Address3_Telephone3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address3_telephone3"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Telephone3");
                this.SetAttributeValue("address3_telephone3", value);
                this.OnPropertyChanged("Address3_Telephone3");
            }
        }

        /// <summary>
        /// Type the UPS zone of the third address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_upszone")]
        public string Address3_UPSZone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address3_upszone"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_UPSZone");
                this.SetAttributeValue("address3_upszone", value);
                this.OnPropertyChanged("Address3_UPSZone");
            }
        }

        /// <summary>
        /// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_utcoffset")]
        public System.Nullable<int> Address3_UTCOffset
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<int>>("address3_utcoffset"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_UTCOffset");
                this.SetAttributeValue("address3_utcoffset", value);
                this.OnPropertyChanged("Address3_UTCOffset");
            }
        }

        /// <summary>
        /// For system use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30")]
        public Microsoft.Xrm.Sdk.Money Aging30
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30"); }
        }

        /// <summary>
        /// Shows the Aging 30 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30_base")]
        public Microsoft.Xrm.Sdk.Money Aging30_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30_base"); }
        }

        /// <summary>
        /// For system use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60")]
        public Microsoft.Xrm.Sdk.Money Aging60
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60"); }
        }

        /// <summary>
        /// Shows the Aging 60 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60_base")]
        public Microsoft.Xrm.Sdk.Money Aging60_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60_base"); }
        }

        /// <summary>
        /// For system use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90")]
        public Microsoft.Xrm.Sdk.Money Aging90
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90"); }
        }

        /// <summary>
        /// Shows the Aging 90 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90_base")]
        public Microsoft.Xrm.Sdk.Money Aging90_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90_base"); }
        }

        /// <summary>
        /// Enter the date of the contact's wedding or service anniversary for use in customer gift programs or other communications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("anniversary")]
        public System.Nullable<System.DateTime> Anniversary
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("anniversary"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Anniversary");
                this.SetAttributeValue("anniversary", value);
                this.OnPropertyChanged("Anniversary");
            }
        }

        /// <summary>
        /// Type the contact's annual income for use in profiling and financial analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annualincome")]
        public Microsoft.Xrm.Sdk.Money AnnualIncome
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("annualincome"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AnnualIncome");
                this.SetAttributeValue("annualincome", value);
                this.OnPropertyChanged("AnnualIncome");
            }
        }

        /// <summary>
        /// Shows the Annual Income field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annualincome_base")]
        public Microsoft.Xrm.Sdk.Money AnnualIncome_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("annualincome_base"); }
        }

        /// <summary>
        /// Type the name of the contact's assistant.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assistantname")]
        public string AssistantName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("assistantname"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AssistantName");
                this.SetAttributeValue("assistantname", value);
                this.OnPropertyChanged("AssistantName");
            }
        }

        /// <summary>
        /// Type the phone number for the contact's assistant.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assistantphone")]
        public string AssistantPhone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("assistantphone"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AssistantPhone");
                this.SetAttributeValue("assistantphone", value);
                this.OnPropertyChanged("AssistantPhone");
            }
        }

        /// <summary>
        /// Enter the contact's birthday for use in customer gift programs or other communications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("birthdate")]
        public System.Nullable<System.DateTime> BirthDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("birthdate"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BirthDate");
                this.SetAttributeValue("birthdate", value);
                this.OnPropertyChanged("BirthDate");
            }
        }

        /// <summary>
        /// Type a second business phone number for this contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("business2")]
        public string Business2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("business2"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Business2");
                this.SetAttributeValue("business2", value);
                this.OnPropertyChanged("Business2");
            }
        }

        /// <summary>
        /// Type a callback phone number for this contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("callback")]
        public string Callback
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("callback"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Callback");
                this.SetAttributeValue("callback", value);
                this.OnPropertyChanged("Callback");
            }
        }

        /// <summary>
        /// Type the names of the contact's children for reference in communications and client programs.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("childrensnames")]
        public string ChildrensNames
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("childrensnames"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ChildrensNames");
                this.SetAttributeValue("childrensnames", value);
                this.OnPropertyChanged("ChildrensNames");
            }
        }

        /// <summary>
        /// Type the company phone of the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("company")]
        public string Company
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("company"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Company");
                this.SetAttributeValue("company", value);
                this.OnPropertyChanged("Company");
            }
        }

        /// <summary>
        /// Unique identifier of the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
        public System.Nullable<System.Guid> ContactId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("contactid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ContactId");
                this.SetAttributeValue("contactid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }

                this.OnPropertyChanged("ContactId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
        public override System.Guid Id
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return base.Id; }
            [System.Diagnostics.DebuggerNonUserCode()]
            set { this.ContactId = value; }
        }

        /// <summary>
        /// Shows who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CreatedBy");
                this.SetAttributeValue("createdby", value);
                this.OnPropertyChanged("CreatedBy");
            }
        }

        /// <summary>
        /// Shows the external party who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyexternalparty")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedByExternalParty
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdbyexternalparty"); }
        }

        /// <summary>
        /// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CreatedOn");
                this.SetAttributeValue("createdon", value);
                this.OnPropertyChanged("CreatedOn");
            }
        }

        /// <summary>
        /// Shows who created the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CreatedOnBehalfBy");
                this.SetAttributeValue("createdonbehalfby", value);
                this.OnPropertyChanged("CreatedOnBehalfBy");
            }
        }

        /// <summary>
        /// Type the credit limit of the contact for reference when you address invoice and accounting issues with the customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit")]
        public Microsoft.Xrm.Sdk.Money CreditLimit
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CreditLimit");
                this.SetAttributeValue("creditlimit", value);
                this.OnPropertyChanged("CreditLimit");
            }
        }

        /// <summary>
        /// Shows the Credit Limit field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit_base")]
        public Microsoft.Xrm.Sdk.Money CreditLimit_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit_base"); }
        }

        /// <summary>
        /// Select whether the contact is on a credit hold, for reference when addressing invoice and accounting issues.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditonhold")]
        public System.Nullable<bool> CreditOnHold
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("creditonhold"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CreditOnHold");
                this.SetAttributeValue("creditonhold", value);
                this.OnPropertyChanged("CreditOnHold");
            }
        }

        /// <summary>
        /// Select the size of the contact's company for segmentation and reporting purposes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customersizecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue CustomerSizeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customersizecode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CustomerSizeCode");
                this.SetAttributeValue("customersizecode", value);
                this.OnPropertyChanged("CustomerSizeCode");
            }
        }

        /// <summary>
        /// Select the category that best describes the relationship between the contact and your organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customertypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue CustomerTypeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customertypecode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CustomerTypeCode");
                this.SetAttributeValue("customertypecode", value);
                this.OnPropertyChanged("CustomerTypeCode");
            }
        }

        /// <summary>
        /// price_level_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultpricelevelid")]
        public Microsoft.Xrm.Sdk.EntityReference DefaultPriceLevelId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultpricelevelid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DefaultPriceLevelId");
                this.SetAttributeValue("defaultpricelevelid", value);
                this.OnPropertyChanged("DefaultPriceLevelId");
            }
        }

        /// <summary>
        /// Type the department or business unit where the contact works in the parent company or business.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("department")]
        public string Department
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("department"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Department");
                this.SetAttributeValue("department", value);
                this.OnPropertyChanged("Department");
            }
        }

        /// <summary>
        /// Type additional information to describe the contact, such as an excerpt from the company's website.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
        public string Description
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("description"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Description");
                this.SetAttributeValue("description", value);
                this.OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Select whether the contact accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkemail")]
        public System.Nullable<bool> DoNotBulkEMail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotbulkemail"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotBulkEMail");
                this.SetAttributeValue("donotbulkemail", value);
                this.OnPropertyChanged("DoNotBulkEMail");
            }
        }

        /// <summary>
        /// Select whether the contact accepts bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the letters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkpostalmail")]
        public System.Nullable<bool> DoNotBulkPostalMail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotbulkpostalmail"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotBulkPostalMail");
                this.SetAttributeValue("donotbulkpostalmail", value);
                this.OnPropertyChanged("DoNotBulkPostalMail");
            }
        }

        /// <summary>
        /// Select whether the contact allows direct email sent from Microsoft Dynamics 365. If Do Not Allow is selected, Microsoft Dynamics 365 will not send the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
        public System.Nullable<bool> DoNotEMail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotemail"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotEMail");
                this.SetAttributeValue("donotemail", value);
                this.OnPropertyChanged("DoNotEMail");
            }
        }

        /// <summary>
        /// Select whether the contact allows faxes. If Do Not Allow is selected, the contact will be excluded from any fax activities distributed in marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
        public System.Nullable<bool> DoNotFax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotfax"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotFax");
                this.SetAttributeValue("donotfax", value);
                this.OnPropertyChanged("DoNotFax");
            }
        }

        /// <summary>
        /// Select whether the contact accepts phone calls. If Do Not Allow is selected, the contact will be excluded from any phone call activities distributed in marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
        public System.Nullable<bool> DoNotPhone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotphone"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotPhone");
                this.SetAttributeValue("donotphone", value);
                this.OnPropertyChanged("DoNotPhone");
            }
        }

        /// <summary>
        /// Select whether the contact allows direct mail. If Do Not Allow is selected, the contact will be excluded from letter activities distributed in marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
        public System.Nullable<bool> DoNotPostalMail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotPostalMail");
                this.SetAttributeValue("donotpostalmail", value);
                this.OnPropertyChanged("DoNotPostalMail");
            }
        }

        /// <summary>
        /// Select whether the contact accepts marketing materials, such as brochures or catalogs. Contacts that opt out can be excluded from marketing initiatives.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotsendmm")]
        public System.Nullable<bool> DoNotSendMM
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotsendmm"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotSendMM");
                this.SetAttributeValue("donotsendmm", value);
                this.OnPropertyChanged("DoNotSendMM");
            }
        }

        /// <summary>
        /// Select the contact's highest level of education for use in segmentation and analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("educationcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue EducationCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("educationcode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EducationCode");
                this.SetAttributeValue("educationcode", value);
                this.OnPropertyChanged("EducationCode");
            }
        }

        /// <summary>
        /// Type the primary email address for the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress1")]
        public string EMailAddress1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("emailaddress1"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EMailAddress1");
                this.SetAttributeValue("emailaddress1", value);
                this.OnPropertyChanged("EMailAddress1");
            }
        }

        /// <summary>
        /// Type the secondary email address for the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress2")]
        public string EMailAddress2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("emailaddress2"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EMailAddress2");
                this.SetAttributeValue("emailaddress2", value);
                this.OnPropertyChanged("EMailAddress2");
            }
        }

        /// <summary>
        /// Type an alternate email address for the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress3")]
        public string EMailAddress3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("emailaddress3"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EMailAddress3");
                this.SetAttributeValue("emailaddress3", value);
                this.OnPropertyChanged("EMailAddress3");
            }
        }

        /// <summary>
        /// Type the employee ID or number for the contact for reference in orders, service cases, or other communications with the contact's organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("employeeid")]
        public string EmployeeId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("employeeid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EmployeeId");
                this.SetAttributeValue("employeeid", value);
                this.OnPropertyChanged("EmployeeId");
            }
        }

        /// <summary>
        /// Shows the default image for the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
        public byte[] EntityImage
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<byte[]>("entityimage"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EntityImage");
                this.SetAttributeValue("entityimage", value);
                this.OnPropertyChanged("EntityImage");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
        public System.Nullable<long> EntityImage_Timestamp
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
        public string EntityImage_URL
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("entityimage_url"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
        public System.Nullable<System.Guid> EntityImageId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid"); }
        }

        /// <summary>
        /// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Identifier for an external user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("externaluseridentifier")]
        public string ExternalUserIdentifier
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("externaluseridentifier"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ExternalUserIdentifier");
                this.SetAttributeValue("externaluseridentifier", value);
                this.OnPropertyChanged("ExternalUserIdentifier");
            }
        }

        /// <summary>
        /// Select the marital status of the contact for reference in follow-up phone calls and other communications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("familystatuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue FamilyStatusCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("familystatuscode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FamilyStatusCode");
                this.SetAttributeValue("familystatuscode", value);
                this.OnPropertyChanged("FamilyStatusCode");
            }
        }

        /// <summary>
        /// Type the fax number for the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
        public string Fax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("fax"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Fax");
                this.SetAttributeValue("fax", value);
                this.OnPropertyChanged("Fax");
            }
        }

        /// <summary>
        /// Type the contact's first name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstname")]
        public string FirstName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("firstname"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FirstName");
                this.SetAttributeValue("firstname", value);
                this.OnPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("followemail")]
        public System.Nullable<bool> FollowEmail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("followemail"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FollowEmail");
                this.SetAttributeValue("followemail", value);
                this.OnPropertyChanged("FollowEmail");
            }
        }

        /// <summary>
        /// Type the URL for the contact's FTP site to enable users to access data and share documents.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ftpsiteurl")]
        public string FtpSiteUrl
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("ftpsiteurl"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FtpSiteUrl");
                this.SetAttributeValue("ftpsiteurl", value);
                this.OnPropertyChanged("FtpSiteUrl");
            }
        }

        /// <summary>
        /// Combines and shows the contact's first and last names so that the full name can be displayed in views and reports.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullname")]
        public string FullName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("fullname"); }
        }

        /// <summary>
        /// Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("gendercode")]
        public Microsoft.Xrm.Sdk.OptionSetValue GenderCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("gendercode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("GenderCode");
                this.SetAttributeValue("gendercode", value);
                this.OnPropertyChanged("GenderCode");
            }
        }

        /// <summary>
        /// Type the passport number or other government ID for the contact for use in documents or reports.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("governmentid")]
        public string GovernmentId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("governmentid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("GovernmentId");
                this.SetAttributeValue("governmentid", value);
                this.OnPropertyChanged("GovernmentId");
            }
        }

        /// <summary>
        /// Select whether the contact has any children for reference in follow-up phone calls and other communications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("haschildrencode")]
        public Microsoft.Xrm.Sdk.OptionSetValue HasChildrenCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("haschildrencode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("HasChildrenCode");
                this.SetAttributeValue("haschildrencode", value);
                this.OnPropertyChanged("HasChildrenCode");
            }
        }

        /// <summary>
        /// Type a second home phone number for this contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("home2")]
        public string Home2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("home2"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Home2");
                this.SetAttributeValue("home2", value);
                this.OnPropertyChanged("Home2");
            }
        }

        /// <summary>
        /// Unique identifier of the data import or data migration that created this record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
        public System.Nullable<int> ImportSequenceNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ImportSequenceNumber");
                this.SetAttributeValue("importsequencenumber", value);
                this.OnPropertyChanged("ImportSequenceNumber");
            }
        }

        /// <summary>
        /// Select whether the contact exists in a separate accounting or other system, such as Microsoft Dynamics GP or another ERP database, for use in integration processes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isbackofficecustomer")]
        public System.Nullable<bool> IsBackofficeCustomer
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("isbackofficecustomer"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IsBackofficeCustomer");
                this.SetAttributeValue("isbackofficecustomer", value);
                this.OnPropertyChanged("IsBackofficeCustomer");
            }
        }

        /// <summary>
        /// Type the job title of the contact to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("jobtitle")]
        public string JobTitle
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("jobtitle"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("JobTitle");
                this.SetAttributeValue("jobtitle", value);
                this.OnPropertyChanged("JobTitle");
            }
        }

        /// <summary>
        /// Type the contact's last name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastname")]
        public string LastName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("lastname"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("LastName");
                this.SetAttributeValue("lastname", value);
                this.OnPropertyChanged("LastName");
            }
        }

        /// <summary>
        /// Contains the date and time stamp of the last on hold time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastonholdtime")]
        public System.Nullable<System.DateTime> LastOnHoldTime
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastonholdtime"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("LastOnHoldTime");
                this.SetAttributeValue("lastonholdtime", value);
                this.OnPropertyChanged("LastOnHoldTime");
            }
        }

        /// <summary>
        /// Shows the date when the contact was last included in a marketing campaign or quick campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastusedincampaign")]
        public System.Nullable<System.DateTime> LastUsedInCampaign
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastusedincampaign"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("LastUsedInCampaign");
                this.SetAttributeValue("lastusedincampaign", value);
                this.OnPropertyChanged("LastUsedInCampaign");
            }
        }

        /// <summary>
        /// Select the primary marketing source that directed the contact to your organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadsourcecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue LeadSourceCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("leadsourcecode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("LeadSourceCode");
                this.SetAttributeValue("leadsourcecode", value);
                this.OnPropertyChanged("LeadSourceCode");
            }
        }

        /// <summary>
        /// Type the name of the contact's manager for use in escalating issues or other follow-up communications with the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("managername")]
        public string ManagerName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("managername"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ManagerName");
                this.SetAttributeValue("managername", value);
                this.OnPropertyChanged("ManagerName");
            }
        }

        /// <summary>
        /// Type the phone number for the contact's manager.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("managerphone")]
        public string ManagerPhone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("managerphone"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ManagerPhone");
                this.SetAttributeValue("managerphone", value);
                this.OnPropertyChanged("ManagerPhone");
            }
        }

        /// <summary>
        /// Whether is only for marketing
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketingonly")]
        public System.Nullable<bool> MarketingOnly
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("marketingonly"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("MarketingOnly");
                this.SetAttributeValue("marketingonly", value);
                this.OnPropertyChanged("MarketingOnly");
            }
        }

        /// <summary>
        /// Unique identifier of the master contact for merge.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
        public Microsoft.Xrm.Sdk.EntityReference MasterId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("masterid"); }
        }

        /// <summary>
        /// Shows whether the account has been merged with a master contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("merged")]
        public System.Nullable<bool> Merged
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("merged"); }
        }

        /// <summary>
        /// Type the contact's middle name or initial to make sure the contact is addressed correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("middlename")]
        public string MiddleName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("middlename"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("MiddleName");
                this.SetAttributeValue("middlename", value);
                this.OnPropertyChanged("MiddleName");
            }
        }

        /// <summary>
        /// Type the mobile phone number for the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilephone")]
        public string MobilePhone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("mobilephone"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("MobilePhone");
                this.SetAttributeValue("mobilephone", value);
                this.OnPropertyChanged("MobilePhone");
            }
        }

        /// <summary>
        /// Shows who last updated the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ModifiedBy");
                this.SetAttributeValue("modifiedby", value);
                this.OnPropertyChanged("ModifiedBy");
            }
        }

        /// <summary>
        /// Shows the external party who modified the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyexternalparty")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedByExternalParty
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedbyexternalparty"); }
        }

        /// <summary>
        /// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ModifiedOn");
                this.SetAttributeValue("modifiedon", value);
                this.OnPropertyChanged("ModifiedOn");
            }
        }

        /// <summary>
        /// Shows who last updated the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ModifiedOnBehalfBy");
                this.SetAttributeValue("modifiedonbehalfby", value);
                this.OnPropertyChanged("ModifiedOnBehalfBy");
            }
        }

        /// <summary>
        /// Describes whether contact is opted out or not
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_gdproptout")]
        public System.Nullable<bool> msdyn_gdproptout
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("msdyn_gdproptout"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msdyn_gdproptout");
                this.SetAttributeValue("msdyn_gdproptout", value);
                this.OnPropertyChanged("msdyn_gdproptout");
            }
        }

        /// <summary>
        /// Type the contact's nickname.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nickname")]
        public string NickName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("nickname"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("NickName");
                this.SetAttributeValue("nickname", value);
                this.OnPropertyChanged("NickName");
            }
        }

        /// <summary>
        /// Type the number of children the contact has for reference in follow-up phone calls and other communications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofchildren")]
        public System.Nullable<int> NumberOfChildren
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<int>>("numberofchildren"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("NumberOfChildren");
                this.SetAttributeValue("numberofchildren", value);
                this.OnPropertyChanged("NumberOfChildren");
            }
        }

        /// <summary>
        /// Shows how long, in minutes, that the record was on hold.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("onholdtime")]
        public System.Nullable<int> OnHoldTime
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<int>>("onholdtime"); }
        }

        /// <summary>
        /// contact_originating_lead
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingleadid")]
        public Microsoft.Xrm.Sdk.EntityReference OriginatingLeadId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingleadid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OriginatingLeadId");
                this.SetAttributeValue("originatingleadid", value);
                this.OnPropertyChanged("OriginatingLeadId");
            }
        }

        /// <summary>
        /// Date and time that the record was migrated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OverriddenCreatedOn");
                this.SetAttributeValue("overriddencreatedon", value);
                this.OnPropertyChanged("OverriddenCreatedOn");
            }
        }

        /// <summary>
        /// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OwnerId");
                this.SetAttributeValue("ownerid", value);
                this.OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OwningBusinessUnit");
                this.SetAttributeValue("owningbusinessunit", value);
                this.OnPropertyChanged("OwningBusinessUnit");
            }
        }

        /// <summary>
        /// Unique identifier of the team who owns the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OwningTeam");
                this.SetAttributeValue("owningteam", value);
                this.OnPropertyChanged("OwningTeam");
            }
        }

        /// <summary>
        /// Unique identifier of the user who owns the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OwningUser");
                this.SetAttributeValue("owninguser", value);
                this.OnPropertyChanged("OwningUser");
            }
        }

        /// <summary>
        /// Type the pager number for the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pager")]
        public string Pager
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("pager"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Pager");
                this.SetAttributeValue("pager", value);
                this.OnPropertyChanged("Pager");
            }
        }

        /// <summary>
        /// Unique identifier of the parent contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentContactId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcontactid"); }
        }

        /// <summary>
        /// Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcustomerid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentCustomerId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcustomerid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ParentCustomerId");
                this.SetAttributeValue("parentcustomerid", value);
                this.OnPropertyChanged("ParentCustomerId");
            }
        }

        /// <summary>
        /// Shows whether the contact participates in workflow rules.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participatesinworkflow")]
        public System.Nullable<bool> ParticipatesInWorkflow
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ParticipatesInWorkflow");
                this.SetAttributeValue("participatesinworkflow", value);
                this.OnPropertyChanged("ParticipatesInWorkflow");
            }
        }

        /// <summary>
        /// Select the payment terms to indicate when the customer needs to pay the total amount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymenttermscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PaymentTermsCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("paymenttermscode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PaymentTermsCode");
                this.SetAttributeValue("paymenttermscode", value);
                this.OnPropertyChanged("PaymentTermsCode");
            }
        }

        /// <summary>
        /// Select the preferred day of the week for service appointments.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmentdaycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentDayCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmentdaycode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredAppointmentDayCode");
                this.SetAttributeValue("preferredappointmentdaycode", value);
                this.OnPropertyChanged("PreferredAppointmentDayCode");
            }
        }

        /// <summary>
        /// Select the preferred time of day for service appointments.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmenttimecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentTimeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmenttimecode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredAppointmentTimeCode");
                this.SetAttributeValue("preferredappointmenttimecode", value);
                this.OnPropertyChanged("PreferredAppointmentTimeCode");
            }
        }

        /// <summary>
        /// Select the preferred method of contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredcontactmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredContactMethodCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredcontactmethodcode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredContactMethodCode");
                this.SetAttributeValue("preferredcontactmethodcode", value);
                this.OnPropertyChanged("PreferredContactMethodCode");
            }
        }

        /// <summary>
        /// equipment_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredequipmentid")]
        public Microsoft.Xrm.Sdk.EntityReference PreferredEquipmentId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredequipmentid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredEquipmentId");
                this.SetAttributeValue("preferredequipmentid", value);
                this.OnPropertyChanged("PreferredEquipmentId");
            }
        }

        /// <summary>
        /// service_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredserviceid")]
        public Microsoft.Xrm.Sdk.EntityReference PreferredServiceId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredserviceid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredServiceId");
                this.SetAttributeValue("preferredserviceid", value);
                this.OnPropertyChanged("PreferredServiceId");
            }
        }

        /// <summary>
        /// Choose the regular or preferred customer service representative for reference when scheduling service activities for the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
        public Microsoft.Xrm.Sdk.EntityReference PreferredSystemUserId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredsystemuserid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredSystemUserId");
                this.SetAttributeValue("preferredsystemuserid", value);
                this.OnPropertyChanged("PreferredSystemUserId");
            }
        }

        /// <summary>
        /// Shows the ID of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        public System.Nullable<System.Guid> ProcessId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("processid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ProcessId");
                this.SetAttributeValue("processid", value);
                this.OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        /// Type the salutation of the contact to make sure the contact is addressed correctly in sales calls, email messages, and marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salutation")]
        public string Salutation
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("salutation"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Salutation");
                this.SetAttributeValue("salutation", value);
                this.OnPropertyChanged("Salutation");
            }
        }

        /// <summary>
        /// Select a shipping method for deliveries sent to this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ShippingMethodCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ShippingMethodCode");
                this.SetAttributeValue("shippingmethodcode", value);
                this.OnPropertyChanged("ShippingMethodCode");
            }
        }

        /// <summary>
        /// Choose the service level agreement (SLA) that you want to apply to the Contact record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
        public Microsoft.Xrm.Sdk.EntityReference SLAId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SLAId");
                this.SetAttributeValue("slaid", value);
                this.OnPropertyChanged("SLAId");
            }
        }

        /// <summary>
        /// Last SLA that was applied to this case. This field is for internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slainvokedid")]
        public Microsoft.Xrm.Sdk.EntityReference SLAInvokedId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slainvokedid"); }
        }

        /// <summary>
        /// Type the name of the contact's spouse or partner for reference during calls, events, or other communications with the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("spousesname")]
        public string SpousesName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("spousesname"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SpousesName");
                this.SetAttributeValue("spousesname", value);
                this.OnPropertyChanged("SpousesName");
            }
        }

        /// <summary>
        /// Shows the ID of the stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        public System.Nullable<System.Guid> StageId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StageId");
                this.SetAttributeValue("stageid", value);
                this.OnPropertyChanged("StageId");
            }
        }

        /// <summary>
        /// Shows whether the contact is active or inactive. Inactive contacts are read-only and can't be edited unless they are reactivated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ContactState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ContactState) (System.Enum.ToObject(typeof(ContactState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StateCode");
                if ((value == null))
                {
                    this.SetAttributeValue("statecode", null);
                }
                else
                {
                    this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int) (value))));
                }

                this.OnPropertyChanged("StateCode");
            }
        }

        /// <summary>
        /// Select the contact's status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StatusCode");
                this.SetAttributeValue("statuscode", value);
                this.OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subscriptionid")]
        public System.Nullable<System.Guid> SubscriptionId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("subscriptionid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SubscriptionId");
                this.SetAttributeValue("subscriptionid", value);
                this.OnPropertyChanged("SubscriptionId");
            }
        }

        /// <summary>
        /// Type the suffix used in the contact's name, such as Jr. or Sr. to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("suffix")]
        public string Suffix
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("suffix"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Suffix");
                this.SetAttributeValue("suffix", value);
                this.OnPropertyChanged("Suffix");
            }
        }

        /// <summary>
        /// Number of users or conversations followed the record
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamsfollowed")]
        public System.Nullable<int> TeamsFollowed
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<int>>("teamsfollowed"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TeamsFollowed");
                this.SetAttributeValue("teamsfollowed", value);
                this.OnPropertyChanged("TeamsFollowed");
            }
        }

        /// <summary>
        /// Type the main phone number for this contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone1")]
        public string Telephone1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("telephone1"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Telephone1");
                this.SetAttributeValue("telephone1", value);
                this.OnPropertyChanged("Telephone1");
            }
        }

        /// <summary>
        /// Type a second phone number for this contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone2")]
        public string Telephone2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("telephone2"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Telephone2");
                this.SetAttributeValue("telephone2", value);
                this.OnPropertyChanged("Telephone2");
            }
        }

        /// <summary>
        /// Type a third phone number for this contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone3")]
        public string Telephone3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("telephone3"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Telephone3");
                this.SetAttributeValue("telephone3", value);
                this.OnPropertyChanged("Telephone3");
            }
        }

        /// <summary>
        /// Select a region or territory for the contact for use in segmentation and analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territorycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue TerritoryCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("territorycode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TerritoryCode");
                this.SetAttributeValue("territorycode", value);
                this.OnPropertyChanged("TerritoryCode");
            }
        }

        /// <summary>
        /// Total time spent for emails (read and write) and meetings by me in relation to the contact record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timespentbymeonemailandmeetings")]
        public string TimeSpentByMeOnEmailAndMeetings
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("timespentbymeonemailandmeetings"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
        public System.Nullable<int> TimeZoneRuleVersionNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TimeZoneRuleVersionNumber");
                this.SetAttributeValue("timezoneruleversionnumber", value);
                this.OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }

        /// <summary>
        /// Choose the local currency for the record to make sure budgets are reported in the correct currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TransactionCurrencyId");
                this.SetAttributeValue("transactioncurrencyid", value);
                this.OnPropertyChanged("TransactionCurrencyId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
        public string TraversedPath
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("traversedpath"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TraversedPath");
                this.SetAttributeValue("traversedpath", value);
                this.OnPropertyChanged("TraversedPath");
            }
        }

        /// <summary>
        /// Time zone code that was in use when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
        public System.Nullable<int> UTCConversionTimeZoneCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("UTCConversionTimeZoneCode");
                this.SetAttributeValue("utcconversiontimezonecode", value);
                this.OnPropertyChanged("UTCConversionTimeZoneCode");
            }
        }

        /// <summary>
        /// Version number of the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Type the contact's professional or personal website or blog URL.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("websiteurl")]
        public string WebSiteUrl
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("websiteurl"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("WebSiteUrl");
                this.SetAttributeValue("websiteurl", value);
                this.OnPropertyChanged("WebSiteUrl");
            }
        }

        /// <summary>
        /// Type the phonetic spelling of the contact's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifirstname")]
        public string YomiFirstName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("yomifirstname"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("YomiFirstName");
                this.SetAttributeValue("yomifirstname", value);
                this.OnPropertyChanged("YomiFirstName");
            }
        }

        /// <summary>
        /// Shows the combined Yomi first and last names of the contact so that the full phonetic name can be displayed in views and reports.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifullname")]
        public string YomiFullName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("yomifullname"); }
        }

        /// <summary>
        /// Type the phonetic spelling of the contact's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomilastname")]
        public string YomiLastName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("yomilastname"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("YomiLastName");
                this.SetAttributeValue("yomilastname", value);
                this.OnPropertyChanged("YomiLastName");
            }
        }

        /// <summary>
        /// Type the phonetic spelling of the contact's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomimiddlename")]
        public string YomiMiddleName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("yomimiddlename"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("YomiMiddleName");
                this.SetAttributeValue("yomimiddlename", value);
                this.OnPropertyChanged("YomiMiddleName");
            }
        }
    }
}