using PokerPortfolio.Models;

namespace PokerPortfolio.Services
{
    public class GameStateService
    {
        public int CardsDealt { get; set; } = 0;
        public string DealerMessage { get; set; } = "Welcome to Caden's Table! Click CHECK, FOLD, or ALL IN to deal cards and unlock projects.";
        public bool SoundEnabled { get; set; } = true;
        public bool TypewriterCompleted { get; set; } = false;

        public void DealCards(int count)
        {
            CardsDealt = count;
        }

        public void UpdateMessage(string message)
        {
            DealerMessage = message;
        }

        public void ToggleSound()
        {
            SoundEnabled = !SoundEnabled;
        }
    }
}


