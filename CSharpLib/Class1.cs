using LibWithTP;

namespace CSharpLib
{
    public static class Class
    {
        public static void Foo()
        {
            var _ = Config.instance.Level1;
            var __ = Config.instance.Level1.Level12;
            var ___ = Config.instance.Level1.Level12.Level13;
            var ____ = Config.instance.Level2;
        }
    }
}