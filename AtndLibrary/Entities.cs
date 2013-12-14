using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtndLibrary
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class hash
    {

        private byte results_returnedField;

        private ushort results_availableField;

        private byte results_startField;

        private hashEvent[] eventsField;

        /// <remarks/>
        public byte results_returned
        {
            get
            {
                return this.results_returnedField;
            }
            set
            {
                this.results_returnedField = value;
            }
        }

        /// <remarks/>
        public ushort results_available
        {
            get
            {
                return this.results_availableField;
            }
            set
            {
                this.results_availableField = value;
            }
        }

        /// <remarks/>
        public byte results_start
        {
            get
            {
                return this.results_startField;
            }
            set
            {
                this.results_startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("event", IsNullable = false)]
        public hashEvent[] events
        {
            get
            {
                return this.eventsField;
            }
            set
            {
                this.eventsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class hashEvent
    {

        private string event_idField;

        private string titleField;

        private object catchField;

        private string descriptionField;

        private string event_urlField;

        private string logo_imageField;

        private System.DateTime started_atField;

        private System.DateTime ended_atField;

        private hashEventCategory[] categoriesField;

        private object urlField;

        private ushort limitField;

        private string addressField;

        private string placeField;

        private decimal latField;

        private decimal lonField;

        private string owner_idField;

        private string owner_nicknameField;

        private object recommended_twitter_accountField;

        private string owner_twitter_idField;

        private string owner_facebook_idField;

        private object owner_google_plus_idField;

        private byte acceptedField;

        private byte waitingField;

        private object hash_tagField;

        private System.DateTime updated_atField;

        private string owner_twitter_imgField;

        private string owner_facebook_imgField;

        private object owner_google_plus_imgField;

        private object deleted_atField;

        private hashEventTicket[] ticketsField;

        /// <remarks/>
        public string event_id
        {
            get
            {
                return this.event_idField;
            }
            set
            {
                this.event_idField = value;
            }
        }

        /// <remarks/>
        public string title
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
        public object @catch
        {
            get
            {
                return this.catchField;
            }
            set
            {
                this.catchField = value;
            }
        }

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
        public string event_url
        {
            get
            {
                return this.event_urlField;
            }
            set
            {
                this.event_urlField = value;
            }
        }

        /// <remarks/>
        public string logo_image
        {
            get
            {
                return this.logo_imageField;
            }
            set
            {
                this.logo_imageField = value;
            }
        }

        /// <remarks/>
        public System.DateTime started_at
        {
            get
            {
                return this.started_atField;
            }
            set
            {
                this.started_atField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ended_at
        {
            get
            {
                return this.ended_atField;
            }
            set
            {
                this.ended_atField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("category", IsNullable = false)]
        public hashEventCategory[] categories
        {
            get
            {
                return this.categoriesField;
            }
            set
            {
                this.categoriesField = value;
            }
        }

        /// <remarks/>
        public object url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public ushort limit
        {
            get
            {
                return this.limitField;
            }
            set
            {
                this.limitField = value;
            }
        }

        /// <remarks/>
        public string address
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
        public string place
        {
            get
            {
                return this.placeField;
            }
            set
            {
                this.placeField = value;
            }
        }

        /// <remarks/>
        public decimal lat
        {
            get
            {
                return this.latField;
            }
            set
            {
                this.latField = value;
            }
        }

        /// <remarks/>
        public decimal lon
        {
            get
            {
                return this.lonField;
            }
            set
            {
                this.lonField = value;
            }
        }

        /// <remarks/>
        public string owner_id
        {
            get
            {
                return this.owner_idField;
            }
            set
            {
                this.owner_idField = value;
            }
        }

        /// <remarks/>
        public string owner_nickname
        {
            get
            {
                return this.owner_nicknameField;
            }
            set
            {
                this.owner_nicknameField = value;
            }
        }

        /// <remarks/>
        public object recommended_twitter_account
        {
            get
            {
                return this.recommended_twitter_accountField;
            }
            set
            {
                this.recommended_twitter_accountField = value;
            }
        }

        /// <remarks/>
        public string owner_twitter_id
        {
            get
            {
                return this.owner_twitter_idField;
            }
            set
            {
                this.owner_twitter_idField = value;
            }
        }

        /// <remarks/>
        public string owner_facebook_id
        {
            get
            {
                return this.owner_facebook_idField;
            }
            set
            {
                this.owner_facebook_idField = value;
            }
        }

        /// <remarks/>
        public object owner_google_plus_id
        {
            get
            {
                return this.owner_google_plus_idField;
            }
            set
            {
                this.owner_google_plus_idField = value;
            }
        }

        /// <remarks/>
        public byte accepted
        {
            get
            {
                return this.acceptedField;
            }
            set
            {
                this.acceptedField = value;
            }
        }

        /// <remarks/>
        public byte waiting
        {
            get
            {
                return this.waitingField;
            }
            set
            {
                this.waitingField = value;
            }
        }

        /// <remarks/>
        public object hash_tag
        {
            get
            {
                return this.hash_tagField;
            }
            set
            {
                this.hash_tagField = value;
            }
        }

        /// <remarks/>
        public System.DateTime updated_at
        {
            get
            {
                return this.updated_atField;
            }
            set
            {
                this.updated_atField = value;
            }
        }

        /// <remarks/>
        public string owner_twitter_img
        {
            get
            {
                return this.owner_twitter_imgField;
            }
            set
            {
                this.owner_twitter_imgField = value;
            }
        }

        /// <remarks/>
        public string owner_facebook_img
        {
            get
            {
                return this.owner_facebook_imgField;
            }
            set
            {
                this.owner_facebook_imgField = value;
            }
        }

        /// <remarks/>
        public object owner_google_plus_img
        {
            get
            {
                return this.owner_google_plus_imgField;
            }
            set
            {
                this.owner_google_plus_imgField = value;
            }
        }

        /// <remarks/>
        public object deleted_at
        {
            get
            {
                return this.deleted_atField;
            }
            set
            {
                this.deleted_atField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ticket", IsNullable = false)]
        public hashEventTicket[] tickets
        {
            get
            {
                return this.ticketsField;
            }
            set
            {
                this.ticketsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class hashEventCategory
    {

        private byte codeField;

        private string code_nameField;

        /// <remarks/>
        public byte code
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
        public string code_name
        {
            get
            {
                return this.code_nameField;
            }
            set
            {
                this.code_nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class hashEventTicket
    {

        private string ticket_nameField;

        private byte ticket_typeField;

        private byte in_venue_typeField;

        private ushort ticket_priceField;

        private System.DateTime sales_end_dateField;

        private System.DateTime sales_start_dateField;

        private object ticket_image_pathField;

        private ushort ticket_issue_numField;

        private byte ticket_sale_numField;

        /// <remarks/>
        public string ticket_name
        {
            get
            {
                return this.ticket_nameField;
            }
            set
            {
                this.ticket_nameField = value;
            }
        }

        /// <remarks/>
        public byte ticket_type
        {
            get
            {
                return this.ticket_typeField;
            }
            set
            {
                this.ticket_typeField = value;
            }
        }

        /// <remarks/>
        public byte in_venue_type
        {
            get
            {
                return this.in_venue_typeField;
            }
            set
            {
                this.in_venue_typeField = value;
            }
        }

        /// <remarks/>
        public ushort ticket_price
        {
            get
            {
                return this.ticket_priceField;
            }
            set
            {
                this.ticket_priceField = value;
            }
        }

        /// <remarks/>
        public System.DateTime sales_end_date
        {
            get
            {
                return this.sales_end_dateField;
            }
            set
            {
                this.sales_end_dateField = value;
            }
        }

        /// <remarks/>
        public System.DateTime sales_start_date
        {
            get
            {
                return this.sales_start_dateField;
            }
            set
            {
                this.sales_start_dateField = value;
            }
        }

        /// <remarks/>
        public object ticket_image_path
        {
            get
            {
                return this.ticket_image_pathField;
            }
            set
            {
                this.ticket_image_pathField = value;
            }
        }

        /// <remarks/>
        public ushort ticket_issue_num
        {
            get
            {
                return this.ticket_issue_numField;
            }
            set
            {
                this.ticket_issue_numField = value;
            }
        }

        /// <remarks/>
        public byte ticket_sale_num
        {
            get
            {
                return this.ticket_sale_numField;
            }
            set
            {
                this.ticket_sale_numField = value;
            }
        }
    }


}
