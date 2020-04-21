using NAudio.Midi;
using SoundTap.Infrastructure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundTap.Domain
{
    class PianoKey
    {
        private PianoNote Note;

        public PianoKey(PianoNote note)
        {
            Tune(note);
        }

        public Color Color
        {
            get
            {
                return Note.Color();
            }
        }

        public NoteOffset Offset
        {
            get
            {
                return Note.Offset() + 7 * Note.Octave;
            }
        }

        public void Press()
        {
            DefaultMidiDevice.ZeroDevice.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
        }

        public void Release()
        {
            DefaultMidiDevice.ZeroDevice.Send(MidiMessage.StopNote(Note, 0, 1).RawData);
        }

        public void Tune(PianoNote note)
        {
            Note = note;
        }
    }
}
