using NAudio.Midi;
using SoundTap.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundTap.Domain
{
    class PianoKey
    {
        private int Note
        {
            get;
            set;
        }

        public PianoKey(int note)
        {
            Tune(note);
        }

        public void Press()
        {
            DefaultMidiDevice.ZeroDevice.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
        }

        public void Release()
        {
            DefaultMidiDevice.ZeroDevice.Send(MidiMessage.StopNote(Note, 0, 1).RawData);
        }

        public void Tune(int note)
        {
            Note = note;
        }
    }
}
