namespace MudCowV2.Helper
{
    public class AvailablePrograms
    {
        public Dictionary<int, string> AllPrograms { get; set; } = new Dictionary<int, string>();

        public AvailablePrograms()
        {
            AllPrograms.Add(1, "MadCow 5x5");
            AllPrograms.Add(2, "Stronglifts 5x5 (not yet available)");
        }
    }
}
