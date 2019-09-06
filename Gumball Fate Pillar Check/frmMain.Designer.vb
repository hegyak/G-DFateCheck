<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.picGumball1 = New System.Windows.Forms.PictureBox()
        Me.picGumball2 = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.lblChainOfFate = New System.Windows.Forms.Label()
        Me.lblBenefit = New System.Windows.Forms.Label()
        Me.chkGumballs = New System.Windows.Forms.CheckedListBox()
        Me.chkFate = New System.Windows.Forms.CheckedListBox()
        Me.tmrGum = New System.Windows.Forms.Timer(Me.components)
        Me.lblGumball1 = New System.Windows.Forms.Label()
        Me.lblGumball2 = New System.Windows.Forms.Label()
        Me.picFact2 = New System.Windows.Forms.PictureBox()
        Me.picFact1 = New System.Windows.Forms.PictureBox()
        CType(Me.picGumball1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGumball2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFact2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFact1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picGumball1
        '
        Me.picGumball1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picGumball1.Location = New System.Drawing.Point(15, 309)
        Me.picGumball1.Name = "picGumball1"
        Me.picGumball1.Size = New System.Drawing.Size(90, 90)
        Me.picGumball1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picGumball1.TabIndex = 0
        Me.picGumball1.TabStop = False
        '
        'picGumball2
        '
        Me.picGumball2.Location = New System.Drawing.Point(167, 309)
        Me.picGumball2.Name = "picGumball2"
        Me.picGumball2.Size = New System.Drawing.Size(90, 90)
        Me.picGumball2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picGumball2.TabIndex = 1
        Me.picGumball2.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(104, 443)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Normal", "Intimacy", "Legacy", "Arch Rival", "The Lovers"})
        Me.cmbType.Location = New System.Drawing.Point(82, 35)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 21)
        Me.cmbType.TabIndex = 6
        '
        'lblChainOfFate
        '
        Me.lblChainOfFate.AutoSize = True
        Me.lblChainOfFate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChainOfFate.Location = New System.Drawing.Point(86, 12)
        Me.lblChainOfFate.Name = "lblChainOfFate"
        Me.lblChainOfFate.Size = New System.Drawing.Size(113, 20)
        Me.lblChainOfFate.TabIndex = 8
        Me.lblChainOfFate.Text = "Chains of Fate"
        '
        'lblBenefit
        '
        Me.lblBenefit.Location = New System.Drawing.Point(12, 234)
        Me.lblBenefit.Name = "lblBenefit"
        Me.lblBenefit.Size = New System.Drawing.Size(255, 62)
        Me.lblBenefit.TabIndex = 9
        Me.lblBenefit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkGumballs
        '
        Me.chkGumballs.FormattingEnabled = True
        Me.chkGumballs.Items.AddRange(New Object() {"Adventurer", "Air Elemental", "Alchemist", "Alexander", "Alien", "Angel Deity", "Apollo", "Archaeologist", "Armor", "Asura", "Athena", "Autobots", "Avalon", "Bandit", "Black Warrior", "Black White Queen", "Blacksmith", "Blade", "Bloody Wolf", "Blue Shark", "Bomberman", "Bounty Hunter", "Bull Demon King", "Bunny", "Butcher", "Cactus", "Captain", "Catherine", "Checkers", "Chef", "Chuchu", "Claw", "Clown", "Commander", "Commando", "Cosmic Godfather", "Creator", "Crusader", "Crypt Lord", "Cupid", "Cyborg", "Cytus", "Dark Dragon", "Dark Elemental", "Death Knight", "Deemo", "Demon", "Demon Hunter", "Destroyer", "Diau Charn", "Divine Dragon", "DJ", "Doctor Octopus", "Duelist", "Dwarf King", "Earth Elemental", "Eternal Titan", "Explosive Pumpkin", "Faerie Dragon", "Fallen Angel", "Fire Elemental", "Fire Giant", "Flagellant", "Franken", "Frost Queen", "Future Cat", "Gaheris", "Galahad", "Gandharva", "Gang Cadre", "Garuda", "Gawaine", "Geisha", "Genie", "Ghost Captain", "Gladiator", "Goblin", "Golden Titan", "Great Guardian", "Guardian", "Gumiho", "Hades", "Hamster", "Heavenly King", "Hella", "Hellfire", "Hercules", "High Priest", "Holy Dragon", "Holy Warrior", "Jeweler", "Joan", "Junkman", "Justice Herald", "Kairo Concubine", "Kairo Monarch", "Kaito", "King", "King Arthur", "Kraken Captain", "Kusanagi Warrior", "Lamorak", "Lancelot", "Lich King", "Light Elemental", "Lionheart King", "Little May", "Machine Herald", "Machinist", "Mage", "Magic Boy", "Magic Golem", "Magmatron", "Mahiraga", "Mammoth", "Masamune", "Medusa", "Merchant", "Merman", "Minstrel", "Mischief", "Modificator", "Monkey King", "Musashi", "Nalakuvara", "Nelson", "Night Knight", "Ninja Frog", "NO.1 Mutant", "NO.1 Parasite", "NO.2 Mutant", "NO.2 Parasite", "NO.3 Mutant", "NO.3 Parasite", "NO.4 Mutant", "NO.4 Parasite", "NO.5 Mutant", "Noble", "Nobunaga", "Odin", "Orc", "Panda", "Pandora", "Paparazzi", "Peter", "Pharaoh", "Pharmacist", "Phoenix", "Pigsy", "Pinocchio", "Pirate", "Poseidon", "Predator", "Priest", "Prince", "Puppeteer", "Raptor", "Red Dragon", "Red Hood", "Referee", "Ripper", "Sage", "Saladin", "Sandy", "Satans Son", "Sculptor", "Semi-Finished Product", "Shadow Assassin", "Skeleton Lord", "Slave", "Snowman", "Sorcerer", "Soul Reaper", "Space Wizard", "Spartan", "Spy", "Star", "Starmoon Scholar", "Sunflower", "Swordsman", "Tarot", "Templar", "Terminator", "Three-eye King", "Time Wizard", "Totem Warlock", "Trainer", "Tripitaka", "Vampire", "Vampire Hunter", "Wang Zhaojun", "Warrior", "Water Elemental", "White Chess Bishop", "Witch", "World Tree", "Xi Shi", "Yaksha", "Yang Yuhuan", "Zerg Queen", "Zeros", "Zeus", "Zombie", "Zorro"})
        Me.chkGumballs.Location = New System.Drawing.Point(342, 12)
        Me.chkGumballs.Name = "chkGumballs"
        Me.chkGumballs.ScrollAlwaysVisible = True
        Me.chkGumballs.Size = New System.Drawing.Size(264, 454)
        Me.chkGumballs.Sorted = True
        Me.chkGumballs.TabIndex = 11
        '
        'chkFate
        '
        Me.chkFate.FormattingEnabled = True
        Me.chkFate.Location = New System.Drawing.Point(12, 62)
        Me.chkFate.Name = "chkFate"
        Me.chkFate.Size = New System.Drawing.Size(255, 169)
        Me.chkFate.TabIndex = 12
        '
        'tmrGum
        '
        Me.tmrGum.Enabled = True
        Me.tmrGum.Interval = 500
        '
        'lblGumball1
        '
        Me.lblGumball1.AutoSize = True
        Me.lblGumball1.Location = New System.Drawing.Point(12, 412)
        Me.lblGumball1.Name = "lblGumball1"
        Me.lblGumball1.Size = New System.Drawing.Size(39, 13)
        Me.lblGumball1.TabIndex = 13
        Me.lblGumball1.Text = "Label1"
        '
        'lblGumball2
        '
        Me.lblGumball2.AutoSize = True
        Me.lblGumball2.Location = New System.Drawing.Point(167, 412)
        Me.lblGumball2.Name = "lblGumball2"
        Me.lblGumball2.Size = New System.Drawing.Size(39, 13)
        Me.lblGumball2.TabIndex = 14
        Me.lblGumball2.Text = "Label3"
        '
        'picFact2
        '
        Me.picFact2.Location = New System.Drawing.Point(157, 299)
        Me.picFact2.Name = "picFact2"
        Me.picFact2.Size = New System.Drawing.Size(110, 110)
        Me.picFact2.TabIndex = 15
        Me.picFact2.TabStop = False
        '
        'picFact1
        '
        Me.picFact1.Location = New System.Drawing.Point(5, 299)
        Me.picFact1.Name = "picFact1"
        Me.picFact1.Size = New System.Drawing.Size(110, 110)
        Me.picFact1.TabIndex = 16
        Me.picFact1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 483)
        Me.Controls.Add(Me.lblGumball2)
        Me.Controls.Add(Me.lblGumball1)
        Me.Controls.Add(Me.chkFate)
        Me.Controls.Add(Me.chkGumballs)
        Me.Controls.Add(Me.lblBenefit)
        Me.Controls.Add(Me.lblChainOfFate)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.picGumball2)
        Me.Controls.Add(Me.picGumball1)
        Me.Controls.Add(Me.picFact2)
        Me.Controls.Add(Me.picFact1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "G&D Fate Checker"
        CType(Me.picGumball1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGumball2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFact2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFact1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGumball1 As PictureBox
    Friend WithEvents picGumball2 As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents lblChainOfFate As Label
    Friend WithEvents lblBenefit As Label
    Friend WithEvents chkGumballs As CheckedListBox
    Friend WithEvents chkFate As CheckedListBox
    Friend WithEvents tmrGum As Timer
    Friend WithEvents lblGumball1 As Label
    Friend WithEvents lblGumball2 As Label
    Friend WithEvents picFact2 As PictureBox
    Friend WithEvents picFact1 As PictureBox
End Class
