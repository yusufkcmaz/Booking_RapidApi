﻿namespace Booking_RapidApi.Models
{
    public class SearchHotelViewModel
    {

        public class Rootobject
        {
            public bool status { get; set; }
            public string message { get; set; }
      
            public long timestamp { get; set; }
            public Data data { get; set; }
        }

        public class Data
        {
            public Hotel[] hotels { get; set; }
            public Meta[] meta { get; set; }
            public Appear[] appear { get; set; }
        }

        public class Hotel
        {
            public int hotel_id { get; set; }
            public string accessibilityLabel { get; set; }
            public Property1 property { get; set; }
        }

        public class Property1    //Lazım olan yer
        {
            public int id { get; set; }
            public float latitude { get; set; }
            public int accuratePropertyClass { get; set; }
            public string[] blockIds { get; set; }
            public int ufi { get; set; }
            public float reviewScore { get; set; }
            public int rankingPosition { get; set; }
            public bool isPreferred { get; set; }
            public string checkoutDate { get; set; } // giriş tarih
            public string countryCode { get; set; }
            public string name { get; set; } // otel ismi
            public int optOutFromGalleryChanges { get; set; }
            public int propertyClass { get; set; }
            public bool isFirstPage { get; set; }
            public string checkinDate { get; set; }
            public Checkout checkout { get; set; }
            public int qualityClass { get; set; }
            public string reviewScoreWord { get; set; }
            public Checkin checkin { get; set; } 
            public string currency { get; set; } //para birimi
            public string[] photoUrls { get; set; }  // otel görselleri
            public int mainPhotoId { get; set; }
            public bool isPreferredPlus { get; set; }
            public int position { get; set; }
            public Pricebreakdown priceBreakdown { get; set; }
            public int reviewCount { get; set; }
            public string wishlistName { get; set; }
            public float longitude { get; set; }
        }

        public class Checkout
        {
            public string untilTime { get; set; }
            public string fromTime { get; set; }
        }

        public class Checkin
        {
            public string untilTime { get; set; }
            public string fromTime { get; set; }
        }

        public class Pricebreakdown
        {
            public Benefitbadge[] benefitBadges { get; set; }
            public Strikethroughprice strikethroughPrice { get; set; }
            public object[] taxExceptions { get; set; }
            public Grossprice grossPrice { get; set; }
        }

        public class Strikethroughprice
        {
            public float value { get; set; }
            public string currency { get; set; }
        }

        public class Grossprice
        {
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class Benefitbadge
        {
            public string variant { get; set; }
            public string explanation { get; set; }
            public string text { get; set; }
            public string identifier { get; set; }
        }

        public class Meta
        {
            public string title { get; set; }
        }

        public class Appear
        {
            public Component component { get; set; }
            public string id { get; set; }
            public string contentUrl { get; set; }
        }

        public class Component
        {
            public Props props { get; set; }
        }

        public class Props
        {
            public Content content { get; set; }
            public bool fill { get; set; }
            public string title { get; set; }
            public string text { get; set; }
        }

        public class Content
        {
            public Props1 props { get; set; }
        }

        public class Props1
        {
            public bool fitContentWidth { get; set; }
            public Item[] items { get; set; }
        }

        public class Item
        {
            public Props2 props { get; set; }
        }

        public class Props2
        {
            public Component1 component { get; set; }
        }

        public class Component1
        {
            public Props3 props { get; set; }
        }

        public class Props3
        {
            public Item1[] items { get; set; }
            public string spacing { get; set; }
            public string icon { get; set; }
            public string variant { get; set; }
            public string tertiaryTintedColor { get; set; }
            public string accessibilityLabel { get; set; }
        }

        public class Item1
        {
            public Props4 props { get; set; }
        }

        public class Props4
        {
            public Text[] text { get; set; }
        }

        public class Text
        {
            public string text { get; set; }
            public string font { get; set; }
            public string color { get; set; }
            public Linkaction[] linkActions { get; set; }
        }

        public class Linkaction
        {
            public Props5 props { get; set; }
        }

        public class Props5
        {
            public string url { get; set; }
        }

    }
}
