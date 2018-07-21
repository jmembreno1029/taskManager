using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using taskmanager;

public class Reading
{
    public static string ReadTextLineFromConsole()
    {
        return Console.ReadLine();
    }
    public static int ReadInt32FromConsole()
    {
        try
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            return -1;
        }
        }
    }