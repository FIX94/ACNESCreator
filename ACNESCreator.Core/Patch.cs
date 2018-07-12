namespace ACNESCreator.Core
{
    public static class Patch
    {
        //entry point for our system
        public static readonly uint PatcherEntryPoint = 0x80003970;
        //entry point for big endian ppc
        public static readonly byte[] PatcherEntryPointData = new byte[]
        {
            0x80, 0x00, 0x39, 0x70
        };
    }
}