using MyPrjTest.Debugging;

namespace MyPrjTest
{
    public class MyPrjTestConsts
    {
        public const string LocalizationSourceName = "MyPrjTest";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "9e8009b2c4b14ae1b1beb45659506060";
    }
}
