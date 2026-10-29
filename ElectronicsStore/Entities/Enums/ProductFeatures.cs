namespace ElectronicsStore.Entities.Enums;

[Flags]
public enum ProductFeatures
{
    None = 0,

    WiFi = 1,

    Bluetooth = 2,

    Nfc = 4,

    FiveG = 8,

    Gps = 16,

    WaterResistance = 32,

    WirelessCharging = 64
}
