using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Midi;

namespace SoundTap.Domain
{
    class Sintezator : IDisposable
    {
        private readonly MidiOut midiOut = new MidiOut(0);
        private const int Chanel = 1;
        private readonly List<int> NotesPlayingNow = new List<int>();

        public void Dispose()
        {
            midiOut.Close();
            midiOut.Dispose();
        }

        public int PlayNote(int note,  int strength = 127)
        {
            //int note = 12 + octave * 12 + (int)tone; // 12 полутонов в октаве, начинаем считать с 0-й октавы (есть еще и -1-ая)

            if (!NotesPlayingNow.Contains(note))
            {
                midiOut.Send(MidiMessage.StartNote(note, strength, Chanel).RawData); // воспроизводим ноту на канале 0
                NotesPlayingNow.Add(note);
            }

            return note;
        }

        public void StopPlaying(int note)
        {
            if (NotesPlayingNow.Contains(note))
            {
                midiOut.Send(MidiMessage.StopNote(note, 0, Chanel).RawData);
                NotesPlayingNow.Remove(note);
            }
        }

    }
}
