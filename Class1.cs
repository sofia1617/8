using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        public void Serialize<T>(T data)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files (*.json)|*.json";

            // Показать диалоговое окно выбора файла для сохранения
            bool? result = saveFileDialog.ShowDialog();

            // Если пользователь выбрал файл и нажал "ОК"
            if (result == true)
            {
                string filePath = saveFileDialog.FileName;

                // Сериализация данных в JSON и сохранение в выбранный файл
                string jsonData = JsonConvert.SerializeObject(data);
                File.WriteAllText(filePath, jsonData);
            }
        }

        public T Deserialize<T>()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files (*.json)|*.json";

            // Показать диалоговое окно выбора файла для открытия
            bool? result = openFileDialog.ShowDialog();

            // Если пользователь выбрал файл и нажал "ОК"
            if (result == true)
            {
                string filePath1 = openFileDialog.FileName;

                // Чтение JSON из выбранного файла и десериализация в объект
                string jsonData = File.ReadAllText(filePath1);
                return JsonConvert.DeserializeObject<T>(jsonData);
            }

            return default(T);
        }
    }
}
