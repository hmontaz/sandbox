

using NotepadAlt;
using System.Windows.Forms;

namespace Notepad
{
	public partial class frmNotepad : Form
	{
		string Filename = "Untitled";
		string OriginalText = "1\n2\n3\n4\n5\n6\n7\n8\n9\n10\n";
		public frmNotepad()
		{
			InitializeComponent();
			toolStripStatusLabel4.AutoSize = false;
			toolStripStatusLabel4.Width = 120;
			textBox1.Text = OriginalText;
			UpdateMenu();
			UpdateFormTitle();
			UpdateStripStatus();
		}

		void UpdateMenu()
		{
			undoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
			undoToolStripMenuItem.ShortcutKeys = Keys.None;

			cutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
			cutToolStripMenuItem.ShortcutKeys = Keys.None;

			copyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
			copyToolStripMenuItem.ShortcutKeys = Keys.None;

			pasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
			pasteToolStripMenuItem.ShortcutKeys = Keys.None;

			deleteToolStripMenuItem.ShortcutKeyDisplayString = "Del";
			deleteToolStripMenuItem.ShortcutKeys = Keys.None;

			zoomInToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Plus";
			zoomOutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Minus";
			restoreDefaultZoomToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+0";
		}

		void UpdateFormTitle()
		{
			var changed = OriginalText != textBox1.Text;
			this.Text = (changed ? "*" : "") + this.Filename + " - Notepad";
		}

		void UpdateStripStatus()
		{
			var position = textBox1.GetPosition();

			statusStrip.Visible = statusBarToolStripMenuItem.Checked;
			toolStripPosition.Text = $"Ln {position.Line},Col {position.Col}";
			toolStripZoom.Text = $"{Math.Round(textBox1.ZoomFactor * 100)}%";
			textBox1.WordWrap = wordWrapToolStripMenuItem.Checked;
		}

		void ResetZoom()
		{
			textBox1.ZoomFactor = 1;
			UpdateStripStatus();
		}

		void ZoomIn()
		{
			if (textBox1.ZoomFactor >= 5) return;
			textBox1.ZoomFactor += 0.1f;
		}

		void ZoomOut()
		{
			if (textBox1.ZoomFactor <= .11) return;
			textBox1.ZoomFactor -= 0.1f;
		}
		void SelectAll()
		{
			textBox1.SelectAll();
		}
		void Undo()
		{
			textBox1.Undo();
		}
		void Cut()
		{
			textBox1.Cut();
		}
		void Copy()
		{
			textBox1.Copy();
		}
		void Paste()
		{
			textBox1.Paste();
		}
		void Delete()
		{

		}

		#region Event Handlers
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			UpdateFormTitle();
			UpdateStripStatus();
		}
		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			UpdateFormTitle();
			UpdateStripStatus();
		}

		private void textBox1_KeyUp(object sender, KeyEventArgs e)
		{
			UpdateFormTitle();
			UpdateStripStatus();
		}

		private void textBox1_MouseClick(object sender, MouseEventArgs e)
		{
			UpdateStripStatus();
		}

		private void textBox1_MouseWheel(object sender, MouseEventArgs e)
		{
			UpdateStripStatus();
		}
		private void restoreDefaultZoomToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ResetZoom();
		}
		private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UpdateStripStatus();
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SelectAll();
		}

		private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ZoomIn();
		}

		private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ZoomOut();
		}
		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Undo();
		}
		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Copy();
		}
		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Cut();
		}
		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Paste();
		}

		private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Undo();
		}

		private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Cut();
		}

		private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Copy();
		}

		private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Paste();
		}

		private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Delete();
		}

		private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			SelectAll();
		}

		private void rightToLeftReadingOrderToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void insertUnicodeControlCharacterToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void openIMEToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void reconversionToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void searchWithBingToolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}
		private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new frmAbout();
			form.ShowDialog();
		}
		#endregion


		private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UpdateStripStatus();
		}
	}
}
