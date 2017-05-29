using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HEManagement.Models
{
    public class SurveyItemExisting
    {
        public Guid SurveyItemExistingID { get; set; }

        [Display(Name ="Room / Location")]
        public string ItemLocation { get; set; }

        [Display(Name ="Ceiling Height"), Range(1,10000)]
        public int CeilingHeight { get; set; }

        [Display(Name = "Hardwired or Plug-Load")]
        public HardwireOrPlugLoad HardwireOrPlugLoad { get; set; }

        [Display(Name = "Interior or Exterior")]
        public InteriorOrExterior InteriorOrExterior { get; set; }
        [Display(Name = "Existing Fixture Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Existing Fixture Type")]
        public ExistingFixtureType ExistingFixtureType { get; set; }

        [Display(Name = "Fixture Base Type")]
        public FistureBaseType FixtureBaseType { get; set; }
        [Display(Name = "Post Install Quantity Recommended"), Range(1,10000)]
        public int PostInstallQuantityRecommended { get; set; }

        public Guid SurveyID { get; set; }
        [ForeignKey("SurveyID")]
        public virtual Survey Survey { get; set; }


    }

    public class SurveyItemExistingDBContext : DbContext
    {
        public DbSet<SurveyItemExisting> SurveyItemExisting { get; set; }
    }

    public enum HardwireOrPlugLoad
    {
        Hardwire,
        [Display(Name = "Plug-Load")]
        PlugLoad
    }

    public enum InteriorOrExterior
    {
        Interior,
        Exterior
    }

    public enum ExistingFixtureType
    {
        [Display(Name = "Incandescent A Lamps")]
        IncandescentALamps,
        [Display(Name = "INCANDESCENT FLAME TIP")]
        INCANDESCENTFLAMETIP,
        [Display(Name = "INCANDESCENT GLOBES")]
        INCANDESCENTGLOBES,
        [Display(Name = "R Lamps (Incandescent)")]
        RLamps,
        [Display(Name = "INCANDESCENT PARs")]
        INCANDESCENTPAR,
        [Display(Name = "HID Replacement")]
        HIDReplacement,
        [Display(Name = "Incandescent (Non-Free)")]
        IncandescentNonFree,
        [Display(Name = "Refrigeration")]
        Refrigeration,
        [Display(Name = "Exit Signs")]
        ExitSigns,
        [Display(Name = "LED Refrigeration Case Lighting")]
        LEDRefrigerationCaseLighting,
        [Display(Name = "LED Wall Pack")]
        LEDWallPack,
        [Display(Name = "Occupancy Sensors")]
        OccupancySensors,
        [Display(Name = "Programmable Thermostat")]
        ProgrammableThermostat,
        [Display(Name = "Refrigeration Hardware")]
        RefrigerationHardware,
        [Display(Name = "Vending Machine Controls")]
        VendingMachineControls,
        [Display(Name = "Water Measures")]
        WaterMeasures,
        [Display(Name = "2' Fixture")]
        twoFT,
        [Display(Name = "3' Fixture")]
        threeFT,
        [Display(Name = "4' Fixture")]
        fourFT,
        [Display(Name = "6' Fixture")]
        sixFT,
        [Display(Name = "8' Fixture")]
        eightFT,

    }
    public enum FistureBaseType
    {
        Strip,
        Troffer,
        Industrial,
        Wrap,
        [Display(Name = "Wall Pack")]
        WallPack,
        [Display(Name = "Pole Lighting")]
        PoleLighting,
        [Display(Name = "Enclosed Strip")]
        EnclosedStrip,
        [Display(Name = "Bi -Pin Base")]
        BiPinBase,
        [Display(Name = "GU -10 Base")]
        GU10Base
    }

    public enum ColorTemperature
    {
        [Display(Name = "2300K")]
        a2300K,
        [Display(Name = "2700K")]
        a2700K,
        [Display(Name = "3000K")]
        a3000K,
        [Display(Name = "3100K")]
        a3100K,
        [Display(Name = "3500K")]
        a3500K,
        [Display(Name = "4100K")]
        a4100K,
        [Display(Name = "4500K")]
        a4500K,
        [Display(Name = "5000K")]
        a5000K,
        [Display(Name = "5500K")]
        a5500K,
        [Display(Name = "6500K")]
        a6500K
    }
}