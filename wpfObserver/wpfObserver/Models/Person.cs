using System;
using wpfObserver.Interfaces;

namespace wpfObserver.Models
{
    // declare the event, this is what the concrete observer classes are looking for 
    public class EmailChangedEventArgs : EventArgs
    {
        public string Email { get; set; }
    }
    public class Person : ISubject<EmailChangedEventArgs>
    {
        // this is the subject class and will handle notifications to observers
        // when the email property changes
        private string _email;
        public event EventHandler<EmailChangedEventArgs> EmailChanged;


        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;

                // declare the function to call to let subscribers know the event occurred
                OnEmailChanged(value);
            }
        }

        private void OnEmailChanged(string value)
        {
            // now invoke the event, passing in the email as the event args
            EmailChanged?.Invoke(this, new EmailChangedEventArgs() { Email = value });
        }

        public void Attach(Interfaces.IObserver<EmailChangedEventArgs> observer)
        {
            // the observer subscribes here to the event
            EmailChanged += observer.Update;
        }

        public void Detach(Interfaces.IObserver<EmailChangedEventArgs> observer)
        {
            // the observer removes itself from updates
            EmailChanged -= observer.Update;
        }
    }
}
