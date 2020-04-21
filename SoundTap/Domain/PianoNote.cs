using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundTap.Domain
{
    public class PianoNote : Note
    {
        public PianoNote(NoteName name, int octave)
        {
            Name = name;
            Octave = octave;
        }

        public PianoNote(Note note)
            : this((NoteName)(note.Id % 12), note.Id / 12 - 5)
        {

        }

        public readonly NoteName Name;
        public readonly int Octave;

        public override int Id =>
            (int)Name + 12 * (Octave + 5);
    }
}
