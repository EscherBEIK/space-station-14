// Simple station

using Robust.Shared.Serialization;

namespace Content.Shared._FtC.Silicon;

[Serializable, NetSerializable]
public enum SiliconChargerVisuals
{
    Lights,
}

[Serializable, NetSerializable]
public enum SiliconChargerVisualState
{
    Normal,
    NormalOpen,
    Charging
}
