namespace Nacos.V2.Config.Abst
{
    public interface IConfigResponse
    {
        object GetParameter(string key);

        void PutParameter(string key, object value);

        IConfigContext GetConfigContext();
    }
}
