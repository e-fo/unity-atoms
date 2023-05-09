using UnityEngine;
using UnityAtoms.Mobile;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Value List of type `TouchUserInput`. Inherits from `AtomValueList&lt;TouchUserInput, TouchUserInputEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/TouchUserInput", fileName = "TouchUserInputValueList")]
    public sealed class TouchUserInputValueList : AtomValueList<TouchUserInput, TouchUserInputEvent, IntEvent> { }
}
