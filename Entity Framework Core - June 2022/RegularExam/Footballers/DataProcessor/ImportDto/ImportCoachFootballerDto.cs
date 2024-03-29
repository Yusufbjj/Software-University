﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;
using Footballers.Data.Models.Enums;

namespace Footballers.DataProcessor.ImportDto
{
    [XmlType("Footballer")]
    public class ImportCoachFootballerDto
    {
        [Required]
        [MinLength(GlobalConstants.FootballerNameMinLength)]
        [MaxLength(GlobalConstants.FootballerNameMaxLength)]
        [XmlElement("Name")]
        public string Name { get; set; }

        [Required]
        [XmlElement("ContractStartDate")]
        public string ContractStartDate { get; set; }

        [Required]
        [XmlElement("ContractEndDate")]
        public string ContractEndDate { get; set; }

        [Required]
        [XmlElement("BestSkillType")]
        public int BestSkillType { get; set; }

        [Required]
        [XmlElement("PositionType")]
        public int PositionType { get; set; }
    }
}
