namespace Danias.Core
{
    public class Kernel
    {
        /// <summary>
        ///     Get environment fixed tick count
        /// </summary>
        public static int TickCount => Environment.TickCount & int.MaxValue;

        /// <summary>
        ///     Get environment base directory
        /// </summary>
        public static string BasePath => AppDomain.CurrentDomain.BaseDirectory;
    }
}
