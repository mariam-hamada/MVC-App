namespace MVC_App.Entities
{
    public class Member : GymUser
    {
        public string? Photo { get; set; }

        public ICollection<Membership> MemberSubscription { get; set; } = default!;

    }
}
