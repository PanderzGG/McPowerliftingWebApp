namespace MudCowV2.Models.ViewModels
{
    public class BeginProgramViewModel
    {
        public string ProgramName { get; set; }
        public string ProgramId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public double BarWeight { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
    }
}
