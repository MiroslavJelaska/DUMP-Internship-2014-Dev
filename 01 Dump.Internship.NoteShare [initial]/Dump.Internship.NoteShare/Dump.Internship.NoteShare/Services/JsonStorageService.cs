using System.Collections.Generic;
using System.IO;
using System.Web;
using Newtonsoft.Json;

namespace Dump.Internship.NoteShare.Services
{
    public class JsonStorageService<T>
    {
        private readonly string jsonFilePath;

        public JsonStorageService()
        {
            var appDataPath = HttpContext.Current.Server.MapPath("~/App_Data");
            var jsonFileName = typeof (T).Name + ".json";

            this.jsonFilePath = Path.Combine(appDataPath, jsonFileName);
        }

        public IList<T> ReadAll()
        {
            if (!File.Exists(this.jsonFilePath))
            {
                return new List<T>();
            }

            var jsonContent = File.ReadAllText(this.jsonFilePath);
            return JsonConvert.DeserializeObject<IList<T>>(jsonContent);
        }

        public void AddItem(T item)
        {
            var allItems = this.ReadAll();
            allItems.Add(item);

            Save(allItems);
        }

        private void Save(IList<T> allItems)
        {
            var jsonContet = JsonConvert.SerializeObject(allItems);

            File.WriteAllText(this.jsonFilePath, jsonContet);
        }
    }
}