#region

using System;

#endregion

namespace KoiVM.VM
{
    public class VMDescriptor
    {
        public VMDescriptor(IVMSettings settings)
        {
            Random = new Random(settings.Seed);
            Settings = settings;
            Architecture = new ArchDescriptor(Random);
            Runtime = new RuntimeDescriptor(Random);
            Data = new DataDescriptor(Random);
        }

        public Random Random
        {
            get;
        }

        public IVMSettings Settings
        {
            get;
        }

        public ArchDescriptor Architecture
        {
            get;
        }

        public RuntimeDescriptor Runtime
        {
            get;
        }

        public DataDescriptor Data
        {
            get;
            private set;
        }

        public void ResetData()
        {
            Data = new DataDescriptor(Random);
        }
    }
}