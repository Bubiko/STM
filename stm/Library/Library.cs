using System.IO;
using System.Collections.Generic;
using System.CodeDom;

public class Library
{
    public List<string> GamesPaths = new List<string>();
    private List<string> ManifestFiles = new List<string>();

    //Game infos
    public List<int> GamesAppID = new List<int>();
    public List<string> GameName = new List<string>();
    public List<short> GameState = new List<short>();
    public List<string> GameOwner = new List<string>();


    public void LibraryIntializa()
    {
        GetPaths();
        GetManifestFiles();
        ReadAndSortManifestFile();
    }
    private void GetPaths()
    {
        //steamu lu mamma ca nu face uptade la asta daca ramai fara hdd
        //Do NOT remove a storage device if is somehow with steam
        string temp;
        foreach (string line in File.ReadAllLines("C:/Program Files (x86)/Steam/config/libraryfolders.vdf"))
        {
            if (line.Contains("\t\t\"path\"\t\t"))
            {
                temp = line.Remove(0,11);
                temp = temp.Replace("\"","");
                temp = temp.Replace("\\\\","/");
                temp = temp + "/steamapps";
                GamesPaths.Add(temp);
            }
        }
    }
    private void GetManifestFiles()
    {
        string[] ManifestFile;
        for (int i = 0; i < GamesPaths.Count; i++)
        {
            ManifestFile = Directory.GetFiles(GamesPaths[i], "*.acf", SearchOption.TopDirectoryOnly);
            foreach(string line in ManifestFile) 
            {
                ManifestFiles.Add(line);
            }
        }
    }

    private void ReadAndSortManifestFile()
    {
        string temp;
        for(int i =0;i<ManifestFiles.Count;i++)
        {
            foreach(string line in File.ReadAllLines(ManifestFiles[i]))
            {
                if(line.Contains("appid"))
                {
                    temp = line.Remove(0, 11);
                    temp = temp.Remove(temp.Length -1,1);
                    GamesAppID.Add(int.Parse(temp));
                }
                if(line.Contains("name"))
                {
                    temp = line.Remove(0, 10);
                    temp = temp.Remove(temp.Length - 1, 1);
                    GameName.Add(temp);
                }
                if (line.Contains("StateFlags"))
                {
                    temp = line.Remove(0, 16);
                    temp = temp.Remove(temp.Length - 1, 1);
                    GameState.Add(short.Parse(temp));
                }
                if (line.Contains("LastOwner"))
                {
                    temp = line.Remove(0, 15);
                    temp = temp.Remove(temp.Length - 1, 1);
                    GameOwner.Add(temp);
                    break;
                }
            }
        }
    }


    public string GiveMeTheGamePath(int AppID)
    {
        foreach(var c in ManifestFiles)
        {
            if (c.Contains(AppID.ToString()))
            {
                return c;
            }
        }
        return "No steamAPI dll found!";
    }
    
}