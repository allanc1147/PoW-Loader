﻿using System;
using System.IO;
using System.Threading;

using PoW_Tool_SheetUtilities.Handler.BattleAssets;
using PoW_Tool_SheetUtilities.Handler.TextAssets;

namespace PoW_Tool_SheetUtilities
{
    internal class SpreadsheetUpdater
    {
        public static void UpdateSpreadsheetsFromGameFiles()
        {
            //Get input folder path
            string workingDirectory = Environment.CurrentDirectory;
            string inputFolder = workingDirectory + Path.DirectorySeparatorChar + "Input";

            new CharacterBehaviourAssetHandler().UpdateSheetFromGameFile(inputFolder);
            new BookAssetHandler().UpdateSheetFromGameFile(inputFolder);
            new BattleAssetHandler().UpdateSheetFromGameFile(inputFolder);
            new TraitAssetHandler().UpdateSheetFromGameFile(inputFolder);
            new StringTableAssetHandler().UpdateSheetFromGameFile(inputFolder);
            new QuestAssetHandler().UpdateSheetFromGameFile(inputFolder);
            new PropsAssetHandler().UpdateSheetFromGameFile(inputFolder);
            new NurturanceAssetHandler().UpdateSheetFromGameFile(inputFolder);
            new EventCubeAssetHandler().UpdateSheetFromGameFile(inputFolder);
            new NpcAssetHandler().UpdateSheetFromGameFile(inputFolder);
            new CharacterInfoAssetHandler().UpdateSheetFromGameFile(inputFolder);
            new BattleAreaAssetHandler().UpdateSheetFromGameFile(inputFolder);
            new MantraAssetHandler().UpdateSheetFromGameFile(inputFolder);
            new TalkAssetHandler().UpdateSheetFromGameFile(inputFolder);

            Console.WriteLine("Waiting 10 seconds because of Google API Quotas...");
            Thread.Sleep(10000);

            //OLD HANDLERS
            //Updating TextAssets
            string textAssetFolder = inputFolder + Path.DirectorySeparatorChar + "chs" + Path.DirectorySeparatorChar + "textfiles";
            new AchievementAssetHandler().UpdateSheetFromGameFile(textAssetFolder);
            new AdjustmentAssetHandler().UpdateSheetFromGameFile(textAssetFolder);
            new AlchemyAssetHandler().UpdateSheetFromGameFile(textAssetFolder);
            //new AnimationMappingAssetHandler().UpdateSheetFromGameFile(textAssetFolder);
            new SkillAssetHandler().UpdateSheetFromGameFile(textAssetFolder);
            //Updating battle related Assets
            string battleAssetFolder = inputFolder + Path.DirectorySeparatorChar + "chs" + Path.DirectorySeparatorChar + "battle";
            new BufferAssetHandler().UpdateSheetFromGameFile(battleAssetFolder);
        }

        public static void ExportToMod(string outputFolder)
        {
            //Get input folder path
            string textAssetFolder = outputFolder + Path.DirectorySeparatorChar + "chs" + Path.DirectorySeparatorChar + "textfiles";

            new CharacterBehaviourAssetHandler().BuildGameDataFromSheet(outputFolder);
            Thread.Sleep(3000);
            new BookAssetHandler().BuildGameDataFromSheet(outputFolder);
            Thread.Sleep(3000);
            new BattleAssetHandler().BuildGameDataFromSheet(outputFolder);
            Thread.Sleep(3000);
            new TraitAssetHandler().BuildGameDataFromSheet(outputFolder);
            Thread.Sleep(3000);
            new StringTableAssetHandler().BuildGameDataFromSheet(outputFolder);
            Thread.Sleep(3000);
            new QuestAssetHandler().BuildGameDataFromSheet(outputFolder);
            Thread.Sleep(3000);
            new PropsAssetHandler().BuildGameDataFromSheet(outputFolder);
            Thread.Sleep(3000);
            new NurturanceAssetHandler().BuildGameDataFromSheet(outputFolder);
            Thread.Sleep(3000);
            new EventCubeAssetHandler().BuildGameDataFromSheet(outputFolder);
            Thread.Sleep(3000);
            new NpcAssetHandler().BuildGameDataFromSheet(outputFolder);
            Thread.Sleep(3000);
            new CharacterInfoAssetHandler().BuildGameDataFromSheet(outputFolder);
            Thread.Sleep(3000);
            new BattleAreaAssetHandler().BuildGameDataFromSheet(outputFolder);
            Thread.Sleep(3000);
            new MantraAssetHandler().BuildGameDataFromSheet(outputFolder);
            Thread.Sleep(3000);

            //OLD HANDLERS
            //Exporting TextAssets
            new TalkAssetHandler().BuildGameDataFromSheet(textAssetFolder);
            Thread.Sleep(3000);
            new AchievementAssetHandler().BuildGameDataFromSheet(textAssetFolder);
            Thread.Sleep(3000);
            new AdjustmentAssetHandler().BuildGameDataFromSheet(textAssetFolder);
            Thread.Sleep(3000);
            new AlchemyAssetHandler().BuildGameDataFromSheet(textAssetFolder);
            Thread.Sleep(3000);
            //new AnimationMappingAssetHandler().BuildGameDataFromSheet(textAssetFolder);
            new SkillAssetHandler().BuildGameDataFromSheet(textAssetFolder);
            Thread.Sleep(3000);
            //Exporting battle related Assets
            string battleAssetFolder = outputFolder + Path.DirectorySeparatorChar + "chs" + Path.DirectorySeparatorChar + "battle";
            new BufferAssetHandler().BuildGameDataFromSheet(battleAssetFolder);
        }
    }
}