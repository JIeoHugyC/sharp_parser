// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using sharp_parser;

const string usersFileName = "regular_users";

foreach (var file in Directory.GetFiles(Directory.GetCurrentDirectory() + "../../../../test"))
{
    string yamlFile = "";
    string jsonFile = "";
    if (file.Contains(usersFileName + ".yaml"))
    {
        yamlFile = File.ReadAllText(file);
    }

    if (file.Contains(usersFileName + ".json"))
    {
        jsonFile = File.ReadAllText(file);
    }

    var user = JsonConvert.DeserializeObject(jsonFile);
    Console.Write(user);

}
