using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models;

namespace Models;

public class Resolution
{

    enum Status
    {
        draft,
        accpeted,
        rejected,
        incomplete
    }


    [Key]
    public string? ResolutionId { get; set; }
    public string? CreationDate { get; set; }
    public string? Abstract { get; set; }
    public string? Status { get; set; }

    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public List<User>? Participants { get; set; }
}
