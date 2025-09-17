public interface IActive
{
    bool IsActive { get; }

    void Activate();
    void Deactivate();
}
