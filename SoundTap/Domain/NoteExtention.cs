using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundTap.Domain
{
    public static class NoteExtention
    {
        public static bool IsSharp(this NoteName noteName)
        {
            return noteName.ToString().EndsWith("Sharp");
        }

        public static System.Drawing.Color Color(this PianoNote note)
        {
            if (note.Name.IsSharp())
                return System.Drawing.Color.Black;
            return System.Drawing.Color.White;
        }

        public static NoteOffset Offset(this PianoNote note)
        {
            return NoteOffset.GetNoteOffset(note.Name);
        }
    }
}
