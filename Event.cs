using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventmanagement
{
    public class Event
    {
        
        private int EventID;
        private string planner;
        private string Name;      
        private string EventType;
        private string venue;
        private int max_participants;
        private DateTime EventDate;     
        private TimeSpan Starttime;      
        private TimeSpan Endtime;       


        // public getters and setters
        public int getId() { return EventID; }
        public void setId(int id) { this.EventID = id; }

        public string getOrganizerId() { return planner; }
        public void setOrganizerId(string organizerId) { this.planner = organizerId; }

        public string getEventName() { return Name; }    
        public void setEventName(string Name) { this.Name = Name; }   

        public string getEventType() { return EventType; }
        public void setEventType(string eventType) { this.EventType = eventType; }

        public string getVenue() { return venue; }
        public void setVenue(string venue) { this.venue = venue; }

        public int getMaxParticipants() { return max_participants; }
        public void setMaxParticipants(int maxParticipants) { this.max_participants = maxParticipants; }

        public DateTime getEventDate() { return EventDate; }   
        public void setEventDate(DateTime eventDate) { this.EventDate = eventDate; } 

        public TimeSpan getStartTime() { return Starttime; }    
        public void setStartTime(TimeSpan startTime) { this.Starttime = startTime; }  

        public TimeSpan getEndTime() { return Endtime; }    
        public void setEndTime(TimeSpan endTime) { this.Endtime = endTime; }   

        // Constructor
        public Event(int id, string Name, string eventType, string venue, int maxParticipants, string organizerId, DateTime eventDate, TimeSpan startTime, TimeSpan endTime)
        {
            this.EventID = id;
            this.Name = Name;      
            this.EventType = eventType;
            this.venue = venue;
            this.max_participants = maxParticipants;
            this.planner = organizerId;
            this.EventDate = eventDate;      
            this.Starttime = startTime;      
            this.Endtime = endTime;          
        }
    }
}
