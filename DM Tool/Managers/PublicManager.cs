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
using DM_Tool.Managers;

namespace DM_Tool
{
    public class PublicManager
    {
        private static  PublicManager instance;

        #region Config File Defines
        private string configFile = "./Files/config.txt";
        private string campaignHash = "##Campaign Name:";
        private string campaignTypeHash = "##Campaign Type:";
        #endregion

        private const string EditionDnD3_5 = "D&D3.5";
        private const string EditionPokemon = "Pokemon";
        private const string EditionDnD5 = "D&D5";
        public static string _campaignName;
        public static string _campaignType;

        public int totalQualityRatios;
        public int totalBaseItemRatios;
        public int totalHardMaterialRatios;

        public enum BABType { [XmlEnum(Name = "POOR")]POOR, [XmlEnum(Name = "AVERAGE")] AVERAGE, [XmlEnum(Name = "GOOD")] GOOD };
        public enum SaveType { [XmlEnum(Name = "POOR")]POOR, [XmlEnum(Name = "GOOD")]GOOD };

        public List<List<string>> listXP;
        public List<AdventureSite> listAdvSites;
        public List<BaseItem> listBaseItems;
        public List<string> listBaseItemNames;
        public List<HardMaterial> listHardMaterials;        
        public List<Quality> listQualities;

        //3.5 guys
        public List<CreatureSize> listCreatureSizes;
        public List<CreatureType> listCreatureTypes;
        public List<Character> listCombinedCharacters;
        public List<Character> listCharacters;
        public List<Character> listCampaignCharacters;
        public List<CharacterClass> listCharacterClasses;

        private static string xmlXPLedger = "./Files/*/XPLedger.xml";
        private static string xmlAdventures = "./Files/*/AdventureSites.xml";
        private static string xmlBaseItems = "./Files/BaseItems.xml";
        private static string xmlCreatureSizes = "./Files/Sizes.xml";
        private static string xmlCreatureTypes = "./Files/CreatureTypes.xml";
        private static string xmlHardMaterials = "./Files/HardMaterials.xml";
        private static string xmlCharacters = "./Files/*/Characters.xml";
        private static string xmlCharacterClasses = "./Files/CharacterClasses.xml";
        private static string xmlQualities = "./Files/Qualitys.xml";
        private static string xmlCalendar = "./Files/*/Calendar.xml";

        private static XmlWriterSettings ws = new XmlWriterSettings();

        private static EditionObject EditionManager;

        private static Calendar _calendar;

        public MainPanel _main;

        private PublicManager()
        {
            totalQualityRatios = 0;
            totalBaseItemRatios = 0;
            totalHardMaterialRatios = 0;

            listXP = new List<List<string>>();
            listBaseItems = new List<BaseItem>();
            listQualities = new List<Quality>();
            listHardMaterials = new List<HardMaterial>();
            listBaseItemNames = new List<string>();
            listAdvSites = new List<AdventureSite>();

            // 3.5 guys
            listCreatureTypes = new List<CreatureType>();
            listCombinedCharacters = new List<Character>();
            listCharacters = new List<Character>();
            listCampaignCharacters = new List<Character>();
            listCharacterClasses = new List<CharacterClass>();
            listCreatureSizes = new List<CreatureSize>();

            CheckConfigFile();
            CheckCampaignConfigFile();
            LoadCampaignInformation();

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

        public string[] GetCharacterNames()
        {
            List<string> names = new List<string>();
            foreach (Character c in listCombinedCharacters)
            {
                names.Add(c.GetName());
            }
            return names.ToArray();
        }

        public Calendar GetCalendar()
        {
            return _calendar;
        }
        #region CampaignInfo
        public void SetCampaignName(string name)
        {
            _campaignName = name;
        }
        public void SetCampaignType(string type)
        {
            _campaignType = type;
        }
        public string GetCampaignName()
        {
            return _campaignName;
        }

        public void LoadCampaign()
        {
            listAdvSites = DeserializeAdventuresFromXML();
            listCampaignCharacters = DeserializeCampaignCharactersFromXML();

            listCombinedCharacters.Clear();
            listCombinedCharacters.AddRange(listCharacters);
            listCombinedCharacters.AddRange(listCampaignCharacters);
            listCombinedCharacters.Sort((p1, p2) => string.Compare(p1.GetName(), p2.GetName(), true));
            _calendar = DeserializeCalendarFromXML();
        }
        #endregion
        #region Config Files
        
        /// <summary>
        /// Read the DMTool config file for default setting information.
        /// </summary>
        public void CheckConfigFile()
        {
            //If no file, create it.
            if (!File.Exists(configFile))
            {
                File.Create(configFile);
            }
            else
            {
                //read in from the config file and determine what the
                //last campaign was set to.
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(configFile);
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains(campaignHash))
                    {
                        _campaignName = line.Split(':')[1];
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
            file.WriteLine(campaignHash + _campaignName);
            file.Close();
        }
        public void CheckCampaignConfigFile()
        {
            string fileName = "./" + "//Files//" + GetCampaignName() + "//config.txt";
            //If no file, create it.
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }
            else
            {
                //read in from the config file and determine what the
                //last campaign was set to.
                string line;
                if(File.Exists(fileName)){
                    System.IO.StreamReader file = new System.IO.StreamReader(fileName);
                    while ((line = file.ReadLine()) != null)
                    {
                        if (line.Contains(campaignHash))
                        {
                            _campaignName = line.Split(':')[1];
                        }
                        if (line.Contains(campaignTypeHash))
                        {
                            _campaignType = line.Split(':')[1];

                            if (_campaignType == EditionDnD3_5)
                            {
                                EditionManager = DnDThirdEdManager.GetInstance();
                            }
                            else if (_campaignType == EditionPokemon)
                            {
                                EditionManager = PTU1_05Manager.GetInstance();
                            }
                        }
                    }
                    file.Close();
                }
            }
        }
        public void WriteCampaignConfigFile()
        {
            string filePath = "./" + "//Files//" + GetCampaignName() + "//config.txt";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(campaignHash + _campaignName);
                sw.WriteLine(campaignTypeHash + _campaignType);
            }
        }     
        #endregion

