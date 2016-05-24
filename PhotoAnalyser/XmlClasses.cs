using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAnalyser
{
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
    public partial class MD_Metadata
    {

        private MD_MetadataFileIdentifier fileIdentifierField;

        private MD_MetadataLanguage languageField;

        private MD_MetadataCharacterSet characterSetField;

        private MD_MetadataParentIdentifier parentIdentifierField;

        private MD_MetadataHierarchyLevel hierarchyLevelField;

        private MD_MetadataHierarchyLevelName hierarchyLevelNameField;

        private MD_MetadataContact contactField;

        private MD_MetadataDateStamp dateStampField;

        private MD_MetadataMetadataStandardName metadataStandardNameField;

        private MD_MetadataMetadataStandardVersion metadataStandardVersionField;

        private MD_MetadataDataSetURI dataSetURIField;

        private MD_MetadataSpatialRepresentationInfo spatialRepresentationInfoField;

        private MD_MetadataReferenceSystemInfo[] referenceSystemInfoField;

        private MD_MetadataIdentificationInfo identificationInfoField;

        private MD_MetadataContentInfo[] contentInfoField;

        private MD_MetadataMetadataConstraints metadataConstraintsField;

        /// <remarks/>
        public MD_MetadataFileIdentifier fileIdentifier
        {
            get
            {
                return this.fileIdentifierField;
            }
            set
            {
                this.fileIdentifierField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataLanguage language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataCharacterSet characterSet
        {
            get
            {
                return this.characterSetField;
            }
            set
            {
                this.characterSetField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataParentIdentifier parentIdentifier
        {
            get
            {
                return this.parentIdentifierField;
            }
            set
            {
                this.parentIdentifierField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataHierarchyLevel hierarchyLevel
        {
            get
            {
                return this.hierarchyLevelField;
            }
            set
            {
                this.hierarchyLevelField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataHierarchyLevelName hierarchyLevelName
        {
            get
            {
                return this.hierarchyLevelNameField;
            }
            set
            {
                this.hierarchyLevelNameField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataContact contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataDateStamp dateStamp
        {
            get
            {
                return this.dateStampField;
            }
            set
            {
                this.dateStampField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataMetadataStandardName metadataStandardName
        {
            get
            {
                return this.metadataStandardNameField;
            }
            set
            {
                this.metadataStandardNameField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataMetadataStandardVersion metadataStandardVersion
        {
            get
            {
                return this.metadataStandardVersionField;
            }
            set
            {
                this.metadataStandardVersionField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataDataSetURI dataSetURI
        {
            get
            {
                return this.dataSetURIField;
            }
            set
            {
                this.dataSetURIField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfo spatialRepresentationInfo
        {
            get
            {
                return this.spatialRepresentationInfoField;
            }
            set
            {
                this.spatialRepresentationInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("referenceSystemInfo")]
        public MD_MetadataReferenceSystemInfo[] referenceSystemInfo
        {
            get
            {
                return this.referenceSystemInfoField;
            }
            set
            {
                this.referenceSystemInfoField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfo identificationInfo
        {
            get
            {
                return this.identificationInfoField;
            }
            set
            {
                this.identificationInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contentInfo")]
        public MD_MetadataContentInfo[] contentInfo
        {
            get
            {
                return this.contentInfoField;
            }
            set
            {
                this.contentInfoField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataMetadataConstraints metadataConstraints
        {
            get
            {
                return this.metadataConstraintsField;
            }
            set
            {
                this.metadataConstraintsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataFileIdentifier
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataLanguage
    {

        private MD_MetadataLanguageLanguageCode languageCodeField;

        /// <remarks/>
        public MD_MetadataLanguageLanguageCode LanguageCode
        {
            get
            {
                return this.languageCodeField;
            }
            set
            {
                this.languageCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataLanguageLanguageCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataCharacterSet
    {

        private MD_MetadataCharacterSetMD_CharacterSetCode mD_CharacterSetCodeField;

        /// <remarks/>
        public MD_MetadataCharacterSetMD_CharacterSetCode MD_CharacterSetCode
        {
            get
            {
                return this.mD_CharacterSetCodeField;
            }
            set
            {
                this.mD_CharacterSetCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataCharacterSetMD_CharacterSetCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataParentIdentifier
    {

        private string nilReasonField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataHierarchyLevel
    {

        private MD_MetadataHierarchyLevelMD_ScopeCode mD_ScopeCodeField;

        /// <remarks/>
        public MD_MetadataHierarchyLevelMD_ScopeCode MD_ScopeCode
        {
            get
            {
                return this.mD_ScopeCodeField;
            }
            set
            {
                this.mD_ScopeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataHierarchyLevelMD_ScopeCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataHierarchyLevelName
    {

        private string nilReasonField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContact
    {

        private MD_MetadataContactCI_ResponsibleParty cI_ResponsiblePartyField;

        /// <remarks/>
        public MD_MetadataContactCI_ResponsibleParty CI_ResponsibleParty
        {
            get
            {
                return this.cI_ResponsiblePartyField;
            }
            set
            {
                this.cI_ResponsiblePartyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsibleParty
    {

        private MD_MetadataContactCI_ResponsiblePartyIndividualName individualNameField;

        private MD_MetadataContactCI_ResponsiblePartyOrganisationName organisationNameField;

        private MD_MetadataContactCI_ResponsiblePartyPositionName positionNameField;

        private MD_MetadataContactCI_ResponsiblePartyContactInfo contactInfoField;

        private MD_MetadataContactCI_ResponsiblePartyRole roleField;

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyIndividualName individualName
        {
            get
            {
                return this.individualNameField;
            }
            set
            {
                this.individualNameField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyOrganisationName organisationName
        {
            get
            {
                return this.organisationNameField;
            }
            set
            {
                this.organisationNameField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyPositionName positionName
        {
            get
            {
                return this.positionNameField;
            }
            set
            {
                this.positionNameField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfo contactInfo
        {
            get
            {
                return this.contactInfoField;
            }
            set
            {
                this.contactInfoField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyRole role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyIndividualName
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyOrganisationName
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyPositionName
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfo
    {

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_Contact cI_ContactField;

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_Contact CI_Contact
        {
            get
            {
                return this.cI_ContactField;
            }
            set
            {
                this.cI_ContactField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_Contact
    {

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactPhone phoneField;

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddress addressField;

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResource onlineResourceField;

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactPhone phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddress address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResource onlineResource
        {
            get
            {
                return this.onlineResourceField;
            }
            set
            {
                this.onlineResourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactPhone
    {

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactPhoneCI_Telephone cI_TelephoneField;

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactPhoneCI_Telephone CI_Telephone
        {
            get
            {
                return this.cI_TelephoneField;
            }
            set
            {
                this.cI_TelephoneField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactPhoneCI_Telephone
    {

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactPhoneCI_TelephoneVoice voiceField;

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactPhoneCI_TelephoneVoice voice
        {
            get
            {
                return this.voiceField;
            }
            set
            {
                this.voiceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactPhoneCI_TelephoneVoice
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddress
    {

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_Address cI_AddressField;

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_Address CI_Address
        {
            get
            {
                return this.cI_AddressField;
            }
            set
            {
                this.cI_AddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_Address
    {

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressDeliveryPoint deliveryPointField;

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressCity cityField;

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressAdministrativeArea administrativeAreaField;

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressPostalCode postalCodeField;

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressCountry countryField;

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressElectronicMailAddress electronicMailAddressField;

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressDeliveryPoint deliveryPoint
        {
            get
            {
                return this.deliveryPointField;
            }
            set
            {
                this.deliveryPointField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressCity city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressAdministrativeArea administrativeArea
        {
            get
            {
                return this.administrativeAreaField;
            }
            set
            {
                this.administrativeAreaField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressPostalCode postalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressCountry country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressElectronicMailAddress electronicMailAddress
        {
            get
            {
                return this.electronicMailAddressField;
            }
            set
            {
                this.electronicMailAddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressDeliveryPoint
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressCity
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressAdministrativeArea
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressPostalCode
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressCountry
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressElectronicMailAddress
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResource
    {

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResource cI_OnlineResourceField;

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResource CI_OnlineResource
        {
            get
            {
                return this.cI_OnlineResourceField;
            }
            set
            {
                this.cI_OnlineResourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResource
    {

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceLinkage linkageField;

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceProtocol protocolField;

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceName nameField;

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceDescription descriptionField;

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceFunction functionField;

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceLinkage linkage
        {
            get
            {
                return this.linkageField;
            }
            set
            {
                this.linkageField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceProtocol protocol
        {
            get
            {
                return this.protocolField;
            }
            set
            {
                this.protocolField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceName name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceDescription description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceFunction function
        {
            get
            {
                return this.functionField;
            }
            set
            {
                this.functionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceLinkage
    {

        private string uRLField;

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceProtocol
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceName
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceDescription
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceFunction
    {

        private MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceFunctionCI_OnLineFunctionCode cI_OnLineFunctionCodeField;

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceFunctionCI_OnLineFunctionCode CI_OnLineFunctionCode
        {
            get
            {
                return this.cI_OnLineFunctionCodeField;
            }
            set
            {
                this.cI_OnLineFunctionCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyContactInfoCI_ContactOnlineResourceCI_OnlineResourceFunctionCI_OnLineFunctionCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyRole
    {

        private MD_MetadataContactCI_ResponsiblePartyRoleCI_RoleCode cI_RoleCodeField;

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyRoleCI_RoleCode CI_RoleCode
        {
            get
            {
                return this.cI_RoleCodeField;
            }
            set
            {
                this.cI_RoleCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyRoleCI_RoleCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDateStamp
    {

        private System.DateTime dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco", DataType = "date")]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataMetadataStandardName
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataMetadataStandardVersion
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataSetURI
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfo
    {

        private MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentation mD_GridSpatialRepresentationField;

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentation MD_GridSpatialRepresentation
        {
            get
            {
                return this.mD_GridSpatialRepresentationField;
            }
            set
            {
                this.mD_GridSpatialRepresentationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentation
    {

        private MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationNumberOfDimensions numberOfDimensionsField;

        private MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionProperties[] axisDimensionPropertiesField;

        private MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationCellGeometry cellGeometryField;

        private MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationTransformationParameterAvailability transformationParameterAvailabilityField;

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationNumberOfDimensions numberOfDimensions
        {
            get
            {
                return this.numberOfDimensionsField;
            }
            set
            {
                this.numberOfDimensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("axisDimensionProperties")]
        public MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionProperties[] axisDimensionProperties
        {
            get
            {
                return this.axisDimensionPropertiesField;
            }
            set
            {
                this.axisDimensionPropertiesField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationCellGeometry cellGeometry
        {
            get
            {
                return this.cellGeometryField;
            }
            set
            {
                this.cellGeometryField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationTransformationParameterAvailability transformationParameterAvailability
        {
            get
            {
                return this.transformationParameterAvailabilityField;
            }
            set
            {
                this.transformationParameterAvailabilityField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationNumberOfDimensions
    {

        private ushort integerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public ushort Integer
        {
            get
            {
                return this.integerField;
            }
            set
            {
                this.integerField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionProperties
    {

        private MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionPropertiesMD_Dimension mD_DimensionField;

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionPropertiesMD_Dimension MD_Dimension
        {
            get
            {
                return this.mD_DimensionField;
            }
            set
            {
                this.mD_DimensionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionPropertiesMD_Dimension
    {

        private MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionPropertiesMD_DimensionDimensionName dimensionNameField;

        private MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionPropertiesMD_DimensionDimensionSize dimensionSizeField;

        private MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionPropertiesMD_DimensionResolution resolutionField;

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionPropertiesMD_DimensionDimensionName dimensionName
        {
            get
            {
                return this.dimensionNameField;
            }
            set
            {
                this.dimensionNameField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionPropertiesMD_DimensionDimensionSize dimensionSize
        {
            get
            {
                return this.dimensionSizeField;
            }
            set
            {
                this.dimensionSizeField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionPropertiesMD_DimensionResolution resolution
        {
            get
            {
                return this.resolutionField;
            }
            set
            {
                this.resolutionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionPropertiesMD_DimensionDimensionName
    {

        private MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionPropertiesMD_DimensionDimensionNameMD_DimensionNameTypeCode mD_DimensionNameTypeCodeField;

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionPropertiesMD_DimensionDimensionNameMD_DimensionNameTypeCode MD_DimensionNameTypeCode
        {
            get
            {
                return this.mD_DimensionNameTypeCodeField;
            }
            set
            {
                this.mD_DimensionNameTypeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionPropertiesMD_DimensionDimensionNameMD_DimensionNameTypeCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionPropertiesMD_DimensionDimensionSize
    {

        private ushort integerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public ushort Integer
        {
            get
            {
                return this.integerField;
            }
            set
            {
                this.integerField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationAxisDimensionPropertiesMD_DimensionResolution
    {

        private Scale scaleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public Scale Scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gco")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.isotc211.org/2005/gco", IsNullable = false)]
    public partial class Scale
    {

        private string uomField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uom
        {
            get
            {
                return this.uomField;
            }
            set
            {
                this.uomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationCellGeometry
    {

        private MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationCellGeometryMD_CellGeometryCode mD_CellGeometryCodeField;

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationCellGeometryMD_CellGeometryCode MD_CellGeometryCode
        {
            get
            {
                return this.mD_CellGeometryCodeField;
            }
            set
            {
                this.mD_CellGeometryCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationCellGeometryMD_CellGeometryCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_GridSpatialRepresentationTransformationParameterAvailability
    {

        private bool booleanField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public bool Boolean
        {
            get
            {
                return this.booleanField;
            }
            set
            {
                this.booleanField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataReferenceSystemInfo
    {

        private MD_MetadataReferenceSystemInfoMD_ReferenceSystem mD_ReferenceSystemField;

        /// <remarks/>
        public MD_MetadataReferenceSystemInfoMD_ReferenceSystem MD_ReferenceSystem
        {
            get
            {
                return this.mD_ReferenceSystemField;
            }
            set
            {
                this.mD_ReferenceSystemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataReferenceSystemInfoMD_ReferenceSystem
    {

        private MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifier referenceSystemIdentifierField;

        /// <remarks/>
        public MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifier referenceSystemIdentifier
        {
            get
            {
                return this.referenceSystemIdentifierField;
            }
            set
            {
                this.referenceSystemIdentifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifier
    {

        private MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_Identifier rS_IdentifierField;

        /// <remarks/>
        public MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_Identifier RS_Identifier
        {
            get
            {
                return this.rS_IdentifierField;
            }
            set
            {
                this.rS_IdentifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_Identifier
    {

        private MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_IdentifierCode codeField;

        private MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_IdentifierCodeSpace codeSpaceField;

        /// <remarks/>
        public MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_IdentifierCode code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_IdentifierCodeSpace codeSpace
        {
            get
            {
                return this.codeSpaceField;
            }
            set
            {
                this.codeSpaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_IdentifierCode
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_IdentifierCodeSpace
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfo
    {

        private MD_MetadataIdentificationInfoMD_DataIdentification mD_DataIdentificationField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentification MD_DataIdentification
        {
            get
            {
                return this.mD_DataIdentificationField;
            }
            set
            {
                this.mD_DataIdentificationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentification
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitation citationField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationAbstract abstractField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywords descriptiveKeywordsField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraints resourceConstraintsField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationSpatialRepresentationType spatialRepresentationTypeField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationLanguage languageField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationCharacterSet characterSetField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationTopicCategory topicCategoryField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtent extentField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitation citation
        {
            get
            {
                return this.citationField;
            }
            set
            {
                this.citationField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationAbstract @abstract
        {
            get
            {
                return this.abstractField;
            }
            set
            {
                this.abstractField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywords descriptiveKeywords
        {
            get
            {
                return this.descriptiveKeywordsField;
            }
            set
            {
                this.descriptiveKeywordsField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraints resourceConstraints
        {
            get
            {
                return this.resourceConstraintsField;
            }
            set
            {
                this.resourceConstraintsField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationSpatialRepresentationType spatialRepresentationType
        {
            get
            {
                return this.spatialRepresentationTypeField;
            }
            set
            {
                this.spatialRepresentationTypeField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationLanguage language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCharacterSet characterSet
        {
            get
            {
                return this.characterSetField;
            }
            set
            {
                this.characterSetField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationTopicCategory topicCategory
        {
            get
            {
                return this.topicCategoryField;
            }
            set
            {
                this.topicCategoryField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtent extent
        {
            get
            {
                return this.extentField;
            }
            set
            {
                this.extentField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitation
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_Citation cI_CitationField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_Citation CI_Citation
        {
            get
            {
                return this.cI_CitationField;
            }
            set
            {
                this.cI_CitationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_Citation
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationTitle titleField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDate dateField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationEdition editionField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationEditionDate editionDateField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationCitedResponsibleParty citedResponsiblePartyField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationPresentationForm presentationFormField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationTitle title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDate date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationEdition edition
        {
            get
            {
                return this.editionField;
            }
            set
            {
                this.editionField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationEditionDate editionDate
        {
            get
            {
                return this.editionDateField;
            }
            set
            {
                this.editionDateField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationCitedResponsibleParty citedResponsibleParty
        {
            get
            {
                return this.citedResponsiblePartyField;
            }
            set
            {
                this.citedResponsiblePartyField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationPresentationForm presentationForm
        {
            get
            {
                return this.presentationFormField;
            }
            set
            {
                this.presentationFormField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationTitle
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDate
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_Date cI_DateField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_Date CI_Date
        {
            get
            {
                return this.cI_DateField;
            }
            set
            {
                this.cI_DateField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_Date
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDate dateField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDateType dateTypeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDate date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDateType dateType
        {
            get
            {
                return this.dateTypeField;
            }
            set
            {
                this.dateTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDate
    {

        private System.DateTime dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco", DataType = "date")]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDateType
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDateTypeCI_DateTypeCode cI_DateTypeCodeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDateTypeCI_DateTypeCode CI_DateTypeCode
        {
            get
            {
                return this.cI_DateTypeCodeField;
            }
            set
            {
                this.cI_DateTypeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDateTypeCI_DateTypeCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationEdition
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationEditionDate
    {

        private System.DateTime dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco", DataType = "date")]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationCitedResponsibleParty
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationCitedResponsiblePartyCI_ResponsibleParty cI_ResponsiblePartyField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationCitedResponsiblePartyCI_ResponsibleParty CI_ResponsibleParty
        {
            get
            {
                return this.cI_ResponsiblePartyField;
            }
            set
            {
                this.cI_ResponsiblePartyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationCitedResponsiblePartyCI_ResponsibleParty
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationCitedResponsiblePartyCI_ResponsiblePartyOrganisationName organisationNameField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationCitedResponsiblePartyCI_ResponsiblePartyRole roleField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationCitedResponsiblePartyCI_ResponsiblePartyOrganisationName organisationName
        {
            get
            {
                return this.organisationNameField;
            }
            set
            {
                this.organisationNameField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationCitedResponsiblePartyCI_ResponsiblePartyRole role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationCitedResponsiblePartyCI_ResponsiblePartyOrganisationName
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationCitedResponsiblePartyCI_ResponsiblePartyRole
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationCitedResponsiblePartyCI_ResponsiblePartyRoleCI_RoleCode cI_RoleCodeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationCitedResponsiblePartyCI_ResponsiblePartyRoleCI_RoleCode CI_RoleCode
        {
            get
            {
                return this.cI_RoleCodeField;
            }
            set
            {
                this.cI_RoleCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationCitedResponsiblePartyCI_ResponsiblePartyRoleCI_RoleCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationPresentationForm
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationPresentationFormCI_PresentationFormCode cI_PresentationFormCodeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationPresentationFormCI_PresentationFormCode CI_PresentationFormCode
        {
            get
            {
                return this.cI_PresentationFormCodeField;
            }
            set
            {
                this.cI_PresentationFormCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationPresentationFormCI_PresentationFormCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationAbstract
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywords
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsKeyword[] mD_KeywordsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("keyword", IsNullable = false)]
        public MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsKeyword[] MD_Keywords
        {
            get
            {
                return this.mD_KeywordsField;
            }
            set
            {
                this.mD_KeywordsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsKeyword
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraints
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_Constraints mD_ConstraintsField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_Constraints MD_Constraints
        {
            get
            {
                return this.mD_ConstraintsField;
            }
            set
            {
                this.mD_ConstraintsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_Constraints
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_ConstraintsUseLimitation useLimitationField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_ConstraintsUseLimitation useLimitation
        {
            get
            {
                return this.useLimitationField;
            }
            set
            {
                this.useLimitationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_ConstraintsUseLimitation
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSpatialRepresentationType
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationSpatialRepresentationTypeMD_SpatialRepresentationTypeCode mD_SpatialRepresentationTypeCodeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationSpatialRepresentationTypeMD_SpatialRepresentationTypeCode MD_SpatialRepresentationTypeCode
        {
            get
            {
                return this.mD_SpatialRepresentationTypeCodeField;
            }
            set
            {
                this.mD_SpatialRepresentationTypeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSpatialRepresentationTypeMD_SpatialRepresentationTypeCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationLanguage
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationLanguageLanguageCode languageCodeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationLanguageLanguageCode LanguageCode
        {
            get
            {
                return this.languageCodeField;
            }
            set
            {
                this.languageCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationLanguageLanguageCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCharacterSet
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationCharacterSetMD_CharacterSetCode mD_CharacterSetCodeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCharacterSetMD_CharacterSetCode MD_CharacterSetCode
        {
            get
            {
                return this.mD_CharacterSetCodeField;
            }
            set
            {
                this.mD_CharacterSetCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCharacterSetMD_CharacterSetCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationTopicCategory
    {

        private string mD_TopicCategoryCodeField;

        /// <remarks/>
        public string MD_TopicCategoryCode
        {
            get
            {
                return this.mD_TopicCategoryCodeField;
            }
            set
            {
                this.mD_TopicCategoryCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtent
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_Extent eX_ExtentField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_Extent EX_Extent
        {
            get
            {
                return this.eX_ExtentField;
            }
            set
            {
                this.eX_ExtentField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_Extent
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentDescription descriptionField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElement[] geographicElementField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentVerticalElement verticalElementField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentDescription description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("geographicElement")]
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElement[] geographicElement
        {
            get
            {
                return this.geographicElementField;
            }
            set
            {
                this.geographicElementField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentVerticalElement verticalElement
        {
            get
            {
                return this.verticalElementField;
            }
            set
            {
                this.verticalElementField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentDescription
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElement
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_BoundingPolygon eX_BoundingPolygonField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBox eX_GeographicBoundingBoxField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_BoundingPolygon EX_BoundingPolygon
        {
            get
            {
                return this.eX_BoundingPolygonField;
            }
            set
            {
                this.eX_BoundingPolygonField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBox EX_GeographicBoundingBox
        {
            get
            {
                return this.eX_GeographicBoundingBoxField;
            }
            set
            {
                this.eX_GeographicBoundingBoxField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_BoundingPolygon
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_BoundingPolygonPolygon polygonField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_BoundingPolygonPolygon polygon
        {
            get
            {
                return this.polygonField;
            }
            set
            {
                this.polygonField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_BoundingPolygonPolygon
    {

        private Polygon polygonField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/gml")]
        public Polygon Polygon
        {
            get
            {
                return this.polygonField;
            }
            set
            {
                this.polygonField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class Polygon
    {

        private string descriptionField;

        private PolygonExterior exteriorField;

        private string idField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public PolygonExterior exterior
        {
            get
            {
                return this.exteriorField;
            }
            set
            {
                this.exteriorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    public partial class PolygonExterior
    {

        private PolygonExteriorLinearRing linearRingField;

        /// <remarks/>
        public PolygonExteriorLinearRing LinearRing
        {
            get
            {
                return this.linearRingField;
            }
            set
            {
                this.linearRingField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    public partial class PolygonExteriorLinearRing
    {

        private string coordinatesField;

        /// <remarks/>
        public string coordinates
        {
            get
            {
                return this.coordinatesField;
            }
            set
            {
                this.coordinatesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBox
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxWestBoundLongitude westBoundLongitudeField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxEastBoundLongitude eastBoundLongitudeField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxSouthBoundLatitude southBoundLatitudeField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxNorthBoundLatitude northBoundLatitudeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxWestBoundLongitude westBoundLongitude
        {
            get
            {
                return this.westBoundLongitudeField;
            }
            set
            {
                this.westBoundLongitudeField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxEastBoundLongitude eastBoundLongitude
        {
            get
            {
                return this.eastBoundLongitudeField;
            }
            set
            {
                this.eastBoundLongitudeField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxSouthBoundLatitude southBoundLatitude
        {
            get
            {
                return this.southBoundLatitudeField;
            }
            set
            {
                this.southBoundLatitudeField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxNorthBoundLatitude northBoundLatitude
        {
            get
            {
                return this.northBoundLatitudeField;
            }
            set
            {
                this.northBoundLatitudeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxWestBoundLongitude
    {

        private decimal decimalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public decimal Decimal
        {
            get
            {
                return this.decimalField;
            }
            set
            {
                this.decimalField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxEastBoundLongitude
    {

        private decimal decimalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public decimal Decimal
        {
            get
            {
                return this.decimalField;
            }
            set
            {
                this.decimalField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxSouthBoundLatitude
    {

        private decimal decimalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public decimal Decimal
        {
            get
            {
                return this.decimalField;
            }
            set
            {
                this.decimalField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxNorthBoundLatitude
    {

        private decimal decimalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public decimal Decimal
        {
            get
            {
                return this.decimalField;
            }
            set
            {
                this.decimalField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentVerticalElement
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentVerticalElementEX_VerticalExtent eX_VerticalExtentField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentVerticalElementEX_VerticalExtent EX_VerticalExtent
        {
            get
            {
                return this.eX_VerticalExtentField;
            }
            set
            {
                this.eX_VerticalExtentField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentVerticalElementEX_VerticalExtent
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentVerticalElementEX_VerticalExtentMinimumValue minimumValueField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentVerticalElementEX_VerticalExtentMaximumValue maximumValueField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentVerticalElementEX_VerticalExtentVerticalCRS verticalCRSField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentVerticalElementEX_VerticalExtentMinimumValue minimumValue
        {
            get
            {
                return this.minimumValueField;
            }
            set
            {
                this.minimumValueField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentVerticalElementEX_VerticalExtentMaximumValue maximumValue
        {
            get
            {
                return this.maximumValueField;
            }
            set
            {
                this.maximumValueField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentVerticalElementEX_VerticalExtentVerticalCRS verticalCRS
        {
            get
            {
                return this.verticalCRSField;
            }
            set
            {
                this.verticalCRSField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentVerticalElementEX_VerticalExtentMinimumValue
    {

        private decimal realField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public decimal Real
        {
            get
            {
                return this.realField;
            }
            set
            {
                this.realField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentVerticalElementEX_VerticalExtentMaximumValue
    {

        private decimal realField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public decimal Real
        {
            get
            {
                return this.realField;
            }
            set
            {
                this.realField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentVerticalElementEX_VerticalExtentVerticalCRS
    {

        private VerticalCRS verticalCRSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/gml")]
        public VerticalCRS VerticalCRS
        {
            get
            {
                return this.verticalCRSField;
            }
            set
            {
                this.verticalCRSField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class VerticalCRS
    {

        private VerticalCRSIdentifier identifierField;

        private string scopeField;

        private VerticalCRSVerticalCS verticalCSField;

        private VerticalCRSVerticalDatum verticalDatumField;

        private string idField;

        /// <remarks/>
        public VerticalCRSIdentifier identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        public string scope
        {
            get
            {
                return this.scopeField;
            }
            set
            {
                this.scopeField = value;
            }
        }

        /// <remarks/>
        public VerticalCRSVerticalCS verticalCS
        {
            get
            {
                return this.verticalCSField;
            }
            set
            {
                this.verticalCSField = value;
            }
        }

        /// <remarks/>
        public VerticalCRSVerticalDatum verticalDatum
        {
            get
            {
                return this.verticalDatumField;
            }
            set
            {
                this.verticalDatumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    public partial class VerticalCRSIdentifier
    {

        private string codeSpaceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeSpace
        {
            get
            {
                return this.codeSpaceField;
            }
            set
            {
                this.codeSpaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    public partial class VerticalCRSVerticalCS
    {

        private VerticalCRSVerticalCSVerticalCS verticalCSField;

        /// <remarks/>
        public VerticalCRSVerticalCSVerticalCS VerticalCS
        {
            get
            {
                return this.verticalCSField;
            }
            set
            {
                this.verticalCSField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    public partial class VerticalCRSVerticalCSVerticalCS
    {

        private VerticalCRSVerticalCSVerticalCSIdentifier identifierField;

        private VerticalCRSVerticalCSVerticalCSAxis axisField;

        private string idField;

        /// <remarks/>
        public VerticalCRSVerticalCSVerticalCSIdentifier identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        public VerticalCRSVerticalCSVerticalCSAxis axis
        {
            get
            {
                return this.axisField;
            }
            set
            {
                this.axisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    public partial class VerticalCRSVerticalCSVerticalCSIdentifier
    {

        private string codeSpaceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeSpace
        {
            get
            {
                return this.codeSpaceField;
            }
            set
            {
                this.codeSpaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    public partial class VerticalCRSVerticalCSVerticalCSAxis
    {

        private VerticalCRSVerticalCSVerticalCSAxisCoordinateSystemAxis coordinateSystemAxisField;

        /// <remarks/>
        public VerticalCRSVerticalCSVerticalCSAxisCoordinateSystemAxis CoordinateSystemAxis
        {
            get
            {
                return this.coordinateSystemAxisField;
            }
            set
            {
                this.coordinateSystemAxisField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    public partial class VerticalCRSVerticalCSVerticalCSAxisCoordinateSystemAxis
    {

        private VerticalCRSVerticalCSVerticalCSAxisCoordinateSystemAxisIdentifier identifierField;

        private string axisAbbrevField;

        private VerticalCRSVerticalCSVerticalCSAxisCoordinateSystemAxisAxisDirection axisDirectionField;

        private ushort maximumValueField;

        private string idField;

        private string uomField;

        /// <remarks/>
        public VerticalCRSVerticalCSVerticalCSAxisCoordinateSystemAxisIdentifier identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        public string axisAbbrev
        {
            get
            {
                return this.axisAbbrevField;
            }
            set
            {
                this.axisAbbrevField = value;
            }
        }

        /// <remarks/>
        public VerticalCRSVerticalCSVerticalCSAxisCoordinateSystemAxisAxisDirection axisDirection
        {
            get
            {
                return this.axisDirectionField;
            }
            set
            {
                this.axisDirectionField = value;
            }
        }

        /// <remarks/>
        public ushort maximumValue
        {
            get
            {
                return this.maximumValueField;
            }
            set
            {
                this.maximumValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string uom
        {
            get
            {
                return this.uomField;
            }
            set
            {
                this.uomField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    public partial class VerticalCRSVerticalCSVerticalCSAxisCoordinateSystemAxisIdentifier
    {

        private string codeSpaceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeSpace
        {
            get
            {
                return this.codeSpaceField;
            }
            set
            {
                this.codeSpaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    public partial class VerticalCRSVerticalCSVerticalCSAxisCoordinateSystemAxisAxisDirection
    {

        private string codeSpaceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeSpace
        {
            get
            {
                return this.codeSpaceField;
            }
            set
            {
                this.codeSpaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    public partial class VerticalCRSVerticalDatum
    {

        private VerticalCRSVerticalDatumVerticalDatum verticalDatumField;

        /// <remarks/>
        public VerticalCRSVerticalDatumVerticalDatum VerticalDatum
        {
            get
            {
                return this.verticalDatumField;
            }
            set
            {
                this.verticalDatumField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    public partial class VerticalCRSVerticalDatumVerticalDatum
    {

        private VerticalCRSVerticalDatumVerticalDatumIdentifier identifierField;

        private string nameField;

        private string scopeField;

        private string idField;

        /// <remarks/>
        public VerticalCRSVerticalDatumVerticalDatumIdentifier identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string scope
        {
            get
            {
                return this.scopeField;
            }
            set
            {
                this.scopeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    public partial class VerticalCRSVerticalDatumVerticalDatumIdentifier
    {

        private string codeSpaceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeSpace
        {
            get
            {
                return this.codeSpaceField;
            }
            set
            {
                this.codeSpaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContentInfo
    {

        private MD_MetadataContentInfoMD_CoverageDescription mD_CoverageDescriptionField;

        private TSXX_addMD tSXX_addMDField;

        /// <remarks/>
        public MD_MetadataContentInfoMD_CoverageDescription MD_CoverageDescription
        {
            get
            {
                return this.mD_CoverageDescriptionField;
            }
            set
            {
                this.mD_CoverageDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.infoterra.de/tsxx/")]
        public TSXX_addMD TSXX_addMD
        {
            get
            {
                return this.tSXX_addMDField;
            }
            set
            {
                this.tSXX_addMDField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContentInfoMD_CoverageDescription
    {

        private MD_MetadataContentInfoMD_CoverageDescriptionAttributeDescription attributeDescriptionField;

        private MD_MetadataContentInfoMD_CoverageDescriptionContentType contentTypeField;

        /// <remarks/>
        public MD_MetadataContentInfoMD_CoverageDescriptionAttributeDescription attributeDescription
        {
            get
            {
                return this.attributeDescriptionField;
            }
            set
            {
                this.attributeDescriptionField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataContentInfoMD_CoverageDescriptionContentType contentType
        {
            get
            {
                return this.contentTypeField;
            }
            set
            {
                this.contentTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContentInfoMD_CoverageDescriptionAttributeDescription
    {

        private string recordTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string RecordType
        {
            get
            {
                return this.recordTypeField;
            }
            set
            {
                this.recordTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContentInfoMD_CoverageDescriptionContentType
    {

        private MD_MetadataContentInfoMD_CoverageDescriptionContentTypeMD_CoverageContentTypeCode mD_CoverageContentTypeCodeField;

        /// <remarks/>
        public MD_MetadataContentInfoMD_CoverageDescriptionContentTypeMD_CoverageContentTypeCode MD_CoverageContentTypeCode
        {
            get
            {
                return this.mD_CoverageContentTypeCodeField;
            }
            set
            {
                this.mD_CoverageContentTypeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContentInfoMD_CoverageDescriptionContentTypeMD_CoverageContentTypeCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.infoterra.de/tsxx/", IsNullable = false)]
    public partial class TSXX_addMD
    {

        private TSXX_addMDDEMInfo dEMInfoField;

        private TSXX_addMDMissionInfo missionInfoField;

        private TSXX_addMDAcquisitionInfo acquisitionInfoField;

        /// <remarks/>
        public TSXX_addMDDEMInfo DEMInfo
        {
            get
            {
                return this.dEMInfoField;
            }
            set
            {
                this.dEMInfoField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDMissionInfo missionInfo
        {
            get
            {
                return this.missionInfoField;
            }
            set
            {
                this.missionInfoField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDAcquisitionInfo acquisitionInfo
        {
            get
            {
                return this.acquisitionInfoField;
            }
            set
            {
                this.acquisitionInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfo
    {

        private TSXX_addMDDEMInfoProductVariantInfo productVariantInfoField;

        private TSXX_addMDDEMInfoProductDetails productDetailsField;

        private TSXX_addMDDEMInfoProductAddContent productAddContentField;

        private TSXX_addMDDEMInfoProductStatistics productStatisticsField;

        private TSXX_addMDDEMInfoProductQuality productQualityField;

        private TSXX_addMDDEMInfoProcessingDetails processingDetailsField;

        /// <remarks/>
        public TSXX_addMDDEMInfoProductVariantInfo productVariantInfo
        {
            get
            {
                return this.productVariantInfoField;
            }
            set
            {
                this.productVariantInfoField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetails productDetails
        {
            get
            {
                return this.productDetailsField;
            }
            set
            {
                this.productDetailsField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductAddContent productAddContent
        {
            get
            {
                return this.productAddContentField;
            }
            set
            {
                this.productAddContentField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductStatistics productStatistics
        {
            get
            {
                return this.productStatisticsField;
            }
            set
            {
                this.productStatisticsField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductQuality productQuality
        {
            get
            {
                return this.productQualityField;
            }
            set
            {
                this.productQualityField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProcessingDetails processingDetails
        {
            get
            {
                return this.processingDetailsField;
            }
            set
            {
                this.processingDetailsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductVariantInfo
    {

        private string productTypeField;

        private string productTypeDescriptionField;

        private string productVariantField;

        private string productVariantDescriptionField;

        private byte resolutionVariantField;

        private TSXX_addMDDEMInfoProductVariantInfoReferenceDocument referenceDocumentField;

        private bool productCustomizationField;

        private string productCustomizationDescrField;

        /// <remarks/>
        public string productType
        {
            get
            {
                return this.productTypeField;
            }
            set
            {
                this.productTypeField = value;
            }
        }

        /// <remarks/>
        public string productTypeDescription
        {
            get
            {
                return this.productTypeDescriptionField;
            }
            set
            {
                this.productTypeDescriptionField = value;
            }
        }

        /// <remarks/>
        public string productVariant
        {
            get
            {
                return this.productVariantField;
            }
            set
            {
                this.productVariantField = value;
            }
        }

        /// <remarks/>
        public string productVariantDescription
        {
            get
            {
                return this.productVariantDescriptionField;
            }
            set
            {
                this.productVariantDescriptionField = value;
            }
        }

        /// <remarks/>
        public byte resolutionVariant
        {
            get
            {
                return this.resolutionVariantField;
            }
            set
            {
                this.resolutionVariantField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductVariantInfoReferenceDocument referenceDocument
        {
            get
            {
                return this.referenceDocumentField;
            }
            set
            {
                this.referenceDocumentField = value;
            }
        }

        /// <remarks/>
        public bool productCustomization
        {
            get
            {
                return this.productCustomizationField;
            }
            set
            {
                this.productCustomizationField = value;
            }
        }

        /// <remarks/>
        public string productCustomizationDescr
        {
            get
            {
                return this.productCustomizationDescrField;
            }
            set
            {
                this.productCustomizationDescrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductVariantInfoReferenceDocument
    {

        private string versionField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetails
    {

        private TSXX_addMDDEMInfoProductDetailsImageDetails imageDetailsField;

        private TSXX_addMDDEMInfoProductDetailsProductExtent productExtentField;

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsImageDetails imageDetails
        {
            get
            {
                return this.imageDetailsField;
            }
            set
            {
                this.imageDetailsField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsProductExtent productExtent
        {
            get
            {
                return this.productExtentField;
            }
            set
            {
                this.productExtentField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsImageDetails
    {

        private string imageDataFormatField;

        private string imageDataTypeField;

        private TSXX_addMDDEMInfoProductDetailsImageDetailsImageDataDepth imageDataDepthField;

        private byte numberOfLayersField;

        private string imageStorageOrderField;

        private string columnContentField;

        private string rowContentField;

        private TSXX_addMDDEMInfoProductDetailsImageDetailsImageRaster imageRasterField;

        private TSXX_addMDDEMInfoProductDetailsImageDetailsFilelocation filelocationField;

        /// <remarks/>
        public string imageDataFormat
        {
            get
            {
                return this.imageDataFormatField;
            }
            set
            {
                this.imageDataFormatField = value;
            }
        }

        /// <remarks/>
        public string imageDataType
        {
            get
            {
                return this.imageDataTypeField;
            }
            set
            {
                this.imageDataTypeField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsImageDetailsImageDataDepth imageDataDepth
        {
            get
            {
                return this.imageDataDepthField;
            }
            set
            {
                this.imageDataDepthField = value;
            }
        }

        /// <remarks/>
        public byte numberOfLayers
        {
            get
            {
                return this.numberOfLayersField;
            }
            set
            {
                this.numberOfLayersField = value;
            }
        }

        /// <remarks/>
        public string imageStorageOrder
        {
            get
            {
                return this.imageStorageOrderField;
            }
            set
            {
                this.imageStorageOrderField = value;
            }
        }

        /// <remarks/>
        public string columnContent
        {
            get
            {
                return this.columnContentField;
            }
            set
            {
                this.columnContentField = value;
            }
        }

        /// <remarks/>
        public string rowContent
        {
            get
            {
                return this.rowContentField;
            }
            set
            {
                this.rowContentField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsImageDetailsImageRaster imageRaster
        {
            get
            {
                return this.imageRasterField;
            }
            set
            {
                this.imageRasterField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsImageDetailsFilelocation filelocation
        {
            get
            {
                return this.filelocationField;
            }
            set
            {
                this.filelocationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsImageDetailsImageDataDepth
    {

        private string unitsField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsImageDetailsImageRaster
    {

        private ushort numberOfRowsField;

        private ushort numberOfColumnsField;

        private TSXX_addMDDEMInfoProductDetailsImageDetailsImageRasterColumnSpacing columnSpacingField;

        private TSXX_addMDDEMInfoProductDetailsImageDetailsImageRasterRowSpacing rowSpacingField;

        private TSXX_addMDDEMInfoProductDetailsImageDetailsImageRasterVerticalSpacing verticalSpacingField;

        /// <remarks/>
        public ushort numberOfRows
        {
            get
            {
                return this.numberOfRowsField;
            }
            set
            {
                this.numberOfRowsField = value;
            }
        }

        /// <remarks/>
        public ushort numberOfColumns
        {
            get
            {
                return this.numberOfColumnsField;
            }
            set
            {
                this.numberOfColumnsField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsImageDetailsImageRasterColumnSpacing columnSpacing
        {
            get
            {
                return this.columnSpacingField;
            }
            set
            {
                this.columnSpacingField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsImageDetailsImageRasterRowSpacing rowSpacing
        {
            get
            {
                return this.rowSpacingField;
            }
            set
            {
                this.rowSpacingField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsImageDetailsImageRasterVerticalSpacing verticalSpacing
        {
            get
            {
                return this.verticalSpacingField;
            }
            set
            {
                this.verticalSpacingField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsImageDetailsImageRasterColumnSpacing
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsImageDetailsImageRasterRowSpacing
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsImageDetailsImageRasterVerticalSpacing
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsImageDetailsFilelocation
    {

        private string hostField;

        private string pathField;

        private string fileField;

        /// <remarks/>
        public string host
        {
            get
            {
                return this.hostField;
            }
            set
            {
                this.hostField = value;
            }
        }

        /// <remarks/>
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        public string file
        {
            get
            {
                return this.fileField;
            }
            set
            {
                this.fileField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsProductExtent
    {

        private TSXX_addMDDEMInfoProductDetailsProductExtentSizeOfAOI sizeOfAOIField;

        private TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographic frameCoordsGeographicField;

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsProductExtentSizeOfAOI sizeOfAOI
        {
            get
            {
                return this.sizeOfAOIField;
            }
            set
            {
                this.sizeOfAOIField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographic frameCoordsGeographic
        {
            get
            {
                return this.frameCoordsGeographicField;
            }
            set
            {
                this.frameCoordsGeographicField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsProductExtentSizeOfAOI
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographic
    {

        private TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicEPSG ePSGField;

        private TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicUpperLeftLongitude upperLeftLongitudeField;

        private TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicUpperLeftLatitude upperLeftLatitudeField;

        private TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicUpperRightLongitude upperRightLongitudeField;

        private TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicUpperRightLatitude upperRightLatitudeField;

        private TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicLowerLeftLongitude lowerLeftLongitudeField;

        private TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicLowerLeftLatitude lowerLeftLatitudeField;

        private TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicLowerRightLongitude lowerRightLongitudeField;

        private TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicLowerRightLatitude lowerRightLatitudeField;

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicEPSG EPSG
        {
            get
            {
                return this.ePSGField;
            }
            set
            {
                this.ePSGField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicUpperLeftLongitude upperLeftLongitude
        {
            get
            {
                return this.upperLeftLongitudeField;
            }
            set
            {
                this.upperLeftLongitudeField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicUpperLeftLatitude upperLeftLatitude
        {
            get
            {
                return this.upperLeftLatitudeField;
            }
            set
            {
                this.upperLeftLatitudeField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicUpperRightLongitude upperRightLongitude
        {
            get
            {
                return this.upperRightLongitudeField;
            }
            set
            {
                this.upperRightLongitudeField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicUpperRightLatitude upperRightLatitude
        {
            get
            {
                return this.upperRightLatitudeField;
            }
            set
            {
                this.upperRightLatitudeField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicLowerLeftLongitude lowerLeftLongitude
        {
            get
            {
                return this.lowerLeftLongitudeField;
            }
            set
            {
                this.lowerLeftLongitudeField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicLowerLeftLatitude lowerLeftLatitude
        {
            get
            {
                return this.lowerLeftLatitudeField;
            }
            set
            {
                this.lowerLeftLatitudeField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicLowerRightLongitude lowerRightLongitude
        {
            get
            {
                return this.lowerRightLongitudeField;
            }
            set
            {
                this.lowerRightLongitudeField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicLowerRightLatitude lowerRightLatitude
        {
            get
            {
                return this.lowerRightLatitudeField;
            }
            set
            {
                this.lowerRightLatitudeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicEPSG
    {

        private string codeListField;

        private ushort codeListValueField;

        private ushort valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public ushort Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicUpperLeftLongitude
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicUpperLeftLatitude
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicUpperRightLongitude
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicUpperRightLatitude
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicLowerLeftLongitude
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicLowerLeftLatitude
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicLowerRightLongitude
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductDetailsProductExtentFrameCoordsGeographicLowerRightLatitude
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductAddContent
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("productDescriptor", typeof(TSXX_addMDDEMInfoProductAddContentProductDescriptor))]
        [System.Xml.Serialization.XmlElementAttribute("productLayer", typeof(TSXX_addMDDEMInfoProductAddContentProductLayer))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductAddContentProductDescriptor
    {

        private string contentTypeField;

        private string contentDetailField;

        private string contentLongNameField;

        private string contentDescriptionField;

        private string contentDataFormatField;

        private TSXX_addMDDEMInfoProductAddContentProductDescriptorContentLocation contentLocationField;

        /// <remarks/>
        public string contentType
        {
            get
            {
                return this.contentTypeField;
            }
            set
            {
                this.contentTypeField = value;
            }
        }

        /// <remarks/>
        public string contentDetail
        {
            get
            {
                return this.contentDetailField;
            }
            set
            {
                this.contentDetailField = value;
            }
        }

        /// <remarks/>
        public string contentLongName
        {
            get
            {
                return this.contentLongNameField;
            }
            set
            {
                this.contentLongNameField = value;
            }
        }

        /// <remarks/>
        public string contentDescription
        {
            get
            {
                return this.contentDescriptionField;
            }
            set
            {
                this.contentDescriptionField = value;
            }
        }

        /// <remarks/>
        public string contentDataFormat
        {
            get
            {
                return this.contentDataFormatField;
            }
            set
            {
                this.contentDataFormatField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductAddContentProductDescriptorContentLocation contentLocation
        {
            get
            {
                return this.contentLocationField;
            }
            set
            {
                this.contentLocationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductAddContentProductDescriptorContentLocation
    {

        private string hostField;

        private string pathField;

        private string fileField;

        /// <remarks/>
        public string host
        {
            get
            {
                return this.hostField;
            }
            set
            {
                this.hostField = value;
            }
        }

        /// <remarks/>
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        public string file
        {
            get
            {
                return this.fileField;
            }
            set
            {
                this.fileField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductAddContentProductLayer
    {

        private string contentTypeField;

        private string contentDetailField;

        private string contentLongNameField;

        private string contentDescriptionField;

        private string contentDataFormatField;

        private string contentDataTypeField;

        private TSXX_addMDDEMInfoProductAddContentProductLayerContentDataDepth contentDataDepthField;

        private byte numberOfLayersField;

        private string imageStorageOrderField;

        private string columnContentField;

        private string rowContentField;

        private TSXX_addMDDEMInfoProductAddContentProductLayerImageRaster imageRasterField;

        private TSXX_addMDDEMInfoProductAddContentProductLayerContentLocation contentLocationField;

        /// <remarks/>
        public string contentType
        {
            get
            {
                return this.contentTypeField;
            }
            set
            {
                this.contentTypeField = value;
            }
        }

        /// <remarks/>
        public string contentDetail
        {
            get
            {
                return this.contentDetailField;
            }
            set
            {
                this.contentDetailField = value;
            }
        }

        /// <remarks/>
        public string contentLongName
        {
            get
            {
                return this.contentLongNameField;
            }
            set
            {
                this.contentLongNameField = value;
            }
        }

        /// <remarks/>
        public string contentDescription
        {
            get
            {
                return this.contentDescriptionField;
            }
            set
            {
                this.contentDescriptionField = value;
            }
        }

        /// <remarks/>
        public string contentDataFormat
        {
            get
            {
                return this.contentDataFormatField;
            }
            set
            {
                this.contentDataFormatField = value;
            }
        }

        /// <remarks/>
        public string contentDataType
        {
            get
            {
                return this.contentDataTypeField;
            }
            set
            {
                this.contentDataTypeField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductAddContentProductLayerContentDataDepth contentDataDepth
        {
            get
            {
                return this.contentDataDepthField;
            }
            set
            {
                this.contentDataDepthField = value;
            }
        }

        /// <remarks/>
        public byte numberOfLayers
        {
            get
            {
                return this.numberOfLayersField;
            }
            set
            {
                this.numberOfLayersField = value;
            }
        }

        /// <remarks/>
        public string imageStorageOrder
        {
            get
            {
                return this.imageStorageOrderField;
            }
            set
            {
                this.imageStorageOrderField = value;
            }
        }

        /// <remarks/>
        public string columnContent
        {
            get
            {
                return this.columnContentField;
            }
            set
            {
                this.columnContentField = value;
            }
        }

        /// <remarks/>
        public string rowContent
        {
            get
            {
                return this.rowContentField;
            }
            set
            {
                this.rowContentField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductAddContentProductLayerImageRaster imageRaster
        {
            get
            {
                return this.imageRasterField;
            }
            set
            {
                this.imageRasterField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductAddContentProductLayerContentLocation contentLocation
        {
            get
            {
                return this.contentLocationField;
            }
            set
            {
                this.contentLocationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductAddContentProductLayerContentDataDepth
    {

        private string unitsField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductAddContentProductLayerImageRaster
    {

        private ushort numberOfRowsField;

        private ushort numberOfColumnsField;

        private TSXX_addMDDEMInfoProductAddContentProductLayerImageRasterColumnSpacing columnSpacingField;

        private TSXX_addMDDEMInfoProductAddContentProductLayerImageRasterRowSpacing rowSpacingField;

        /// <remarks/>
        public ushort numberOfRows
        {
            get
            {
                return this.numberOfRowsField;
            }
            set
            {
                this.numberOfRowsField = value;
            }
        }

        /// <remarks/>
        public ushort numberOfColumns
        {
            get
            {
                return this.numberOfColumnsField;
            }
            set
            {
                this.numberOfColumnsField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductAddContentProductLayerImageRasterColumnSpacing columnSpacing
        {
            get
            {
                return this.columnSpacingField;
            }
            set
            {
                this.columnSpacingField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductAddContentProductLayerImageRasterRowSpacing rowSpacing
        {
            get
            {
                return this.rowSpacingField;
            }
            set
            {
                this.rowSpacingField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductAddContentProductLayerImageRasterColumnSpacing
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductAddContentProductLayerImageRasterRowSpacing
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductAddContentProductLayerContentLocation
    {

        private string hostField;

        private string pathField;

        private string fileField;

        /// <remarks/>
        public string host
        {
            get
            {
                return this.hostField;
            }
            set
            {
                this.hostField = value;
            }
        }

        /// <remarks/>
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        public string file
        {
            get
            {
                return this.fileField;
            }
            set
            {
                this.fileField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductStatistics
    {

        private TSXX_addMDDEMInfoProductStatisticsNrInvalidPixels nrInvalidPixelsField;

        private uint nrValidPixelsField;

        private TSXX_addMDDEMInfoProductStatisticsMinValue minValueField;

        private TSXX_addMDDEMInfoProductStatisticsMaxValue maxValueField;

        private TSXX_addMDDEMInfoProductStatisticsMeanValue meanValueField;

        private TSXX_addMDDEMInfoProductStatisticsStdDev stdDevField;

        /// <remarks/>
        public TSXX_addMDDEMInfoProductStatisticsNrInvalidPixels nrInvalidPixels
        {
            get
            {
                return this.nrInvalidPixelsField;
            }
            set
            {
                this.nrInvalidPixelsField = value;
            }
        }

        /// <remarks/>
        public uint nrValidPixels
        {
            get
            {
                return this.nrValidPixelsField;
            }
            set
            {
                this.nrValidPixelsField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductStatisticsMinValue minValue
        {
            get
            {
                return this.minValueField;
            }
            set
            {
                this.minValueField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductStatisticsMaxValue maxValue
        {
            get
            {
                return this.maxValueField;
            }
            set
            {
                this.maxValueField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductStatisticsMeanValue meanValue
        {
            get
            {
                return this.meanValueField;
            }
            set
            {
                this.meanValueField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProductStatisticsStdDev stdDev
        {
            get
            {
                return this.stdDevField;
            }
            set
            {
                this.stdDevField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductStatisticsNrInvalidPixels
    {

        private short valueInvalidPixelsField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public short valueInvalidPixels
        {
            get
            {
                return this.valueInvalidPixelsField;
            }
            set
            {
                this.valueInvalidPixelsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductStatisticsMinValue
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductStatisticsMaxValue
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductStatisticsMeanValue
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductStatisticsStdDev
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProductQuality
    {

        private string qualityRemarkField;

        private bool availabilityOfReferenceDatasetField;

        private System.DateTime dateofAnalysisField;

        /// <remarks/>
        public string qualityRemark
        {
            get
            {
                return this.qualityRemarkField;
            }
            set
            {
                this.qualityRemarkField = value;
            }
        }

        /// <remarks/>
        public bool availabilityOfReferenceDataset
        {
            get
            {
                return this.availabilityOfReferenceDatasetField;
            }
            set
            {
                this.availabilityOfReferenceDatasetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DateofAnalysis
        {
            get
            {
                return this.dateofAnalysisField;
            }
            set
            {
                this.dateofAnalysisField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProcessingDetails
    {

        private TSXX_addMDDEMInfoProcessingDetailsDataProcessing dataProcessingField;

        private TSXX_addMDDEMInfoProcessingDetailsPostProcessing postProcessingField;

        /// <remarks/>
        public TSXX_addMDDEMInfoProcessingDetailsDataProcessing dataProcessing
        {
            get
            {
                return this.dataProcessingField;
            }
            set
            {
                this.dataProcessingField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProcessingDetailsPostProcessing postProcessing
        {
            get
            {
                return this.postProcessingField;
            }
            set
            {
                this.postProcessingField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProcessingDetailsDataProcessing
    {

        private string productBaseTypeField;

        private TSXX_addMDDEMInfoProcessingDetailsDataProcessingCitation citationField;

        private TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfo generationInfoField;

        /// <remarks/>
        public string ProductBaseType
        {
            get
            {
                return this.productBaseTypeField;
            }
            set
            {
                this.productBaseTypeField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProcessingDetailsDataProcessingCitation citation
        {
            get
            {
                return this.citationField;
            }
            set
            {
                this.citationField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfo generationInfo
        {
            get
            {
                return this.generationInfoField;
            }
            set
            {
                this.generationInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProcessingDetailsDataProcessingCitation
    {

        private CI_Citation cI_CitationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
        public CI_Citation CI_Citation
        {
            get
            {
                return this.cI_CitationField;
            }
            set
            {
                this.cI_CitationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
    public partial class CI_Citation
    {

        private CI_CitationTitle titleField;

        private CI_CitationDate dateField;

        private CI_CitationCitedResponsibleParty citedResponsiblePartyField;

        /// <remarks/>
        public CI_CitationTitle title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public CI_CitationDate date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        public CI_CitationCitedResponsibleParty citedResponsibleParty
        {
            get
            {
                return this.citedResponsiblePartyField;
            }
            set
            {
                this.citedResponsiblePartyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class CI_CitationTitle
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class CI_CitationDate
    {

        private CI_CitationDateCI_Date cI_DateField;

        /// <remarks/>
        public CI_CitationDateCI_Date CI_Date
        {
            get
            {
                return this.cI_DateField;
            }
            set
            {
                this.cI_DateField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class CI_CitationDateCI_Date
    {

        private CI_CitationDateCI_DateDate dateField;

        private CI_CitationDateCI_DateDateType dateTypeField;

        /// <remarks/>
        public CI_CitationDateCI_DateDate date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        public CI_CitationDateCI_DateDateType dateType
        {
            get
            {
                return this.dateTypeField;
            }
            set
            {
                this.dateTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class CI_CitationDateCI_DateDate
    {

        private System.DateTime dateField;

        private bool dateFieldSpecified;

        private System.DateTime dateTimeField;

        private bool dateTimeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco", DataType = "date")]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateSpecified
        {
            get
            {
                return this.dateFieldSpecified;
            }
            set
            {
                this.dateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public System.DateTime DateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateTimeSpecified
        {
            get
            {
                return this.dateTimeFieldSpecified;
            }
            set
            {
                this.dateTimeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class CI_CitationDateCI_DateDateType
    {

        private CI_CitationDateCI_DateDateTypeCI_DateTypeCode cI_DateTypeCodeField;

        /// <remarks/>
        public CI_CitationDateCI_DateDateTypeCI_DateTypeCode CI_DateTypeCode
        {
            get
            {
                return this.cI_DateTypeCodeField;
            }
            set
            {
                this.cI_DateTypeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class CI_CitationDateCI_DateDateTypeCI_DateTypeCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class CI_CitationCitedResponsibleParty
    {

        private CI_CitationCitedResponsiblePartyCI_ResponsibleParty cI_ResponsiblePartyField;

        /// <remarks/>
        public CI_CitationCitedResponsiblePartyCI_ResponsibleParty CI_ResponsibleParty
        {
            get
            {
                return this.cI_ResponsiblePartyField;
            }
            set
            {
                this.cI_ResponsiblePartyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class CI_CitationCitedResponsiblePartyCI_ResponsibleParty
    {

        private CI_CitationCitedResponsiblePartyCI_ResponsiblePartyOrganisationName organisationNameField;

        private CI_CitationCitedResponsiblePartyCI_ResponsiblePartyRole roleField;

        /// <remarks/>
        public CI_CitationCitedResponsiblePartyCI_ResponsiblePartyOrganisationName organisationName
        {
            get
            {
                return this.organisationNameField;
            }
            set
            {
                this.organisationNameField = value;
            }
        }

        /// <remarks/>
        public CI_CitationCitedResponsiblePartyCI_ResponsiblePartyRole role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class CI_CitationCitedResponsiblePartyCI_ResponsiblePartyOrganisationName
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class CI_CitationCitedResponsiblePartyCI_ResponsiblePartyRole
    {

        private CI_CitationCitedResponsiblePartyCI_ResponsiblePartyRoleCI_RoleCode cI_RoleCodeField;

        /// <remarks/>
        public CI_CitationCitedResponsiblePartyCI_ResponsiblePartyRoleCI_RoleCode CI_RoleCode
        {
            get
            {
                return this.cI_RoleCodeField;
            }
            set
            {
                this.cI_RoleCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class CI_CitationCitedResponsiblePartyCI_ResponsiblePartyRoleCI_RoleCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfo
    {

        private string demTileIdentifierField;

        private byte demTileVersionField;

        private string demTileStatusField;

        private string generationFacilityField;

        private string copyrightInfoField;

        private TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoGenerationSystem generationSystemField;

        private System.DateTime generationTimeField;

        private string referenceDocumentField;

        private string revisionField;

        private TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoProcessorDetails processorDetailsField;

        /// <remarks/>
        public string demTileIdentifier
        {
            get
            {
                return this.demTileIdentifierField;
            }
            set
            {
                this.demTileIdentifierField = value;
            }
        }

        /// <remarks/>
        public byte demTileVersion
        {
            get
            {
                return this.demTileVersionField;
            }
            set
            {
                this.demTileVersionField = value;
            }
        }

        /// <remarks/>
        public string demTileStatus
        {
            get
            {
                return this.demTileStatusField;
            }
            set
            {
                this.demTileStatusField = value;
            }
        }

        /// <remarks/>
        public string generationFacility
        {
            get
            {
                return this.generationFacilityField;
            }
            set
            {
                this.generationFacilityField = value;
            }
        }

        /// <remarks/>
        public string copyrightInfo
        {
            get
            {
                return this.copyrightInfoField;
            }
            set
            {
                this.copyrightInfoField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoGenerationSystem generationSystem
        {
            get
            {
                return this.generationSystemField;
            }
            set
            {
                this.generationSystemField = value;
            }
        }

        /// <remarks/>
        public System.DateTime generationTime
        {
            get
            {
                return this.generationTimeField;
            }
            set
            {
                this.generationTimeField = value;
            }
        }

        /// <remarks/>
        public string referenceDocument
        {
            get
            {
                return this.referenceDocumentField;
            }
            set
            {
                this.referenceDocumentField = value;
            }
        }

        /// <remarks/>
        public string revision
        {
            get
            {
                return this.revisionField;
            }
            set
            {
                this.revisionField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoProcessorDetails processorDetails
        {
            get
            {
                return this.processorDetailsField;
            }
            set
            {
                this.processorDetailsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoGenerationSystem
    {

        private decimal versionField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoProcessorDetails
    {

        private string processingRevisionField;

        private string processingVersionCalOldestField;

        private string processingVersionCalLatestField;

        private string processingVersionMosOldestField;

        private string processingVersionMosLatestField;

        private string processingVersionArchField;

        private byte numberOfUsedAcquisitionsField;

        private byte numberOfUsedScenesField;

        private byte minNumberCoveragesField;

        private byte maxNumberCoveragesField;

        private TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoProcessorDetailsCartographicParameters cartographicParametersField;

        private TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoProcessorDetailsProcessingParameter processingParameterField;

        /// <remarks/>
        public string processingRevision
        {
            get
            {
                return this.processingRevisionField;
            }
            set
            {
                this.processingRevisionField = value;
            }
        }

        /// <remarks/>
        public string processingVersionCalOldest
        {
            get
            {
                return this.processingVersionCalOldestField;
            }
            set
            {
                this.processingVersionCalOldestField = value;
            }
        }

        /// <remarks/>
        public string processingVersionCalLatest
        {
            get
            {
                return this.processingVersionCalLatestField;
            }
            set
            {
                this.processingVersionCalLatestField = value;
            }
        }

        /// <remarks/>
        public string processingVersionMosOldest
        {
            get
            {
                return this.processingVersionMosOldestField;
            }
            set
            {
                this.processingVersionMosOldestField = value;
            }
        }

        /// <remarks/>
        public string processingVersionMosLatest
        {
            get
            {
                return this.processingVersionMosLatestField;
            }
            set
            {
                this.processingVersionMosLatestField = value;
            }
        }

        /// <remarks/>
        public string processingVersionArch
        {
            get
            {
                return this.processingVersionArchField;
            }
            set
            {
                this.processingVersionArchField = value;
            }
        }

        /// <remarks/>
        public byte numberOfUsedAcquisitions
        {
            get
            {
                return this.numberOfUsedAcquisitionsField;
            }
            set
            {
                this.numberOfUsedAcquisitionsField = value;
            }
        }

        /// <remarks/>
        public byte numberOfUsedScenes
        {
            get
            {
                return this.numberOfUsedScenesField;
            }
            set
            {
                this.numberOfUsedScenesField = value;
            }
        }

        /// <remarks/>
        public byte minNumberCoverages
        {
            get
            {
                return this.minNumberCoveragesField;
            }
            set
            {
                this.minNumberCoveragesField = value;
            }
        }

        /// <remarks/>
        public byte maxNumberCoverages
        {
            get
            {
                return this.maxNumberCoveragesField;
            }
            set
            {
                this.maxNumberCoveragesField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoProcessorDetailsCartographicParameters cartographicParameters
        {
            get
            {
                return this.cartographicParametersField;
            }
            set
            {
                this.cartographicParametersField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoProcessorDetailsProcessingParameter processingParameter
        {
            get
            {
                return this.processingParameterField;
            }
            set
            {
                this.processingParameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoProcessorDetailsCartographicParameters
    {

        private string horizontalDatumCodeField;

        private string verticalDatumCodeField;

        private string coordinateSystemField;

        /// <remarks/>
        public string horizontalDatumCode
        {
            get
            {
                return this.horizontalDatumCodeField;
            }
            set
            {
                this.horizontalDatumCodeField = value;
            }
        }

        /// <remarks/>
        public string verticalDatumCode
        {
            get
            {
                return this.verticalDatumCodeField;
            }
            set
            {
                this.verticalDatumCodeField = value;
            }
        }

        /// <remarks/>
        public string coordinateSystem
        {
            get
            {
                return this.coordinateSystemField;
            }
            set
            {
                this.coordinateSystemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoProcessorDetailsProcessingParameter
    {

        private TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoProcessorDetailsProcessingParameterBestResolutionOnGround bestResolutionOnGroundField;

        private TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoProcessorDetailsProcessingParameterBestVerticalResolution bestVerticalResolutionField;

        private bool phaseInformationIncludedField;

        private string accessRegionField;

        private bool onTopMosaicField;

        private string demInterpolationMethodField;

        /// <remarks/>
        public TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoProcessorDetailsProcessingParameterBestResolutionOnGround bestResolutionOnGround
        {
            get
            {
                return this.bestResolutionOnGroundField;
            }
            set
            {
                this.bestResolutionOnGroundField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoProcessorDetailsProcessingParameterBestVerticalResolution bestVerticalResolution
        {
            get
            {
                return this.bestVerticalResolutionField;
            }
            set
            {
                this.bestVerticalResolutionField = value;
            }
        }

        /// <remarks/>
        public bool phaseInformationIncluded
        {
            get
            {
                return this.phaseInformationIncludedField;
            }
            set
            {
                this.phaseInformationIncludedField = value;
            }
        }

        /// <remarks/>
        public string accessRegion
        {
            get
            {
                return this.accessRegionField;
            }
            set
            {
                this.accessRegionField = value;
            }
        }

        /// <remarks/>
        public bool onTopMosaic
        {
            get
            {
                return this.onTopMosaicField;
            }
            set
            {
                this.onTopMosaicField = value;
            }
        }

        /// <remarks/>
        public string demInterpolationMethod
        {
            get
            {
                return this.demInterpolationMethodField;
            }
            set
            {
                this.demInterpolationMethodField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoProcessorDetailsProcessingParameterBestResolutionOnGround
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProcessingDetailsDataProcessingGenerationInfoProcessorDetailsProcessingParameterBestVerticalResolution
    {

        private string unitsField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProcessingDetailsPostProcessing
    {

        private TSXX_addMDDEMInfoProcessingDetailsPostProcessingCitation citationField;

        private TSXX_addMDDEMInfoProcessingDetailsPostProcessingGenerationSystem generationSystemField;

        /// <remarks/>
        public TSXX_addMDDEMInfoProcessingDetailsPostProcessingCitation citation
        {
            get
            {
                return this.citationField;
            }
            set
            {
                this.citationField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDDEMInfoProcessingDetailsPostProcessingGenerationSystem generationSystem
        {
            get
            {
                return this.generationSystemField;
            }
            set
            {
                this.generationSystemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProcessingDetailsPostProcessingCitation
    {

        private CI_Citation cI_CitationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
        public CI_Citation CI_Citation
        {
            get
            {
                return this.cI_CitationField;
            }
            set
            {
                this.cI_CitationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDDEMInfoProcessingDetailsPostProcessingGenerationSystem
    {

        private string versionField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDMissionInfo
    {

        private string missionField;

        private TSXX_addMDMissionInfoSatellite[] satelliteField;

        private string sourceField;

        /// <remarks/>
        public string mission
        {
            get
            {
                return this.missionField;
            }
            set
            {
                this.missionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("satellite")]
        public TSXX_addMDMissionInfoSatellite[] satellite
        {
            get
            {
                return this.satelliteField;
            }
            set
            {
                this.satelliteField = value;
            }
        }

        /// <remarks/>
        public string source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDMissionInfoSatellite
    {

        private byte numField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte num
        {
            get
            {
                return this.numField;
            }
            set
            {
                this.numField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDAcquisitionInfo
    {

        private string sensorField;

        private string cooperativeModeField;

        private string imagingModeField;

        private string lookDirectionField;

        private string orbitDirectionField;

        private string polarisationModeField;

        private string polarisationField;

        private TSXX_addMDAcquisitionInfoTemporalCoverage temporalCoverageField;

        /// <remarks/>
        public string sensor
        {
            get
            {
                return this.sensorField;
            }
            set
            {
                this.sensorField = value;
            }
        }

        /// <remarks/>
        public string cooperativeMode
        {
            get
            {
                return this.cooperativeModeField;
            }
            set
            {
                this.cooperativeModeField = value;
            }
        }

        /// <remarks/>
        public string imagingMode
        {
            get
            {
                return this.imagingModeField;
            }
            set
            {
                this.imagingModeField = value;
            }
        }

        /// <remarks/>
        public string lookDirection
        {
            get
            {
                return this.lookDirectionField;
            }
            set
            {
                this.lookDirectionField = value;
            }
        }

        /// <remarks/>
        public string orbitDirection
        {
            get
            {
                return this.orbitDirectionField;
            }
            set
            {
                this.orbitDirectionField = value;
            }
        }

        /// <remarks/>
        public string polarisationMode
        {
            get
            {
                return this.polarisationModeField;
            }
            set
            {
                this.polarisationModeField = value;
            }
        }

        /// <remarks/>
        public string polarisation
        {
            get
            {
                return this.polarisationField;
            }
            set
            {
                this.polarisationField = value;
            }
        }

        /// <remarks/>
        public TSXX_addMDAcquisitionInfoTemporalCoverage temporalCoverage
        {
            get
            {
                return this.temporalCoverageField;
            }
            set
            {
                this.temporalCoverageField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.infoterra.de/tsxx/")]
    public partial class TSXX_addMDAcquisitionInfoTemporalCoverage
    {

        private System.DateTime tsxx_startTimeField;

        private System.DateTime tsxx_stopTimeField;

        /// <remarks/>
        public System.DateTime tsxx_startTime
        {
            get
            {
                return this.tsxx_startTimeField;
            }
            set
            {
                this.tsxx_startTimeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime tsxx_stopTime
        {
            get
            {
                return this.tsxx_stopTimeField;
            }
            set
            {
                this.tsxx_stopTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataMetadataConstraints
    {

        private MD_MetadataMetadataConstraintsMD_LegalConstraints mD_LegalConstraintsField;

        /// <remarks/>
        public MD_MetadataMetadataConstraintsMD_LegalConstraints MD_LegalConstraints
        {
            get
            {
                return this.mD_LegalConstraintsField;
            }
            set
            {
                this.mD_LegalConstraintsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataMetadataConstraintsMD_LegalConstraints
    {

        private MD_MetadataMetadataConstraintsMD_LegalConstraintsAccessConstraints accessConstraintsField;

        private MD_MetadataMetadataConstraintsMD_LegalConstraintsUseConstraints useConstraintsField;

        private MD_MetadataMetadataConstraintsMD_LegalConstraintsOtherConstraints otherConstraintsField;

        /// <remarks/>
        public MD_MetadataMetadataConstraintsMD_LegalConstraintsAccessConstraints accessConstraints
        {
            get
            {
                return this.accessConstraintsField;
            }
            set
            {
                this.accessConstraintsField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataMetadataConstraintsMD_LegalConstraintsUseConstraints useConstraints
        {
            get
            {
                return this.useConstraintsField;
            }
            set
            {
                this.useConstraintsField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataMetadataConstraintsMD_LegalConstraintsOtherConstraints otherConstraints
        {
            get
            {
                return this.otherConstraintsField;
            }
            set
            {
                this.otherConstraintsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataMetadataConstraintsMD_LegalConstraintsAccessConstraints
    {

        private MD_MetadataMetadataConstraintsMD_LegalConstraintsAccessConstraintsMD_RestrictionCode mD_RestrictionCodeField;

        /// <remarks/>
        public MD_MetadataMetadataConstraintsMD_LegalConstraintsAccessConstraintsMD_RestrictionCode MD_RestrictionCode
        {
            get
            {
                return this.mD_RestrictionCodeField;
            }
            set
            {
                this.mD_RestrictionCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataMetadataConstraintsMD_LegalConstraintsAccessConstraintsMD_RestrictionCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataMetadataConstraintsMD_LegalConstraintsUseConstraints
    {

        private MD_MetadataMetadataConstraintsMD_LegalConstraintsUseConstraintsMD_RestrictionCode mD_RestrictionCodeField;

        /// <remarks/>
        public MD_MetadataMetadataConstraintsMD_LegalConstraintsUseConstraintsMD_RestrictionCode MD_RestrictionCode
        {
            get
            {
                return this.mD_RestrictionCodeField;
            }
            set
            {
                this.mD_RestrictionCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataMetadataConstraintsMD_LegalConstraintsUseConstraintsMD_RestrictionCode
    {

        private string codeListField;

        private string codeListValueField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataMetadataConstraintsMD_LegalConstraintsOtherConstraints
    {

        private string nilReasonField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }
    }


}
