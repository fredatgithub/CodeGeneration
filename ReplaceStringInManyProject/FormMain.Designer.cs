﻿using System.Windows.Forms;

namespace ReplaceStringInManyProject
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
      this.DisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.SmallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.LargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buttonPeekDirectory = new System.Windows.Forms.Button();
      this.labelPath = new System.Windows.Forms.Label();
      this.textBoxInitialPath = new System.Windows.Forms.TextBox();
      this.textBoxfileToChange = new System.Windows.Forms.TextBox();
      this.labelFileToChange = new System.Windows.Forms.Label();
      this.buttonPeekFile = new System.Windows.Forms.Button();
      this.textBoxStringToSearch = new System.Windows.Forms.TextBox();
      this.labelStringToSearch = new System.Windows.Forms.Label();
      this.textBoxReplaceBy = new System.Windows.Forms.TextBox();
      this.labelReplaceBy = new System.Windows.Forms.Label();
      this.buttonReplace = new System.Windows.Forms.Button();
      this.listViewResult = new System.Windows.Forms.ListView();
      this.buttonSearch = new System.Windows.Forms.Button();
      this.buttonViewFile = new System.Windows.Forms.Button();
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
            this.DisplayToolStripMenuItem,
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
      this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
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
      this.cancelToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
      this.cancelToolStripMenuItem.Text = "&Annuler";
      // 
      // redoToolStripMenuItem
      // 
      this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
      this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.redoToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
      this.redoToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(194, 6);
      // 
      // cutToolStripMenuItem
      // 
      this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
      this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.cutToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
      this.cutToolStripMenuItem.Text = "&Couper";
      this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
      this.copyToolStripMenuItem.Text = "Co&pier";
      this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // pasteToolStripMenuItem
      // 
      this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.pasteToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
      this.pasteToolStripMenuItem.Text = "Co&ller";
      this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(194, 6);
      // 
      // selectAllToolStripMenuItem
      // 
      this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
      this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
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
      this.personalizeToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
      this.personalizeToolStripMenuItem.Text = "&Personnaliser";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
      this.optionsToolStripMenuItem.Text = "&Options";
      this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
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
      this.frenchToolStripMenuItem.Checked = true;
      this.frenchToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
      this.frenchToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
      this.frenchToolStripMenuItem.Text = "Français";
      this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
      // 
      // englishToolStripMenuItem
      // 
      this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
      this.englishToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
      this.englishToolStripMenuItem.Text = "Anglais";
      this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
      // 
      // DisplayToolStripMenuItem
      // 
      this.DisplayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmallToolStripMenuItem,
            this.MediumToolStripMenuItem,
            this.LargeToolStripMenuItem});
      this.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem";
      this.DisplayToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
      this.DisplayToolStripMenuItem.Text = "Affichage";
      // 
      // SmallToolStripMenuItem
      // 
      this.SmallToolStripMenuItem.Checked = true;
      this.SmallToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.SmallToolStripMenuItem.Name = "SmallToolStripMenuItem";
      this.SmallToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
      this.SmallToolStripMenuItem.Text = "Petit";
      this.SmallToolStripMenuItem.Click += new System.EventHandler(this.SmallToolStripMenuItem_Click);
      // 
      // MediumToolStripMenuItem
      // 
      this.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem";
      this.MediumToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
      this.MediumToolStripMenuItem.Text = "Moyen";
      this.MediumToolStripMenuItem.Click += new System.EventHandler(this.MediumToolStripMenuItem_Click);
      // 
      // LargeToolStripMenuItem
      // 
      this.LargeToolStripMenuItem.Name = "LargeToolStripMenuItem";
      this.LargeToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
      this.LargeToolStripMenuItem.Text = "Grand";
      this.LargeToolStripMenuItem.Click += new System.EventHandler(this.LargeToolStripMenuItem_Click);
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
      this.summaryToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
      this.summaryToolStripMenuItem.Text = "&Sommaire";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // searchToolStripMenuItem
      // 
      this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
      this.searchToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
      this.searchToolStripMenuItem.Text = "&Rechercher";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(172, 6);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
      this.aboutToolStripMenuItem.Text = "À &propos de...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
      // 
      // buttonPeekDirectory
      // 
      this.buttonPeekDirectory.Location = new System.Drawing.Point(840, 70);
      this.buttonPeekDirectory.Name = "buttonPeekDirectory";
      this.buttonPeekDirectory.Size = new System.Drawing.Size(34, 23);
      this.buttonPeekDirectory.TabIndex = 2;
      this.buttonPeekDirectory.Text = "...";
      this.buttonPeekDirectory.UseVisualStyleBackColor = true;
      this.buttonPeekDirectory.Click += new System.EventHandler(this.buttonPeekDirectory_Click);
      // 
      // labelPath
      // 
      this.labelPath.AutoSize = true;
      this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelPath.Location = new System.Drawing.Point(29, 71);
      this.labelPath.Name = "labelPath";
      this.labelPath.Size = new System.Drawing.Size(90, 20);
      this.labelPath.TabIndex = 3;
      this.labelPath.Text = "Initial path:";
      // 
      // textBoxInitialPath
      // 
      this.textBoxInitialPath.Location = new System.Drawing.Point(165, 71);
      this.textBoxInitialPath.Name = "textBoxInitialPath";
      this.textBoxInitialPath.Size = new System.Drawing.Size(661, 22);
      this.textBoxInitialPath.TabIndex = 4;
      this.textBoxInitialPath.TextChanged += new System.EventHandler(this.textBoxInitialPath_TextChanged);
      // 
      // textBoxfileToChange
      // 
      this.textBoxfileToChange.Location = new System.Drawing.Point(165, 118);
      this.textBoxfileToChange.Name = "textBoxfileToChange";
      this.textBoxfileToChange.Size = new System.Drawing.Size(661, 22);
      this.textBoxfileToChange.TabIndex = 7;
      this.textBoxfileToChange.TextChanged += new System.EventHandler(this.textBoxfileToChange_TextChanged);
      // 
      // labelFileToChange
      // 
      this.labelFileToChange.AutoSize = true;
      this.labelFileToChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelFileToChange.Location = new System.Drawing.Point(29, 118);
      this.labelFileToChange.Name = "labelFileToChange";
      this.labelFileToChange.Size = new System.Drawing.Size(119, 20);
      this.labelFileToChange.TabIndex = 6;
      this.labelFileToChange.Text = "File to change:";
      // 
      // buttonPeekFile
      // 
      this.buttonPeekFile.Location = new System.Drawing.Point(840, 117);
      this.buttonPeekFile.Name = "buttonPeekFile";
      this.buttonPeekFile.Size = new System.Drawing.Size(34, 23);
      this.buttonPeekFile.TabIndex = 5;
      this.buttonPeekFile.Text = "...";
      this.buttonPeekFile.UseVisualStyleBackColor = true;
      this.buttonPeekFile.Click += new System.EventHandler(this.buttonPeekFile_Click);
      // 
      // textBoxStringToSearch
      // 
      this.textBoxStringToSearch.Location = new System.Drawing.Point(165, 167);
      this.textBoxStringToSearch.Name = "textBoxStringToSearch";
      this.textBoxStringToSearch.Size = new System.Drawing.Size(661, 22);
      this.textBoxStringToSearch.TabIndex = 10;
      this.textBoxStringToSearch.Text = "200";
      this.textBoxStringToSearch.TextChanged += new System.EventHandler(this.textBoxStringToSearch_TextChanged);
      // 
      // labelStringToSearch
      // 
      this.labelStringToSearch.AutoSize = true;
      this.labelStringToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelStringToSearch.Location = new System.Drawing.Point(29, 167);
      this.labelStringToSearch.Name = "labelStringToSearch";
      this.labelStringToSearch.Size = new System.Drawing.Size(133, 20);
      this.labelStringToSearch.TabIndex = 9;
      this.labelStringToSearch.Text = "String to search:";
      // 
      // textBoxReplaceBy
      // 
      this.textBoxReplaceBy.Location = new System.Drawing.Point(165, 215);
      this.textBoxReplaceBy.Name = "textBoxReplaceBy";
      this.textBoxReplaceBy.Size = new System.Drawing.Size(661, 22);
      this.textBoxReplaceBy.TabIndex = 13;
      this.textBoxReplaceBy.Text = "1024";
      this.textBoxReplaceBy.TextChanged += new System.EventHandler(this.textBoxReplaceBy_TextChanged);
      // 
      // labelReplaceBy
      // 
      this.labelReplaceBy.AutoSize = true;
      this.labelReplaceBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelReplaceBy.Location = new System.Drawing.Point(29, 215);
      this.labelReplaceBy.Name = "labelReplaceBy";
      this.labelReplaceBy.Size = new System.Drawing.Size(97, 20);
      this.labelReplaceBy.TabIndex = 12;
      this.labelReplaceBy.Text = "Replace by:";
      // 
      // buttonReplace
      // 
      this.buttonReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonReplace.Location = new System.Drawing.Point(165, 253);
      this.buttonReplace.Name = "buttonReplace";
      this.buttonReplace.Size = new System.Drawing.Size(99, 29);
      this.buttonReplace.TabIndex = 14;
      this.buttonReplace.Text = "Replace";
      this.buttonReplace.UseVisualStyleBackColor = true;
      this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
      // 
      // listViewResult
      // 
      this.listViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listViewResult.Location = new System.Drawing.Point(32, 300);
      this.listViewResult.Name = "listViewResult";
      this.listViewResult.Size = new System.Drawing.Size(850, 203);
      this.listViewResult.TabIndex = 15;
      this.listViewResult.UseCompatibleStateImageBehavior = false;
      this.listViewResult.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewResult_ItemChecked);
      // 
      // buttonSearch
      // 
      this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonSearch.Location = new System.Drawing.Point(32, 253);
      this.buttonSearch.Name = "buttonSearch";
      this.buttonSearch.Size = new System.Drawing.Size(116, 29);
      this.buttonSearch.TabIndex = 16;
      this.buttonSearch.Text = "Search";
      this.buttonSearch.UseVisualStyleBackColor = true;
      this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
      // 
      // buttonViewFile
      // 
      this.buttonViewFile.Enabled = false;
      this.buttonViewFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonViewFile.Location = new System.Drawing.Point(283, 253);
      this.buttonViewFile.Name = "buttonViewFile";
      this.buttonViewFile.Size = new System.Drawing.Size(99, 29);
      this.buttonViewFile.TabIndex = 17;
      this.buttonViewFile.Text = "View";
      this.buttonViewFile.UseVisualStyleBackColor = true;
      this.buttonViewFile.Click += new System.EventHandler(this.buttonViewFile_Click);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(911, 534);
      this.Controls.Add(this.buttonViewFile);
      this.Controls.Add(this.buttonSearch);
      this.Controls.Add(this.listViewResult);
      this.Controls.Add(this.buttonReplace);
      this.Controls.Add(this.textBoxReplaceBy);
      this.Controls.Add(this.labelReplaceBy);
      this.Controls.Add(this.textBoxStringToSearch);
      this.Controls.Add(this.labelStringToSearch);
      this.Controls.Add(this.textBoxfileToChange);
      this.Controls.Add(this.labelFileToChange);
      this.Controls.Add(this.buttonPeekFile);
      this.Controls.Add(this.textBoxInitialPath);
      this.Controls.Add(this.labelPath);
      this.Controls.Add(this.buttonPeekDirectory);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "FormMain";
      this.ShowIcon = false;
      this.Text = "Replace a string in many files";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainFormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
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
    private System.Windows.Forms.ToolStripMenuItem DisplayToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem SmallToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MediumToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem LargeToolStripMenuItem;
    private System.Windows.Forms.Button buttonPeekDirectory;
    private System.Windows.Forms.Label labelPath;
    private System.Windows.Forms.TextBox textBoxInitialPath;
    private System.Windows.Forms.TextBox textBoxfileToChange;
    private System.Windows.Forms.Label labelFileToChange;
    private System.Windows.Forms.Button buttonPeekFile;
    private System.Windows.Forms.TextBox textBoxStringToSearch;
    private System.Windows.Forms.Label labelStringToSearch;
    private System.Windows.Forms.TextBox textBoxReplaceBy;
    private System.Windows.Forms.Label labelReplaceBy;
    private System.Windows.Forms.Button buttonReplace;
    private System.Windows.Forms.ListView listViewResult;
    private System.Windows.Forms.Button buttonSearch;
    private Button buttonViewFile;
  }
}