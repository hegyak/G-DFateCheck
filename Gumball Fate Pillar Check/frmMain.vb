Imports System.IO
Public Class frmMain
    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        'Normal
        'Intimacy()
        'Legacy()
        'Arch Rival
        'The Lovers

        picGumball1.BackColor = SystemColors.Control
        picGumball2.BackColor = SystemColors.Control

        If cmbType.SelectedIndex = 0 Then
            'Normal
            Normal()
        ElseIf cmbType.SelectedIndex = 1 Then
            Intimacy()
        ElseIf cmbType.SelectedIndex = 2 Then
            Legacy()
        ElseIf cmbType.SelectedIndex = 3 Then
            Arch_Rival()
        ElseIf cmbType.SelectedIndex = 4 Then
            Lovers()
        End If
        If blnLoad = True Then
            Exit Sub
        End If
        LoadFate()
    End Sub
    Dim BlnFateSave As Boolean = False
    Sub Normal()
        'Pyramid Sale  10,000  Adventurer  Athena  
        'Forge a sword  10,000   Swordsman   Blacksmith  
        'Sword And Spell  10,000   Swordsman   Mage  
        'Lightning And Thunder  15,000   Mage   Dwarf_King  
        'Manhunt!  15,000   Bandit   Bounty_Hunter  
        'Punish Evil  15,000   Bandit   Zorro  
        'Chess Competition  15,000   Tarot   Checkers  
        'Monarchic Hymn  20,000   Minstrel  _King  
        'Paean of the Gods  50,000   Minstrel   Creator  
        'Hero Paean  20,000   Minstrel  _Warrior  
        'Hunter I  15,000   Bounty_Hunter   Predator  
        'Hunter II  15,000   Bounty_Hunter   Vampire_Hunter  
        'Hunter III  20,000   Bounty_Hunter   Demon_Hunter  
        'Medical Science  20,000   Priest   Pharmacist  
        'Follower  15,000   Priest   Sage  
        'I, robot  20,000   Machinist   Zeros  
        'Mech Champion  30,000   Zeros   Armor  
        'Pet Breeder  20,000   Sorcerer   Future_Cat  
        'Crime Cracker  30,000   Night_Knight   Zorro  
        'Extraterrestrial Warrior  20,000   Predator   Templar  
        'Soul Reliquary  20,000   Ghost_Captain   Lich_King  
        'Space-time Traveler  20,000   Terminator   Future_Cat  
        'Les Miserables I  20,000   Slave   Modificator  
        'Overlord  30,000   Nobunaga   Masamune  
        'BOOM  30,000   Explosive Pumpkin  Bomberman 
        'Resurgent  30,000   Skeleton_Lord   Pharaoh  
        'Mummy Research  30,000   Archaeologist   Pharaoh  
        'Jade Carving  50,000   Sculptor   Jeweler  
        'Circus  20,000   Mammoth   Clown  
        'Armored Champion  30,000   Armor   Holy_Warrior  
        'Octopus  20,000   Kraken_Captain   Doctor_Octopus  
        'War Weapon  30,000   Zeros   Machine_Herald  
        'Cleric  20,000   Sage   White Chess Bishop  
        'One Man Army  20,000   Zerg_Queen   Checkers  
        'Eastern Mythology  30,000   Monkey_King   Nalakuvara  
        'Eye of Destruction  30,000   Medusa   Three-eye_King  
        'Space Time Manipulator  20,000   Time_Wizard   Future_Cat  
        'Plane Source  50,000   Creator   Time_Wizard  
        'Space Traveller  20,000   Autobots   Alien  
        'Anatomist  30,000   Butcher   Ripper  
        'Warlock Alliance  30,000   Time_Wizard   Totem_Warlock  
        'Les Miserables II  10,000   Slave   Junkman  
        'Burrowing Master  20,000   Rabbit   Hamster  
        'Natural Believer  30,000   Starmoon_Scholar   Totem_Warlock  
        'Friend of Faerie  15,000   Pinocchio   Lancelot  
        'Money Above Everything Else  30,000   Alchemist   Jeweler  
        'Ravager  20,000   Bandit   Gang_Cadre  
        'Speak Your Wish!  20,000   Divine_Dragon   Genie  
        'Training  20,000   Ninja_Frog   Flagellant  
        'Mechanical Expert  30,000   Machinist   Goblin  
        'The Fallen  15,000   Death_Knight   Black_Warrior  
        'Master of Physical Attack  20,000   Duelist   Ninja_Frog  
        'Devil Contract  30,000   Explosive Pumpkin   Satan's Son  
        'One Man Guarding Against All  20,000   Spartan   Orc  
        'Mafia  20,000   Cosmic_Godfather   Gang_Cadre  
        'Great Route  15,000   Pirate  _Captain  
        'Frog? Frog!  20,000   No.1_Mutant   Ninja_Frog  
        'Edge of Fine Silver  20,000   Vampire_Hunter   Blade  
        'Battle Mech  30,000   Armor   Avalon  
        'Mascot  20,000   Rabbit   Chuchu   
        'Queen's Dignity  15,000   Zerg_Queen  _Catherine  
        'Legendary King  30,000  King_Arthur   Alexander  
        'Burrowing Master II  30,000   Hamster   Crypt_Lord  
        'One-man Army II  20,000   Zerg_Queen   Kairo Monarch  
        'One-man Army III  30,000   Zerg_Queen   Kairo_Concubine  
        'Steel-Like Body  20,000   Zeros   Avalon  
        'Life Movement  30,000   Deemo   Gandharva  
        'Protection  30,000   Monkey_King   Great Guardian  
        'Creature of the Night  15,000   Vampire   Yaksha  
        'Angry Birds  15,000   Phoenix   Garuda  
        'Hercules  50,000   Hercules   Asura  
        'Man guards the pass II  20,000   Spartan   Lamorak  
        'Steel Will  15,000   Justice Herald   Gaheris  
        'God of War  30,000   Athena   Magmatron  

        chkFate.Items.Clear()
		chkFate.Items.Add("Pyramid Sale")
		chkFate.Items.Add("Forge A Sword")
		chkFate.Items.Add("Sword And Spell")
		chkFate.Items.Add("Lightning And Thunder")
		chkFate.Items.Add("Manhunt!")
		chkFate.Items.Add("Punish Evil")
		chkFate.Items.Add("Chess Competition")
		chkFate.Items.Add("Monarchic Hymn")
		chkFate.Items.Add("Paean of the Gods")
		chkFate.Items.Add("Hero Paean")
		chkFate.Items.Add("Hunter I")
		chkFate.Items.Add("Hunter II")
		chkFate.Items.Add("Hunter III")
		chkFate.Items.Add("Medical Science")
		chkFate.Items.Add("Follower")
		chkFate.Items.Add("I, robot")
		chkFate.Items.Add("Mech Champion")
		chkFate.Items.Add("Pet Breeder")
		chkFate.Items.Add("Crime Cracker")
        chkFate.Items.Add("Extraterrestrial Warrior")
        chkFate.Items.Add("Soul Reliquary")
		chkFate.Items.Add("Space-time Traveler")
		chkFate.Items.Add("Les Miserables I")
		chkFate.Items.Add("Overlord")
		chkFate.Items.Add("BOOM")
		chkFate.Items.Add("Resurgent")
		chkFate.Items.Add("Mummy Research")
		chkFate.Items.Add("Jade Carving")
		chkFate.Items.Add("Circus")
		chkFate.Items.Add("Armored Champion")
		chkFate.Items.Add("Octopus")
		chkFate.Items.Add("War Weapon")
		chkFate.Items.Add("Cleric")
		chkFate.Items.Add("One Man Army")
		chkFate.Items.Add("Eastern Mythology")
		chkFate.Items.Add("Eye of Destruction")
		chkFate.Items.Add("Space Time Manipulator")
		chkFate.Items.Add("Plane Source")
		chkFate.Items.Add("Space Traveller")
		chkFate.Items.Add("Anatomist")
		chkFate.Items.Add("Warlock Alliance")
		chkFate.Items.Add("Les Miserables II")
		chkFate.Items.Add("Burrowing Master")
		chkFate.Items.Add("Natural Believer")
		chkFate.Items.Add("Friend of Faerie")
		chkFate.Items.Add("Money Above Everything Else")
		chkFate.Items.Add("Ravager")
		chkFate.Items.Add("Speak Your Wish!")
		chkFate.Items.Add("Training")
		chkFate.Items.Add("Mechanical Expert")
		chkFate.Items.Add("The Fallen")
		chkFate.Items.Add("Master of Physical Attack")
		chkFate.Items.Add("Devil Contract")
		chkFate.Items.Add("One Man Guarding Against All")
		chkFate.Items.Add("Mafia")
		chkFate.Items.Add("Great Route")
		chkFate.Items.Add("Frog? Frog!")
		chkFate.Items.Add("Edge of Fine Silver")
		chkFate.Items.Add("Battle Mech")
		chkFate.Items.Add("Mascot")
		chkFate.Items.Add("Queen's Dignity")
        chkFate.Items.Add("Legendary King")
        chkFate.Items.Add("Burrowing Master II")
		chkFate.Items.Add("One-man Army II")
		chkFate.Items.Add("One-man Army III")
		chkFate.Items.Add("Steel-Like Body")
		chkFate.Items.Add("Life Movement")
		chkFate.Items.Add("Protection")
		chkFate.Items.Add("Creature of the Night")
		chkFate.Items.Add("Angry Birds")
		chkFate.Items.Add("Hercules")
		chkFate.Items.Add("Man Guards the Pass II")
		chkFate.Items.Add("Steel Will")
        chkFate.Items.Add("God of War")
        chkFate.Items.Add("Ragnarok")
        chkFate.Items.Add("Biohazard")
        chkFate.Items.Add("The Walking Dead")
        chkFate.Items.Add("Mischief Will")
        chkFate.Items.Add("Criminal Act")
        chkFate.Items.Add("Half-Snake")
        chkFate.SelectedIndex = 0
	End Sub
	Sub Intimacy()
		'Intimacy Gives		Gems
		'Gladiator Competition  1   Gladiator   Spartan  
		'Jungle Guardian  2   Raptor   Claw  
		'Mysterious Plant I  2   World_Tree   Sunflower  
		'Mysterious Plant II  3   World_Tree   Cactus  
		'Voyager I  1   Pirate   Kraken_Captain  
		'Voyager II  1   Pirate   Ghost_Captain  
		'Godfather I  3   No.1_Mutant   Cosmic_Godfather  
		'Godfather II  2   NO.2_Mutant   Cosmic_Godfather  
		'Godfather III  1   NO.3_Mutant   Cosmic_Godfather  
		'Godfather IV  1   NO.4_Mutant   Cosmic_Godfather  
		'Godfather V  1   NO.5_Mutant   Cosmic_Godfather  
		'Soldier  3   Guardian   Commando  
		'Special Troops  2   Commander   Commando  
		'King Kong  3   Monkey_King   Peter  
		'Father And Son I  3  _King   Prince  
		'Lead Actor And Director  2   Adventurer   Peter  
		'Honor Among Thieves  1   Bandit   Kaito  
		'Flame Affinity  1   Hellfire   Fire Elemental  
		'Father And Son II  2   Heavenly_King   Nalakuvara  
		'Allegiance  3   Hades   Skeleton_Lord  
		'God 's Gift  3   Athena   Pandora  
		'Love Like Fish To Water  2   Water Elemental   Merman  
		'Affinity Like Snow  2   Snowman   Frost Queen  
		'Best Partners  3   Butcher   Chef  
		'Performer  2   Clown   Trainer  
		'Marionette I  2   Magic Golem   Puppeteer  
		'Crazy Scientist  2   Doctor_Octopus   Franken  
		'Marionette II  2   Pinocchio   Puppeteer  
		'Laskar Jihad  2   Crusader   White Chess Bishop  
		'For the Tribe  3   Orc   Totem_Warlock  
		'Brother  2   Gawaine   Gaheris  
		'Father And Son III  2   Galahad   Lancelot  
		'Ancient Tree Melody  3   World_Tree   Deemo  
		'Voice of the Soul  2   Deemo   Cytus  
		'Secret of Space-time  3   Time_Wizard  SkyWizard 
		'Mechanical Master  2   Machine_Herald  Catherine  
		'Dark Power  2   Demon   Satan's Son  
		'Blood Brother  2   Monkey_King  Bull Demon_King  
		'Mould 2  Sculptor   Semi-Finished Product  
		'Martial Arts Extreme  3   Musashi   Kusanagi_Warrior  
		'Go West for Buddhist Scriptures I  3   Monkey_King   Tripitaka  
		'Go West for Buddhist Scriptures II  2   Tripitaka   Pigsy  
		'Go West for Buddhist Scriptures I  1   Tripitaka   Sandy  
		chkFate.Items.Clear()
		chkFate.Items.Add("Gladiator Competition")
		chkFate.Items.Add("Jungle Guardian")
		chkFate.Items.Add("Mysterious Plant I")
		chkFate.Items.Add("Mysterious Plant II")
		chkFate.Items.Add("Voyager I")
		chkFate.Items.Add("Voyager II")
		chkFate.Items.Add("Godfather I")
		chkFate.Items.Add("Godfather II")
		chkFate.Items.Add("Godfather III")
		chkFate.Items.Add("Godfather IV")
		chkFate.Items.Add("Godfather V")
		chkFate.Items.Add("Soldier")
		chkFate.Items.Add("Special Troops")
		chkFate.Items.Add("King Kong")
		chkFate.Items.Add("Father And Son I")
		chkFate.Items.Add("Lead Actor And Director")
		chkFate.Items.Add("Honor Among Thieves")
		chkFate.Items.Add("Flame Affinity")
		chkFate.Items.Add("Father And Son II")
		chkFate.Items.Add("Allegiance")
		chkFate.Items.Add("God's Gift")
		chkFate.Items.Add("Love Like Fish To Water")
		chkFate.Items.Add("Affinity Like Snow")
		chkFate.Items.Add("Best Partners")
		chkFate.Items.Add("Performer")
		chkFate.Items.Add("Marionette I")
		chkFate.Items.Add("Crazy Scientist")
		chkFate.Items.Add("Marionette II")
		chkFate.Items.Add("Laskar Jihad")
		chkFate.Items.Add("For the Tribe")
		chkFate.Items.Add("Brother")
		chkFate.Items.Add("Father And Son III")
		chkFate.Items.Add("Ancient Tree Melody")
		chkFate.Items.Add("Voice of the Soul")
		chkFate.Items.Add("Secret of Space-time")
		chkFate.Items.Add("Mechanical Master")
		chkFate.Items.Add("Dark Power")
		chkFate.Items.Add("Blood Brother")
		chkFate.Items.Add("Mould")
		chkFate.Items.Add("Martial Arts Extreme")
		chkFate.Items.Add("Go West for Buddhist Scriptures I")
		chkFate.Items.Add("Go West for Buddhist Scriptures II")
        chkFate.Items.Add("Go West for Buddhist Scriptures III")
        chkFate.Items.Add("Dragon and Phoenix")
        chkFate.Items.Add("Blushing the Living")
        chkFate.Items.Add("Breath Holders")
        chkFate.Items.Add("Explosion Art")
        chkFate.SelectedIndex = 0


	End Sub
	Sub Legacy()
		'Buffs the Gumball:

		'Sorcery Legacy  Sorcerer: Power+1   Witch   Sorcerer  
		'Demon_Hunter  Vampire_Hunter: Attack+1   Demon_Hunter   Vampire_Hunter  
		'Legacy of the Sea I  Kraken_Captain: HP+20   Kraken_Captain   Poseidon  
		'Heritage of the Sea II  Ghost_Captain: MP+20   Ghost_Captain   Poseidon  
		'Heritage of the Sea III  Pirate: HP+20   Pirate   Poseidon  
		'Toxin Research  Pharmacist: HP+20   Pharmacist   Cyborg  
		'Commander  Crusader: HP+20   Crusader   Lionheart_King  
		'Heart of_Warrior  Musashi: Attack+1   Musashi   Panda  
		'Killer  Bloody Wolf: Attack+1   Shadow Assassin   Bloody Wolf  
		'Light Faith I  Priest: MP+20   Priest   Apollo  
		'Light Faith II  Sage: MP+20   Sage   Apollo  
		'Lord of the Underworld  Soul Reaper: Attack+1  	 Soul Reaper   Hades  
		'Flame Legacy  Fire Elemental: Power+1   Fire Elemental   Phoenix  
		'Champion 's Legacy  Adventurer: Attack+1   Adventurer  _Warrior  
		'Magic Legacy  Mage: Power+1   Mage   Magic Boy  
		'Fighting God's Legacy I  Gladiator: HP+20   Gladiator   Hercules  
		'Dark Faith  Fallen Angel: Power+1   Fallen Angel   Hades  
		'Lurker  Spy: Attack+1   Spy   Shadow Assassin  
		'Soul of Undead  Death_Knight: Attack+1   Death_Knight   Lich_King  
		'Song of the Sea  Water Elemental: MP+20   Poseidon   Water Elemental  
		'God of Fight's Inheritance  Spartan: Attack+1   Hercules   Spartan  
		'Sky Guardian _Captain: Attack+1  _Captain   Nelson  
		'Divination of Life  Tarot: Power+1   Tarot   High Priest  
		'Road of Music  Minstrel: HP+20   Minstrel   DJ  
		'Trailer  Shadow Assassin: Attack+1   Shadow Assassin   Paparazzi  
		'Thunder Fury  Air Elemental : Power+1   Air Elemental   Zeus  
		'Power of Aegis  Athena: Power+1   Athena   Zeus  
		'Ascetic Practices  Flagellant: HP+20   Flagellant   Tripitaka  
		'Pure Soul  Galahad: Attack+1   Sage   Galahad  
		chkFate.Items.Clear()
		chkFate.Items.Add("Sorcery Legacy")
		chkFate.Items.Add("Demon Hunter")
		chkFate.Items.Add("Legacy of the Sea I")
		chkFate.Items.Add("Heritage of the Sea II")
		chkFate.Items.Add("Heritage of the Sea III")
		chkFate.Items.Add("Toxin Research")
		chkFate.Items.Add("Commander")
		chkFate.Items.Add("Heart of Warrior")
		chkFate.Items.Add("Killer")
		chkFate.Items.Add("Light Faith I")
		chkFate.Items.Add("Light Faith II")
		chkFate.Items.Add("Lord of the Underworld")
		chkFate.Items.Add("Flame Legacy")
		chkFate.Items.Add("Champion's Legacy")
		chkFate.Items.Add("Magic Legacy")
		chkFate.Items.Add("Fighting God's Legacy I")
		chkFate.Items.Add("Dark Faith")
		chkFate.Items.Add("Lurker")
		chkFate.Items.Add("Soul of Undead")
		chkFate.Items.Add("Song of the Sea")
		chkFate.Items.Add("God of Fight's Inheritance")
		chkFate.Items.Add("Sky Guardian")
		chkFate.Items.Add("Divination of Life")
		chkFate.Items.Add("Road of Music")
		chkFate.Items.Add("Trailer")
		chkFate.Items.Add("Thunder Fury")
		chkFate.Items.Add("Power of Aegis")
		chkFate.Items.Add("Ascetic Practices")
        chkFate.Items.Add("Pure Soul")
        chkFate.Items.Add("Gigaku")
        chkFate.SelectedIndex = 0
	End Sub
	Sub Arch_Rival()
        'Gives Golden Pots

        'Nemesis I  Gumball Pot x5   Vampire   Vampire_Hunter  
        'Natural Enemy II  Golden Pot x2   Demon   Demon_Hunter  
        'Light And Dark I  Golden Pot x2   Fallen Angel   Angel Deity  
        'Light And Dark II  Golden Pot x2   Apollo   Hades  
        'Dragon Slayer  Gumball Pot x5  _Warrior   Dark Dragon  
        'Dawn of Justice  Golden Pot x2   Night_Knight   Justice Herald  
        'Civil War  Golden Pot x2   Armor   Guardian  
        'Battle of Twilight  Golden Pot x2   Duelist   Angel Deity  
        'Slaughter House  Golden Pot x2   Mammoth   Butcher  
        'Eastern Holy War  Golden Pot x2   Lionheart_King   Saladin  
        'Creation And Destruction  Golden Pot x2   Destroyer   Creator  
        'Song of Ice And Fire  Gumball Pot x5   Fire Elemental   Snowman  
        'Soul Reaping  Gumball Pot x5   Soul Reaper   Ghost_Captain  
        'Arch Rival  Golden Pot x2   Night_Knight   Clown  
        'Exploiter  Gumball Pot x5   Prince   Slave  
        'Undercover Affair  Golden Pot x2   Blue Shark   Bloody Wolf  
        'Light and Dark  Golden Pot x2   Apollo   Hades
        'Plunder  Gumball Pot x5   Bandit   Merchant  
        'Prank Arrow  Golden Pot x2   Apollo   Cupid  
        'Animal Taming Act  Golden Pot x2   Mammoth   Trainer  
        'Blood Clan Nightmare  Gumball Pot x5   Vampire   Blade  
        'Magical Battle  Golden Pot x2   Monkey_King   Three-eye_King  
        'Cat And Mouse  Gumball Pot x5   Future_Cat   Hamster  
        'Seal  Gumball Pot x2   Angel Deity   Satan's Son  
        'Natural Enemy III  Gumball Pot x2   Medusa   Garuda  
        'Betrayer  Gumball Pot x5   Lancelot  King_Arthur  
        chkFate.Items.Clear()
		chkFate.Items.Add("Nemesis I")
		chkFate.Items.Add("Natural Enemy II")
		chkFate.Items.Add("Light And Dark I")
		chkFate.Items.Add("Light And Dark II")
		chkFate.Items.Add("Dragon Slayer")
		chkFate.Items.Add("Dawn of Justice")
		chkFate.Items.Add("Civil War")
		chkFate.Items.Add("Battle of Twilight")
		chkFate.Items.Add("Slaughter House")
		chkFate.Items.Add("Eastern Holy War")
		chkFate.Items.Add("Creation And Destruction")
		chkFate.Items.Add("Song of Ice And Fire")
		chkFate.Items.Add("Soul Reaping")
		chkFate.Items.Add("Arch Rival")
		chkFate.Items.Add("Exploiter")
        chkFate.Items.Add("Undercover Affair")
        chkFate.Items.Add("Light and Dark")
        chkFate.Items.Add("Plunder")
		chkFate.Items.Add("Prank Arrow")
		chkFate.Items.Add("Animal Taming Act")
		chkFate.Items.Add("Blood Clan Nightmare")
		chkFate.Items.Add("Magical Battle")
		chkFate.Items.Add("Cat And Mouse")
		chkFate.Items.Add("Seal")
		chkFate.Items.Add("Natural Enemy III")
        chkFate.Items.Add("Betrayer")
        chkFate.Items.Add("Plants Vs. Zombies")
        chkFate.Items.Add("Last Stand")
        chkFate.Items.Add("A Song of Ice and Fire")
        chkFate.Items.Add("Exploitation and Revolt")
        chkFate.SelectedIndex = 0
	End Sub
	Sub Lovers()
		'Give Babies, Benefits all

		'Royal Romantic History I  MP +20  _King   Red Hood  
		'Royal Romantic History II  HP +20   Prince   Red Hood  
		'Cursed Love  Power+1   Medusa   Poseidon  
		'Bodyguard  Attack + 1   Holy_Warrior   Athena  
		'Love of Nagas  Spell effect +1%   Holy Dragon   Faerie Dragon  
		'Emperor And Queen  1 extra sign-in reward gem   Checkers   Black & White Queen  
		'Summer Sunshine  Reduce training room time by 30 minutes   Sunflower   Cactus  
		'Old Affection  Increase score by 2% in settlement (Affect coins And EXP rewards)   Commando   Zerg_Queen  
		'Oriental Romance I  Damage magic effects +2%   Nobunaga   Gumiho  
		'Oriental Romance II  Life bottles in maze heal +5%   Masamune   Geisha  
		'Childhood Friend  Increase score by 2% in settlement (Affect coins And EXP rewards)   Adventurer   Little May  
		'Underworld Romance  Gumball's Dark Spell effect +3%   Hades   Pandora  
		chkFate.Items.Clear()
		chkFate.Items.Add("Royal Romantic History I")
		chkFate.Items.Add("Royal Romantic History II")
		chkFate.Items.Add("Cursed Love")
		chkFate.Items.Add("Bodyguard")
		chkFate.Items.Add("Love of Nagas")
		chkFate.Items.Add("Emperor And Queen")
		chkFate.Items.Add("Summer Sunshine")
		chkFate.Items.Add("Old Affection")
		chkFate.Items.Add("Oriental Romance I")
		chkFate.Items.Add("Oriental Romance II")
		chkFate.Items.Add("Childhood Friend")
		chkFate.Items.Add("Underworld Romance")
		chkFate.SelectedIndex = 0
	End Sub
	Sub CheckFate(Gumball1 As String, Gumball2 As String)
		Gumball1 = Gumball1.ToLower
		Gumball2 = Gumball2.ToLower
		picGumball1.BackColor = SystemColors.Control
		picGumball2.BackColor = SystemColors.Control
		For Each Str As String In chkGumballs.CheckedItems
			Str = Str.ToLower

			If Gumball1 = Str Then
                'MessageBox.Show("Match")
                picGumball1.BackColor = Color.Green
            End If
            If Gumball2 = Str Then
                'MessageBox.Show("Match")
                picGumball2.BackColor = Color.Green
            End If
        Next
    End Sub
    Dim Fates As New List(Of String)
    'Dim NorFates As New List(Of String)
    'Dim IntFates As New List(Of String)
    'Dim LegFates As New List(Of String)
    'Dim ArcFates As New List(Of String)
    'Dim LovFates As New List(Of String)
    Dim blnLoad As Boolean = True
    Sub Fate()
        'Normal
        Fates.Add("Pyramid Sale")
        Fates.Add("Forge A Sword")
        Fates.Add("Sword And Spell")
        Fates.Add("Lightning And Thunder")
        Fates.Add("Manhunt!")
        Fates.Add("Punish Evil")
        Fates.Add("Chess Competition")
        Fates.Add("Monarchic Hymn")
        Fates.Add("Paean of the Gods")
        Fates.Add("Hero Paean")
        Fates.Add("Hunter I")
        Fates.Add("Hunter II")
        Fates.Add("Hunter III")
        Fates.Add("Medical Science")
        Fates.Add("Follower")
        Fates.Add("I, robot")
        Fates.Add("Mech Champion")
        Fates.Add("Pet Breeder")
        Fates.Add("Crime Cracker")
        Fates.Add("Extraterrestrial Warrior")
        Fates.Add("Soul Reliquary")
        Fates.Add("Space-time Traveler")
        Fates.Add("Les Miserables I")
        Fates.Add("Overlord")
        Fates.Add("BOOM")
        Fates.Add("Resurgent")
        Fates.Add("Mummy Research")
        Fates.Add("Jade Carving")
        Fates.Add("Circus")
        Fates.Add("Armored Champion")
        Fates.Add("Octopus")
        Fates.Add("War Weapon")
        Fates.Add("Cleric")
        Fates.Add("One Man Army")
        Fates.Add("Eastern Mythology")
        Fates.Add("Eye of Destruction")
        Fates.Add("Space Time Manipulator")
        Fates.Add("Plane Source")
        Fates.Add("Space Traveller")
        Fates.Add("Anatomist")
        Fates.Add("Warlock Alliance")
        Fates.Add("Les Miserables II")
        Fates.Add("Burrowing Master")
        Fates.Add("Natural Believer")
        Fates.Add("Friend of Faerie")
        Fates.Add("Money Above Everything Else")
        Fates.Add("Ravager")
        Fates.Add("Speak Your Wish!")
        Fates.Add("Training")
        Fates.Add("Mechanical Expert")
        Fates.Add("The Fallen")
        Fates.Add("Master of Physical Attack")
        Fates.Add("Devil Contract")
        Fates.Add("One Man Guarding Against All")
        Fates.Add("Mafia")
        Fates.Add("Great Route")
        Fates.Add("Frog? Frog!")
        Fates.Add("Edge of Fine Silver")
        Fates.Add("Battle Mech")
        Fates.Add("Mascot")
        Fates.Add("Queen's Dignity")
        Fates.Add("Legendary King")
        Fates.Add("Burrowing Master II")
        Fates.Add("One-man Army II")
        Fates.Add("One-man Army III")
        Fates.Add("Steel-Like Body")
        Fates.Add("Life Movement")
        Fates.Add("Protection")
        Fates.Add("Creature of the Night")
        Fates.Add("Angry Birds")
        Fates.Add("Hercules")
        Fates.Add("Man Guards the Pass II")
        Fates.Add("Steel Will")
        Fates.Add("God of War")
        Fates.Add("Ragnarok")
        Fates.Add("Ragnarok")
        Fates.Add("Biohazard")
        Fates.Add("The Walking Dead")
        Fates.Add("Mischief Will")
        Fates.Add("Criminal Act")
        Fates.Add("Half-Snake")

        'Intimacy
        Fates.Add("Gladiator Competition")
        Fates.Add("Jungle Guardian")
        Fates.Add("Mysterious Plant I")
        Fates.Add("Mysterious Plant II")
        Fates.Add("Voyager I")
        Fates.Add("Voyager II")
        Fates.Add("Godfather I")
        Fates.Add("Godfather II")
        Fates.Add("Godfather III")
        Fates.Add("Godfather IV")
        Fates.Add("Godfather V")
        Fates.Add("Soldier")
        Fates.Add("Special Troops")
        Fates.Add("King Kong")
        Fates.Add("Father And Son I")
        Fates.Add("Lead Actor And Director")
        Fates.Add("Honor Among Thieves")
        Fates.Add("Flame Affinity")
        Fates.Add("Father And Son II")
        Fates.Add("Allegiance")
        Fates.Add("God's Gift")
        Fates.Add("Love Like Fish To Water")
        Fates.Add("Affinity Like Snow")
        Fates.Add("Best Partners")
        Fates.Add("Performer")
        Fates.Add("Marionette I")
        Fates.Add("Crazy Scientist")
        Fates.Add("Marionette II")
        Fates.Add("Laskar Jihad")
        Fates.Add("For the Tribe")
        Fates.Add("Brother")
        Fates.Add("Father And Son III")
        Fates.Add("Ancient Tree Melody")
        Fates.Add("Voice of the Soul")
        Fates.Add("Secret of Space-time")
        Fates.Add("Mechanical Master")
        Fates.Add("Dark Power")
        Fates.Add("Blood Brother")
        Fates.Add("Mould")
        Fates.Add("Martial Arts Extreme")
        Fates.Add("Go West for Buddhist Scriptures I")
        Fates.Add("Go West for Buddhist Scriptures II")
        Fates.Add("Go West for Buddhist Scriptures III")
        Fates.Add("Dragon and Phoenix")
        Fates.Add("Blushing the Living")
        Fates.Add("Breath Holders")
        Fates.Add("Explosion Art")

        'Legacy
        Fates.Add("Sorcery Legacy")
        Fates.Add("Demon Hunter")
        Fates.Add("Legacy of the Sea I")
        Fates.Add("Heritage of the Sea II")
        Fates.Add("Heritage of the Sea III")
        Fates.Add("Toxin Research")
        Fates.Add("Commander")
        Fates.Add("Heart of Warrior")
        Fates.Add("Killer")
        Fates.Add("Light Faith I")
        Fates.Add("Light Faith II")
        Fates.Add("Lord of the Underworld")
        Fates.Add("Flame Legacy")
        Fates.Add("Champion's Legacy")
        Fates.Add("Magic Legacy")
        Fates.Add("Fighting God's Legacy I")
        Fates.Add("Dark Faith")
        Fates.Add("Lurker")
        Fates.Add("Soul of Undead")
        Fates.Add("Song of the Sea")
        Fates.Add("God of Fight's Inheritance")
        Fates.Add("Sky Guardian")
        Fates.Add("Divination of Life")
        Fates.Add("Road of Music")
        Fates.Add("Trailer")
        Fates.Add("Thunder Fury")
        Fates.Add("Power of Aegis")
        Fates.Add("Ascetic Practices")
        Fates.Add("Pure Soul")
        Fates.Add("Gigaku")

        'Arch Rival
        Fates.Add("Nemesis I")
        Fates.Add("Natural Enemy II")
        Fates.Add("Light And Dark I")
        Fates.Add("Light And Dark II")
        Fates.Add("Dragon Slayer")
        Fates.Add("Dawn of Justice")
        Fates.Add("Civil War")
        Fates.Add("Battle of Twilight")
        Fates.Add("Slaughter House")
        Fates.Add("Eastern Holy War")
        Fates.Add("Creation And Destruction")
        Fates.Add("Song of Ice And Fire")
        Fates.Add("Soul Reaping")
        Fates.Add("Arch Rival")
        Fates.Add("Exploiter")
        Fates.Add("Undercover Affair")
        Fates.Add("Plunder")
        Fates.Add("Prank Arrow")
        Fates.Add("Animal Taming Act")
        Fates.Add("Blood Clan Nightmare")
        Fates.Add("Magical Battle")
        Fates.Add("Cat And Mouse")
        Fates.Add("Seal")
        Fates.Add("Natural Enemy III")
        Fates.Add("Betrayer")
        Fates.Add("Plants Vs. Zombies")
        Fates.Add("Last Stand")
        Fates.Add("A Song of Ice and Fire")
        Fates.Add("Exploitation and Revolt")

        'Lovers
        Fates.Add("Royal Romantic History I")
        Fates.Add("Royal Romantic History II")
        Fates.Add("Cursed Love")
        Fates.Add("Bodyguard")
        Fates.Add("Love of Nagas")
        Fates.Add("Emperor And Queen")
        Fates.Add("Summer Sunshine")
        Fates.Add("Old Affection")
        Fates.Add("Oriental Romance I")
        Fates.Add("Oriental Romance II")
        Fates.Add("Childhood Friend")
        Fates.Add("Underworld Romance")
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
    End Sub
    Sub Save()
        Dim itemChecked As Object
        Dim Writer As New StreamWriter("Gumballs.txt")
        For Each itemChecked In chkGumballs.CheckedItems

            'MsgBox(itemChecked.ToString)
            Writer.WriteLine(itemChecked)
        Next
        Writer.Flush()
        Writer.Close()
        Writer = New StreamWriter("Fate.txt")
        For Each Str As String In Fates
            Writer.WriteLine(Str)
        Next
        Writer.Flush()
        Writer.Close()
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.DoEvents()

    End Sub
    Sub LoadGum()
        cmbType.SelectedIndex = 0
        Dim GumballInfo As New FileInfo("Gumballs.txt")
        If GumballInfo.Exists = True Then
            Dim Value As String
            Dim Reader As New StreamReader("Gumballs.txt")
            Do Until Reader.Peek = -1
                Value = Reader.ReadLine()
                'MessageBox.Show(Value)
                'MessageBox.Show(chkGumballs.)

                chkGumballs.SetItemChecked(chkGumballs.Items.IndexOf(Value), True)
                Application.DoEvents()
            Loop
            Reader.Close()
            Reader.Dispose()
        Else
            'MessageBox.Show("No")
        End If
    End Sub

    Sub LoadFate()
        'blnLoad = True
        Dim FateInfo As New FileInfo("Fate.txt")
        If FateInfo.Exists = True Then
            Dim Value As String
            Dim Temp As String
            Dim IndexofFate As Integer
            Dim Reader As New StreamReader("Fate.txt")
            Do Until Reader.Peek = -1
                Value = Reader.ReadLine()
                If Value.EndsWith(" True") = True Then
                    Temp = Value.Replace(" True", "")
                    IndexofFate = chkFate.Items.IndexOf(Temp)
                    If IndexofFate <> -1 Then
                        'MessageBox.Show(IndexofFate)
                        chkFate.SetItemChecked(IndexofFate, True)
                        Dim indexing As Integer = Fates.IndexOf(Temp)
                        If indexing <> -1 Then
                            'MessageBox.Show(Fates(indexing))
                            Fates(indexing) = Fates(indexing).Replace(Fates(indexing), Fates(indexing) & " True")
                            'MessageBox.Show(Fates(indexing))
                        End If
                    End If
                End If
            Loop
            Reader.Close()
            Reader.Dispose()

        End If
    End Sub
    Private Sub chkGumballs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chkGumballs.SelectedIndexChanged
        chkFate.SelectedIndex = -1
        lblBenefit.Text = ""

        Dim Gumball As String = chkGumballs.SelectedItem
        Gumball = Gumball.Replace(" ", "_")
        picGumball1.ImageLocation = ("./Images/" & Gumball & ".png")
        picGumball2.ImageLocation = Nothing
        Gumball = Gumball.Replace("_", " ")

        lblGumball1.Text = Gumball
        lblGumball2.Text = ""
        picGumball1.BackColor = SystemColors.Control
        picGumball2.BackColor = SystemColors.Control
        Factions()
    End Sub
    Sub Factions()

        'This is going to be tricky...
        Select Case picGumball1.ImageLocation
            Case "./Images/Adventurer.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Air_Elemental.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Alchemist.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Alexander.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Alien.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Angel_Deity.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Apollo.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Archaeologist.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Armor.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Asura.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Athena.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Autobots.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Avalon.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Bandit.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Black_Warrior.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Black_White_Queen.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Blacksmith.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Blade.png"
                _picFact1.BackColor = Color.Yellow
            Case "./Images/Bloody_Wolf.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Blue_Shark.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Bomberman.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Bounty_Hunter.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Bull_Demon_King.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Bunny.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Butcher.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Cactus.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Captain.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Catherine.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Checkers.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Chef.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Chuchu.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Claw.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Clown.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Commander.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Commando.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Cosmic_Godfather.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Creator.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Crusader.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Crypt_Lord.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Cupid.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Cyborg.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Cytus.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/DJ.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Dark_Dragon.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Dark_Elemental.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Death_Knight.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Deemo.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Demon.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Demon_Hunter.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Destroyer.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Divine_Dragon.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Doctor_Octopus.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Duelist.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Dwarf_King.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Earth_Elemental.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Explosive_Pumpkin.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Faerie_Dragon.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Fallen_Angel.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Fire_Elemental.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Flagellant.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Franken.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Frost_Queen.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Future_Cat.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Gaheris.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Galahad.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Gandharva.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Gang_Cadre.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Garuda.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Gawaine.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Geisha.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Genie.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Ghost_Captain.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Gladiator.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Goblin.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Golden_Titan.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Great_Guardian.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Guardian.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Gumiho.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Hades.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Hamster.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Heavenly_King.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Hella.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Hellfire.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Hercules.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/High_Priest.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Holy_Dragon.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Holy_Warrior.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Jeweler.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Junkman.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Justice_Herald.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Kairo_Concubine.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Kairo_Monarch.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Kaito.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/King.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/King_Arthur.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Kraken_Captain.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Kusanagi_Warrior.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Joan.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Lamorak.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Lancelot.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Lich_King.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Light_Elemental.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Lionheart_King.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Little_May.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Machine_Herald.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Machinist.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Mage.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Magic_Boy.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Magic_Golem.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Magmatron.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Mahiraga.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Mammoth.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Masamune.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Medusa.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Merchant.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Merman.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Minstrel.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Mischief.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Modificator.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Monkey_King.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Musashi.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/NO.1_Mutant.png"
                picFact1.BackColor = Color.Red
            Case "./Images/NO.2_Mutant.png"
                picFact1.BackColor = Color.Red
            Case "./Images/NO.3_Mutant.png"
                picFact1.BackColor = Color.Red
            Case "./Images/NO.4_Mutant.png"
                picFact1.BackColor = Color.Red
            Case "./Images/NO.5_Mutant.png"
                picFact1.BackColor = Color.Red
            Case "./Images/NO.1_Parasite.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/NO.2_Parasite.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/NO.3_Parasite.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/NO.4_Parasite.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Nalakuvara.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Nelson.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Night_Knight.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Ninja_Frog.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Nobunaga.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Orc.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Panda.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Pandora.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Paparazzi.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Peter.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Pharaoh.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Pharmacist.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Phoenix.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Pigsy.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Pinocchio.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Pirate.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Poseidon.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Predator.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Priest.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Prince.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Puppeteer.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Raptor.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Red_Dragon.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Red_Hood.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Referee.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Ripper.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Sage.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Saladin.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Sandy.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Satans_Son.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Sculptor.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Semi-Finished_Product.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Shadow_Assassin.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Skeleton_Lord.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Slave.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Snowman.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Sorcerer.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Soul_Reaper.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Spartan.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Space_Wizard.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Spy.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Star.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Starmoon_Scholar.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Sunflower.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Swordsman.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Tarot.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Templar.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Terminator.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Three-eye_King.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Time_Wizard.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Totem_Warlock.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Trainer.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Tripitaka.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Vampire.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Vampire_Hunter.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Warrior.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Water_Elemental.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/White_Chess_Bishop.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Witch.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/World_Tree.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Yaksha.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Zerg_Queen.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Zeros.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Zeus.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Zorro.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Fire_Giant.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Odin.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Zombie.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Diau_Charn.png"
                picFact1.BackColor = Color.Red
            Case "./Images/Xi_Shi.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Yang_Yuhuan.png"
                picFact1.BackColor = Color.Blue
            Case "./Images/Wang_Zhaojun.png"
                picFact1.BackColor = Color.Yellow
            Case "./Images/Noble.png"
                picFact1.BackColor = Color.LightGreen
            Case "./Images/Eternal_Titan.png"
                picFact1.BackColor = Color.Red
            Case Else
                picFact1.BackColor = Color.Gray


        End Select
        Select Case picGumball2.ImageLocation
            Case "./Images/Adventurer.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Air_Elemental.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Alchemist.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Alexander.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Alien.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Angel_Deity.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Apollo.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Archaeologist.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Armor.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Asura.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Athena.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Autobots.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Avalon.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Bandit.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Black_Warrior.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Black_White_Queen.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Blacksmith.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Blade.png"
                _picFact2.BackColor = Color.Yellow
            Case "./Images/Bloody_Wolf.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Blue_Shark.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Bomberman.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Bounty_Hunter.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Bull_Demon_King.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Bunny.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Butcher.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Cactus.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Captain.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Catherine.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Checkers.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Chef.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Chuchu.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Claw.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Clown.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Commander.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Commando.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Cosmic_Godfather.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Creator.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Crusader.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Crypt_Lord.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Cupid.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Cyborg.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Cytus.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/DJ.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Dark_Dragon.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Dark_Elemental.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Death_Knight.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Deemo.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Demon.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Demon_Hunter.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Destroyer.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Divine_Dragon.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Doctor_Octopus.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Duelist.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Dwarf_King.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Earth_Elemental.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Explosive_Pumpkin.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Faerie_Dragon.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Fallen_Angel.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Fire_Elemental.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Flagellant.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Franken.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Frost_Queen.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Future_Cat.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Gaheris.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Galahad.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Gandharva.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Gang_Cadre.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Garuda.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Gawaine.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Geisha.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Genie.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Ghost_Captain.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Gladiator.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Goblin.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Golden_Titan.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Great_Guardian.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Guardian.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Gumiho.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Hades.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Hamster.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Heavenly_King.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Hella.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Hellfire.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Hercules.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/High_Priest.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Holy_Dragon.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Holy_Warrior.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Jeweler.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Junkman.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Justice_Herald.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Kairo_Concubine.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Kairo_Monarch.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Kaito.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/King.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/King_Arthur.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Kraken_Captain.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Kusanagi_Warrior.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Joan.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Lamorak.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Lancelot.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Lich_King.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Light_Elemental.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Lionheart_King.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Little_May.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Machine_Herald.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Machinist.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Mage.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Magic_Boy.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Magic_Golem.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Magmatron.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Mahiraga.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Mammoth.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Masamune.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Medusa.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Merchant.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Merman.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Minstrel.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Mischief.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Modificator.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Monkey_King.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Musashi.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/NO.1_Mutant.png"
                picFact2.BackColor = Color.Red
            Case "./Images/NO.2_Mutant.png"
                picFact2.BackColor = Color.Red
            Case "./Images/NO.3_Mutant.png"
                picFact2.BackColor = Color.Red
            Case "./Images/NO.4_Mutant.png"
                picFact2.BackColor = Color.Red
            Case "./Images/NO.5_Mutant.png"
                picFact2.BackColor = Color.Red
            Case "./Images/NO.1_Parasite.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/NO.2_Parasite.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/NO.3_Parasite.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/NO.4_Parasite.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Nalakuvara.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Nelson.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Night_Knight.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Ninja_Frog.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Nobunaga.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Orc.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Panda.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Pandora.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Paparazzi.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Peter.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Pharaoh.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Pharmacist.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Phoenix.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Pigsy.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Pinocchio.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Pirate.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Poseidon.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Predator.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Priest.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Prince.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Puppeteer.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Raptor.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Red_Dragon.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Red_Hood.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Referee.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Ripper.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Sage.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Saladin.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Sandy.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Satans_Son.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Sculptor.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Semi-Finished_Product.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Shadow_Assassin.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Skeleton_Lord.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Slave.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Snowman.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Sorcerer.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Soul_Reaper.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Spartan.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Space_Wizard.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Spy.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Star.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Starmoon_Scholar.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Sunflower.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Swordsman.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Tarot.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Templar.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Terminator.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Three-eye_King.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Time_Wizard.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Totem_Warlock.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Trainer.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Tripitaka.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Vampire.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Vampire_Hunter.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Warrior.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Water_Elemental.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/White_Chess_Bishop.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Witch.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/World_Tree.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Yaksha.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Zerg_Queen.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Zeros.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Zeus.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Zorro.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Fire_Giant.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Odin.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Zombie.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Diau_Charn.png"
                picFact2.BackColor = Color.Red
            Case "./Images/Xi_Shi.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Yang_Yuhuan.png"
                picFact2.BackColor = Color.Blue
            Case "./Images/Wang_Zhaojun.png"
                picFact2.BackColor = Color.Yellow
            Case "./Images/Noble.png"
                picFact2.BackColor = Color.LightGreen
            Case "./Images/Eternal_Titan.png"
                picFact2.BackColor = Color.Red
            Case Else
                picFact2.BackColor = Color.Gray
        End Select
        'If picGumball1.ImageLocation.EndsWith("Adventurer.png") = True Then

        'End If
    End Sub
    Private Sub chkFate_ItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs) Handles chkFate.ItemCheck
        'Dim messageBoxCS As System.Text.StringBuilder = New System.Text.StringBuilder()
        'messageBoxCS.AppendFormat("{0} = {1}", "Index", e.Index)
        'messageBoxCS.AppendLine()
        'messageBoxCS.AppendFormat("{0} = {1}", "NewValue", e.NewValue)
        'MessageBox.Show(e.NewValue)
        'messageBoxCS.AppendLine()
        'messageBoxCS.AppendFormat("{0} = {1}", "CurrentValue", e.CurrentValue)
        'messageBoxCS.AppendLine()
        'MessageBox.Show(messageBoxCS.ToString(), "ItemCheck Event")
        'MessageBox.Show(chkFate.SelectedItem)

        If blnLoad = True Then
            'MessageBox.Show("Load")
            Exit Sub
        End If
        If e.NewValue = 1 Then
            'MessageBox.Show(chkFate.SelectedItem)
            'MessageBox.Show(Fates.IndexOf(chkSelect))
            Dim chkSelect As String = chkFate.SelectedItem

            Dim indexing As Integer = Fates.IndexOf(chkSelect)
            If indexing <> -1 Then
                ' MessageBox.Show(Fates(indexing))
                Fates(indexing) = Fates(indexing).Replace(Fates(indexing), Fates(indexing) & " True")
                'MessageBox.Show(Fates(indexing))
            End If

        ElseIf e.NewValue = 0 Then
            'MessageBox.Show(chkFate.SelectedItem)

            Dim chkSelect As String = chkFate.SelectedItem
            ' MessageBox.Show(chkSelect)
            Dim indexing As Integer = Fates.IndexOf(chkSelect & " True")
            'MessageBox.Show("Looking For " & Fates(indexing))

            If indexing <> -1 Then
                Fates(indexing) = chkSelect
            End If
            'MessageBox.Show("I should Not have True: " & Fates(indexing))
        End If
        BlnFateSave = True
    End Sub
    Private Sub lstFate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chkFate.SelectedIndexChanged

        Dim Gumball1 As String = ""
        Dim Gumball2 As String = ""

        If cmbType.SelectedIndex = 0 Then
            Select Case chkFate.SelectedIndex
                Case 0
                    lblBenefit.Text = "10,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Adventurer.png")
                    picGumball2.ImageLocation = ("./Images/Athena.png")
                Case 1
                    lblBenefit.Text = "10,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Swordsman.png")
                    picGumball2.ImageLocation = ("./Images/Blacksmith.png")
                Case 2
                    lblBenefit.Text = "10,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Swordsman.png")
                    picGumball2.ImageLocation = ("./Images/Mage.png")
                Case 3
                    lblBenefit.Text = "15,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Mage.png")
                    picGumball2.ImageLocation = ("./Images/Dwarf_King.png")
                Case 4
                    lblBenefit.Text = "15,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Bandit.png")
                    picGumball2.ImageLocation = ("./Images/Bounty_Hunter.png")
                Case 5
                    lblBenefit.Text = "15,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Bandit.png")
                    picGumball2.ImageLocation = ("./Images/Zorro.png")
                Case 6
                    lblBenefit.Text = "15,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Tarot.png")
                    picGumball2.ImageLocation = ("./Images/Checkers.png")
                Case 7
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Minstrel.png")
                    picGumball2.ImageLocation = ("./Images/King.png")
                Case 8
                    lblBenefit.Text = "50,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Minstrel.png")
                    picGumball2.ImageLocation = ("./Images/Creator.png")
                Case 9
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Minstrel.png")
                    picGumball2.ImageLocation = ("./Images/Warrior.png")
                Case 10
                    lblBenefit.Text = "15,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Bounty_Hunter.png")
                    picGumball2.ImageLocation = ("./Images/Predator.png")
                Case 11
                    lblBenefit.Text = "15,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Bounty_Hunter.png")
                    picGumball2.ImageLocation = ("./Images/Vampire_Hunter.png")
                Case 12
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Bounty_Hunter.png")
                    picGumball2.ImageLocation = ("./Images/Demon_Hunter.png")
                Case 13
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Priest.png")
                    picGumball2.ImageLocation = ("./Images/Pharmacist.png")
                Case 14
                    lblBenefit.Text = "15,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Priest.png")
                    picGumball2.ImageLocation = ("./Images/Sage.png")
                Case 15
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Machinist.png")
                    picGumball2.ImageLocation = ("./Images/Zeros.png")
                Case 16
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Zeros.png")
                    picGumball2.ImageLocation = ("./Images/Armor.png")
                Case 17
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Sorcerer.png")
                    picGumball2.ImageLocation = ("./Images/Future_Cat.png")
                Case 18
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Night_Knight.png")
                    picGumball2.ImageLocation = ("./Images/Zorro.png")
                Case 19
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Predator.png")
                    picGumball2.ImageLocation = ("./Images/Templar.png")
                Case 20
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Ghost_Captain.png")
                    picGumball2.ImageLocation = ("./Images/Lich_King.png")
                Case 21
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Terminator.png")
                    picGumball2.ImageLocation = ("./Images/Future_Cat.png")
                Case 22
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Slave.png")
                    picGumball2.ImageLocation = ("./Images/Modificator.png")
                Case 23
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Nobunaga.png")
                    picGumball2.ImageLocation = ("./Images/Masamune.png")
                Case 24
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Explosive_Pumpkin.png")
                    picGumball2.ImageLocation = ("./Images/Bomberman.png")
                Case 25
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Skeleton_Lord.png")
                    picGumball2.ImageLocation = ("./Images/Pharaoh.png")
                Case 26
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Archaeologist.png")
                    picGumball2.ImageLocation = ("./Images/Pharaoh.png")
                Case 27
                    lblBenefit.Text = "50,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Sculptor.png")
                    picGumball2.ImageLocation = ("./Images/Jeweler.png")
                Case 28
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Mammoth.png")
                    picGumball2.ImageLocation = ("./Images/Clown.png")
                Case 29
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Armor.png")
                    picGumball2.ImageLocation = ("./Images/Holy_Warrior.png")
                Case 30
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Kraken_Captain.png")
                    picGumball2.ImageLocation = ("./Images/Doctor_Octopus.png")
                Case 31
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Zeros.png")
                    picGumball2.ImageLocation = ("./Images/Machine_Herald.png")
                Case 32
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Sage.png")
                    picGumball2.ImageLocation = ("./Images/White_Chess_Bishop.png")
                Case 33
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Zerg_Queen.png")
                    picGumball2.ImageLocation = ("./Images/Checkers.png")
                Case 34
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Monkey_King.png")
                    picGumball2.ImageLocation = ("./Images/Nalakuvara.png")
                Case 35
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Medusa.png")
                    picGumball2.ImageLocation = ("./Images/Three-eye_King.png")
                Case 36
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Time_Wizard.png")
                    picGumball2.ImageLocation = ("./Images/Future_Cat.png")
                Case 37
                    lblBenefit.Text = "50,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Creator.png")
                    picGumball2.ImageLocation = ("./Images/Time_Wizard.png")
                Case 38
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Autobots.png")
                    picGumball2.ImageLocation = ("./Images/Alien.png")
                Case 39
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Butcher.png")
                    picGumball2.ImageLocation = ("./Images/Ripper.png")
                Case 40
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Time_Wizard.png")
                    picGumball2.ImageLocation = ("./Images/Totem_Warlock.png")
                Case 41
                    lblBenefit.Text = "10,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Slave.png")
                    picGumball2.ImageLocation = ("./Images/Junkman.png")
                Case 42
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Bunny.png")
                    picGumball2.ImageLocation = ("./Images/Hamster.png")
                Case 43
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Starmoon_Scholar.png")
                    picGumball2.ImageLocation = ("./Images/Totem_Warlock.png")
                Case 44
                    lblBenefit.Text = "15,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Pinocchio.png")
                    picGumball2.ImageLocation = ("./Images/Lancelot.png")
                Case 45
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Alchemist.png")
                    picGumball2.ImageLocation = ("./Images/Jeweler.png")
                Case 46
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Bandit.png")
                    picGumball2.ImageLocation = ("./Images/Gang_Cadre.png")
                Case 47
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Divine_Dragon.png")
                    picGumball2.ImageLocation = ("./Images/Genie.png")
                Case 48
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Ninja_Frog.png")
                    picGumball2.ImageLocation = ("./Images/Flagellant.png")
                Case 49
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Machinist.png")
                    picGumball2.ImageLocation = ("./Images/Goblin.png")
                Case 50
                    lblBenefit.Text = "15,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Death_Knight.png")
                    picGumball2.ImageLocation = ("./Images/Black_Warrior.png")
                Case 51
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Duelist.png")
                    picGumball2.ImageLocation = ("./Images/Ninja_Frog.png")
                Case 52
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Explosive_Pumpkin.png")
                    picGumball2.ImageLocation = ("./Images/Satans_Son.png")
                Case 53
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Spartan.png")
                    picGumball2.ImageLocation = ("./Images/Orc.png")
                Case 54
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Cosmic_Godfather.png")
                    picGumball2.ImageLocation = ("./Images/Gang_Cadre.png")
                Case 55
                    lblBenefit.Text = "15,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Pirate.png")
                    picGumball2.ImageLocation = ("./Images/Captain.png")
                Case 56
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/NO.1_Mutant.png")
                    picGumball2.ImageLocation = ("./Images/Ninja_Frog.png")
                Case 57
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Vampire_Hunter.png")
                    picGumball2.ImageLocation = ("./Images/Blade.png")
                Case 58
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Armor.png")
                    picGumball2.ImageLocation = ("./Images/Avalon.png")
                Case 59
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Bunny.png")
                    picGumball2.ImageLocation = ("./Images/Chuchu.png")
                Case 60
                    lblBenefit.Text = "15,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Zerg_Queen.png")
                    picGumball2.ImageLocation = ("./Images/Catherine.png")
                Case 61
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/King_Arthur.png")
                    picGumball2.ImageLocation = ("./Images/Alexander.png")
                Case 62
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Hamster.png")
                    picGumball2.ImageLocation = ("./Images/Crypt_Lord.png")
                Case 63
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Zerg_Queen.png")
                    picGumball2.ImageLocation = ("./Images/Kairo_Monarch.png")
                Case 64
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Zerg_Queen.png")
                    picGumball2.ImageLocation = ("./Images/Kairo_Concubine.png")
                Case 65
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Zeros.png")
                    picGumball2.ImageLocation = ("./Images/Avalon.png")
                Case 66
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Deemo.png")
                    picGumball2.ImageLocation = ("./Images/Gandharva.png")
                Case 67
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Monkey_King.png")
                    picGumball2.ImageLocation = ("./Images/Great_Guardian.png")
                Case 68
                    lblBenefit.Text = "15,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Vampire.png")
                    picGumball2.ImageLocation = ("./Images/Yaksha.png")
                Case 69
                    lblBenefit.Text = "15,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Phoenix.png")
                    picGumball2.ImageLocation = ("./Images/Garuda.png")
                Case 70
                    lblBenefit.Text = "50,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Hercules.png")
                    picGumball2.ImageLocation = ("./Images/Asura.png")
                Case 71
                    lblBenefit.Text = "20,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Spartan.png")
                    picGumball2.ImageLocation = ("./Images/Lamorak.png")
                Case 72
                    lblBenefit.Text = "15,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Justice_Herald.png")
                    picGumball2.ImageLocation = ("./Images/Gaheris.png")
                Case 73
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Athena.png")
                    picGumball2.ImageLocation = ("./Images/Magmatron.png")
                Case 74
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Odin.png")
                    picGumball2.ImageLocation = ("./Images/Fire_Giant.png")
                Case 75
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Cyborg.png")
                    picGumball2.ImageLocation = ("./Images/Zombie.png")
                Case 76
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Franken.png")
                    picGumball2.ImageLocation = ("./Images/Zombie.png")
                Case 77
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Clown.png")
                    picGumball2.ImageLocation = ("./Images/Cupid.png")
                Case 78
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Clown.png")
                    picGumball2.ImageLocation = ("./Images/Ripper.png")
                Case 79
                    lblBenefit.Text = "30,000 Coins"
                    picGumball1.ImageLocation = ("./Images/Medusa.png")
                    picGumball2.ImageLocation = ("./Images/Mahiraga.png")
            End Select
        ElseIf cmbType.SelectedIndex = 1 Then
            Select Case chkFate.SelectedIndex
                Case 0
                    lblBenefit.Text = "1 Gem"
                    picGumball1.ImageLocation = ("./Images/Gladiator.png")
                    picGumball2.ImageLocation = ("./Images/Spartan.png")
                Case 1
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Raptor.png")
                    picGumball2.ImageLocation = ("./Images/Claw.png")
                Case 2
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/World_Tree.png")
                    picGumball2.ImageLocation = ("./Images/Sunflower.png")
                Case 3
                    lblBenefit.Text = "3 Gems"
                    picGumball1.ImageLocation = ("./Images/World_Tree.png")
                    picGumball2.ImageLocation = ("./Images/Cactus.png")
                Case 4
                    lblBenefit.Text = "1 Gem"
                    picGumball1.ImageLocation = ("./Images/Pirate.png")
                    picGumball2.ImageLocation = ("./Images/Kraken_Captain.png")
                Case 5
                    lblBenefit.Text = "1 Gem"
                    picGumball1.ImageLocation = ("./Images/Pirate.png")
                    picGumball2.ImageLocation = ("./Images/Ghost_Captain.png")
                Case 6
                    lblBenefit.Text = "3 Gems"
                    picGumball1.ImageLocation = ("./Images/NO.1_Mutant.png")
                    picGumball2.ImageLocation = ("./Images/Cosmic_Godfather.png")
                Case 7
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/NO.2_Mutant.png")
                    picGumball2.ImageLocation = ("./Images/Cosmic_Godfather.png")
                Case 8
                    lblBenefit.Text = "1 Gem"
                    picGumball1.ImageLocation = ("./Images/NO.3_Mutant.png")
                    picGumball2.ImageLocation = ("./Images/Cosmic_Godfather.png")
                Case 9
                    lblBenefit.Text = "1 Gem"
                    picGumball1.ImageLocation = ("./Images/NO.4_Mutant.png")
                    picGumball2.ImageLocation = ("./Images/Cosmic_Godfather.png")
                Case 10
                    lblBenefit.Text = "1 Gem"
                    picGumball1.ImageLocation = ("./Images/NO.5_Mutant.png")
                    picGumball2.ImageLocation = ("./Images/Cosmic_Godfather.png")
                Case 11
                    lblBenefit.Text = "3 Gems"
                    picGumball1.ImageLocation = ("./Images/Guardian.png")
                    picGumball2.ImageLocation = ("./Images/Commando.png")
                Case 12
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Commander.png")
                    picGumball2.ImageLocation = ("./Images/Commando.png")
                Case 13
                    lblBenefit.Text = "3 Gems"
                    picGumball1.ImageLocation = ("./Images/Monkey_King.png")
                    picGumball2.ImageLocation = ("./Images/Peter.png")
                Case 14
                    lblBenefit.Text = "3 Gems"
                    picGumball1.ImageLocation = ("./Images/King.png")
                    picGumball2.ImageLocation = ("./Images/Prince.png")
                Case 15
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Adventurer.png")
                    picGumball2.ImageLocation = ("./Images/Peter.png")
                Case 16
                    lblBenefit.Text = "1 Gem"
                    picGumball1.ImageLocation = ("./Images/Bandit.png")
                    picGumball2.ImageLocation = ("./Images/Kaito.png")
                Case 17
                    lblBenefit.Text = "1 Gem"
                    picGumball1.ImageLocation = ("./Images/Hellfire.png")
                    picGumball2.ImageLocation = ("./Images/Fire_Elemental.png")
                Case 18
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Heavenly_King.png")
                    picGumball2.ImageLocation = ("./Images/Nalakuvara.png")
                Case 19
                    lblBenefit.Text = "3 Gems"
                    picGumball1.ImageLocation = ("./Images/Hades.png")
                    picGumball2.ImageLocation = ("./Images/Skeleton_Lord.png")
                Case 20
                    lblBenefit.Text = "3 Gems"
                    picGumball1.ImageLocation = ("./Images/Athena.png")
                    picGumball2.ImageLocation = ("./Images/Pandora.png")
                Case 21
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Water_Elemental.png")
                    picGumball2.ImageLocation = ("./Images/Merman.png")
                Case 22
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Snowman.png")
                    picGumball2.ImageLocation = ("./Images/Frost_Queen.png")
                Case 23
                    lblBenefit.Text = "3 Gems"
                    picGumball1.ImageLocation = ("./Images/Butcher.png")
                    picGumball2.ImageLocation = ("./Images/Chef.png")
                Case 24
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Clown.png")
                    picGumball2.ImageLocation = ("./Images/Trainer.png")
                Case 25
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Magic_Golem.png")
                    picGumball2.ImageLocation = ("./Images/Puppeteer.png")
                Case 26
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Doctor_Octopus.png")
                    picGumball2.ImageLocation = ("./Images/Franken.png")
                Case 27
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Pinocchio.png")
                    picGumball2.ImageLocation = ("./Images/Puppeteer.png")
                Case 28
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Crusader.png")
                    picGumball2.ImageLocation = ("./Images/White_Chess_Bishop.png")
                Case 29
                    lblBenefit.Text = "3 Gems"
                    picGumball1.ImageLocation = ("./Images/Orc.png")
                    picGumball2.ImageLocation = ("./Images/Totem_Warlock.png")
                Case 30
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Gawaine.png")
                    picGumball2.ImageLocation = ("./Images/Gaheris.png")
                Case 31
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Galahad.png")
                    picGumball2.ImageLocation = ("./Images/Lancelot.png")
                Case 32
                    lblBenefit.Text = "3 Gems"
                    picGumball1.ImageLocation = ("./Images/World_Tree.png")
                    picGumball2.ImageLocation = ("./Images/Deemo.png")
                Case 33
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Deemo.png")
                    picGumball2.ImageLocation = ("./Images/Cytus.png")
                Case 34
                    lblBenefit.Text = "3 Gems"
                    picGumball1.ImageLocation = ("./Images/Time_Wizard.png")
                    picGumball2.ImageLocation = ("./Images/Space_Wizard.png")
                Case 35
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Machine_Herald.png")
                    picGumball2.ImageLocation = ("./Images/Catherine.png")
                Case 36
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Demon.png")
                    picGumball2.ImageLocation = ("./Images/Satans_Son.png")
                Case 37
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Monkey_King.png")
                    picGumball2.ImageLocation = ("./Images/Bull_Demon_King.png")
                Case 38
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Sculptor.png")
                    picGumball2.ImageLocation = ("./Images/Semi-Finished_Product.png")
                Case 39
                    lblBenefit.Text = "3 Gems"
                    picGumball1.ImageLocation = ("./Images/Musashi.png")
                    picGumball2.ImageLocation = ("./Images/Kusanagi_Warrior.png")
                Case 40
                    lblBenefit.Text = "3 Gems"
                    picGumball1.ImageLocation = ("./Images/Monkey_King.png")
                    picGumball2.ImageLocation = ("./Images/Tripitaka.png")
                Case 41
                    lblBenefit.Text = "2 Gems"
                    picGumball1.ImageLocation = ("./Images/Tripitaka.png")
                    picGumball2.ImageLocation = ("./Images/Pigsy.png")
                Case 42
                    lblBenefit.Text = "1 Gem"
                    picGumball1.ImageLocation = ("./Images/Tripitaka.png")
                    picGumball2.ImageLocation = ("./Images/Sandy.png")
                Case 43
                    lblBenefit.Text = "2 Gem"
                    picGumball1.ImageLocation = ("./Images/Divine_Dragon.png")
                    picGumball2.ImageLocation = ("./Images/Phoenix.png")
                Case 44
                    lblBenefit.Text = "3 Gem"
                    picGumball1.ImageLocation = ("./Images/Diau_Charn.png")
                    picGumball2.ImageLocation = ("./Images/Yang_Yuhuan.png")
                Case 45
                    lblBenefit.Text = "3 Gem"
                    picGumball1.ImageLocation = ("./Images/Xi_Shi.png")
                    picGumball2.ImageLocation = ("./Images/Wang_Zhaojun.png")
                Case 46
                    lblBenefit.Text = "3 Gem"
                    picGumball1.ImageLocation = ("./Images/Bomberman.png")
                    picGumball2.ImageLocation = ("./Images/Goblin.png")
            End Select
        ElseIf cmbType.SelectedIndex = 2 Then
            Select Case chkFate.SelectedIndex
                Case 0
                    lblBenefit.Text = "Sorcerer: Power +1"
                    picGumball1.ImageLocation = ("./Images/Witch.png")
                    picGumball2.ImageLocation = ("./Images/Sorcerer.png")
                Case 1
                    lblBenefit.Text = "Vampire_Hunter: Attack +1"
                    picGumball1.ImageLocation = ("./Images/Demon_Hunter.png")
                    picGumball2.ImageLocation = ("./Images/Vampire_Hunter.png")
                Case 2
                    lblBenefit.Text = "Kraken_Captain: HP +20"
                    picGumball1.ImageLocation = ("./Images/Kraken_Captain.png")
                    picGumball2.ImageLocation = ("./Images/Poseidon.png")
                Case 3
                    lblBenefit.Text = "Ghost_Captain: MP +20"
                    picGumball1.ImageLocation = ("./Images/Ghost_Captain.png")
                    picGumball2.ImageLocation = ("./Images/Poseidon.png")
                Case 4
                    lblBenefit.Text = "Pirate: HP +20"
                    picGumball1.ImageLocation = ("./Images/Pirate.png")
                    picGumball2.ImageLocation = ("./Images/Poseidon.png")
                Case 5
                    lblBenefit.Text = "Pharmacist: HP +20"
                    picGumball1.ImageLocation = ("./Images/Pharmacist.png")
                    picGumball2.ImageLocation = ("./Images/Cyborg.png")
                Case 6
                    lblBenefit.Text = "Crusader: HP +20"
                    picGumball1.ImageLocation = ("./Images/Crusader.png")
                    picGumball2.ImageLocation = ("./Images/Lionheart_King.png")
                Case 7
                    lblBenefit.Text = "Musashi: Attack +1"
                    picGumball1.ImageLocation = ("./Images/Musashi.png")
                    picGumball2.ImageLocation = ("./Images/Panda.png")
                Case 8
                    lblBenefit.Text = "Bloody Wolf: Attack +1"
                    picGumball1.ImageLocation = ("./Images/Shadow_Assassin.png")
                    picGumball2.ImageLocation = ("./Images/Bloody_Wolf.png")
                Case 9
                    lblBenefit.Text = "Priest: MP +20"
                    picGumball1.ImageLocation = ("./Images/Priest.png")
                    picGumball2.ImageLocation = ("./Images/Apollo.png")
                Case 10
                    lblBenefit.Text = "Sage: MP +20"
                    picGumball1.ImageLocation = ("./Images/Sage.png")
                    picGumball2.ImageLocation = ("./Images/Apollo.png")
                Case 11
                    lblBenefit.Text = "Soul Reaper: Attack +1"
                    picGumball1.ImageLocation = ("./Images/Soul_Reaper.png")
                    picGumball2.ImageLocation = ("./Images/Hades.png")
                Case 12
                    lblBenefit.Text = "Fire Elemental: Power +1"
                    picGumball1.ImageLocation = ("./Images/Fire_Elemental.png")
                    picGumball2.ImageLocation = ("./Images/Phoenix.png")
                Case 13
                    lblBenefit.Text = "Adventurer: Attack +1"
                    picGumball1.ImageLocation = ("./Images/Adventurer.png")
                    picGumball2.ImageLocation = ("./Images/Warrior.png")
                Case 14
                    lblBenefit.Text = "Mage: Power +1"
                    picGumball1.ImageLocation = ("./Images/Mage.png")
                    picGumball2.ImageLocation = ("./Images/Magic_Boy.png")
                Case 15
                    lblBenefit.Text = "Gladiator: HP +20"
                    picGumball1.ImageLocation = ("./Images/Gladiator.png")
                    picGumball2.ImageLocation = ("./Images/Hercules.png")
                Case 16
                    lblBenefit.Text = "Fallen Angel: Power +1"
                    picGumball1.ImageLocation = ("./Images/Fallen_Angel.png")
                    picGumball2.ImageLocation = ("./Images/Hades.png")
                Case 17
                    lblBenefit.Text = "Spy: Attack +1"
                    picGumball1.ImageLocation = ("./Images/Spy.png")
                    picGumball2.ImageLocation = ("./Images/Shadow_Assassin.png")
                Case 18
                    lblBenefit.Text = "Death_Knight: Attack +1"
                    picGumball1.ImageLocation = ("./Images/Death_Knight.png")
                    picGumball2.ImageLocation = ("./Images/Lich_King.png")
                Case 19
                    lblBenefit.Text = "Water Elemental: MP +20"
                    picGumball1.ImageLocation = ("./Images/Poseidon.png")
                    picGumball2.ImageLocation = ("./Images/Water_Elemental.png")
                Case 20
                    lblBenefit.Text = "Spartan: Attack +1"
                    picGumball1.ImageLocation = ("./Images/Hercules.png")
                    picGumball2.ImageLocation = ("./Images/Spartan.png")
                Case 21
                    lblBenefit.Text = "Captain: Attack +1"
                    picGumball1.ImageLocation = ("./Images/Nelson.png")
                    picGumball2.ImageLocation = ("./Images/Captain.png")
                Case 22
                    lblBenefit.Text = "Tarot: Power +1"
                    picGumball1.ImageLocation = ("./Images/Tarot.png")
                    picGumball2.ImageLocation = ("./Images/High_Priest.png")
                Case 23
                    lblBenefit.Text = "Minstrel: HP +20"
                    picGumball1.ImageLocation = ("./Images/Minstrel.png")
                    picGumball2.ImageLocation = ("./Images/DJ.png")
                Case 24
                    lblBenefit.Text = "Shadow Assassin: Attack +1"
                    picGumball1.ImageLocation = ("./Images/Shadow_Assassin.png")
                    picGumball2.ImageLocation = ("./Images/Paparazzi.png")
                Case 25
                    lblBenefit.Text = "Air Elemental : Power +1"
                    picGumball1.ImageLocation = ("./Images/Air_Elemental.png")
                    picGumball2.ImageLocation = ("./Images/Zeus.png")
                Case 26
                    lblBenefit.Text = "Athena: Power +1"
                    picGumball1.ImageLocation = ("./Images/Athena.png")
                    picGumball2.ImageLocation = ("./Images/Zeus.png")
                Case 27
                    lblBenefit.Text = "Flagellant: HP +20"
                    picGumball1.ImageLocation = ("./Images/Flagellant.png")
                    picGumball2.ImageLocation = ("./Images/Tripitaka.png")
                Case 28
                    lblBenefit.Text = "Galahad: Attack +1"
                    picGumball1.ImageLocation = ("./Images/Sage.png")
                    picGumball2.ImageLocation = ("./Images/Galahad.png")
                Case 29
                    lblBenefit.Text = "Geisha: MP +20"
                    picGumball1.ImageLocation = ("./Images/Geisha.png")
                    picGumball2.ImageLocation = ("./Images/Gandharva.png")
            End Select
        ElseIf cmbType.SelectedIndex = 3 Then
            Select Case chkFate.SelectedIndex
                Case 0
                    lblBenefit.Text = "Gumball Pot x5"
                    picGumball1.ImageLocation = ("./Images/Vampire.png")
                    picGumball2.ImageLocation = ("./Images/Vampire_Hunter.png")
                Case 1
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Demon.png")
                    picGumball2.ImageLocation = ("./Images/Demon_Hunter.png")
                Case 2
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Fallen_Angel.png")
                    picGumball2.ImageLocation = ("./Images/Angel_Deity.png")
                Case 3
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Apollo.png")
                    picGumball2.ImageLocation = ("./Images/Hades.png")
                Case 4
                    lblBenefit.Text = "Gumball Pot x5"
                    picGumball1.ImageLocation = ("./Images/Warrior.png")
                    picGumball2.ImageLocation = ("./Images/Dark_Dragon.png")
                Case 5
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Night_Knight.png")
                    picGumball2.ImageLocation = ("./Images/Justice_Herald.png")
                Case 6
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Armor.png")
                    picGumball2.ImageLocation = ("./Images/Guardian.png")
                Case 7
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Duelist.png")
                    picGumball2.ImageLocation = ("./Images/Angel_Deity.png")
                Case 8
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Mammoth.png")
                    picGumball2.ImageLocation = ("./Images/Butcher.png")
                Case 9
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Lionheart_King.png")
                    picGumball2.ImageLocation = ("./Images/Saladin.png")
                Case 10
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Destroyer.png")
                    picGumball2.ImageLocation = ("./Images/Creator.png")
                Case 11
                    lblBenefit.Text = "Gumball Pot x5"
                    picGumball1.ImageLocation = ("./Images/Fire_Elemental.png")
                    picGumball2.ImageLocation = ("./Images/Snowman.png")
                Case 12
                    lblBenefit.Text = "Gumball Pot x5"
                    picGumball1.ImageLocation = ("./Images/Soul_Reaper.png")
                    picGumball2.ImageLocation = ("./Images/Ghost_Captain.png")
                Case 13
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Night_Knight.png")
                    picGumball2.ImageLocation = ("./Images/Clown.png")
                Case 14
                    lblBenefit.Text = "Gumball Pot x5"
                    picGumball1.ImageLocation = ("./Images/Prince.png")
                    picGumball2.ImageLocation = ("./Images/Slave.png")
                Case 15
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Blue_Shark.png")
                    picGumball2.ImageLocation = ("./Images/Bloody_Wolf.png")
                Case 16
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Apollo.png")
                    picGumball2.ImageLocation = ("./Images/Hades.png")
                Case 17
                    lblBenefit.Text = "Gumball Pot x5"
                    picGumball1.ImageLocation = ("./Images/Bandit.png")
                    picGumball2.ImageLocation = ("./Images/Merchant.png")
                Case 18
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Apollo.png")
                    picGumball2.ImageLocation = ("./Images/Cupid.png")
                Case 19
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Mammoth.png")
                    picGumball2.ImageLocation = ("./Images/Trainer.png")
                Case 20
                    lblBenefit.Text = "Gumball Pot x5"
                    picGumball1.ImageLocation = ("./Images/Vampire.png")
                    picGumball2.ImageLocation = ("./Images/Blade.png")
                Case 21
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Monkey_King.png")
                    picGumball2.ImageLocation = ("./Images/Three-eye_King.png")
                Case 22
                    lblBenefit.Text = "Gumball Pot x5"
                    picGumball1.ImageLocation = ("./Images/Future_Cat.png")
                    picGumball2.ImageLocation = ("./Images/Hamster.png")
                Case 23
                    lblBenefit.Text = "Gumball Pot x2"
                    picGumball1.ImageLocation = ("./Images/Angel_Deity.png")
                    picGumball2.ImageLocation = ("./Images/Satans_Son.png")
                Case 24
                    lblBenefit.Text = "Gumball Pot x2"
                    picGumball1.ImageLocation = ("./Images/Medusa.png")
                    picGumball2.ImageLocation = ("./Images/Garuda.png")
                Case 25
                    lblBenefit.Text = "Gumball Pot x5"
                    picGumball1.ImageLocation = ("./Images/Lancelot.png")
                    picGumball2.ImageLocation = ("./Images/King_Arthur.png")
                Case 26
                    lblBenefit.Text = "Gumball Pot x5"
                    picGumball1.ImageLocation = ("./Images/Sunflower.png")
                    picGumball2.ImageLocation = ("./Images/Zombie.png")
                Case 27
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Armor.png")
                    picGumball2.ImageLocation = ("./Images/Eternal_Titan.png")
                Case 28
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Frost_Queen.png")
                    picGumball2.ImageLocation = ("./Images/Fire_Giant.png")
                Case 29
                    lblBenefit.Text = "Golden Pot x2"
                    picGumball1.ImageLocation = ("./Images/Slave.png")
                    picGumball2.ImageLocation = ("./Images/Noble.png")
            End Select
        ElseIf cmbType.SelectedIndex = 4 Then
            Select Case chkFate.SelectedIndex
                Case 0
                    lblBenefit.Text = "All Gumballs MP +20"
                    picGumball1.ImageLocation = ("./Images/King.png")
                    picGumball2.ImageLocation = ("./Images/Red_Hood.png")
                Case 1
                    lblBenefit.Text = "All Gumballs HP +20"
                    picGumball1.ImageLocation = ("./Images/Prince.png")
                    picGumball2.ImageLocation = ("./Images/Red_Hood.png")
                Case 2
                    lblBenefit.Text = "All Gumballs Power+1"
                    picGumball1.ImageLocation = ("./Images/Medusa.png")
                    picGumball2.ImageLocation = ("./Images/Poseidon.png")
                Case 3
                    lblBenefit.Text = "All Gumballs Attack + 1"
                    picGumball1.ImageLocation = ("./Images/Holy_Warrior.png")
                    picGumball2.ImageLocation = ("./Images/Athena.png")
                Case 4
                    lblBenefit.Text = "All Gumballs Spell effect +1%"
                    picGumball1.ImageLocation = ("./Images/Holy_Dragon.png")
                    picGumball2.ImageLocation = ("./Images/Faerie_Dragon.png")
                Case 5
                    lblBenefit.Text = "1 extra sign-in reward gem"
                    picGumball1.ImageLocation = ("./Images/Checkers.png")
                    picGumball2.ImageLocation = ("./Images/Black_White_Queen.png")
                Case 6
                    lblBenefit.Text = "All Gumballs Reduce training room time by 30 minutes"
                    picGumball1.ImageLocation = ("./Images/Sunflower.png")
                    picGumball2.ImageLocation = ("./Images/Cactus.png")
                Case 7
                    lblBenefit.Text = "Increase score by 2% in settlement (Affect coins And EXP rewards)"
                    picGumball1.ImageLocation = ("./Images/Commando.png")
                    picGumball2.ImageLocation = ("./Images/Zerg_Queen.png")
                Case 8
                    lblBenefit.Text = "All Gumballs Damage magic effects +2%"
                    picGumball1.ImageLocation = ("./Images/Nobunaga.png")
                    picGumball2.ImageLocation = ("./Images/Gumiho.png")
                Case 9
                    lblBenefit.Text = "Life bottles In maze heal +5%"
                    picGumball1.ImageLocation = ("./Images/Masamune.png")
                    picGumball2.ImageLocation = ("./Images/Geisha.png")
                Case 10
                    lblBenefit.Text = "Increase score by 2% In settlement (Affect coins And EXP rewards)"
                    picGumball1.ImageLocation = ("./Images/Adventurer.png")
                    picGumball2.ImageLocation = ("./Images/Little_May.png")
                Case 11
                    lblBenefit.Text = "All Gumballs Gumball's Dark Spell effect +3%"
                    picGumball1.ImageLocation = ("./Images/Hades.png")
                    picGumball2.ImageLocation = ("./Images/Pandora.png")

            End Select
        End If
        Try
            Gumball1 = Path.GetFileNameWithoutExtension(picGumball1.ImageLocation)
            Gumball1 = Gumball1.Replace("./Images/", "")
            Gumball1 = Gumball1.Replace(".png", "")
            Gumball1 = Gumball1.Replace("_", " ")
            Gumball2 = Path.GetFileNameWithoutExtension(picGumball2.ImageLocation)
            Gumball2 = Gumball2.Replace("./Images/", "")
            Gumball2 = Gumball2.Replace(".png", "")
            Gumball2 = Gumball2.Replace("_", " ")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        '
        'Gumball1 = picGumball1.ImageLocationLocation
        'MessageBox.Show("GUM1 " & Gumball1)

        CheckFate(Gumball1, Gumball2)
        Gumball1 = Gumball1.Replace("_", " ")
        Gumball2 = Gumball2.Replace("_", " ")
        lblGumball2.Text = Gumball2
        lblGumball1.Text = Gumball1
        Factions()
    End Sub

    Private Sub tmrGum_Tick(sender As Object, e As EventArgs) Handles tmrGum.Tick
        tmrGum.Enabled = False
        LoadGum()
        Fate()
        LoadFate()

        blnLoad = False
        cmbType.SelectedIndex = 1
        Application.DoEvents()
        cmbType.SelectedIndex = 2
        Application.DoEvents()
        cmbType.SelectedIndex = 3
        Application.DoEvents()
        cmbType.SelectedIndex = 4
        Application.DoEvents()
        cmbType.SelectedIndex = 0
        Application.DoEvents()
    End Sub
End Class
