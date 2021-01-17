using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EducationalStudyAPI.Models
{
public class Completlocalizationschoolstudy
 {

[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int Id { get; set; }

public int? ClassesNumber { get; set; }

public string NeedAreaPosition { get; set; }

public string NearestPlacesToBuilding { get; set; }

public int? LandPieceCode { get; set; }

public string SurrondSchoolsEffects { get; set; }

public string EducationType { get; set; }

public string PeriodStatus2 { get; set; }

public int? ConfirmedStudentNumber { get; set; }

public string StudentType { get; set; }

public string RadiusEmiratizationCircle { get; set; }

public DateTime? StudyDate { get; set; }

public string EducationalPhase { get; set; }

public string SchoolsPosition { get; set; }

 }
}