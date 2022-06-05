namespace EmptyMvc.Services
{
    public class SingletonService : ISingletonService
    {
        private string _id { get; set; }
        public string GetId()
        {
            if(string.IsNullOrEmpty(_id))
                _id = Guid.NewGuid().ToString();

            return _id;
        }
    }
}
