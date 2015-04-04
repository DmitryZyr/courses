namespace SimpleStorage
{
    public class Configuration : IConfiguration
    {
        public int CurrentNodePort { get; set; }
        public int[] OtherShardsPorts { get; set; }
    }
}