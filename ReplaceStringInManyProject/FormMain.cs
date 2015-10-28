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
using ReplaceStringInManyProject.Properties;

namespace ReplaceStringInManyProject
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    public readonly Dictionary<string, string> _languageDicoEn = new Dictionary<string, string>();
    public readonly Dictionary<string, string> _languageDicoFr = new Dictionary<string, string>();
    private string _currentLanguage = "english";
    private ConfigurationOptions _configurationOptions = new ConfigurationOptions();

    private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveWindowValue();
      Application.Exit();
    }

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
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

    private void FormMain_Load(object sender, EventArgs e)
    {
      LoadSettingsAtStartup();
    }

    private void LoadSettingsAtStartup()
    {
      DisplayTitle();
      GetWindowValue();
      LoadLanguages();
      SetLanguage(Settings.Default.LastLanguageUsed);
      SetButtonEnabled(buttonSearch, textBoxInitialPath, textBoxfileToChange, textBoxStringToSearch, textBoxReplaceBy);
      SetButtonEnabled(buttonReplace, textBoxInitialPath, textBoxfileToChange, textBoxStringToSearch, textBoxReplaceBy);
      SetButtonEnabled(buttonReplace, listViewResult);
      SetButtonEnabled(buttonViewFile, listViewResult);
    }

    private void LoadConfigurationOptions()
    {
      _configurationOptions.Option1Name = Settings.Default.Option1Name;
      _configurationOptions.Option2Name = Settings.Default.Option2Name;
    }

    private void SaveConfigurationOptions()
    {
      _configurationOptions.Option1Name = Settings.Default.Option1Name;
      _configurationOptions.Option2Name = Settings.Default.Option2Name;
    }

    private void LoadLanguages()
    {
      if (!File.Exists(Settings.Default.LanguageFileName))
      {
        CreateLanguageFile();
      }

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
          MessageBox.Show("Your xml file: " + Settings.Default.LanguageFileName +
            " has duplicate like: " + i.name);
        }

        if (!_languageDicoFr.ContainsKey(i.name))
        {
          _languageDicoFr.Add(i.name, i.frenchValue);
        }
        else
        {
          MessageBox.Show("Your xml file: " + Settings.Default.LanguageFileName +
            " has duplicate like: " + i.name);
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
      textBoxInitialPath.Text = Settings.Default.textBoxInitialPath;
      textBoxfileToChange.Text = Settings.Default.textBoxfileToChange;
      textBoxStringToSearch.Text = Settings.Default.textBoxStringToSearch;
      textBoxReplaceBy.Text = Settings.Default.textBoxReplaceBy;
      SetDisplayOption(Settings.Default.DisplayToolStripMenuItem);
      LoadConfigurationOptions();
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.LastLanguageUsed = frenchToolStripMenuItem.Checked ? "French" : "English";
      Settings.Default.DisplayToolStripMenuItem = GetDisplayOption();
      Settings.Default.textBoxInitialPath = textBoxInitialPath.Text;
      Settings.Default.textBoxfileToChange = textBoxfileToChange.Text;
      Settings.Default.textBoxStringToSearch = textBoxStringToSearch.Text;
      Settings.Default.textBoxReplaceBy = textBoxReplaceBy.Text;
      SaveConfigurationOptions();
      Settings.Default.Save();
    }

    private string GetDisplayOption()
    {
      if (SmallToolStripMenuItem.Checked)
      {
        return "Small";
      }

      if (MediumToolStripMenuItem.Checked)
      {
        return "Medium";
      }

      return LargeToolStripMenuItem.Checked ? "Large" : string.Empty;
    }

    private void SetDisplayOption(string option)
    {
      UncheckAllOptions();
      switch (option.ToLower())
      {
        case "small":
          SmallToolStripMenuItem.Checked = true;
          break;
        case "medium":
          MediumToolStripMenuItem.Checked = true;
          break;
        case "large":
          LargeToolStripMenuItem.Checked = true;
          break;
        default:
          SmallToolStripMenuItem.Checked = true;
          break;
      }
    }

    private void UncheckAllOptions()
    {
      SmallToolStripMenuItem.Checked = false;
      MediumToolStripMenuItem.Checked = false;
      LargeToolStripMenuItem.Checked = false;
    }

    private void FormMainFormClosing(object sender, FormClosingEventArgs e)
    {
      SaveWindowValue();
    }

    private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _currentLanguage = Language.French.ToString();
      SetLanguage(Language.French.ToString());
      AdjustAllControls();
    }

    private void englishToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _currentLanguage = Language.English.ToString();
      SetLanguage(Language.English.ToString());
      AdjustAllControls();
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
          DisplayToolStripMenuItem.Text = _languageDicoEn["Display"];
          SmallToolStripMenuItem.Text = _languageDicoEn["Small"];
          MediumToolStripMenuItem.Text = _languageDicoEn["Medium"];
          LargeToolStripMenuItem.Text = _languageDicoEn["Large"];
          labelPath.Text = _languageDicoEn["Initial path"] + Punctuation.Colon;
          labelFileToChange.Text = _languageDicoEn["File to change"] + Punctuation.Colon;
          labelStringToSearch.Text = _languageDicoEn["String to search"] + Punctuation.Colon;
          labelReplaceBy.Text = _languageDicoEn["Replace by"] + Punctuation.Colon;
          buttonSearch.Text = _languageDicoEn["Search"];
          buttonReplace.Text = _languageDicoEn["Replace"];
          buttonViewFile.Text = _languageDicoEn["View"];

          _currentLanguage = "English";
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
          DisplayToolStripMenuItem.Text = _languageDicoFr["Display"];
          SmallToolStripMenuItem.Text = _languageDicoFr["Small"];
          MediumToolStripMenuItem.Text = _languageDicoFr["Medium"];
          LargeToolStripMenuItem.Text = _languageDicoFr["Large"];
          labelPath.Text = _languageDicoFr["Initial path"] + Punctuation.OneSpace + Punctuation.Colon;
          labelFileToChange.Text = _languageDicoFr["File to change"] + Punctuation.OneSpace + Punctuation.Colon;
          labelStringToSearch.Text = _languageDicoFr["String to search"] + Punctuation.OneSpace + Punctuation.Colon;
          labelReplaceBy.Text = _languageDicoFr["Replace by"] + Punctuation.OneSpace + Punctuation.Colon;
          buttonSearch.Text = _languageDicoFr["Search"];
          buttonReplace.Text = _languageDicoFr["Replace"];
          buttonViewFile.Text = _languageDicoFr["View"];
          _currentLanguage = "French";
          break;
        default:
          SetLanguage("English");
          break;
      }
    }

    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control>
      {
        textBoxInitialPath, textBoxfileToChange, textBoxStringToSearch, textBoxReplaceBy
      });
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        CutToClipboard(tb);
      }
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control>
      {
        textBoxInitialPath, textBoxfileToChange, textBoxStringToSearch, textBoxReplaceBy
      });
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        CopyToClipboard(tb);
      }
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control>
      {
        textBoxInitialPath, textBoxfileToChange, textBoxStringToSearch, textBoxReplaceBy
      });
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        PasteFromClipboard(tb);
      }
    }

    private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control>
      {
        textBoxInitialPath, textBoxfileToChange, textBoxStringToSearch, textBoxReplaceBy
      });
      TextBox control = focusedControl as TextBox;
      if (control != null) control.SelectAll();
    }

    private void CutToClipboard(TextBoxBase tb, string errorMessage = "nothing")
    {
      if (tb != ActiveControl) return;
      if (tb.Text == string.Empty)
      {
        DisplayMessage(Translate("There is") + Punctuation.OneSpace +
          Translate(errorMessage) + Punctuation.OneSpace +
          Translate("to cut") + Punctuation.OneSpace, Translate(errorMessage),
          MessageBoxButtons.OK);
        return;
      }

      if (tb.SelectedText == string.Empty)
      {
        DisplayMessage(Translate("No text has been selected"),
          Translate(errorMessage), MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(tb.SelectedText);
      tb.SelectedText = string.Empty;
    }

    private void CopyToClipboard(TextBoxBase tb, string message = "nothing")
    {
      if (tb != ActiveControl) return;
      if (tb.Text == string.Empty)
      {
        DisplayMessage(Translate("There is nothing to copy") + Punctuation.OneSpace,
          Translate(message), MessageBoxButtons.OK);
        return;
      }

      if (tb.SelectedText == string.Empty)
      {
        DisplayMessage(Translate("No text has been selected"),
          Translate(message), MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(tb.SelectedText);
    }

    private void PasteFromClipboard(TextBoxBase tb)
    {
      if (tb != ActiveControl) return;
      var selectionIndex = tb.SelectionStart;
      tb.Text = tb.Text.Insert(selectionIndex, Clipboard.GetText());
      tb.SelectionStart = selectionIndex + Clipboard.GetText().Length;
    }

    private void DisplayMessage(string message, string title, MessageBoxButtons buttons)
    {
      MessageBox.Show(this, message, title, buttons);
    }

    private string Translate(string index)
    {
      string result = string.Empty;
      switch (_currentLanguage.ToLower())
      {
        case "english":
          result = _languageDicoEn.ContainsKey(index) ? _languageDicoEn[index] :
           "the term: \"" + index + "\" has not been translated yet.\nPlease tell the developer to translate this term";
          break;
        case "french":
          result = _languageDicoFr.ContainsKey(index) ? _languageDicoFr[index] :
            "the term: \"" + index + "\" has not been translated yet.\nPlease tell the developer to translate this term";
          break;
      }

      return result;
    }

    private static Control FindFocusedControl(Control container)
    {
      foreach (Control childControl in container.Controls.Cast<Control>().Where(childControl => childControl.Focused))
      {
        return childControl;
      }

      return (from Control childControl in container.Controls
              select FindFocusedControl(childControl)).FirstOrDefault(maybeFocusedControl => maybeFocusedControl != null);
    }

    private static Control FindFocusedControl(List<Control> container)
    {
      return container.FirstOrDefault(control => control.Focused);
    }

    private static Control FindFocusedControl(params Control[] container)
    {
      return container.FirstOrDefault(control => control.Focused);
    }

    private static Control FindFocusedControl(IEnumerable<Control> container)
    {
      return container.FirstOrDefault(control => control.Focused);
    }

    private static string ChooseDirectory()
    {
      string result = string.Empty;
      FolderBrowserDialog fbd = new FolderBrowserDialog();
      if (fbd.ShowDialog() == DialogResult.OK)
      {
        result = fbd.SelectedPath;
      }

      return result;
    }

    private void SmallToolStripMenuItem_Click(object sender, EventArgs e)
    {
      UncheckAllOptions();
      SmallToolStripMenuItem.Checked = true;
      AdjustAllControls();
    }

    private void MediumToolStripMenuItem_Click(object sender, EventArgs e)
    {
      UncheckAllOptions();
      MediumToolStripMenuItem.Checked = true;
      AdjustAllControls();
    }

    private void LargeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      UncheckAllOptions();
      LargeToolStripMenuItem.Checked = true;
      AdjustAllControls();
    }

    private static void AdjustControls(params Control[] listOfControls)
    {
      if (listOfControls.Length == 0)
      {
        return;
      }

      int position = listOfControls[0].Width + 33; // 33 is the initial padding
      bool isFirstControl = true;
      foreach (Control control in listOfControls)
      {
        if (isFirstControl)
        {
          isFirstControl = false;
        }
        else
        {
          control.Left = position + 10;
          position += control.Width;
        }
      }
    }

    private void AdjustAllControls()
    {
      AdjustControls(labelPath, textBoxInitialPath, buttonPeekDirectory);
      AdjustControls(labelFileToChange, textBoxfileToChange, buttonPeekFile);
      AdjustControls(labelStringToSearch, textBoxStringToSearch);
      AdjustControls(labelReplaceBy, textBoxReplaceBy);
    }

    private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormOptions frmOptions = new FormOptions(_configurationOptions);

      if (frmOptions.ShowDialog() == DialogResult.OK)
      {
        _configurationOptions = frmOptions.ConfigurationOptions2;
      }
    }

    private void buttonPeekDirectory_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog fbd = new FolderBrowserDialog();
      if (fbd.ShowDialog() == DialogResult.OK)
      {
        textBoxInitialPath.Text = fbd.SelectedPath;
      }
    }

    private void textBoxInitialPath_TextChanged(object sender, EventArgs e)
    {
      SetButtonEnabled(buttonSearch, textBoxInitialPath, textBoxfileToChange, textBoxStringToSearch, textBoxReplaceBy);
      SetButtonEnabled(buttonReplace, textBoxInitialPath, textBoxfileToChange, textBoxStringToSearch, textBoxReplaceBy);
    }

    private static void SetButtonEnabled(Button button, params TextBox[] textBoxes)
    {
      bool result = true;
      foreach (TextBox box in textBoxes.Where(box => box.Text.Length == 0))
      {
        result = false;
      }

      button.Enabled = result;
    }

    private static void SetButtonEnabled(Button button, params ListView[] listViews)
    {
      bool result = true;
      foreach (ListView view in listViews.Where(view => view.Items.Count == 0))
      {
        result = false;
      }

      button.Enabled = result;
    }

    private void textBoxfileToChange_TextChanged(object sender, EventArgs e)
    {
      SetButtonEnabled(buttonSearch, textBoxInitialPath, textBoxfileToChange, textBoxStringToSearch, textBoxReplaceBy);
      SetButtonEnabled(buttonReplace, textBoxInitialPath, textBoxfileToChange, textBoxStringToSearch, textBoxReplaceBy);
      SetButtonEnabled(buttonReplace, listViewResult);
    }

    private void textBoxStringToSearch_TextChanged(object sender, EventArgs e)
    {
      SetButtonEnabled(buttonSearch, textBoxInitialPath, textBoxfileToChange, textBoxStringToSearch, textBoxReplaceBy);
      SetButtonEnabled(buttonReplace, textBoxInitialPath, textBoxfileToChange, textBoxStringToSearch, textBoxReplaceBy);
      SetButtonEnabled(buttonReplace, listViewResult);
    }

    private void textBoxReplaceBy_TextChanged(object sender, EventArgs e)
    {
      SetButtonEnabled(buttonSearch, textBoxInitialPath, textBoxfileToChange, textBoxStringToSearch, textBoxReplaceBy);
      SetButtonEnabled(buttonReplace, textBoxInitialPath, textBoxfileToChange, textBoxStringToSearch, textBoxReplaceBy);
      SetButtonEnabled(buttonReplace, listViewResult);
    }

    private void buttonPeekFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog fd = new OpenFileDialog();
      if (fd.ShowDialog() == DialogResult.OK)
      {
        textBoxfileToChange.Text = fd.SafeFileName;
      }
    }

    private void buttonSearch_Click(object sender, EventArgs e)
    {
      listViewResult.Items.Clear();
      listViewResult.Columns.Add("To be updated",
        StringMax("To be updated", textBoxfileToChange.Text, "To be updated".Length * 8), HorizontalAlignment.Left);
      listViewResult.Columns.Add("Solution Name", 240, HorizontalAlignment.Left);
      listViewResult.Columns.Add("Solution Path", 640, HorizontalAlignment.Left);
      listViewResult.View = View.Details;
      listViewResult.LabelEdit = false;
      listViewResult.AllowColumnReorder = true;
      listViewResult.CheckBoxes = true;
      listViewResult.FullRowSelect = true;
      listViewResult.GridLines = true;
      listViewResult.Sorting = SortOrder.None;
      int resultFound = 0;
      foreach (var directory in Directory.EnumerateDirectories(textBoxInitialPath.Text))
      {
        var filteredFiles = Directory.GetFiles(directory, textBoxfileToChange.Text).ToList();
        foreach (var file in filteredFiles)
        {
          // filtering files containing string to search
          if (!FileContains(file, textBoxStringToSearch.Text)) continue;
          var tmpSolPath = GetDirectoryFileNameAndExtension(file)[0];
          var tmpSolNameOnly0 = GetDirectoryFileNameAndExtension(file)[0];
          var tmpSolNameOnly = tmpSolNameOnly0.Substring(tmpSolNameOnly0.LastIndexOf('\\') + 1);
          ListViewItem item1 = new ListViewItem(textBoxfileToChange.Text) { Checked = false };
          item1.SubItems.Add(tmpSolNameOnly);
          item1.SubItems.Add(tmpSolPath);
          if (IsInlistView(listViewResult, item1, 2)) continue;
          listViewResult.Items.Add(item1);
          resultFound++;
          Application.DoEvents();
        }
      }

      listViewResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
      buttonReplace.Enabled = listViewResult.Items.Count != 0;
    }

    private static bool FileContains(string fileName, string textToSearch)
    {
      if (!File.Exists(fileName)) return false;
      try
      {
        StreamReader sr = new StreamReader(fileName);
        var fileContent = sr.ReadToEnd();
        sr.Close();
        return fileContent.Contains(textToSearch);
      }
      catch (Exception) { return false; }
    }

    private static bool FileReplace(string fileName, string textToSearch, string textToReplace)
    {
      if (!File.Exists(fileName)) return false;
      try
      {
        var sr = new StreamReader(fileName);
        var fileContent = sr.ReadToEnd();
        sr.Close();
        fileContent.Replace(textToSearch, textToReplace);
        var sw = new StreamWriter(fileName);
        sw.Write(fileContent);
        sw.Close();
        return true;
      }
      catch (Exception) { return false; }
    }

    private static void AdjustListViewColumnWidth(ListView lv, int numberOfColumn)
    {
      if (lv.Items.Count == 0)
      {
        return;
      }

      int[] columnWidth = new int[numberOfColumn];
      for (int i = 0; i < numberOfColumn; i++)
      {
        columnWidth[i] = lv.Items[0].SubItems[i].Text.Length;
      }

      for (int i = 0; i < lv.Items.Count; i++)
      {
        for (int j = 0; j < lv.Items[i].SubItems.Count; j++)
        {
          columnWidth[j] = Math.Max(lv.Items[i].SubItems[j].Text.Length, columnWidth[0]);
        }
      }
    }

    private static string[] GetDirectoryFileNameAndExtension(string filePath)
    {
      string directory = Path.GetDirectoryName(filePath);
      string fileName = Path.GetFileNameWithoutExtension(filePath);
      string extension = Path.GetExtension(filePath);

      return new[] { directory, fileName, extension };
    }

    private static bool IsInlistView(ListView listView, ListViewItem lviItem, int columnNumber)
    {
      bool result = false;
      foreach (ListViewItem item in listView.Items)
      {
        if (item.SubItems[columnNumber].Text == lviItem.SubItems[columnNumber].Text)
        {
          result = true;
          break;
        }
      }

      return result;
    }

    private void buttonReplace_Click(object sender, EventArgs e)
    {
      if (listViewResult.Items.Count == 0)
      {
        DisplayMessage(Translate("The list doesn't have any item") +
                         Punctuation.Period, Translate("List empty"), MessageBoxButtons.OK);
        return;
      }

      int counter = 0;
      foreach (ListViewItem item in listViewResult.CheckedItems)
      {
        if (FileReplace(AddSlash(item.SubItems[2].Text) + item.SubItems[0].Text, 
          textBoxStringToSearch.Text, textBoxReplaceBy.Text))
        {
          counter++;
        }
      }

      DisplayMessage(counter + Punctuation.OneSpace + Translate("file") +
         Punctuation.OneSpace + "has been modified", Translate("File modified"), MessageBoxButtons.OK);
    }

    private void buttonViewFile_Click(object sender, EventArgs e)
    {
      if (listViewResult.Items.Count == 0)
      {
        DisplayMessage(Translate("The list doesn't have any item to view") +
                         Punctuation.Period + Punctuation.CrLf +
                         Translate("Check off some items"),
          Translate("No selected item"), MessageBoxButtons.OK);
        return;
      }

      var checkedFiles = listViewResult.CheckedItems;
      foreach (ListViewItem item in checkedFiles)
      {
        StartProcess(AddSlash(item.SubItems[2].Text) + item.SubItems[0].Text);
      }
    }

    private static string AddSlash(string myString)
    {
      return myString.EndsWith("\\") ? myString : myString + "\\";
    }

    private void StartProcess(string fileName, string application = "notepad.exe")
    {
      if (File.Exists(fileName))
      {
        Process process = new Process
        {
          StartInfo =
          {
            FileName = application,
            Arguments = fileName
          }
        };
        process.Start();
      }
      else
      {
        MessageBox.Show(Translate("The file") + Punctuation.CrLf + fileName +
          Punctuation.CrLf + Translate("doesn't exist"));
      }
    }

    private void listViewResult_ItemChecked(object sender, ItemCheckedEventArgs e)
    {
      buttonViewFile.Enabled = GetItemChecked(listViewResult) > 0;
    }

    private static int GetItemChecked(ListView lv)
    {
      return lv.CheckedItems.Count;
    }

    private int StringMax(string s1, string s2, int minimum = 1)
    {
      if (s1.Length == s2.Length)
      {
        return s1.Length < minimum ? minimum : s1.Length;
      }

      if (s1.Length > s2.Length)
      {
        return s1.Length < minimum ? minimum : s1.Length;
      }

      if (s1.Length < s2.Length)
      {
        return s2.Length < minimum ? minimum : s2.Length;
      }

      return minimum;
    }
  }
}