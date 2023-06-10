using System.ComponentModel.DataAnnotations.Schema;

namespace NationalParksApi;

public class NatlPark
{
    public int NatlParkId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    [ForeignKey("StateId")]
    public int StateId { get; set; }
    // public State State { get; set; }
}
