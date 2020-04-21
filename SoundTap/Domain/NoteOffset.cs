using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundTap.Domain
{
    public class NoteOffset
    {
        private NoteOffset(int integerPart, bool withHalf)
        {
            IntegerPart = integerPart;
            WithHalf = withHalf;
        }

        private readonly int IntegerPart;
        private readonly bool WithHalf;

        public static NoteOffset GetNoteOffset(NoteName name)
        {
            var integerPart = 0;
            var currentNote = (NoteName)0;
            while (name != currentNote)
            {
                ++currentNote;
                if (!currentNote.IsSharp())
                    ++integerPart;
            }
            return new NoteOffset(integerPart, name.IsSharp());
        }

        public static implicit operator int(NoteOffset offset)
        {
            return offset.IntegerPart;
        }

        public static int operator *(int factor, NoteOffset offset)
        {
            var res = offset.IntegerPart * factor;
            if (offset.WithHalf)
            {
                res += factor / 2;
            }
            return res;
        }

        public static int operator *(NoteOffset offset, int factor)
        {
            return factor * offset;
        }

        public static NoteOffset operator +(int exstraOffset, NoteOffset offset)
        {
            return new NoteOffset(offset.IntegerPart + exstraOffset, offset.WithHalf);
        }

        public static NoteOffset operator +(NoteOffset offset, int exstraOffset)
        {
            return exstraOffset + offset;
        }
    }
}
