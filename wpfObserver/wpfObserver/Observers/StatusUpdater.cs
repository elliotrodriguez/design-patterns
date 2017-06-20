using System.Windows.Controls;
using wpfObserver.Models;

namespace wpfObserver.Observers
{
    public class StatusUpdater: Interfaces.IObserver<EmailChangedEventArgs>
    {
        private readonly TextBlock _statusElement;

        public StatusUpdater(TextBlock statusElement)
        {
            _statusElement = statusElement;
        }

        public void Update(object sender, EmailChangedEventArgs e)
        {
            _statusElement.Text = $@"Email address changed to {e.Email}";
        }
    }
}
