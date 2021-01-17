using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EducationalStudyAPI.Models
{
public class Schoolstudiesforauthproj
 {

[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int Id { get; set; }

public int? LandPieceCode { get; set; }

public string PhaseCode { get; set; }

public int? StudentsNumber { get; set; }

public DateTime? StudyDate { get; set; }

 }
}