namespace Content.Client.Weapons.Melee.Components;

/// <summary>
/// Used for melee attack animations. Typically just has a fadeout.
/// </summary>
[RegisterComponent]
public sealed partial class WeaponArcVisualsComponent : Component
{
    [DataField("animation")]
    public WeaponArcAnimation Animation = WeaponArcAnimation.None;

    [ViewVariables(VVAccess.ReadWrite), DataField("fadeOut")]
    public bool Fadeout = true;
}

public enum WeaponArcAnimation : byte
{
    None,
    Thrust,
    Slash,
    //CrystallPunk Melee upgrade
    CPSlash,
    CPThrust
}
