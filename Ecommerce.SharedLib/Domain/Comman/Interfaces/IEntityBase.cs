using System.ComponentModel.DataAnnotations;

namespace Ecommerce.SharedLib.Domain.Comman.Interfaces
{
    public interface IEntityBase<TKey> 
    {
        [Key]
        TKey Id { get;set;}
    }

    public interface IDeleteEntity
    {
        bool IsDeleted { get; set; }    
    }

    public interface IDeleteEntity<TKey> : IDeleteEntity,IEntityBase<TKey>
    {

    }

    public interface IAduitEntity
    {
        Guid? Createdby { get; set; }
        Guid? Updatedby { get; set; }
        DateTime? CreatedDate { get; set; }
        DateTime? UpdatedDate { get; set; }
        void SetCreator(string creator,DateTime createdate);
        void SetUpdator(string updator,DateTime updatedate);
    }

    public interface IAduitEntity<TKey> : IAduitEntity ,IDeleteEntity<TKey>
    {

    }

}
