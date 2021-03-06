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

        public AttackRadius attackRadius { get { return (AttackRadius)GetComponent(ComponentIds.AttackRadius); } }
        public bool hasAttackRadius { get { return HasComponent(ComponentIds.AttackRadius); } }

        public Entity AddAttackRadius(float newValue) {
            var component = CreateComponent<AttackRadius>(ComponentIds.AttackRadius);
            component.Value = newValue;
            return AddComponent(ComponentIds.AttackRadius, component);
        }

        public Entity ReplaceAttackRadius(float newValue) {
            var component = CreateComponent<AttackRadius>(ComponentIds.AttackRadius);
            component.Value = newValue;
            ReplaceComponent(ComponentIds.AttackRadius, component);
            return this;
        }

        public Entity RemoveAttackRadius() {
            return RemoveComponent(ComponentIds.AttackRadius);
        }
    }

    public partial class Matcher {

        static IMatcher _matcherAttackRadius;

        public static IMatcher AttackRadius {
            get {
                if(_matcherAttackRadius == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.AttackRadius);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherAttackRadius = matcher;
                }

                return _matcherAttackRadius;
            }
        }
    }
}
