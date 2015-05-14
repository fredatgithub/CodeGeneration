/*
The MIT License(MIT)
Copyright(c) 2015 Freddy Juhel
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using CodeGeneration.Properties;

namespace CodeGeneration
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    readonly Dictionary<string, string> languageDicoEn = new Dictionary<string, string>();
    readonly Dictionary<string, string> languageDicoFr = new Dictionary<string, string>();
    readonly Dictionary<string, string> codeLanguageExtension = new Dictionary<string, string>();
    private bool trimStartCode;
    private bool trimEndCode;
    private bool placeAfterSpaces;
    private bool targetLanguage;

    private void QuitToolStripMenuItemClick(object sender, EventArgs e)
    {
      SaveWindowValue();
      Application.Exit();
    }

    private void AboutToolStripMenuItemClick(object sender, EventArgs e)
    {
      AboutBoxApplication aboutBoxApplication = new AboutBoxApplication();
      aboutBoxApplication.ShowDialog();
    }

    private void DisplayTitle()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      Text += string.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
    }

    private void FormMainLoad(object sender, EventArgs e)
    {
      DisplayTitle();
      GetWindowValue();
      LoadLanguages();
      SetLanguage(Settings.Default.LastLanguageUsed);
      LoadCheckboxesAtStartup();
      SetCheckBoxesAtStartup();
      comboBoxCodeLanguage.Items.Add("C#");
      comboBoxCodeLanguage.Items.Add("C++");
      comboBoxCodeLanguage.Items.Add("Visual Basic");
      comboBoxCodeLanguage.SelectedIndex = 0;
      codeLanguageExtension.Add("C#", ".cs");
      codeLanguageExtension.Add("C++", ".cpp");
      codeLanguageExtension.Add("Visual Basic", ".vb");
    }

    private void LoadCheckboxesAtStartup()
    {
      // TODO
    }

    private void SetCheckBoxesAtStartup()
    {
      foreach (CheckBox control in Controls.OfType<CheckBox>())
      {
        switch (control.Name)
        {
          case "checkBoxTargetLanguage":
            targetLanguage = checkBoxTargetLanguage.Checked;
            break;
          case "checkBoxRemoveEndingSpaces":
            trimEndCode = checkBoxRemoveEndingSpaces.Checked;
            break;
          case "checkBoxRemoveStartingSpaces":
            trimStartCode = checkBoxRemoveStartingSpaces.Checked;
            break;
          case "checkBoxPlaceAfterSpaces":
            placeAfterSpaces = checkBoxPlaceAfterSpaces.Checked;
            break;
        }
      }
    }

    private void LoadLanguages()
    {
      if (!File.Exists(Settings.Default.LanguageFileName))
      {
        CreateLanguageFile();
      }

      // read the translation file and feed the language
      XDocument xDoc = XDocument.Load(Settings.Default.LanguageFileName);
      var result = from node in xDoc.Descendants("term")
                   where node.HasElements
                   select new
                   {
                     name = node.Element("name").Value,
                     englishValue = node.Element("englishValue").Value,
                     frenchValue = node.Element("frenchValue").Value
                   };
      foreach (var i in result)
      {
        languageDicoEn.Add(i.name, i.englishValue);
        languageDicoFr.Add(i.name, i.frenchValue);
      }
    }

    private static void CreateLanguageFile()
    {
      List<string> minimumVersion = new List<string>
      {
        "<?xml version=\"1.0\" encoding=\"utf - 8\" ?>",
        "<Document>",
        "<DocumentVersion>",
        "<version> 1.0 </version>",
        "</DocumentVersion>",
        "<terms>",
         "<term>",
        "<name>MenuFile</name>",
        "<englishValue>File</englishValue>",
        "<frenchValue>Fichier</frenchValue>",
        "</term>",
        "<term>",
      "<name>MenuFileNew</name>",
      "<englishValue>New</englishValue>",
      "<frenchValue>Nouveau</frenchValue>",
      "</term>",
      "<term>",
      "<name>MenuFileOpen</name>",
      "<englishValue>Open</englishValue>",
      "<frenchValue>Ouvrir</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuFileSave</name>",
      "<englishValue>Save</englishValue>",
      "<frenchValue>Enregistrer</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuFileSaveAs</name>",
      "<englishValue>Save as ...</englishValue>",
      "<frenchValue>Enregistrer sous ...</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuFilePrint</name>",
      "<englishValue>Print ...</englishValue>",
      "<frenchValue>Imprimer ...</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenufilePageSetup</name>",
      "<englishValue>Page setup</englishValue>",
      "<frenchValue>Aperçu avant impression</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenufileQuit</name>",
      "<englishValue>Quit</englishValue>",
      "<frenchValue>Quitter</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuEdit</name>",
      "<englishValue>Edit</englishValue>",
      "<frenchValue>Edition</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuEditCancel</name>",
      "<englishValue>Cancel</englishValue>",
      "<frenchValue>Annuler</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuEditRedo</name>",
      "<englishValue>Redo</englishValue>",
      "<frenchValue>Rétablir</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuEditCut</name>",
      "<englishValue>Cut</englishValue>",
      "<frenchValue>Couper</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuEditCopy</name>",
      "<englishValue>Copy</englishValue>",
      "<frenchValue>Copier</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuEditPaste</name>",
      "<englishValue>Paste</englishValue>",
      "<frenchValue>Coller</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuEditSelectAll</name>",
      "<englishValue>Select All</englishValue>",
      "<frenchValue>Sélectionner tout</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuTools</name>",
      "<englishValue>Tools</englishValue>",
      "<frenchValue>Outils</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuToolsCustomize</name>",
      "<englishValue>Customize ...</englishValue>",
      "<frenchValue>Personaliser ...</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuToolsOptions</name>",
      "<englishValue>Options</englishValue>",
      "<frenchValue>Options</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuLanguage</name>",
      "<englishValue>Language</englishValue>",
      "<frenchValue>Langage</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuLanguageEnglish</name>",
      "<englishValue>English</englishValue>",
      "<frenchValue>Anglais</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuLanguageFrench</name>",
      "<englishValue>French</englishValue>",
      "<frenchValue>Français</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuHelp</name>",
      "<englishValue>Help</englishValue>",
      "<frenchValue>Aide</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuHelpSummary</name>",
      "<englishValue>Summary</englishValue>",
      "<frenchValue>Sommaire</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuHelpIndex</name>",
      "<englishValue>Index</englishValue>",
      "<frenchValue>Index</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuHelpSearch</name>",
      "<englishValue>Search</englishValue>",
      "<frenchValue>Rechercher</frenchValue>",
    "</term>",
    "<term>",
      "<name>MenuHelpAbout</name>",
      "<englishValue>About</englishValue>",
      "<frenchValue>A propos de ...</frenchValue>",
    "</term>",
  "</terms>",
"</Document>"
      };
      StreamWriter sw = new StreamWriter(Settings.Default.LanguageFileName);
      foreach (string item in minimumVersion)
      {
        sw.WriteLine(item);
      }

      sw.Close();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.SourceFileName = textBoxSourceFile.Text;
      Settings.Default.TargetfileName = textBoxTargetFile.Text;
      Settings.Default.Save();
    }

    private void FormMainFormClosing(object sender, FormClosingEventArgs e)
    {
      SaveWindowValue();
    }

    private void FrenchToolStripMenuItemClick(object sender, EventArgs e)
    {
      SetLanguage(Language.French.ToString());
    }

    private void EnglishToolStripMenuItemClick(object sender, EventArgs e)
    {
      SetLanguage(Language.English.ToString());
    }

    private void SetLanguage(string myLanguage)
    {
      switch (myLanguage)
      {
        case "English":
          frenchToolStripMenuItem.Checked = false;
          englishToolStripMenuItem.Checked = true;
          fileToolStripMenuItem.Text = languageDicoEn["MenuFile"];
          newToolStripMenuItem.Text = languageDicoEn["MenuFileNew"];
          openToolStripMenuItem.Text = languageDicoEn["MenuFileOpen"];
          saveToolStripMenuItem.Text = languageDicoEn["MenuFileSave"];
          saveasToolStripMenuItem.Text = languageDicoEn["MenuFileSaveAs"];
          printPreviewToolStripMenuItem.Text = languageDicoEn["MenuFilePrint"];
          printPreviewToolStripMenuItem.Text = languageDicoEn["MenufilePageSetup"];
          quitToolStripMenuItem.Text = languageDicoEn["MenufileQuit"];
          editToolStripMenuItem.Text = languageDicoEn["MenuEdit"];
          cancelToolStripMenuItem.Text = languageDicoEn["MenuEditCancel"];
          redoToolStripMenuItem.Text = languageDicoEn["MenuEditRedo"];
          cutToolStripMenuItem.Text = languageDicoEn["MenuEditCut"];
          copyToolStripMenuItem.Text = languageDicoEn["MenuEditCopy"];
          pasteToolStripMenuItem.Text = languageDicoEn["MenuEditPaste"];
          selectAllToolStripMenuItem.Text = languageDicoEn["MenuEditSelectAll"];
          toolsToolStripMenuItem.Text = languageDicoEn["MenuTools"];
          personalizeToolStripMenuItem.Text = languageDicoEn["MenuToolsCustomize"];
          optionsToolStripMenuItem.Text = languageDicoEn["MenuToolsOptions"];
          languagetoolStripMenuItem.Text = languageDicoEn["MenuLanguage"];
          englishToolStripMenuItem.Text = languageDicoEn["MenuLanguageEnglish"];
          frenchToolStripMenuItem.Text = languageDicoEn["MenuLanguageFrench"];
          helpToolStripMenuItem.Text = languageDicoEn["MenuHelp"];
          summaryToolStripMenuItem.Text = languageDicoEn["MenuHelpSummary"];
          indexToolStripMenuItem.Text = languageDicoEn["MenuHelpIndex"];
          searchToolStripMenuItem.Text = languageDicoEn["MenuHelpSearch"];
          aboutToolStripMenuItem.Text = languageDicoEn["MenuHelpAbout"];

          break;
        case "French":
          frenchToolStripMenuItem.Checked = true;
          englishToolStripMenuItem.Checked = false;
          fileToolStripMenuItem.Text = languageDicoFr["MenuFile"];
          newToolStripMenuItem.Text = languageDicoFr["MenuFileNew"];
          openToolStripMenuItem.Text = languageDicoFr["MenuFileOpen"];
          saveToolStripMenuItem.Text = languageDicoFr["MenuFileSave"];
          saveasToolStripMenuItem.Text = languageDicoFr["MenuFileSaveAs"];
          printPreviewToolStripMenuItem.Text = languageDicoFr["MenuFilePrint"];
          printPreviewToolStripMenuItem.Text = languageDicoFr["MenufilePageSetup"];
          quitToolStripMenuItem.Text = languageDicoFr["MenufileQuit"];
          editToolStripMenuItem.Text = languageDicoFr["MenuEdit"];
          cancelToolStripMenuItem.Text = languageDicoFr["MenuEditCancel"];
          redoToolStripMenuItem.Text = languageDicoFr["MenuEditRedo"];
          cutToolStripMenuItem.Text = languageDicoFr["MenuEditCut"];
          copyToolStripMenuItem.Text = languageDicoFr["MenuEditCopy"];
          pasteToolStripMenuItem.Text = languageDicoFr["MenuEditPaste"];
          selectAllToolStripMenuItem.Text = languageDicoFr["MenuEditSelectAll"];
          toolsToolStripMenuItem.Text = languageDicoFr["MenuTools"];
          personalizeToolStripMenuItem.Text = languageDicoFr["MenuToolsCustomize"];
          optionsToolStripMenuItem.Text = languageDicoFr["MenuToolsOptions"];
          languagetoolStripMenuItem.Text = languageDicoFr["MenuLanguage"];
          englishToolStripMenuItem.Text = languageDicoFr["MenuLanguageEnglish"];
          frenchToolStripMenuItem.Text = languageDicoFr["MenuLanguageFrench"];
          helpToolStripMenuItem.Text = languageDicoFr["MenuHelp"];
          summaryToolStripMenuItem.Text = languageDicoFr["MenuHelpSummary"];
          indexToolStripMenuItem.Text = languageDicoFr["MenuHelpIndex"];
          searchToolStripMenuItem.Text = languageDicoFr["MenuHelpSearch"];
          aboutToolStripMenuItem.Text = languageDicoFr["MenuHelpAbout"];

          break;

      }
    }

    private void ButtonPickSourceFileClick(object sender, EventArgs e)
    {
      var opendialog = new OpenFileDialog
      { Filter = @"Code files(*.cs; *.cpp; *.vb)| *.cs; *.cpp; *.vb" };
      if (opendialog.ShowDialog() == DialogResult.OK)
      {
        textBoxSourceFile.Text = opendialog.FileName;
      }
    }

    private void ButtonTargetDirectoryClick(object sender, EventArgs e)
    {
      // choose a directory
      if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        textBoxTargetFile.Text = folderBrowserDialog1.SelectedPath;
      }
    }

    private void ButtonGenerateFileClick(object sender, EventArgs e)
    {
      // verify prerequisite and generate the target file
      if (textBoxSourceFile.Text == string.Empty &&
        textBoxTargetFile.Text == string.Empty)
      {
        DisplayMsg("There is nothing to add either before or after each line", "no modification",
          MessageBoxButtons.OK);
        return;
      }

      if (textBoxSourceFile.Text == string.Empty)
      {
        DisplayMsg("Choose a code file", "No code file", MessageBoxButtons.OK);
        return;
      }

      if (textBoxTargetFile.Text == string.Empty)
      {
        DisplayMsg("Choose a target directory", "No target directory", MessageBoxButtons.OK);
        return;
      }

      if (!Directory.Exists(textBoxTargetFile.Text))
      {
        DisplayMsg("The target directory doesn't exist", "No Target directory", MessageBoxButtons.OK);
        return;
      }

      if (!File.Exists(textBoxSourceFile.Text))
      {
        DisplayMsg("The source file doesn't exist", "No source file", MessageBoxButtons.OK);
        return;
      }

      //reading the source file
      List<string> sourceFile = new List<string>();
      StreamReader sr = new StreamReader(textBoxSourceFile.Text);
      while (!sr.EndOfStream)
      {
        sourceFile.Add(sr.ReadLine());
      }
      
      sr.Close();
      // processing the source file
      for (int i = 0; i < sourceFile.Count; i++)
      {
        if (trimStartCode)
        {
          sourceFile[i] = sourceFile[i].TrimStart();
        }

        if (trimEndCode)
        {
          sourceFile[i] = sourceFile[i].TrimEnd();
        }
      }
      // writing the file
      string extension = targetLanguage ? Path.GetExtension(textBoxSourceFile.Text) :
        codeLanguageExtension[comboBoxCodeLanguage.SelectedItem.ToString()];
      string savedFile = Path.Combine(textBoxTargetFile.Text,
        Path.GetFileNameWithoutExtension(textBoxSourceFile.Text) + "2." + extension);
      StreamWriter sw = new StreamWriter(savedFile);
      foreach (string line in sourceFile)
      {
        // write after spaces if any TODO
        sw.WriteLine(textBoxTextBefore.Text + line + textBoxTextAfter.Text);
      }

      sw.Close();
      var result = DisplayMessage("The file\n" + textBoxSourceFile.Text + "\nhas been created.\ndo you want to open it ?", 
        "Code File created", MessageBoxButtons.YesNo);
      if (result == DialogResult.Yes)
      {
        Process.Start("notepad.exe"); // TODO debug open the file with notepad.exe // savedFile
      }
    }

    private void CheckBoxTargetFileCheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxTargetFile.Checked)
      {
        if (textBoxSourceFile.Text == string.Empty)
        {
          DisplayMsg("Choose a code file first", "No source directory", MessageBoxButtons.OK);
          checkBoxTargetFile.Checked = false;
          return;
        }
        else
        {
          if (!Directory.Exists(RemoveFileNameFromDirectory(textBoxSourceFile.Text)))
          {
            DisplayMsg("The source directory doesn't exist", "No Source directory", MessageBoxButtons.OK);
            checkBoxTargetFile.Checked = false;
            return;
          }
          else
          {
            textBoxTargetFile.Text = RemoveFileNameFromDirectory(textBoxSourceFile.Text);
          }
        }
      }
    }

    private static string RemoveFileNameFromDirectory(string filePath)
    {
      return Path.GetDirectoryName(filePath);
    }

    private DialogResult DisplayMessage(string message, string title, MessageBoxButtons buttons)
    {
      DialogResult result = MessageBox.Show(this, message, title, buttons);
      return result;
    }

    private void DisplayMsg(string message, string title, MessageBoxButtons buttons)
    {
      MessageBox.Show(this, message, title, buttons);
    }

    private static string[] GetDirectoryFileNameAndExtension(string filePath)
    {
      string directory = Path.GetDirectoryName(filePath);
      string fileName = Path.GetFileNameWithoutExtension(filePath);
      string extension = Path.GetExtension(filePath);

      return new[] { directory, fileName, extension };
    }

    private void CheckBoxRemoveStartingSpacesCheckedChanged(object sender, EventArgs e)
    {
      trimStartCode = checkBoxRemoveStartingSpaces.Checked;
    }

    private void CheckBoxRemoveEndingSpacesCheckedChanged(object sender, EventArgs e)
    {
      trimEndCode = checkBoxRemoveEndingSpaces.Checked;
    }

    private void CheckBoxPlaceAfterSpacesCheckedChanged(object sender, EventArgs e)
    {
      placeAfterSpaces = checkBoxPlaceAfterSpaces.Checked;
    }

    private void checkBoxTargetLanguage_CheckedChanged(object sender, EventArgs e)
    {
      targetLanguage = checkBoxTargetLanguage.Checked;
    }
  }
}