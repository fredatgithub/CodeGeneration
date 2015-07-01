namespace CodeGeneration
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.personalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.languagetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buttonGenerateFile = new System.Windows.Forms.Button();
      this.checkBoxTargetFile = new System.Windows.Forms.CheckBox();
      this.labelTargetFile = new System.Windows.Forms.Label();
      this.textBoxTargetFile = new System.Windows.Forms.TextBox();
      this.buttonTargetDirectory = new System.Windows.Forms.Button();
      this.labelTextAfter = new System.Windows.Forms.Label();
      this.textBoxTextAfter = new System.Windows.Forms.TextBox();
      this.labelTextBefore = new System.Windows.Forms.Label();
      this.textBoxTextBefore = new System.Windows.Forms.TextBox();
      this.labelSourceFile = new System.Windows.Forms.Label();
      this.textBoxSourceFile = new System.Windows.Forms.TextBox();
      this.buttonPickSourceFile = new System.Windows.Forms.Button();
      this.comboBoxCodeLanguage = new System.Windows.Forms.ComboBox();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.checkBoxRemoveStartingSpaces = new System.Windows.Forms.CheckBox();
      this.checkBoxPlaceAfterSpaces = new System.Windows.Forms.CheckBox();
      this.checkBoxRemoveEndingSpaces = new System.Windows.Forms.CheckBox();
      this.checkBoxTargetLanguage = new System.Windows.Forms.CheckBox();
      this.checkBoxLaunchNotepad = new System.Windows.Forms.CheckBox();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.languagetoolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(911, 28);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
      this.fileToolStripMenuItem.Text = "&Fichier";
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.newToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.newToolStripMenuItem.Text = "&Nouveau";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.openToolStripMenuItem.Text = "&Ouvrir";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(244, 6);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.saveToolStripMenuItem.Text = "&Enregistrer";
      // 
      // saveasToolStripMenuItem
      // 
      this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
      this.saveasToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.saveasToolStripMenuItem.Text = "Enregistrer &sous";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
      // 
      // printToolStripMenuItem
      // 
      this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.printToolStripMenuItem.Name = "printToolStripMenuItem";
      this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.printToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.printToolStripMenuItem.Text = "&Imprimer";
      // 
      // printPreviewToolStripMenuItem
      // 
      this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
      this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.printPreviewToolStripMenuItem.Text = "Aperçu a&vant impression";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(244, 6);
      // 
      // quitToolStripMenuItem
      // 
      this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
      this.quitToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.quitToolStripMenuItem.Text = "&Quitter";
      this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItemClick);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
      this.editToolStripMenuItem.Text = "&Edition";
      // 
      // cancelToolStripMenuItem
      // 
      this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
      this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.cancelToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
      this.cancelToolStripMenuItem.Text = "&Annuler";
      // 
      // redoToolStripMenuItem
      // 
      this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
      this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.redoToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
      this.redoToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(246, 6);
      // 
      // cutToolStripMenuItem
      // 
      this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
      this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.cutToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
      this.cutToolStripMenuItem.Text = "&Couper";
      this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
      this.copyToolStripMenuItem.Text = "Co&pier";
      this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // pasteToolStripMenuItem
      // 
      this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.pasteToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
      this.pasteToolStripMenuItem.Text = "Co&ller";
      this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(246, 6);
      // 
      // selectAllToolStripMenuItem
      // 
      this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
      this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
      this.selectAllToolStripMenuItem.Text = "Sélectio&nner tout";
      this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
      // 
      // toolsToolStripMenuItem
      // 
      this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
      this.toolsToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
      this.toolsToolStripMenuItem.Text = "&Outils";
      // 
      // personalizeToolStripMenuItem
      // 
      this.personalizeToolStripMenuItem.Name = "personalizeToolStripMenuItem";
      this.personalizeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
      this.personalizeToolStripMenuItem.Text = "&Personnaliser";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // languagetoolStripMenuItem
      // 
      this.languagetoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frenchToolStripMenuItem,
            this.englishToolStripMenuItem});
      this.languagetoolStripMenuItem.Name = "languagetoolStripMenuItem";
      this.languagetoolStripMenuItem.Size = new System.Drawing.Size(86, 24);
      this.languagetoolStripMenuItem.Text = "Language";
      // 
      // frenchToolStripMenuItem
      // 
      this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
      this.frenchToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
      this.frenchToolStripMenuItem.Text = "Français";
      this.frenchToolStripMenuItem.Click += new System.EventHandler(this.FrenchToolStripMenuItemClick);
      // 
      // englishToolStripMenuItem
      // 
      this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
      this.englishToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
      this.englishToolStripMenuItem.Text = "Anglais";
      this.englishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItemClick);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
      this.helpToolStripMenuItem.Text = "&Aide";
      // 
      // summaryToolStripMenuItem
      // 
      this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
      this.summaryToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
      this.summaryToolStripMenuItem.Text = "&Sommaire";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // searchToolStripMenuItem
      // 
      this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
      this.searchToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
      this.searchToolStripMenuItem.Text = "&Rechercher";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(178, 6);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
      this.aboutToolStripMenuItem.Text = "À &propos de...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
      // 
      // buttonGenerateFile
      // 
      this.buttonGenerateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonGenerateFile.Location = new System.Drawing.Point(123, 460);
      this.buttonGenerateFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonGenerateFile.Name = "buttonGenerateFile";
      this.buttonGenerateFile.Size = new System.Drawing.Size(156, 33);
      this.buttonGenerateFile.TabIndex = 25;
      this.buttonGenerateFile.Text = "Generate the file";
      this.buttonGenerateFile.UseVisualStyleBackColor = true;
      this.buttonGenerateFile.Click += new System.EventHandler(this.ButtonGenerateFileClick);
      // 
      // checkBoxTargetFile
      // 
      this.checkBoxTargetFile.AutoSize = true;
      this.checkBoxTargetFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxTargetFile.Location = new System.Drawing.Point(123, 117);
      this.checkBoxTargetFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.checkBoxTargetFile.Name = "checkBoxTargetFile";
      this.checkBoxTargetFile.Size = new System.Drawing.Size(394, 21);
      this.checkBoxTargetFile.TabIndex = 24;
      this.checkBoxTargetFile.Text = "Target file in the same directory as the source file";
      this.checkBoxTargetFile.UseVisualStyleBackColor = true;
      this.checkBoxTargetFile.CheckedChanged += new System.EventHandler(this.CheckBoxTargetFileCheckedChanged);
      // 
      // labelTargetFile
      // 
      this.labelTargetFile.AutoSize = true;
      this.labelTargetFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTargetFile.Location = new System.Drawing.Point(21, 191);
      this.labelTargetFile.Name = "labelTargetFile";
      this.labelTargetFile.Size = new System.Drawing.Size(92, 17);
      this.labelTargetFile.TabIndex = 23;
      this.labelTargetFile.Text = "Target File:";
      // 
      // textBoxTargetFile
      // 
      this.textBoxTargetFile.Location = new System.Drawing.Point(123, 188);
      this.textBoxTargetFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxTargetFile.Name = "textBoxTargetFile";
      this.textBoxTargetFile.Size = new System.Drawing.Size(727, 22);
      this.textBoxTargetFile.TabIndex = 22;
      // 
      // buttonTargetDirectory
      // 
      this.buttonTargetDirectory.Location = new System.Drawing.Point(856, 190);
      this.buttonTargetDirectory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonTargetDirectory.Name = "buttonTargetDirectory";
      this.buttonTargetDirectory.Size = new System.Drawing.Size(33, 23);
      this.buttonTargetDirectory.TabIndex = 21;
      this.buttonTargetDirectory.Text = "...";
      this.buttonTargetDirectory.UseVisualStyleBackColor = true;
      this.buttonTargetDirectory.Click += new System.EventHandler(this.ButtonTargetDirectoryClick);
      // 
      // labelTextAfter
      // 
      this.labelTextAfter.AutoSize = true;
      this.labelTextAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTextAfter.Location = new System.Drawing.Point(21, 330);
      this.labelTextAfter.Name = "labelTextAfter";
      this.labelTextAfter.Size = new System.Drawing.Size(83, 17);
      this.labelTextAfter.TabIndex = 20;
      this.labelTextAfter.Text = "Text after:";
      // 
      // textBoxTextAfter
      // 
      this.textBoxTextAfter.Location = new System.Drawing.Point(123, 325);
      this.textBoxTextAfter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxTextAfter.Name = "textBoxTextAfter";
      this.textBoxTextAfter.Size = new System.Drawing.Size(727, 22);
      this.textBoxTextAfter.TabIndex = 19;
      // 
      // labelTextBefore
      // 
      this.labelTextBefore.AutoSize = true;
      this.labelTextBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTextBefore.Location = new System.Drawing.Point(21, 268);
      this.labelTextBefore.Name = "labelTextBefore";
      this.labelTextBefore.Size = new System.Drawing.Size(96, 17);
      this.labelTextBefore.TabIndex = 18;
      this.labelTextBefore.Text = "Text before:";
      // 
      // textBoxTextBefore
      // 
      this.textBoxTextBefore.Location = new System.Drawing.Point(123, 263);
      this.textBoxTextBefore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxTextBefore.Name = "textBoxTextBefore";
      this.textBoxTextBefore.Size = new System.Drawing.Size(727, 22);
      this.textBoxTextBefore.TabIndex = 17;
      // 
      // labelSourceFile
      // 
      this.labelSourceFile.AutoSize = true;
      this.labelSourceFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSourceFile.Location = new System.Drawing.Point(21, 76);
      this.labelSourceFile.Name = "labelSourceFile";
      this.labelSourceFile.Size = new System.Drawing.Size(95, 17);
      this.labelSourceFile.TabIndex = 16;
      this.labelSourceFile.Text = "Source File:";
      // 
      // textBoxSourceFile
      // 
      this.textBoxSourceFile.Location = new System.Drawing.Point(123, 74);
      this.textBoxSourceFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxSourceFile.Name = "textBoxSourceFile";
      this.textBoxSourceFile.Size = new System.Drawing.Size(727, 22);
      this.textBoxSourceFile.TabIndex = 15;
      // 
      // buttonPickSourceFile
      // 
      this.buttonPickSourceFile.Location = new System.Drawing.Point(856, 74);
      this.buttonPickSourceFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonPickSourceFile.Name = "buttonPickSourceFile";
      this.buttonPickSourceFile.Size = new System.Drawing.Size(33, 23);
      this.buttonPickSourceFile.TabIndex = 14;
      this.buttonPickSourceFile.Text = "...";
      this.buttonPickSourceFile.UseVisualStyleBackColor = true;
      this.buttonPickSourceFile.Click += new System.EventHandler(this.ButtonPickSourceFileClick);
      // 
      // comboBoxCodeLanguage
      // 
      this.comboBoxCodeLanguage.FormattingEnabled = true;
      this.comboBoxCodeLanguage.Location = new System.Drawing.Point(653, 144);
      this.comboBoxCodeLanguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.comboBoxCodeLanguage.Name = "comboBoxCodeLanguage";
      this.comboBoxCodeLanguage.Size = new System.Drawing.Size(121, 24);
      this.comboBoxCodeLanguage.TabIndex = 26;
      // 
      // checkBoxRemoveStartingSpaces
      // 
      this.checkBoxRemoveStartingSpaces.AutoSize = true;
      this.checkBoxRemoveStartingSpaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxRemoveStartingSpaces.Location = new System.Drawing.Point(123, 366);
      this.checkBoxRemoveStartingSpaces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.checkBoxRemoveStartingSpaces.Name = "checkBoxRemoveStartingSpaces";
      this.checkBoxRemoveStartingSpaces.Size = new System.Drawing.Size(246, 21);
      this.checkBoxRemoveStartingSpaces.TabIndex = 28;
      this.checkBoxRemoveStartingSpaces.Text = "Remove starting white spaces";
      this.checkBoxRemoveStartingSpaces.UseVisualStyleBackColor = true;
      this.checkBoxRemoveStartingSpaces.CheckedChanged += new System.EventHandler(this.CheckBoxRemoveStartingSpacesCheckedChanged);
      // 
      // checkBoxPlaceAfterSpaces
      // 
      this.checkBoxPlaceAfterSpaces.AutoSize = true;
      this.checkBoxPlaceAfterSpaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxPlaceAfterSpaces.Location = new System.Drawing.Point(123, 406);
      this.checkBoxPlaceAfterSpaces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.checkBoxPlaceAfterSpaces.Name = "checkBoxPlaceAfterSpaces";
      this.checkBoxPlaceAfterSpaces.Size = new System.Drawing.Size(380, 21);
      this.checkBoxPlaceAfterSpaces.TabIndex = 29;
      this.checkBoxPlaceAfterSpaces.Text = "Place start string after white space or tabulation";
      this.checkBoxPlaceAfterSpaces.UseVisualStyleBackColor = true;
      this.checkBoxPlaceAfterSpaces.CheckedChanged += new System.EventHandler(this.CheckBoxPlaceAfterSpacesCheckedChanged);
      // 
      // checkBoxRemoveEndingSpaces
      // 
      this.checkBoxRemoveEndingSpaces.AutoSize = true;
      this.checkBoxRemoveEndingSpaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxRemoveEndingSpaces.Location = new System.Drawing.Point(600, 366);
      this.checkBoxRemoveEndingSpaces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.checkBoxRemoveEndingSpaces.Name = "checkBoxRemoveEndingSpaces";
      this.checkBoxRemoveEndingSpaces.Size = new System.Drawing.Size(240, 21);
      this.checkBoxRemoveEndingSpaces.TabIndex = 30;
      this.checkBoxRemoveEndingSpaces.Text = "Remove ending white spaces";
      this.checkBoxRemoveEndingSpaces.UseVisualStyleBackColor = true;
      this.checkBoxRemoveEndingSpaces.CheckedChanged += new System.EventHandler(this.CheckBoxRemoveEndingSpacesCheckedChanged);
      // 
      // checkBoxTargetLanguage
      // 
      this.checkBoxTargetLanguage.AutoSize = true;
      this.checkBoxTargetLanguage.Checked = true;
      this.checkBoxTargetLanguage.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxTargetLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxTargetLanguage.Location = new System.Drawing.Point(123, 149);
      this.checkBoxTargetLanguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.checkBoxTargetLanguage.Name = "checkBoxTargetLanguage";
      this.checkBoxTargetLanguage.Size = new System.Drawing.Size(505, 21);
      this.checkBoxTargetLanguage.TabIndex = 31;
      this.checkBoxTargetLanguage.Text = "Target language similar to the source file or choose another one:";
      this.checkBoxTargetLanguage.UseVisualStyleBackColor = true;
      this.checkBoxTargetLanguage.CheckedChanged += new System.EventHandler(this.checkBoxTargetLanguage_CheckedChanged);
      // 
      // checkBoxLaunchNotepad
      // 
      this.checkBoxLaunchNotepad.AutoSize = true;
      this.checkBoxLaunchNotepad.Checked = true;
      this.checkBoxLaunchNotepad.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxLaunchNotepad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxLaunchNotepad.Location = new System.Drawing.Point(123, 226);
      this.checkBoxLaunchNotepad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.checkBoxLaunchNotepad.Name = "checkBoxLaunchNotepad";
      this.checkBoxLaunchNotepad.Size = new System.Drawing.Size(695, 21);
      this.checkBoxLaunchNotepad.TabIndex = 32;
      this.checkBoxLaunchNotepad.Text = "Open target file with Notepad.exe otherwise let the standard application open the" +
    " target file";
      this.checkBoxLaunchNotepad.UseVisualStyleBackColor = true;
      this.checkBoxLaunchNotepad.CheckedChanged += new System.EventHandler(this.checkBoxLaunchNotepad_CheckedChanged);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(911, 503);
      this.Controls.Add(this.checkBoxLaunchNotepad);
      this.Controls.Add(this.checkBoxTargetLanguage);
      this.Controls.Add(this.checkBoxRemoveEndingSpaces);
      this.Controls.Add(this.checkBoxPlaceAfterSpaces);
      this.Controls.Add(this.checkBoxRemoveStartingSpaces);
      this.Controls.Add(this.comboBoxCodeLanguage);
      this.Controls.Add(this.buttonGenerateFile);
      this.Controls.Add(this.checkBoxTargetFile);
      this.Controls.Add(this.labelTargetFile);
      this.Controls.Add(this.textBoxTargetFile);
      this.Controls.Add(this.buttonTargetDirectory);
      this.Controls.Add(this.labelTextAfter);
      this.Controls.Add(this.textBoxTextAfter);
      this.Controls.Add(this.labelTextBefore);
      this.Controls.Add(this.textBoxTextBefore);
      this.Controls.Add(this.labelSourceFile);
      this.Controls.Add(this.textBoxSourceFile);
      this.Controls.Add(this.buttonPickSourceFile);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "FormMain";
      this.ShowIcon = false;
      this.Text = "Code generation";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainFormClosing);
      this.Load += new System.EventHandler(this.FormMainLoad);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem personalizeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem languagetoolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    private System.Windows.Forms.Button buttonGenerateFile;
    private System.Windows.Forms.CheckBox checkBoxTargetFile;
    private System.Windows.Forms.Label labelTargetFile;
    private System.Windows.Forms.TextBox textBoxTargetFile;
    private System.Windows.Forms.Button buttonTargetDirectory;
    private System.Windows.Forms.Label labelTextAfter;
    private System.Windows.Forms.TextBox textBoxTextAfter;
    private System.Windows.Forms.Label labelTextBefore;
    private System.Windows.Forms.TextBox textBoxTextBefore;
    private System.Windows.Forms.Label labelSourceFile;
    private System.Windows.Forms.TextBox textBoxSourceFile;
    private System.Windows.Forms.Button buttonPickSourceFile;
    private System.Windows.Forms.ComboBox comboBoxCodeLanguage;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.CheckBox checkBoxRemoveStartingSpaces;
    private System.Windows.Forms.CheckBox checkBoxPlaceAfterSpaces;
    private System.Windows.Forms.CheckBox checkBoxRemoveEndingSpaces;
    private System.Windows.Forms.CheckBox checkBoxTargetLanguage;
    private System.Windows.Forms.CheckBox checkBoxLaunchNotepad;
  }
}