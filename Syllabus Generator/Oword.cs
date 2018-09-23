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
        private string fileSource;
        private string fileTarget;

        // Declare default values
        private Object oMissing;
        private Object oFalse;

        //Declare MS Word Application and Document objects
        private Word.Application oWord;
        private Word.Document oWordDoc;


        public Oword(string fileSource, string fileTarget)
        {
            this.fileSource = fileSource;
            this.fileTarget = fileTarget;

            // Get the path of the executing assembly.
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // The location to save the file.
            Object oSaveAsFile = (Object)(path + $@"{fileTarget}");

            // Create object of Word and Document.
            this.oWord = new Word.Application();
            this.oWordDoc = new Word.Document();

            
        }

        public void DefaultValues()
        {
            // Don't display Word.
            this.oWord.Visible = false;

            // Object of oMissing "Null Value".
            this.oMissing = System.Reflection.Missing.Value;

            // Object of false.
            this.oFalse = false;
        }

        private void SearchReplace(string findText, string replaceText)
        {
            // Get the path of the executing assembly.
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // The location to save the file.
            Object oSaveAsFile = (Object)(path + @"\Test.docx");

                        oWord.Documents.Open(@"C:\Test\NewDocument.docx");

            Word.Find findObject = oWord.Application.Selection.Find;

            findObject.ClearFormatting();
            findObject.Text = findText;
            findObject.Replacement.ClearFormatting();
            findObject.Replacement.Text = replaceText;

            object replaceAll = Word.WdReplace.wdReplaceAll;


            if (findObject.Execute(ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref replaceAll, ref oMissing, ref oMissing, ref oMissing, ref oMissing))
            {
                MessageBox.Show("Text found.");
            }
            else
            {
                MessageBox.Show("The text could not be located.");
            }

            // Close the file.
            oWordDoc.Close(ref oFalse, ref oMissing, ref oMissing);

            // Quit Word.exe
            oWord.Quit(ref oMissing, ref oMissing, ref oMissing);
        }

        private void FindLoop()
        {
            int intFound = 0;
            Word.Range rng = this.Content;

            rng.Find.ClearFormatting();
            rng.Find.Forward = true;
            rng.Find.Text = "find me";

            rng.Find.Execute(
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing);

            while (rng.Find.Found)
            {
                intFound++;
                rng.Find.Execute(
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing);
            }

            MessageBox.Show("Strings found: " + intFound.ToString());
        }
    }
}
