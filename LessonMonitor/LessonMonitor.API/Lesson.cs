using System;

namespace LessonMonitor.API
{
    public class Lesson
    {
        public int Id { get; set; }
        public string TitleLesson { get; set; }
        public string DescriptionLesson { get; set; }
        public DateTime DateLesson { get; set; }
    }
}
