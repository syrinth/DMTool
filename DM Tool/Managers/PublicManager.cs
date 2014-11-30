using System;
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
        public List<Character> listCombinedCharacters;
        public List<Character> listCharacters;
        public List<Character> listCampaignCharacters;
        public List<CharacterClass> listCharacterClasses;
        public List<Quality> listQualities;

        private static string Campaign;
        private static string xmlAdventures = "AdventureSites.xml";
        private static string xmlBaseItems = "BaseItems.xml";
        private static string xmlCreatureSizes = "Sizes.xml";
        private static string xmlCreatureTypes = "CreatureTypes.xml";
        private static string xmlHardMaterials = "HardMaterials.xml";
        private static string xmlCharacters = "Characters.xml";
        private static string xmlCharacterClasses = "CharacterClasses.xml";
        private static string xmlQualities = "Qualitys.xml";

        private static XmlWriterSettings ws = new XmlWriterSettings();

        public MainPanel _main;

        private PublicManager()
        {
            totalQualityRatios = 0;
            totalBaseItemRatios = 0;
            totalHardMaterialRatios = 0;
            ConfigFile();
            ws.NewLineHandling = NewLineHandling.Entitize;
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

        #region CampaignInfo
        public void SetCampaign(string val)
        {
            Campaign = val;
        }

        public string GetCampaign()
        {
            return Campaign;
        }

        public void LoadCampaign()
        {
            listAdvSites = DeserializeAdventuresFromXML();
        }
        #endregion
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

        public void DisplayCharacters()
        {
            _main.DisplayCharacters();
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
                case "Character":
                    CharacterControl m = new CharacterControl(page, listCombinedCharacters.Find(x => x.GetName().Equals(name)));
                    page.Controls.Add(m);
                    m.Dock = DockStyle.Fill;
                    break;
                case "Character Class":
                    CharacterClass cc = listCharacterClasses.Find(x => x.name.Equals(name));
                    CharacterClassControl charClass;
                    if (cc == null)
                    {
                        charClass = new CharacterClassControl(page, name);
                    }
                    else{
                        charClass = new CharacterClassControl(page, cc);
                    }
                    page.Controls.Add(charClass);
                    charClass.Dock = DockStyle.Fill;
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
            SerializeCharactersToXML(listCharacters);
            SerializeCampaignCharactersToXML(listCampaignCharacters);
            SerializeAdventuresToXML(listAdvSites);
            SerializeCreatureSizesToXML(listCreatureSizes);
            SerializeCreatureTypesToXML(listCreatureTypes);
            SerializeQualitiesToXML(listQualities);
            SerializeBaseItemsToXML(listBaseItems);
            SerializeHardMaterialsToXML(listHardMaterials);
            SerializeCharacterClassesToXML(listCharacterClasses);
        }

        static public void SerializeAdventuresToXML(List<AdventureSite> sites)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<AdventureSite>));
            using (XmlWriter wr = XmlWriter.Create(Campaign + "\\" + xmlAdventures, ws))
            {
                serializer.Serialize(wr, sites);
            }
        }

        static public void SerializeCharactersToXML(List<Character> characters)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Character>));
            using (XmlWriter wr = XmlWriter.Create(xmlCharacters, ws))
            {
                serializer.Serialize(wr, characters);
            }
        }

        static public void SerializeCampaignCharactersToXML(List<Character> characters)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Character>));
            using (XmlWriter wr = XmlWriter.Create(Campaign + "\\" + xmlCharacters, ws))
            {
                serializer.Serialize(wr, characters);
            }
        }

        static public void SerializeCreatureTypesToXML(List<CreatureType> sites)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<CreatureType>));
            using (XmlWriter wr = XmlWriter.Create(xmlCreatureTypes, ws))
            {
                serializer.Serialize(wr, sites);
            }
        }

        static public void SerializeQualitiesToXML(List<Quality> sites)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Quality>));
            using (XmlWriter wr = XmlWriter.Create(xmlQualities, ws))
            {
                serializer.Serialize(wr, sites);
            }
        }

        static public void SerializeCreatureSizesToXML(List<CreatureSize> sites)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<CreatureSize>));
            using (XmlWriter wr = XmlWriter.Create(xmlCreatureSizes, ws))
            {
                serializer.Serialize(wr, sites);
            }
        }

        static public void SerializeHardMaterialsToXML(List<HardMaterial> sites)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<HardMaterial>));
            using (XmlWriter wr = XmlWriter.Create(xmlHardMaterials, ws))
            {
                serializer.Serialize(wr, sites);
            }
        }

        static public void SerializeBaseItemsToXML(List<BaseItem> sites)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<BaseItem>));
            using (XmlWriter wr = XmlWriter.Create(xmlBaseItems, ws))
            {
                serializer.Serialize(wr, sites);
            }
        }

        static public void SerializeCharacterClassesToXML(List<CharacterClass> sites)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<CharacterClass>));
            using (XmlWriter wr = XmlWriter.Create(xmlCharacterClasses, ws))
            {
                serializer.Serialize(wr, sites);
            }
        }

        #endregion

        #region Deserialization

        public void LoadDefault()
        {
            listCreatureTypes = DeserializeCreatureTypesFromXML();
            listCharacters = DeserializeCharactersFromXML();
            listCampaignCharacters = DeserializeCampaignCharactersFromXML();
            listQualities = DeserializeQualitiesFromXML();
            listAdvSites = DeserializeAdventuresFromXML();
            listHardMaterials = DeserializeHardMaterialsFromXML();
            listBaseItems = DeserializeBaseItemsFromXML();
            listCreatureSizes = DeserializeCreatureSizesFromXML();
            listCharacterClasses = DeserializeCharacterClassesFromXML();

            foreach (BaseItem i in listBaseItems)
            {
                listBaseItemNames.Add(i.name);
            }

            listCombinedCharacters.Clear();
            listCombinedCharacters.AddRange(listCharacters);
            listCombinedCharacters.AddRange(listCampaignCharacters);
        }

        static public List<AdventureSite> DeserializeAdventuresFromXML()
        {
            List<AdventureSite> advs = new List<AdventureSite>();
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<AdventureSite>));
                TextReader textReader = new StreamReader(Campaign + "\\" + xmlAdventures);
                advs = (List<AdventureSite>)deserializer.Deserialize(textReader);
                textReader.Close();

            }
            catch
            {
            }

            return advs;
        }

        static public List<Character> DeserializeCharactersFromXML()
        {
            List<Character> characters = new List<Character>();
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Character>));
                TextReader textReader = new StreamReader(xmlCharacters);
                characters = (List<Character>)deserializer.Deserialize(textReader);
                textReader.Close();
            }
            catch
            {
            }

            return characters;
        }

        static public List<Character> DeserializeCampaignCharactersFromXML()
        {
            List<Character> characters = new List<Character>();
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Character>));
                TextReader textReader = new StreamReader(Campaign + "\\" + xmlCharacters);
                characters = (List<Character>)deserializer.Deserialize(textReader);
                textReader.Close();
            }
            catch
            {
            }

            return characters;
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

        static public List<CharacterClass> DeserializeCharacterClassesFromXML()
        {
            List<CharacterClass> advs = new List<CharacterClass>();
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<CharacterClass>));
                TextReader textReader = new StreamReader(xmlCharacterClasses);
                advs = (List<CharacterClass>)deserializer.Deserialize(textReader);
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
