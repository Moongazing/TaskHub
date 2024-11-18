
namespace Moongazing.Core.Persistence.Repositories;

public class Entity<TId> : IEntityTimestamps
{
    private Guid id;

    public Entity(Guid id)
    {
        this.id = id;
    }

    public TId Id { get; set; } = default!;
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }

}
