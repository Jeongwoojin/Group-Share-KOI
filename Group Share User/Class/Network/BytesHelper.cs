using System;
using System.Text;
public class BytesHelper
{
    //오른쪽 bytes 공백제거
    static public byte[] ArrayRTrim(byte[] arr)
    {
        byte[] rArr;
        int rLen = 0;
        for (int i = arr.Length - 1; i > 0; i--)
        {
            if (arr[i] == 0)
            {
                rLen++;
            }
            else
            {
                break;
            }
        }
        rArr = new byte[arr.Length - rLen];

        Array.Copy(arr, rArr, rArr.Length);
        return rArr;
    }
    //왼쪽공백 제거
    static public byte[] ArrLTrim(byte[] bytes)
    {
        int Len = 0;
        byte[]   LTrimBytes;
        for (int i = 0; i < bytes.Length - 1; i++)
        {
            if (bytes[i] != 0)
            {
                Len++;
            }
            else
            {
                break;
            }
        }
        LTrimBytes = new byte[bytes.Length - Len];
        Array.Copy(bytes, LTrimBytes, LTrimBytes.Length);
        return LTrimBytes; 
    }
    //양쪽 공백제거
    static public byte[] ArrayTrim(byte[] arr)
    {
        arr = ArrLTrim(arr);
        arr = ArrayRTrim(arr);
        return arr;
    }
}
