namespace SimpleStorage
{
    public interface IConfiguration
    {
        int CurrentNodePort { get; }
        int[] OtherShardsPorts { get; }
    }
}