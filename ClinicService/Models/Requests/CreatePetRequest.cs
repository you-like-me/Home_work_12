namespace ClinicService.Models.Requests
{
    public class CreatePetRequest
    {
        public string Name { get; set; }

        public DateTime Birthday { get; set; }
    }
}
