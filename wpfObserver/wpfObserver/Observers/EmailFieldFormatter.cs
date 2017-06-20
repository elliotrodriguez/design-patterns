using wpfObserver.Models;
using System.Windows.Media;

namespace wpfObserver.Observers
{
    public class EmailFieldFormatter : Interfaces.IObserver<EmailChangedEventArgs>
    {
        // the concrete observer class
        private readonly System.Windows.Controls.TextBox _emailField;

        public EmailFieldFormatter(System.Windows.Controls.TextBox emailField)
        {
            _emailField = emailField;
        }

        public void Update(object sender, EmailChangedEventArgs e)
        {
            //highlight yellow if has a value, white if empty
            var highlightcolor = Color.FromArgb(255, 255, 255, 255);

            if (!string.IsNullOrEmpty(e.Email))
            {
                highlightcolor =  Color.FromArgb(255, 255, 255, 0);
            }

            _emailField.Background = new SolidColorBrush(highlightcolor);
        }
    }
}
