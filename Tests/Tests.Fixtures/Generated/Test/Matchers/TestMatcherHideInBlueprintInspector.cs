//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public sealed partial class TestMatcher {

    static IMatcher<TestEntity> _matcherHideInBlueprintInspector;

    public static IMatcher<TestEntity> HideInBlueprintInspector {
        get {
            if(_matcherHideInBlueprintInspector == null) {
                var matcher = (Matcher<TestEntity>)Matcher<TestEntity>.AllOf(TestComponentsLookup.HideInBlueprintInspector);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherHideInBlueprintInspector = matcher;
            }

            return _matcherHideInBlueprintInspector;
        }
    }
}