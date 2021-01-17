using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EducationalStudyAPI.Models
{
public class Queryedustudyinperiod
 {

[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int Id { get; set; }

public int? SchoolArea { get; set; }

public int? BuildingCode { get; set; }

public string BuildingOwnership { get; set; }

public int? ClassroomNumber { get; set; }

public string LandPieceCode { get; set; }

public int? StudentsNumber { get; set; }

public string PeriodNumber { get; set; }

public string LandOwnership { get; set; }

public DateTime? StudyDate { get; set; }

 }
}