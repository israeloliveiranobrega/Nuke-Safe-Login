namespace Nuke_Safe_Login.Domain.Models.Base;

public class BaseMetaData
{
    public Guid Id { get; set; } = Guid.CreateVersion7();

    public Guid CreatedBy { get; set; }
    public DateTime CreateDate { get; set; }

    public Guid? LastUpdateBy { get; set; }
    public DateTime? LastUpdateDate { get; set; }

    public bool IsSuspended { get; set; }
    public Guid? SuspendedBy { get; set; }
    public DateTime? SuspendedDate { get; set; }

    public bool IsDeleted { get; set; }
    public Guid? DeletedBy { get; set; }
    public DateTime? DeletedDate { get; set; }

    public uint Version { get; set; }
}
