//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {

    public partial class Entity {

        static readonly NeedSpawn needSpawnComponent = new NeedSpawn();

        public bool isNeedSpawn {
            get { return HasComponent(ComponentIds.NeedSpawn); }
            set {
                if(value != isNeedSpawn) {
                    if(value) {
                        AddComponent(ComponentIds.NeedSpawn, needSpawnComponent);
                    } else {
                        RemoveComponent(ComponentIds.NeedSpawn);
                    }
                }
            }
        }

        public Entity IsNeedSpawn(bool value) {
            isNeedSpawn = value;
            return this;
        }
    }

    public partial class Matcher {

        static IMatcher _matcherNeedSpawn;

        public static IMatcher NeedSpawn {
            get {
                if(_matcherNeedSpawn == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.NeedSpawn);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherNeedSpawn = matcher;
                }

                return _matcherNeedSpawn;
            }
        }
    }
}
