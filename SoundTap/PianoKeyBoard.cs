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
    public partial class PianoKeyBoard : Form
    {
        private int _buttonPos = 0;
        private int ButtonPos
        {
            get
            {
                var res = _buttonPos;
                _buttonPos += 75;
                return res;
            }
        }

        private Button NextKeyButton(PianoKey key)
        {
            var button = new Button();
            button.BackColor = Color.White;
            button.Location = new Point(ButtonPos, 0);
            button.Size = new Size(75, 400);
            button.MouseDown += new MouseEventHandler((s, e) => key.Press());
            button.MouseUp += new MouseEventHandler((s, e) => key.Release());
            return button;
        }

        public PianoKeyBoard()
        {
            var notes = new int[] { 60, 62, 64, 65, 67, 69, 71};
            var keys = notes.Select(n => new PianoKey(n));
            var keyButtons = keys.Select(k => NextKeyButton(k)).ToArray();
            SuspendLayout();
            ClientSize = new Size(75 * 7, 400);
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
