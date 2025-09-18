public interface IActive
{
    bool IsActive { get; }

    void Active();
    void Activate();
    void Deactivate();
}
