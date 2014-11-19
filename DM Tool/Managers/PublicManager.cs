﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using DM_Tool.Classes;
using DM_Tool.Controls;

namespace DM_Tool
{
    public class PublicManager
    {
        private static  PublicManager instance;

        private string configFile = "./config.txt";
        private string campaignHash = "##Campaign Name:";
        public string Campaign;

        public int totalQualityRatios;
        public int totalBaseItemRatios;
        public int totalHardMaterialRatios;

        public enum BABType { [XmlEnum(Name = "POOR")]POOR, [XmlEnum(Name = "AVERAGE")] AVERAGE, [XmlEnum(Name = "GOOD")] GOOD };
        public enum SaveType { [XmlEnum(Name = "POOR")]POOR, [XmlEnum(Name = "GOOD")]GOOD };

        public List<AdventureSite> listAdvSites;
        public List<BaseItem> listBaseItems;
        public List<string> listBaseItemNames;
        public List<CreatureSize> listCreatureSizes;
        public List<CreatureType> listCreatureTypes;
        public List<HardMaterial> listHardMaterials;
        public List<CharacterSheet> listCharacterSheets;
        public List<Quality> listQualities;
        
        private static string xmlAdventures = "AdventureSites.xml";
        public static string xmlBaseItems = "BaseItems.xml";
        private static string xmlCreatureSizes = "Sizes.xml";
        private static string xmlCreatureTypes = "CreatureTypes.xml";
        private static string xmlHardMaterials = "HardMaterials.xml";
        private static string xmlCharacterSheets = "Monsters.xml";
        private static string xmlQualities = "Qualitys.xml";

        public MainPanel _main;

        private PublicManager()
        {
            totalQualityRatios = 0;
            totalBaseItemRatios = 0;
            totalHardMaterialRatios = 0;
            ConfigFile();
        }

        public static PublicManager GetInstance(){
            if (instance == null)
            {
                instance = new PublicManager();
            }
            return instance;
        }

        public void SetMain(MainPanel main){
            _main = main;
        }

