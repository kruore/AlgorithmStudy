using System;
using System.IO;
using System.Collections.Generic;
using System;
using System.IO;
using System.Collections;

using System;
using System.IO;

class Test
{
    public List<string> pathFile_txt = new List<string>();
    public Dictionary<string, Queue<string>> lines = new Dictionary<string, Queue<string>>();

    public static void Main()
    {
        Test test = new Test();
        DirectoryInfo di = new DirectoryInfo("C:\\KINLAB_DATAFIXER\\");
        foreach (FileInfo fileInfo in di.GetFiles("*.txt")) //GetFiles() 적용시 모든 파일을 가져옴
        {
            try
            {
                string sNewFileName = string.Format(@"C:\KINLAB_DATAFIXER\" + System.IO.Path.ChangeExtension(fileInfo.Name, ".txt"));
                string Key = fileInfo.Name;
                Queue<string> datas = new Queue<string>();
                test.lines.Add(Key, datas);
                if (sNewFileName.Contains("_WATCH"))
                {
                    Console.WriteLine(sNewFileName);
                    string line;
                    string result = string.Empty;
                    StreamReader sr = new StreamReader(fileInfo.FullName);
                    while ((line = sr.ReadLine()) != null)                  //line변수에 SR에서 한줄을 읽은 걸 저장, 읽은 줄이 null이 아닐때까지 반복
                    {
                        result += line;                                      //전체 라인 변수에 그 값을 저장
                        result += ";";                                   //표출을 위해서 추가
                    }
                    // Console.WriteLine(result);
                    string[] data = result.Split(';');
                    for (int i = 1; i < data.Length - 1; i++)
                    {
                        string[] lineByLine = data[i].Split(',');
                        if (lineByLine.Length == 12)
                        {
                            bool isRight = true;
                            for (int j = 1; j < lineByLine.Length; j++)
                            {
                                if (j < 3)
                                {
                                    if (lineByLine[j].Length == 13)
                                    {

                                        double a;
                                        isRight = double.TryParse(lineByLine[j], out a);
                                        if (!isRight)
                                        {
                                            Console.WriteLine(data[i]);
                                            isRight = false;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        isRight = false;
                                        break;
                                    }
                                }
                                else if (j == 3)
                                {
                                    if (lineByLine[j].Length == 1)
                                    {
                                        float b;
                                        isRight = float.TryParse(lineByLine[j], out b);
                                        if (!isRight)
                                        {
                                            Console.WriteLine(data[i]);
                                            isRight = false;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        isRight = false;
                                        break;
                                    }
                                }
                                else if (j == 4)
                                {
                                    if (lineByLine[j].Length == 13)
                                    {
                                        double b;
                                        isRight = double.TryParse(lineByLine[j], out b);
                                        if (!isRight)
                                        {
                                            Console.WriteLine(data[i]);
                                            isRight = false;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        isRight = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (lineByLine[j].Length <= 6)
                                    {
                                        float b;
                                        isRight = float.TryParse(lineByLine[j], out b);
                                        if (!isRight)
                                        {
                                            Console.WriteLine(data[i]);
                                            isRight = false;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        isRight = false;
                                        break;
                                    }
                                }
                            }
                            if (isRight)
                            {
                                test.lines[Key].Enqueue(data[i]);
                            }
                            else if (!isRight)
                            {
                                Console.WriteLine("???????????");
                            }

                        }
                        else
                        {
                            Console.WriteLine("ERRORLINE" + data[i]);
                        }
                    }
                }
                else if (sNewFileName.Contains("AirPot"))
                {
                    Console.WriteLine(sNewFileName);
                    string line;
                    string result = string.Empty;
                    StreamReader sr = new StreamReader(fileInfo.FullName);
                    while ((line = sr.ReadLine()) != null)                  //line변수에 SR에서 한줄을 읽은 걸 저장, 읽은 줄이 null이 아닐때까지 반복
                    {
                        result += line;                                      //전체 라인 변수에 그 값을 저장
                        result += ";";                                   //표출을 위해서 추가
                    }
                    // Console.WriteLine(result);
                    string[] data = result.Split(';');
                    for (int i = 1; i < data.Length - 1; i++)
                    {
                        string[] lineByLine = data[i].Split(',');
                        if (lineByLine.Length == 11)
                        {
                            bool isRight = true;
                            for (int j = 1; j < lineByLine.Length; j++)
                            {
                                if (j < 3)
                                {
                                    if (lineByLine[j].Length == 13)
                                    {

                                        double a;
                                        isRight = double.TryParse(lineByLine[j], out a);
                                        if (!isRight)
                                        {
                                            Console.WriteLine(data[i]);
                                            isRight = false;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        isRight = false;
                                        break;
                                    }
                                }
                                else if (j == 3)
                                {
                                    if (lineByLine[j].Length == 1)
                                    {
                                        float b;
                                        isRight = float.TryParse(lineByLine[j], out b);
                                        if (!isRight)
                                        {
                                            Console.WriteLine(data[i]);
                                            isRight = false;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        isRight = false;
                                        break;
                                    }
                                }
                                else if (j == 4)
                                {
                                    if (lineByLine[j].Length == 13)
                                    {
                                        double b;
                                        isRight = double.TryParse(lineByLine[j], out b);
                                        if (!isRight)
                                        {
                                            Console.WriteLine(data[i]);
                                            isRight = false;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        isRight = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (lineByLine[j].Length <= 6)
                                    {
                                        float b;
                                        isRight = float.TryParse(lineByLine[j], out b);
                                        if (!isRight)
                                        {
                                            Console.WriteLine(data[i]);
                                            isRight = false;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        isRight = false;
                                        break;
                                    }
                                }
                            }
                            if (isRight)
                            {
                                test.lines[Key].Enqueue(data[i]);
                            }
                            else if (!isRight)
                            {
                                Console.WriteLine("???????????");
                            }

                        }
                        else
                        {
                            Console.WriteLine("ERRORLINE" + data[i]);
                        }
                    }
                }
                else if (sNewFileName.Contains("_Device"))
                {
                    Console.WriteLine(sNewFileName);
                    string line;
                    string result = string.Empty;
                    StreamReader sr = new StreamReader(fileInfo.FullName);
                    while ((line = sr.ReadLine()) != null)                  //line변수에 SR에서 한줄을 읽은 걸 저장, 읽은 줄이 null이 아닐때까지 반복
                    {
                        result += line;                                      //전체 라인 변수에 그 값을 저장
                        result += ";";                                   //표출을 위해서 추가
                    }
                    // Console.WriteLine(result);
                    string[] data = result.Split(';');
                    for (int i = 1; i < data.Length - 1; i++)
                    {
                        test.lines[Key].Enqueue(data[i]);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex.Message.ToString());
            }

            foreach (var line in test.lines)
            {
                if (line.Key.Contains("WATCH"))
                {
                    test.WriteSteamingData_Batch_WATCH();
                    Console.WriteLine("WATCH DATA");
                }
                else if (line.Key.Contains("AirPot"))
                {
                    test.WriteSteamingData_Batch_AirPot();
                    Console.WriteLine("AIRPOT DATA");
                }
                else if (line.Key.Contains("_Device"))
                {
                    test.WriteSteamingData_Batch_DEVICE();
                    Console.WriteLine("DEVICE DATA");
                }
            }
        }
    }

    bool isCategoryPrinted_W = false;
    bool isCategoryPrinted_A = false;
    bool isCategoryPrinted_D = false;
    private string mainfolder_Path = string.Empty;
    public bool WriteSteamingData_Batch_WATCH()
    {
        bool tempb = false;
        try
        {
            isCategoryPrinted_W = false;
            foreach (var a in lines)
            {
                if (a.Key.Contains("WATCH"))
                {
                    string tempFileName = "C:\\KINLAB_DATAFIXER\\MAKENEW\\" + a.Key;
                    string str_DataCategory = null;
                    string file_Location = tempFileName;
                    string m_str_DataCategory = string.Empty;

                    int totalCountoftheQueue = a.Value.Count;

                    //Debug.Log("Saving Data Starts. Queue Count : " + totalCountoftheQueue);

                    using (StreamWriter streamWriter = File.AppendText(file_Location))
                    {
                        while (lines[a.Key].Count != 0)
                        {
                            string stringData = lines[a.Key].Dequeue();
                            if (lines[a.Key].Count == 0)
                            {
                                string[] splitData = stringData.Split(',');
                                /// <param name="_idx">schema 명</param>
                                /// <param name="_datedata">날짜</param>
                                /// <param name="_weight">무게</param>
                                /// <param name="_count">횟수</param>
                                /// <param name="_time">운동시간</param>
                                /// <param name="_machineindex">머신의 index</param>
                                /// <param name="_exerciseclass">운동종류</param>
                                /// <param name="_mucleclass">운동에 쓰이는 근육</param>
                            }
                            if (stringData.Length > 0)
                            {
                                if (!isCategoryPrinted_W)
                                {
                                    str_DataCategory =
                                    "Device,"
                                    + "PTPTime,"
                                    + "UnixTime,"
                                    + "Protocool,"
                                    + "CurrentDeviceTime,"
                                    + "GyroX,"
                                    + "GyroY,"
                                    + "GyroZ,"
                                    + "AccX,"
                                    + "AccY,"
                                    + "AccZ,"
                                    + "HeartRate";

                                    streamWriter.WriteLine(str_DataCategory);
                                    isCategoryPrinted_W = true;
                                }
                                streamWriter.WriteLine(stringData);
                            }
                        }
                        tempb = true;
                        isCategoryPrinted_W = false;
                    }
                    Console.WriteLine(file_Location);
                }
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(";;;;;;;;;;" + e);
        }
        Console.WriteLine("SAVE");

        return tempb;
    }
    public bool WriteSteamingData_Batch_AirPot()
    {
        bool tempb = false;
        try
        {
            isCategoryPrinted_A = false;
            foreach (var a in lines)
            {
                if (a.Key.Contains("AirPot"))
                {
                    string tempFileName = "C:\\KINLAB_DATAFIXER\\MAKENEW\\" + a.Key;
                    string str_DataCategory = null;
                    string file_Location = tempFileName;
                    string m_str_DataCategory = string.Empty;

                    int totalCountoftheQueue = a.Value.Count;

                    //Debug.Log("Saving Data Starts. Queue Count : " + totalCountoftheQueue);

                    using (StreamWriter streamWriter = File.AppendText(file_Location))
                    {
                        while (lines[a.Key].Count != 0)
                        {
                            string stringData = lines[a.Key].Dequeue();
                            if (lines[a.Key].Count == 0)
                            {
                                string[] splitData = stringData.Split(',');
                                /// <param name="_idx">schema 명</param>
                                /// <param name="_datedata">날짜</param>
                                /// <param name="_weight">무게</param>
                                /// <param name="_count">횟수</param>
                                /// <param name="_time">운동시간</param>
                                /// <param name="_machineindex">머신의 index</param>
                                /// <param name="_exerciseclass">운동종류</param>
                                /// <param name="_mucleclass">운동에 쓰이는 근육</param>
                            }
                            if (stringData.Length > 0)
                            {
                                if (!isCategoryPrinted_A)
                                {
                                    str_DataCategory =

                                    "Device,"
                                + "PTPTime,"
                                + "UnixTime,"
                                + "Protocool,"
                                + "CurrentDeviceTime,"
                                + "GyroX,"
                                + "GyroY,"
                                + "GyroZ,"
                                + "AccX,"
                                + "AccY,"
                                + "AccZ"
                                ;
                                    streamWriter.WriteLine(str_DataCategory);
                                    isCategoryPrinted_A = true;
                                }
                                streamWriter.WriteLine(stringData);
                            }
                        }
                        tempb = true;
                        isCategoryPrinted_A = false;
                    }
                    Console.WriteLine(file_Location);
                }
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(";;;;;;;;;;" + e);
        }
        Console.WriteLine("SAVE");

        return tempb;
    }
    public bool WriteSteamingData_Batch_DEVICE()
    {
        bool tempb = false;
        try
        {
            isCategoryPrinted_D = false;

            foreach (var a in lines)
            {
                if (a.Key.Contains("_Device"))
                {

                    string tempFileName = "C:\\KINLAB_DATAFIXER\\MAKENEW\\" + a.Key;
                    string str_DataCategory = null;
                    string file_Location = tempFileName;
                    string m_str_DataCategory = string.Empty;

                    int totalCountoftheQueue = a.Value.Count;

                    //Debug.Log("Saving Data Starts. Queue Count : " + totalCountoftheQueue);

                    using (StreamWriter streamWriter = File.AppendText(file_Location))
                    {
                        while (lines[a.Key].Count != 0)
                        {
                            string stringData = lines[a.Key].Dequeue();
                            if (lines[a.Key].Count == 0)
                            {
                                string[] splitData = stringData.Split(',');
                                /// <param name="_idx">schema 명</param>
                                /// <param name="_datedata">날짜</param>
                                /// <param name="_weight">무게</param>
                                /// <param name="_count">횟수</param>
                                /// <param name="_time">운동시간</param>
                                /// <param name="_machineindex">머신의 index</param>
                                /// <param name="_exerciseclass">운동종류</param>
                                /// <param name="_mucleclass">운동에 쓰이는 근육</param>
                            }
                            if (stringData.Length > 0)
                            {
                                if (!isCategoryPrinted_D)
                                {
                                    str_DataCategory =
                                   "DeviceName,"
                                   + "PTPTime,"
                                   + "UnixTime,"
                                   + "protocool,"
                                   + "CurrentDeviceTime,"
                                   + "DistanceMM,"
                                   + "DistanceCM,"
                                   + "Weight,"
                                   + "Count,"
                                   + "DistanceADC,"
                                   + "WeightADC,"
                                   + "DeviceName(Current)";
                                    streamWriter.WriteLine(str_DataCategory);
                                    isCategoryPrinted_D = true;
                                }
                                streamWriter.WriteLine(stringData);
                            }
                        }
                        tempb = true;
                        isCategoryPrinted_D = false;
                    }
                    Console.WriteLine(file_Location);
                }
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(";;;;;;;;;;" + e);
        }
        Console.WriteLine("SAVE");

        return tempb;
    }
}
