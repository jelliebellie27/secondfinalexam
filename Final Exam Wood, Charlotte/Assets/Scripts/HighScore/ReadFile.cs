using System.Collections;
using System.Collections.Generic;
using System.IO;


public static class ReadFile
{
    static string filePath = "./Assets/Files/";
    
    public static string readScores()
    {
        string data = "";
        string dataLine;
        StreamReader sr = new StreamReader(filePath + "scores.txt");

        while ((dataLine = sr.ReadLine()) != null)
        {
            data += dataLine + "\n";
        }
        return data;

    }

}