        public void DisplayCharacters()
        {
            _main.DisplayCharacters();
        }

        public void DisplayCharacterClasses()
        {
            _main.DisplayCharacterClasses();
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
            using (XmlWriter wr = XmlWriter.Create(xmlAdventures.Replace("*", _campaignName), ws))
            {
                serializer.Serialize(wr, sites);
            }
        }

        static public void SerializeCharactersToXML(List<Character> characters)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Character>));
            using (XmlWriter wr = XmlWriter.Create(xmlCharacters.Replace("*", ""), ws))
            {
                serializer.Serialize(wr, characters);
            }
        }

        static public void SerializeCampaignCharactersToXML(List<Character> characters)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Character>));
            using (XmlWriter wr = XmlWriter.Create(xmlCharacters.Replace("*", _campaignName), ws))
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

        static public void SerializeXPLedgerToXML(List<List<string>> xpList)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<List<string>>));
            using (XmlWriter wr = XmlWriter.Create(xmlXPLedger.Replace("*", _campaignName), ws))
            {
                serializer.Serialize(wr, xpList);
            }
        }

        static public void SerializeCalendarToXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Calendar));
            using (XmlWriter wr = XmlWriter.Create(xmlCalendar.Replace("*", _campaignName), ws))
            {
                serializer.Serialize(wr, _calendar);
            }
        }

        #endregion

        #region Deserialization

        public void LoadCampaignInformation()
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

            _calendar = DeserializeCalendarFromXML();
        }

        static public List<AdventureSite> DeserializeAdventuresFromXML()
        {
            List<AdventureSite> advs = new List<AdventureSite>();
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<AdventureSite>));
                TextReader textReader = new StreamReader(xmlAdventures.Replace("*", _campaignName));
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
                TextReader textReader = new StreamReader(xmlCharacters.Replace("*/", ""));
                characters = (List<Character>)deserializer.Deserialize(textReader);
                textReader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return characters;
        }

        static public List<Character> DeserializeCampaignCharactersFromXML()
        {
            List<Character> characters = new List<Character>();
            try
            {
                string name = xmlCharacters.Replace("*", _campaignName);
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Character>));
                TextReader textReader = new StreamReader(name);
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

        static public Calendar DeserializeCalendarFromXML()
        {
            Calendar cal = new Calendar();
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Calendar));
                TextReader textReader = new StreamReader(xmlCalendar.Replace("*", _campaignName));
                cal = (Calendar)deserializer.Deserialize(textReader);
                textReader.Close();
            }
            catch
            {
            }

            return cal;
        }

        static public List<List<string>> DeserializeXPLedgerFromXML()
        {
            List<List<string>> xpLedger = new List<List<string>>();
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<List<string>>));
                TextReader textReader = new StreamReader(xmlXPLedger.Replace("*", _campaignName));
                xpLedger = (List<List<string>>)deserializer.Deserialize(textReader);
                textReader.Close();
            }
            catch
            {
            }

            return xpLedger;
        }
        #endregion

        public List<Character> GetRightCharacterList(Character c)
        {
            if (c._campaignSpecific)
            {
                return listCampaignCharacters;
            }
            else
            {
                return listCharacters;
            }
        }

        public List<String> GetBaseMenuEntries()
        {
            if (EditionManager != null)
            {
                return EditionManager.GetBaseMenuItems();
            }
            else
            {
                return new List<String>();
            }
        }
    }
}
