namespace TemplateRestAPI.Models.Common
{
    public class SingleObjectResponse<TData>
    {
        public TData Data { get; set; }

        public SingleObjectResponse() { }

        public SingleObjectResponse(TData data)
        {
            this.Data = data;
        }
    }

    public class SingleObjectResponse
    {
        public object Data { get; set; }

        public SingleObjectResponse()
        {

        }

        public SingleObjectResponse(object data)
        {
            this.Data = data;
        }
    }
}
