namespace ClinicService.Models.Requests
{
    public class CreateConsultationRequest
    {
        public DateTime ConsultationDate { get; set; }

        public string Description { get; set; }
    }
}
