namespace CSharpFundamentals.Basic
{
    public class Structures
    {
        public readonly string DefaultValue;

        public struct CONSTANTS
        {
            public const string LATITUDE = "LATITUDE";
            public const string LONGITUDE = "LONGITUDE";
        }

        public Structures()
        {
            DefaultValue = "default";
        }

        public static void ConstantsExample()
        {
            //Structures.CONSTANTS.LATITUDE = "NEW VALUE"; // can't modify it
            Console.WriteLine(Structures.CONSTANTS.LATITUDE);
        }

        public static void ReadonlyExample()
        {
            var structureObject = new Structures();
            //structureObject.DefaultValue = "NEW VALUE"; // can't modify it
            Console.WriteLine(structureObject.DefaultValue);
        }
    }
}
