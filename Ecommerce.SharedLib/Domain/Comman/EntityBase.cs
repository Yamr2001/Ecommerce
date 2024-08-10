using Ecommerce.SharedLib.Domain.Comman.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.SharedLib.Domain.Comman
{
    public abstract class EntityBase<TKey> : IEntityBase<TKey>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required TKey Id {  get; set; }   
    }
    public abstract class DeleteEntity<TKey> : EntityBase<TKey>, IDeleteEntity<TKey>
    {
        public bool IsDeleted { get ; set ; }
    }

    public abstract class AduitEntity<TKey> : DeleteEntity<TKey>, IAduitEntity<TKey>
    {
        public Guid? Createdby { get; set ; }
        public Guid? Updatedby { get ; set ; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get ; set ; }

        public void SetCreator(string creator, DateTime createdate)
        {
           Createdby = !string.IsNullOrWhiteSpace(creator) ?Guid.Parse(creator) : null;
           CreatedDate = createdate;
        }

        public void SetUpdator(string updator, DateTime updatedate)
        {
            Updatedby = !string.IsNullOrWhiteSpace(updator) ? Guid.Parse(updator) : null;
            UpdatedDate = updatedate;
        }
    }
}
