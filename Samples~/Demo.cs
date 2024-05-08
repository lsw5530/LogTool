using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    void Start()
    {
        LogConfig cfg = new LogConfig
        {
            enableLog = true,
            logPrefix = "",
            enableTime = true,
            logSeparate = ">",
            enableThreadID = true,
            enableTrace = false,
            enableSave = true,
            enableCover = true,
            savePath = Application.persistentDataPath + "/LogTool/",
            saveName = "ClientLogTool.txt",
            loggerEnum = LoggerType.Unity,
        };
        LogTool.InitSettings(cfg);
        LogTool.ColorLog(LogColor.Red, "Color Log:Red.");
        LogTool.ColorLog(LogColor.Green, "Color Log:Green.");
        LogTool.ColorLog(LogColor.Blue, "Color Log:Blue.");
        LogTool.ColorLog(LogColor.Cyan, "Color Log:Cyan.");
        LogTool.ColorLog(LogColor.Magenta, "Color Log:Magenta.");
        LogTool.ColorLog(LogColor.Yellow, "Color Log:Yellow.");
    } 
    
}
