using System;

namespace repro
{
    class Program
    {
        private static Lazy<bool> _isSpellCheckSupported = new Lazy<bool>(() =>
        {
            var type = Type.GetTypeFromCLSID(Guid.Parse("7AB36653-1796-484B-BDFA-E74F1DB7C1DC"), false);

            return type != null;
        }, true);

        public static bool IsSpellCheckSupported => _isSpellCheckSupported.Value;

        static void Main(string[] args)
        {
            Console.WriteLine($"Spell check supported: {IsSpellCheckSupported}");
            Console.ReadLine();
        }
    }
}
