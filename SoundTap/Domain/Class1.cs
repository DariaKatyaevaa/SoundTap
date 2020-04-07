using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Midi;


namespace SoundTap.Domain
{
    interface ISound
    {

    }

    class Note : ISound
    {
        public int Octave;
        public Tone Tone;
    }

    public enum Tone
    {
        A = 9,
        Ad = 10,
        B = 11,
        C = 0,
        Cd = 1,
        D = 2,
        Dd = 3,
        E = 4,
        F = 5,
        Fd = 6,
        G = 7,
        Gd = 8
    }
}
