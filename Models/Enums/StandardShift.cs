namespace Models.Enums
{
    public enum StandardShift
    {
        Morning = 1,    // 08:00 - 16:00 (8 saat)
        Evening = 2,    // 16:00 - 00:00 (8 saat)
        Night = 3,      // 00:00 - 08:00 (8 saat)
        ExtendedMorning = 4, // 08:00 - 18:00 (10 saat - elektrikçi/IT için)
        Off = 5         // Off günü
    }
}
