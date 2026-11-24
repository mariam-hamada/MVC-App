namespace MVC_App.Entities
{
    public class Trainer : GymUser
    {
        public Specialties Speciality { get; set; }

        public ICollection<Session> Sessions { get; set; } = default!;
    }
}
