﻿namespace EducationApp2.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }

        // Relationships
        public User Student { get; set; }
        public User Teacher { get; set; }
    }
}
