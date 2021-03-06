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

        public PrefabComponent prefab { get { return (PrefabComponent)GetComponent(ComponentIds.Prefab); } }
        public bool hasPrefab { get { return HasComponent(ComponentIds.Prefab); } }

        public Entity AddPrefab(UnityEngine.GameObject newValue) {
            var component = CreateComponent<PrefabComponent>(ComponentIds.Prefab);
            component.Value = newValue;
            return AddComponent(ComponentIds.Prefab, component);
        }

        public Entity ReplacePrefab(UnityEngine.GameObject newValue) {
            var component = CreateComponent<PrefabComponent>(ComponentIds.Prefab);
            component.Value = newValue;
            ReplaceComponent(ComponentIds.Prefab, component);
            return this;
        }

        public Entity RemovePrefab() {
            return RemoveComponent(ComponentIds.Prefab);
        }
    }

    public partial class Matcher {

        static IMatcher _matcherPrefab;

        public static IMatcher Prefab {
            get {
                if(_matcherPrefab == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Prefab);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherPrefab = matcher;
                }

                return _matcherPrefab;
            }
        }
    }
}
