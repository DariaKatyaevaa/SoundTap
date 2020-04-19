using NAudio.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundTap.Infrastructure
{
    public static class DefaultMidiDevice
    {
        public static readonly MidiOut ZeroDevice = new MidiOut(0);
    }
}
