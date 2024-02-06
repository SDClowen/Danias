using Danias.Core;
using Danias.Plugins;

namespace Danias.Customers
{
    public class Bootstrap : IPlugin
    {
        public string InternalName => "Danias.Customers";

        public string DisplayName => "Customers";

        public bool DisplayAsTab => true;

        public int Index => -1;

        public bool RequireLogin => true;

        public object View => new View();

        public void Initialize()
        {
            Log.Notify("Danias.Customers has been initialized");
        }

        public void Translate()
        {
            throw new NotImplementedException();
        }
    }
}
