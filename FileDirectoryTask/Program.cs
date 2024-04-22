namespace FileDirectoryTask
{
    internal class Program
    {

        private static string File = "names.json";
        private static List<string> names = new List<string>();
        static void Main(string[] args)
        {
            
        }
        static void LoadData()
        {
            if (File.(File))
            {
                string json = File.ReadAllText(File);
                names = DeserializeObject<List<string>>(json);
            }
        }
        static void SaveData()
        {
            string json = JsonConvert.SerializeObject(names);
            File.WriteAllLines (File, json);
        }
        static void Add(string name)
        {
            LoadData(); 
            names.Add(name);
            SaveData();
        }
        static bool Search(string name)
        {
            LoadData(); 
            return names.Contains(name);
        }
        static void Delete(int index)
        {
            LoadData();
            if (index >= 0 && index < names.Count)
            {
                names.RemoveAt(index);
                SaveData();
            }
            else
            {
                Console.WriteLine("Index out of range.");
            }


        }
}