using System.ComponentModel.DataAnnotations;

namespace PowerliftingREST.Models
{
    //1. Represantation of our database
    public class Command
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        public string Platform { get; set; }
    }

    public class Powerlifting
    {
        [Key]
        public int index { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        [MaxLength(1)]
        public string sex { get; set; }
        [Required]
        [MaxLength(3)]
        public string eventType { get; set; }
        [Required]
        public string equipment { get; set; }
        public int age { get; set; }
        public int ageClass { get; set; }
        [Required]
        public string division { get; set; }
        [Required]
        public double bodyweightkg { get; set; }
        [Required]
        public string weightclasskg { get; set; }
        public double squat1kg { get; set; }
        public double squat2kg { get; set; }
        public double squat3kg { get; set; }
        public double squat4kg { get; set; }
        public double best3squatkg { get; set; }
        public double bench1kg { get; set; }
        public double bench2kg { get; set; }
        public double bench3kg { get; set; }
        public double bench4kg { get; set; }
        public double best3benchkg { get; set; }
        public double deadlift1kg { get; set; }
        public double deadlift2kg { get; set; }
        public double deadlift3kg { get; set; }
        public double deadlift4kg { get; set; }
        public double best3deadliftkg{ get; set; }
        [Required]
        public double totalkg { get; set; }
        public string place { get; set; }
        public double wilks { get; set; }
        public double mcculloch { get; set; }
        public double glossbrenner { get; set; }
        public double ipfpoints{ get; set; }
        public string tested { get; set; }
        public string country { get; set; }
        public string federation { get; set; }
        public string date { get; set; }
        public string meetcountry { get; set; }
        public string meetstate { get; set; }
        public string meetname { get; set; }
    }
}