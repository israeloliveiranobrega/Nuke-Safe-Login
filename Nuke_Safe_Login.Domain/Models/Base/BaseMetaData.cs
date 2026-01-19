namespace Nuke_Safe_Login.Models.Base
{
    public class BaseMetaData
    {
        public Guid Id { get; set; } = Guid.CreateVersion7();

        public DateTime CreateDate { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }

        public uint Version { get; set; }
    }
}
