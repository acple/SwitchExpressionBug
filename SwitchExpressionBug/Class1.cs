using System;

namespace SwitchExpressionBug
{
    public enum EnumA { A, B, C }

    public enum EnumB { X, Y, Z }

    public class Class1
    {
        public string Repro(EnumA a, EnumB b)
            => (a, b) switch
            {
                (EnumA.A, EnumB.X) => "AX",
                (_, EnumB.Y) => "_Y",
                (EnumA.B, EnumB.X) => "BZ",
                (_, EnumB.Z) => "_Z",
                (_, _) => throw new ArgumentException()
            };
    }
}
