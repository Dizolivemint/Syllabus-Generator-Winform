using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Syllabus_Generator
{
    class Oword
    {
        // Declare source and target files
        public string fileTarget { get; set; }
        public string fileSource { get; set; }

        // Declare default values
        private Object oMissing;
        private Object oFalse;
        private string path { get; set; }

        //Declare MS Word Application and Document objects
        private Word.Application oWord;
        private Word.Document oWordDoc;
             

        public Oword(string fileSource, string fileTarget)
        {
            this.fileSource = fileSource;
            this.fileTarget = fileTarget;

            // Get the path of the executing assembly.
            this.path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\";

            // Create object of Word and Document.
            this.oWord = new Word.Application();
            this.oWordDoc = new Word.Document();

            this.OpenTemplate();
        }

        private void DefaultValues()
        {
            // Don't display Word.
            this.oWord.Visible = false;

            // Object of oMissing "Null Value".
            this.oMissing = System.Reflection.Missing.Value;

            // Object of false.
            this.oFalse = false;
        }

        private void OpenTemplate()
        {

            // The location of the template file
            Object oTemplate = (Object)(this.path + $@"{this.fileSource}");

            // Open the source template
            this.oWordDoc = this.oWord.Documents.Add(ref oTemplate);

            if (this.fileTarget == "")
                this.fileTarget = @"temp.docx";

            this.fileTarget = this.path + this.fileTarget;
            this.SaveAs(this.fileTarget);
            this.OpenFile();
        }

        private void OpenFile()
        {
            object missing = System.Reflection.Missing.Value;
            object oFileTarget = (Object)this.fileTarget;
            this.oWord.Documents.Open(ref oFileTarget, ref missing, ref missing, ref missing, 
                ref missing, ref missing, ref missing, ref missing, 
                ref missing, ref missing, ref missing, ref oFalse, 
                ref missing, ref missing, ref missing, ref missing);
        }

        public void SearchReplace(string findText, string replaceText, bool msg)
        {
            object replaceAll = Word.WdReplace.wdReplaceAll;
            object oMissing = System.Reflection.Missing.Value;

            // First Header Replacement
            foreach (Word.Section section in oWordDoc.Sections)
            {
                Word.Find findHeader = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterFirstPage].Range.Find;

                findHeader.ClearFormatting();
                findHeader.Text = findText;
                findHeader.Replacement.ClearFormatting();
                findHeader.Replacement.Text = replaceText;

                if (findHeader.Execute(ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref replaceAll, ref oMissing, ref oMissing, ref oMissing, ref oMissing))
                {
                    if (msg)
                        MessageBox.Show($"Replaced: {findText} with {replaceText}.");
                }
                else
                {
                    if (msg)
                        MessageBox.Show("The text could not be located.");
                }
            }

            // All other Header Replacements
            foreach (Word.Section section in oWordDoc.Sections)
            {
                Word.Find findHeader = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.Find;

                findHeader.ClearFormatting();
                findHeader.Text = findText;
                findHeader.Replacement.ClearFormatting();
                findHeader.Replacement.Text = replaceText;

                if (findHeader.Execute(ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref replaceAll, ref oMissing, ref oMissing, ref oMissing, ref oMissing))
                {
                    if (msg)
                        MessageBox.Show($"Replaced: {findText} with {replaceText}.");
                }
                else
                {
                    if (msg)
                        MessageBox.Show("The text could not be located.");
                }
            }

            Word.Find findObject = oWord.Application.Selection.Find;

            findObject.ClearFormatting();
            findObject.Text = findText;
            findObject.Replacement.ClearFormatting();
            findObject.Replacement.Text = replaceText;

            

            if (findObject.Execute(ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref replaceAll, ref oMissing, ref oMissing, ref oMissing, ref oMissing))
             {
                if (msg)
                    MessageBox.Show($"Replaced: {findText} with {replaceText}.");
             }
             else
             {
                if (msg)
                   MessageBox.Show("The text could not be located.");
             }
        }

        public void FindLoop(string findText)
        {
            int intFound = 0;
            Word.Range rng = this.oWordDoc.Content;

            rng.Find.ClearFormatting();
            rng.Find.Forward = true;
            rng.Find.Text = findText;

            rng.Find.Execute(
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);

            while (rng.Find.Found)
            {
                intFound++;
                rng.Find.Execute(
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            }

            MessageBox.Show("Strings found: " + intFound.ToString());
        }

        public void SaveAs(string strFileName)
        {
            object fileName = strFileName;

            oWordDoc.SaveAs2(fileName);
        }

        public void Close()
        {
            // Close the file.
            oWordDoc.Close();

            // Quit Word.exe
            oWord.Quit();

            GC.Collect(); //This is used for Garbage collection.
        }

        public object SaveFileDialog()
        {
            SaveFileDialog fdlg = new SaveFileDialog();

            fdlg.Title = "Destination";
            fdlg.InitialDirectory = this.path;
            fdlg.Filter = "All files (*.*)|*.*||Text Backup (*.txt)|*.txt||Docx files (*.docx)|*.docx";
            fdlg.FilterIndex = 3;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                return (Object)fdlg.FileName;
            }
            return null;
        }
    }
}