        #region Config File
        public void ConfigFile()
        {
            if (!File.Exists(configFile))
            {
                File.Create(configFile);
            }
            else
            {
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(configFile);
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains(campaignHash))
                    {
                        Campaign = line.Split(':')[1];
                        xmlAdventures = Campaign + "\\" + xmlAdventures;
                    }
                }
                file.Close();
            }
        }

        public void WriteConfigFile()
        {
            if (!File.Exists(configFile))
            {
                File.Delete(configFile);
            }
            System.IO.StreamWriter file = new System.IO.StreamWriter(configFile);
            file.WriteLine(campaignHash + Campaign);
            file.Close();
        }
        #endregion

        public void DisplayCreatures()
        {
            _main.DisplayCreatures();
        }

        public void DisplayAdvSites()
        {
            _main.DisplayAdventureSites();
        }

        public void NewTab(string controlType, string name)
        {
            TabPage page = new TabPage(name);
            switch (controlType)
            {
                case "Type":
                    TypeControl tc = new TypeControl(listCreatureTypes.Find(x => x.name.Equals(name)));
                    page.Controls.Add(tc);
                    tc.Dock = DockStyle.Fill;
                    break;
                case "Monster":
                    MonsterControl m = new MonsterControl(page, listCharacterSheets.Find(x => x.name.Equals(name)));
                    page.Controls.Add(m);
                    m.Dock = DockStyle.Fill;
                    break;
                case "AdventureSite":
                    AdventureSiteControl adv = new AdventureSiteControl(page, listAdvSites.Find(x => x.GetName().Equals(name)), _main);
                    page.Controls.Add(adv);
                    adv.Dock = DockStyle.Fill;
                    break;
                default:
                    break;

            }

            page.AutoScroll = true;
            page.AutoScrollMargin = new System.Drawing.Size(20, 20);
            page.AutoScrollMinSize = new System.Drawing.Size(page.Width, page.Height);
            _main.AddOrSelectPage(page);
        }

        #region Serialization

        public void Save()
        {
            SerializeMonstersToXML(listCharacterSheets);
            SerializeAdventuresToXML(listAdvSites);
            SerializeCreatureSizesToXML(listCreatureSizes);
            SerializeCreatureTypesToXML(listCreatureTypes);
            SerializeQualitiesToXML(listQualities);
            SerializeBaseItemsToXML(listBaseItems);
            SerializeHardMaterialsToXML(listHardMaterials);
        }

        static public void SerializeAdventuresToXML(List<AdventureSite> sites)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<AdventureSite>));
            TextWriter textWriter = new StreamWriter(xmlAdventures);
            serializer.Serialize(textWriter, sites);
            textWriter.Close();
        }

        static public void SerializeMonstersToXML(List<CharacterSheet> sites)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<CharacterSheet>));
            TextWriter textWriter = new StreamWriter(xmlCharacterSheets);
            serializer.Serialize(textWriter, sites);
            textWriter.Close();
        }

        static public void SerializeCreatureTypesToXML(List<CreatureType> sites)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<CreatureType>));
            TextWriter textWriter = new StreamWriter(xmlCreatureTypes);
            serializer.Serialize(textWriter, sites);
            textWriter.Close();
        }

        static public void SerializeQualitiesToXML(List<Quality> sites)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Quality>));
            TextWriter textWriter = new StreamWriter(xmlQualities);
            serializer.Serialize(textWriter, sites);
            textWriter.Close();
        }

        static public void SerializeCreatureSizesToXML(List<CreatureSize> sites)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<CreatureSize>));
            TextWriter textWriter = new StreamWriter(xmlCreatureSizes);
            serializer.Serialize(textWriter, sites);
            textWriter.Close();
        }

        static public void SerializeHardMaterialsToXML(List<HardMaterial> sites)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<HardMaterial>));
            TextWriter textWriter = new StreamWriter(xmlHardMaterials);
            serializer.Serialize(textWriter, sites);
            textWriter.Close();
        }

        static public void SerializeBaseItemsToXML(List<BaseItem> sites)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<BaseItem>));
            TextWriter textWriter = new StreamWriter(xmlBaseItems);
            serializer.Serialize(textWriter, sites);
            textWriter.Close();
        }

        #endregion

        #region Deserialization

        public void Load(string Campaign)
        {
            listCreatureTypes = DeserializeCreatureTypesFromXML();
            listCharacterSheets = DeserializeMonstersFromXML();
            listQualities = DeserializeQualitiesFromXML();
            listAdvSites = DeserializeAdventuresFromXML();
            listHardMaterials = DeserializeHardMaterialsFromXML();
            listBaseItems = DeserializeBaseItemsFromXML();
            listCreatureSizes = DeserializeCreatureSizesFromXML();

            foreach (BaseItem i in listBaseItems)
            {
                listBaseItemNames.Add(i.name);
            }
        }

        static public List<AdventureSite> DeserializeAdventuresFromXML()
        {
            List<AdventureSite> advs = new List<AdventureSite>();
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<AdventureSite>));
                TextReader textReader = new StreamReader(xmlAdventures);
                advs = (List<AdventureSite>)deserializer.Deserialize(textReader);
                textReader.Close();

            }
            catch
            {
            }

            return advs;
        }

        static public List<CharacterSheet> DeserializeMonstersFromXML()
        {
            List<CharacterSheet> monsters = new List<CharacterSheet>();
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<CharacterSheet>));
                TextReader textReader = new StreamReader(xmlCharacterSheets);
                monsters = (List<CharacterSheet>)deserializer.Deserialize(textReader);
                textReader.Close();
            }
            catch
            {
            }

            return monsters;
        }

        static public List<CreatureType> DeserializeCreatureTypesFromXML()
        {
            List<CreatureType> advs = new List<CreatureType>();
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<CreatureType>));
                TextReader textReader = new StreamReader(xmlCreatureTypes);
                advs = (List<CreatureType>)deserializer.Deserialize(textReader);
                textReader.Close();

            }
            catch
            {
            }

            return advs;
        }

        static public List<Quality> DeserializeQualitiesFromXML()
        {
            List<Quality> advs = new List<Quality>();
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Quality>));
                TextReader textReader = new StreamReader(xmlQualities);
                advs = (List<Quality>)deserializer.Deserialize(textReader);
                textReader.Close();
            }
            catch
            {
            }

            return advs;
        }

        static public List<CreatureSize> DeserializeCreatureSizesFromXML()
        {
            List<CreatureSize> advs = new List<CreatureSize>();
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<CreatureSize>));
                TextReader textReader = new StreamReader(xmlCreatureSizes);
                advs = (List<CreatureSize>)deserializer.Deserialize(textReader);
                textReader.Close();
            }
            catch
            {
            }

            return advs;
        }

        static public List<HardMaterial> DeserializeHardMaterialsFromXML()
        {
            List<HardMaterial> advs = new List<HardMaterial>();
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<HardMaterial>));
                TextReader textReader = new StreamReader(xmlHardMaterials);
                advs = (List<HardMaterial>)deserializer.Deserialize(textReader);
                textReader.Close();
            }
            catch
            {
            }

            return advs;
        }

        static public List<BaseItem> DeserializeBaseItemsFromXML()
        {
            List<BaseItem> advs = new List<BaseItem>();
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<BaseItem>));
                TextReader textReader = new StreamReader(xmlBaseItems);
                advs = (List<BaseItem>)deserializer.Deserialize(textReader);
                textReader.Close();
            }
            catch
            {
            }

            return advs;
        }
        #endregion
    }
}