using System.ComponentModel.DataAnnotations.Schema;

namespace NationalParksApi;

public class NatlPark
{
    public int NatlParkId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int StateId { get; set; }
    [ForeignKey("StateId")]
    public State State { get; set; }
}
