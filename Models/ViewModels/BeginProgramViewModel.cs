namespace MCPowerlifting.Models.ViewModels
{
    public class BeginProgramViewModel
    {
        public string ProgramName { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public float BarWeight { get; set; }

        public string? Description { get; set; }
    }
}
