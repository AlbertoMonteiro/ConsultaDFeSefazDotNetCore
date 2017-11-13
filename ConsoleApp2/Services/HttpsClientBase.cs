using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ConsoleApp2
{
    public abstract class HttpsClientBase<T> : ClientBase<T>
        where T : class
    {
        protected HttpsClientBase(string urlEndpoint)
            : base(GetBindingForEndpoint(), new EndpointAddress(urlEndpoint))
        { }

        private static Binding GetBindingForEndpoint()
            => new BasicHttpsBinding(BasicHttpsSecurityMode.Transport) { Security = { Transport = { ClientCredentialType = HttpClientCredentialType.Certificate } } };
    }
}