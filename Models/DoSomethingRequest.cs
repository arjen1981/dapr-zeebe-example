using System.ComponentModel.DataAnnotations;

namespace dapr_zeebe_example.Models
{
    public record DoSomethingRequest(
        [Required] string Message);
}