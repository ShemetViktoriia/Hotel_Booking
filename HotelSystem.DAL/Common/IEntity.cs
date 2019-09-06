namespace HotelSystem.DAL.Common
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
