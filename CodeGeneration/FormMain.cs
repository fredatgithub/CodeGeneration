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

    readonly Dictionary<string, string> _languageDicoEn = new Dictionary<string, string>();
    readonly Dictionary<string, string> _languageDicoFr = new Dictionary<string, string>();
    Dictionary<string, string> codeLanguageExtension = new Dictionary<string, string>();
    private bool trimStartCode;
    private bool trimEndCode;
    private bool placeAfterSpaces;
    private bool targetLanguage;
    private bool launchNotepad;

    private void QuitToolStripMenuItemClick(object sender, EventArgs e)
    {
      SaveSettingsBeforeExiting();
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
      LoadCodeLanguageDictionary();
      LoadComboBoxLanguage();
      LoadSettingsAtStartup();
      SetCheckBoxesAtStartup();
    }

    private void LoadComboBoxLanguage()
    {
      comboBoxCodeLanguage.Items.Clear();
      comboBoxCodeLanguage.Items.Add("C#");
      comboBoxCodeLanguage.Items.Add("C++");
      comboBoxCodeLanguage.Items.Add("Visual Basic");
      comboBoxCodeLanguage.Items.Add("Text");
    }

    private void LoadCodeLanguageDictionary()
    {
      codeLanguageExtension.Add("C#", ".cs");
      codeLanguageExtension.Add("C++", ".cpp");
      codeLanguageExtension.Add("Visual Basic", ".vb");
      codeLanguageExtension.Add("Text", ".txt");
    }

    private void LoadSettingsAtStartup()
    {
      textBoxSourceFile.Text = Settings.Default.SourceFileName;
      textBoxTargetFile.Text = Settings.Default.TargetfileName;
      checkBoxTargetFile.Checked = Settings.Default.checkBoxTargetFile;
      checkBoxTargetLanguage.Checked = Settings.Default.checkBoxTargetLanguage;
      checkBoxLaunchNotepad.Checked = Settings.Default.checkBoxLaunchNotepad;
      textBoxTextBefore.Text = Settings.Default.textBoxTextBefore;
      textBoxTextAfter.Text = Settings.Default.textBoxTextAfter;
      checkBoxRemoveStartingSpaces.Checked = Settings.Default.checkBoxRemoveStartingSpaces;
      checkBoxRemoveEndingSpaces.Checked = Settings.Default.checkBoxRemoveEndingSpaces;
      checkBoxPlaceAfterSpaces.Checked = Settings.Default.checkBoxPlaceAfterSpaces;
      if (Settings.Default.comboBoxCodeLanguage == string.Empty)
      {
        comboBoxCodeLanguage.SelectedIndex = 0;
      }
      else
      {
        comboBoxCodeLanguage.SelectedItem = GetLanguage(Settings.Default.comboBoxCodeLanguage);
      }
    }

    private string GetLanguage(string language)
    {
      string result = string.Empty;
      foreach (var item in codeLanguageExtension.Where(item => item.Key == language))
      {
        result = item.Key;
        break;
      }

      return result;
    }

    private void SaveSettingsBeforeExiting()
    {
      Settings.Default.SourceFileName = textBoxSourceFile.Text;
      Settings.Default.TargetfileName = textBoxTargetFile.Text;
      Settings.Default.checkBoxTargetFile = checkBoxTargetFile.Checked;
      Settings.Default.checkBoxTargetLanguage = checkBoxTargetLanguage.Checked;
      Settings.Default.checkBoxLaunchNotepad = checkBoxLaunchNotepad.Checked;
      Settings.Default.textBoxTextBefore = textBoxTextBefore.Text;
      Settings.Default.textBoxTextAfter = textBoxTextAfter.Text;
      Settings.Default.checkBoxRemoveStartingSpaces = checkBoxRemoveStartingSpaces.Checked;
      Settings.Default.checkBoxRemoveEndingSpaces = checkBoxRemoveEndingSpaces.Checked;
      Settings.Default.checkBoxPlaceAfterSpaces = checkBoxPlaceAfterSpaces.Checked;
      Settings.Default.SourceFileName = textBoxSourceFile.Text;
      Settings.Default.TargetfileName = textBoxTargetFile.Text;
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      if (comboBoxCodeLanguage.SelectedIndex == -1)
      {
        if (comboBoxCodeLanguage.Items.Count == 0)
        {
          comboBoxCodeLanguage.Items.Add("text");
        }

        comboBoxCodeLanguage.SelectedIndex = 0;
      }

      Settings.Default.comboBoxCodeLanguage = comboBoxCodeLanguage.SelectedItem.ToString();
      Settings.Default.Save();
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
          case "checkBoxLaunchNotepad":
            launchNotepad = checkBoxLaunchNotepad.Checked;
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
      XDocument xDoc;
      try
      {
        xDoc = XDocument.Load(Settings.Default.LanguageFileName);
      }
      catch (Exception exception)
      {
        MessageBox.Show("Error while loading xml file " + exception);
        CreateLanguageFile();
        return;
      }

      var result = from node in xDoc.Descendants("term")
                   where node.HasElements
                   let xElementName = node.Element("name")
                   where xElementName != null
                   let xElementEnglish = node.Element("englishValue")
                   where xElementEnglish != null
                   let xElementFrench = node.Element("frenchValue")
                   where xElementFrench != null
                   select new
                   {
                     name = xElementName.Value,
                     englishValue = xElementEnglish.Value,
                     frenchValue = xElementFrench.Value
                   };
      foreach (var i in result)
      {
        if (!_languageDicoEn.ContainsKey(i.name))
        {
          _languageDicoEn.Add(i.name, i.englishValue);
        }
        else
        {
          MessageBox.Show("Your xml file has duplicate like: " + i.name);
        }

        if (!_languageDicoFr.ContainsKey(i.name))
        {
          _languageDicoFr.Add(i.name, i.frenchValue);
        }
        else
        {
          MessageBox.Show("Your xml file has duplicate like: " + i.name);
        }
      }
    }

    private static void CreateLanguageFile()
    {
      List<string> minimumVersion = new List<string>
      {
        "<?xml version=\"1.0\" encoding=\"utf-8\" ?>",
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
  "</terms>"
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

    private void FormMainFormClosing(object sender, FormClosingEventArgs e)
    {
      SaveSettingsBeforeExiting();
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
          fileToolStripMenuItem.Text = _languageDicoEn["MenuFile"];
          newToolStripMenuItem.Text = _languageDicoEn["MenuFileNew"];
          openToolStripMenuItem.Text = _languageDicoEn["MenuFileOpen"];
          saveToolStripMenuItem.Text = _languageDicoEn["MenuFileSave"];
          saveasToolStripMenuItem.Text = _languageDicoEn["MenuFileSaveAs"];
          printPreviewToolStripMenuItem.Text = _languageDicoEn["MenuFilePrint"];
          printPreviewToolStripMenuItem.Text = _languageDicoEn["MenufilePageSetup"];
          quitToolStripMenuItem.Text = _languageDicoEn["MenufileQuit"];
          editToolStripMenuItem.Text = _languageDicoEn["MenuEdit"];
          cancelToolStripMenuItem.Text = _languageDicoEn["MenuEditCancel"];
          redoToolStripMenuItem.Text = _languageDicoEn["MenuEditRedo"];
          cutToolStripMenuItem.Text = _languageDicoEn["MenuEditCut"];
          copyToolStripMenuItem.Text = _languageDicoEn["MenuEditCopy"];
          pasteToolStripMenuItem.Text = _languageDicoEn["MenuEditPaste"];
          selectAllToolStripMenuItem.Text = _languageDicoEn["MenuEditSelectAll"];
          toolsToolStripMenuItem.Text = _languageDicoEn["MenuTools"];
          personalizeToolStripMenuItem.Text = _languageDicoEn["MenuToolsCustomize"];
          optionsToolStripMenuItem.Text = _languageDicoEn["MenuToolsOptions"];
          languagetoolStripMenuItem.Text = _languageDicoEn["MenuLanguage"];
          englishToolStripMenuItem.Text = _languageDicoEn["MenuLanguageEnglish"];
          frenchToolStripMenuItem.Text = _languageDicoEn["MenuLanguageFrench"];
          helpToolStripMenuItem.Text = _languageDicoEn["MenuHelp"];
          summaryToolStripMenuItem.Text = _languageDicoEn["MenuHelpSummary"];
          indexToolStripMenuItem.Text = _languageDicoEn["MenuHelpIndex"];
          searchToolStripMenuItem.Text = _languageDicoEn["MenuHelpSearch"];
          aboutToolStripMenuItem.Text = _languageDicoEn["MenuHelpAbout"];
          break;

        case "French":
          frenchToolStripMenuItem.Checked = true;
          englishToolStripMenuItem.Checked = false;
          fileToolStripMenuItem.Text = _languageDicoFr["MenuFile"];
          newToolStripMenuItem.Text = _languageDicoFr["MenuFileNew"];
          openToolStripMenuItem.Text = _languageDicoFr["MenuFileOpen"];
          saveToolStripMenuItem.Text = _languageDicoFr["MenuFileSave"];
          saveasToolStripMenuItem.Text = _languageDicoFr["MenuFileSaveAs"];
          printPreviewToolStripMenuItem.Text = _languageDicoFr["MenuFilePrint"];
          printPreviewToolStripMenuItem.Text = _languageDicoFr["MenufilePageSetup"];
          quitToolStripMenuItem.Text = _languageDicoFr["MenufileQuit"];
          editToolStripMenuItem.Text = _languageDicoFr["MenuEdit"];
          cancelToolStripMenuItem.Text = _languageDicoFr["MenuEditCancel"];
          redoToolStripMenuItem.Text = _languageDicoFr["MenuEditRedo"];
          cutToolStripMenuItem.Text = _languageDicoFr["MenuEditCut"];
          copyToolStripMenuItem.Text = _languageDicoFr["MenuEditCopy"];
          pasteToolStripMenuItem.Text = _languageDicoFr["MenuEditPaste"];
          selectAllToolStripMenuItem.Text = _languageDicoFr["MenuEditSelectAll"];
          toolsToolStripMenuItem.Text = _languageDicoFr["MenuTools"];
          personalizeToolStripMenuItem.Text = _languageDicoFr["MenuToolsCustomize"];
          optionsToolStripMenuItem.Text = _languageDicoFr["MenuToolsOptions"];
          languagetoolStripMenuItem.Text = _languageDicoFr["MenuLanguage"];
          englishToolStripMenuItem.Text = _languageDicoFr["MenuLanguageEnglish"];
          frenchToolStripMenuItem.Text = _languageDicoFr["MenuLanguageFrench"];
          helpToolStripMenuItem.Text = _languageDicoFr["MenuHelp"];
          summaryToolStripMenuItem.Text = _languageDicoFr["MenuHelpSummary"];
          indexToolStripMenuItem.Text = _languageDicoFr["MenuHelpIndex"];
          searchToolStripMenuItem.Text = _languageDicoFr["MenuHelpSearch"];
          aboutToolStripMenuItem.Text = _languageDicoFr["MenuHelpAbout"];
          break;

      }
    }

    private void ButtonPickSourceFileClick(object sender, EventArgs e)
    {
      var opendialog = new OpenFileDialog
      { Filter = @"Code files(*.cs; *.cpp; *.vb *.txt)| *.cs; *.cpp; *.vb; *.txt" };
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
        if (placeAfterSpaces)
        {
          sw.WriteLine(InsertString(line, textBoxTextBefore.Text) + textBoxTextAfter.Text);
        }
        else
        {
          sw.WriteLine(textBoxTextBefore.Text + line + textBoxTextAfter.Text);
        }
        
      }

      sw.Close();
      var result = DisplayMessage("The file\n" + textBoxSourceFile.Text + "\nhas been created.\ndo you want to open it ?",
        "Code File created", MessageBoxButtons.YesNo);
      if (result == DialogResult.Yes)
      {
        if (launchNotepad)
        {
          Process.Start("notepad.exe", savedFile);
        }
        else
        {
          Process.Start(savedFile);
        }
      }
    }

    private string InsertString(string myString, string stringToBeinserted, char characterToSkip = ' ')
    {
      string result = myString;
      int firstIndexOf = 0;
      for (int i = 0; i < myString.Length; i++)
      {
        if (myString[i] == characterToSkip || myString[i] == '\t')
        {
          firstIndexOf++;
        }
        else
        {
          break;
        }
      }

      string blanks = myString.Substring(0, firstIndexOf);
      string afterBlanks = myString.Substring(firstIndexOf, myString.Length - blanks.Length);
      result = blanks + stringToBeinserted + afterBlanks;
      return result;
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

    private void checkBoxLaunchNotepad_CheckedChanged(object sender, EventArgs e)
    {
      launchNotepad = checkBoxLaunchNotepad.Checked;
    }

    private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
  }
}
