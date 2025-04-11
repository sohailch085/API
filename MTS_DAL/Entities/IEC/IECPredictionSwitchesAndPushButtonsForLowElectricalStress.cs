﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_DAL.Entities.IEC
{
    public class IECPredictionSwitchesAndPushButtonsForLowElectricalStress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Trid { get; set; }
        [ForeignKey("Projects")]
        public long PROJECTID { get; set; }
        public RAMProjects Projects { get; set; } = new RAMProjects();
        [Column(TypeName = "varchar(30)")]
        public string? WBS { get; set; } = string.Empty;
        public int? RegionType { get; set; }
        public int? LoadType { get; set; }
        public double? Lambda { get; set; }
        public double? LambdaRef { get; set; }
        public double? PieEs { get; set; }
        public DateTime? CREATEDDATE { get; set; }
        public DateTime? UPDATEDATE { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string USERIDZU { get; set; } = string.Empty;
    }
}
