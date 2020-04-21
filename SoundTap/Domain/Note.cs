using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundTap.Domain
{
    public abstract class Note
    {
        private class SimpleNote : Note
        {
            public SimpleNote(int id)
            {
                _id = id;
            }

            private readonly int _id;

            public override int Id => _id;
        }

        public abstract int Id
        {
            get;
        }

        public static implicit operator int(Note note)
        {
            return note.Id;
        }

        public static IEnumerable<Note> Range(Note start, Note end)
        {
            for (int id = start.Id; id <= end.Id; ++id)
            {
                yield return new SimpleNote(id);
            }
        }
    }
}
