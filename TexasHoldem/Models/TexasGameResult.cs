namespace TexasHoldEm.Models
{
    public class TexasGameResult
    {
        public string WinnerName { get; set; }
        
        public string WinLevel { get; set; }
        
        public string WinCard { get; set; }

        public bool IsTie { get; set; } = false;
    }
}