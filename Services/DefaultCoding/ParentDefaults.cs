namespace Services.DefaultCoding
{
    public class ParentDefaults
    {
        public static KolCodingsDefaults KolCoding { get; } = new KolCodingsDefaults();
        public static MoeinCodingsDefaults MoeinCoding { get; } = new MoeinCodingsDefaults();
        public static TafsilCodingDefaults TafsilCoding { get; } = new TafsilCodingDefaults();
    }
}
