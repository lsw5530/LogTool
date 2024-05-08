using UnityEngine;

class Root {
    public void Init() {
        LogTool.Log("Init Root Log.");
        Mgr mgr = new Mgr();
        mgr.Init();
    }
}
class Mgr {
    public void Init() {
        LogTool.Warn("Init Mgr Warn");
        Item item = new Item();
        item.Init();
    }
}
class Item {
    public void Init() {
        LogTool.Error("Init Item Error");
        LogTool.Trace("Trace This Function.");
    }
}

public class GameStart : MonoBehaviour {
    void Start() {
        LogConfig cfg = new LogConfig {
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

        //LogTool.Log("{0} start...", "ServerLogTool");
        LogTool.ColorLog(LogColor.Red, "Color Log:Red.");
        LogTool.ColorLog(LogColor.Green, "Color Log:Green.");
        LogTool.ColorLog(LogColor.Blue, "Color Log:Blue.");
        LogTool.ColorLog(LogColor.Cyan, "Color Log:Cyan.");
        LogTool.ColorLog(LogColor.Magenta, "Color Log:Magenta.");
        LogTool.ColorLog(LogColor.Yellow, "Color Log:Yellow.");

        Root rt = new Root();
        rt.Init();
    }
}
