using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MTS_DAL.Entities.IEC
{
    public class IECSwitchesAndPushButtonsForLowElectricalStress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Trid { get; set; }
        public string SwitchesType { get; set; } = "";
    }
}
