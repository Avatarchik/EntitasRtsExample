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

        static readonly Select selectComponent = new Select();

        public bool isSelect {
            get { return HasComponent(ComponentIds.Select); }
            set {
                if(value != isSelect) {
                    if(value) {
                        AddComponent(ComponentIds.Select, selectComponent);
                    } else {
                        RemoveComponent(ComponentIds.Select);
                    }
                }
            }
        }

        public Entity IsSelect(bool value) {
            isSelect = value;
            return this;
        }
    }

    public partial class Matcher {

        static IMatcher _matcherSelect;

        public static IMatcher Select {
            get {
                if(_matcherSelect == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Select);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherSelect = matcher;
                }

                return _matcherSelect;
            }
        }
    }
}