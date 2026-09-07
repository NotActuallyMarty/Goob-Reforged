using Robust.Shared.Serialization;
using Content.Shared.DoAfter;

namespace Content.Goobstation.Shared.PseudoItem;


[Serializable, NetSerializable]
public sealed partial class PseudoItemInsertDoAfterEvent : SimpleDoAfterEvent
{
}
