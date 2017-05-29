using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace HEManagement.Models
{
    public class Customer
    {
        public Guid CustomerID { get; set; }
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Display(Name = "Address Line 1")]
        public string Address1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        [Display(Name = "Utility Account Number")]
        public string UtilityAccountNumber { get; set; }
        [Display(Name = "Decision Maker Name")]
        public string DecisionMakerName { get; set; }
        [Display(Name = "Decision Maker Position")]
        public string DecisionMakerPosition { get; set; }
        [Display(Name = "Site Contact Name")]
        public string SiteContactName { get; set; }
        [Display(Name = "Site Contact Position")]
        public string SiteContactPosition { get; set; }

        [Display(Name ="Business Type")]
        public BusinessType BusinessType { get; set;  }

    }
    public class CustomerDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }

    public enum BusinessType
    {
        [Display(Name ="Auto Related")]
        AutoRelated,
        Bakery,
        Banks,
        Church,
        [Display(Name = "College - Cafeteria")]
        CollegeCafeteria,
        [Display(Name = "College - Classes/Administrative")]
        CollegeClassesAdministrative,
        [Display(Name = "College - Dormitory")]
        CollegeDormitory,
        [Display(Name = "Commercial Condos")]
        CommercialCondos,
        [Display(Name = "Convenience Stores")]
        ConvenienceStores,
        [Display(Name = "Convention Center")]
        ConventionCenter,
        [Display(Name = "Court House")]
        CourtHouse,
        [Display(Name = "Dining - Bar/Lounge/Leisure")]
        DiningBarLoungeLeisure,
        [Display(Name = "Dining - Cafeteria/Fast Food")]
        DiningCafeteriaFastFood,
        [Display(Name = "Dining - Family")]
        DiningFamily,
        Entertainment,
        [Display(Name = "Exercise Center")]
        ExerciseCenter,
        [Display(Name = "Fast Food Restaurants")]
        FastFoodRestaurants,
        [Display(Name = "Fire Station (Unmanned)")]
        FireStationUnmanned,
        [Display(Name = "Food Stores")]
        FoodStores,
        Gymnasium,
        Hospitals,
        [Display(Name = "Hospitals / Health Care")]
        HospitalsHealthCare,
        [Display(Name = "Industrial - 1 Shift")]
        Industrial1Shift,
        [Display(Name = "Industrial - 2 Shift")]
        Industrial2Shift,
        [Display(Name = "Industrial - 3 Shift")]
        Industrial3Shift,
        Laundromats,
        Library,
        [Display(Name = "Light Manufacturers")]
        LightManufacturers,
        [Display(Name = "Lodging - Hotels/Motels")]
        LodgingHotelsMotels,
        [Display(Name = "Mall Concourse")]
        MallConcourse,
        [Display(Name = "Manufacturing Facility")]
        ManufacturingFacility,
        [Display(Name = "Medical Offices")]
        MedicalOffices,
        [Display(Name = "Motion Picture Theatre")]
        MotionPictureTheatre,
        [Display(Name = "Multi-Family Common Areas")]
        MultiFamilyCommonAreas,
        Museum,
        [Display(Name = "Nursing Homes")]
        NursingHomes,
        [Display(Name = "Office - General Office Types")]
        OfficeGeneralOfficeTypes,
        [Display(Name = "Office - Retail")]
        OfficeRetail,
        [Display(Name = "Parking Garages")]
        ParkingGarages,
        [Display(Name = "Parking Lots")]
        ParkingLots,
        Penitentiary,
        [Display(Name = "Performing Arts Theatre")]
        PerformingArtsTheatre,
        [Display(Name = "Police / Fire Stations (24-Hr)")]
        PoliceFireStations24Hr,
        [Display(Name = "Post Office")]
        PostOffice,
        [Display(Name = "Pump Stations")]
        PumpStations,
        [Display(Name = "Refrigerated Warehouse")]
        RefrigeratedWarehouse,
        [Display(Name = "Religious Building")]
        ReligiousBuilding,
        Restaurants,
        Retail,
        [Display(Name = "School (University)")]
        SchoolUniversity,
        [Display(Name = "Schools (Jr / Sr High)")]
        SchoolsJrSrHigh,
        [Display(Name = "Schools (Preschool / Elementary)")]
        SchoolsPreschoolElementary,
        [Display(Name = "Shools (Technical / Vocational)")]
        SchoolsTechnicalVocational,
        [Display(Name = "Small Services")]
        SmallServices,
        [Display(Name = "Sports Arena")]
        SportsArena,
        [Display(Name = "Town Hall")]
        TownHall,
        Transportation,
        [Display(Name = "Warehouse (Not Refrigerated)")]
        WarehouseNotRefrigerated,
        [Display(Name = "Waste / Water Treatment Plant")]
        WasteWaterTreatmentPlant,
        Workshop

    }
}