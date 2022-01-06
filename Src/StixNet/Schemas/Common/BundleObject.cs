namespace StixNet.Schemas.Common;
public sealed class BundleObject
{
    public string? Id { get; set; }
    public string? Type { get; set; }
    public IEnumerable<STIXObject> Objects { get; set; }

    public BundleObject()
    {
        Objects = Enumerable.Empty<STIXObject>();
    }

    public IEnumerable<T> GetObjects<T>() where T : STIXObject
    {
        if (Objects is null || !Objects.Any())
        {
            return Enumerable.Empty<T>();
        }
        return Objects.Where(obj => obj is T).Select(obj => (T)obj);
    }
}
