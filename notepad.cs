C# NotePad
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace notepad
{
public partial class NotePad : Form
{
public NotePad()
{
InitializeComponent();
}
private void fileToolStripMenuItem_Click(object sender, EventArgs e)
{
}
private void editToolStripMenuItem_Click(object sender, EventArgs e)
{
}
private void Form1_Load(object sender, EventArgs e)
{
}
private void copyToolStripMenuItem_Click(object sender, EventArgs e)
{
richTextBox1.Copy();
}
private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
{
richTextBox1.Paste();
}
private void cutToolStripMenuItem_Click(object sender, EventArgs e)
{
richTextBox1.Cut();
}
private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
{
}
private void clearToolStripMenuItem_Click(object sender, EventArgs e)
{
richTextBox1.Clear();
}
private void exitToolStripMenuItem_Click(object sender, EventArgs e)
{
}
private void openToolStripMenuItem_Click(object sender, EventArgs e)
{
}
private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
{
if (openFileDialog1.ShowDialog() == DialogResult.OK)
{
richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
}
}
private void saveToolStripMenuItem_Click(object sender, EventArgs e)
{
saveFileDialog1.DefaultExt = ".txt";
saveFileDialog1.Filter = "Text File|.txt|PDF FILE|.pdf|WORD FILE|.Doc";
DialogResult dr = saveFileDialog1.ShowDialog();
if( dr== DialogResult.OK)
{
File.WriteAllText(saveFileDialog1.FileName,richTextBox1.Text);
}
}
private void createToolStripMenuItem_Click(object sender, EventArgs e)
{
richTextBox1.Clear();
}
private void exitToolStripMenuItem1_Click_1(object sender, EventArgs e)
{
Close();
}
}
}

