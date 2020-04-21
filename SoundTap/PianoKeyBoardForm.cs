using SoundTap.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundTap
{
    public partial class PianoKeyBoardForm : Form
    {

        private Button GetKeyButton(PianoKey key)
        {
            var button = new Button();
            button.BackColor = key.Color;
            var buttonOffset = key.Offset * 80;
            if (button.BackColor == Color.Black)
                buttonOffset += 20;
            button.Location = new Point(buttonOffset, 0);
            button.Size = button.BackColor == Color.White ? new Size(80, 400) : new Size(40, 300);
            button.MouseDown += new MouseEventHandler((s, e) => key.Press());
            button.MouseUp += new MouseEventHandler((s, e) => key.Release());
            if (button.BackColor == Color.White)
                button.HandleCreated += new EventHandler((s, e) => button.SendToBack());
            return button;
        }

        public PianoKeyBoardForm()
        {
            var notes = Note.Range(new PianoNote(NoteName.C, 0), new PianoNote(NoteName.C, 1))
                .Select(n => new PianoNote(n));
            var keys = notes.Select(n => new PianoKey(n));
            var keyButtons = keys.Select(k => GetKeyButton(k)).ToArray();
            SuspendLayout();
            ClientSize = new Size(80 * 8, 400);
            Controls.AddRange(keyButtons);
            Name = "Piano";
            Load += LoadPianoKeyBoard;
            ResumeLayout();
        }

        private void LoadPianoKeyBoard(object sender, EventArgs e)
        {

        }
    }
}
