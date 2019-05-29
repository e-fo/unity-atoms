using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/String", fileName = "StringVariable")]
    public sealed class StringVariable : EquatableScriptableObjectVariable<
        string,
        StringEvent,
        StringStringEvent>
    { }
}