using System.Collections.Generic;
using System.Dynamic;

namespace Simplify.Core
{
    public class RequestInformation : DynamicObject
    {
        private Dictionary<string, object> _cache = new Dictionary<string, object>();
        
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            var name = binder.Name.ToLower();
            return _cache.TryGetValue(name, out result);
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            _cache[binder.Name.ToLower()] = value;

            return true;
        }
    }
}