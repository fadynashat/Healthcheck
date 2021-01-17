using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EducationalStudyAPI.Models
{
public class Studentdatainschoolstudy
 {

[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int Id { get; set; }

public int? BuildingCode { get; set; }

public int? LandPieceCode { get; set; }

public string StudentsNumber { get; set; }

public string PeriodName { get; set; }

public string PeriodNumber { get; set; }

public DateTime? StudyDate { get; set; }

 }
}