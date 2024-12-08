using System;

namespace eventmanagement
{
    public class Booking
    {
        private string bookingId;  
        private int participantId;  
        private int eventId;  

        
        public Booking(string bookingId, int participantId, int eventId)
        {
            this.bookingId = bookingId;
            this.participantId = participantId;
            this.eventId = eventId;
        }

        
        public string getBookingId() { return bookingId; }
        public void setBookingId(string bookingId) { this.bookingId = bookingId; }

     
        public int getParticipantId() { return participantId; }
        public void setParticipantId(int participantId) { this.participantId = participantId; }

     
        public int getEventId() { return eventId; }
        public void setEventId(int eventId) { this.eventId = eventId; }
    }
}
