using System;
using System.IO;

namespace DiffTestAlgorithm
{
    class FileReaderFunc
    {
        //
        //
        ulong fFilePosition = 0;
        ulong sFilePosition = 0;
        //
        //
        byte[] ByteArrayInit(string path)
        {
            using (FileStream fileStream = File.OpenRead(path))
            {
                byte[] fileByteArray = new byte[fileStream.Length];
                fileStream.Read(fileByteArray);
                return fileByteArray;
            }
        }
        ulong StringCounter(byte[] fileByteArray)
        {
            ulong count = 0;
            for(int i = 0; i < fileByteArray.Length; i++)
            {
                if (fileByteArray[i] == (byte)'\n' || i == fileByteArray.Length - 1)
                {
                    count++;
                }
            }
            return count;
        }
        string fStringParser(byte[] fileByteArray, ulong fileByteArrayLength, ulong position)
        {
            byte[] stringByteArray = new byte[fileByteArray.Length];
            string fileOutputString = "";
            for(ulong i = position; position < fileByteArrayLength; i++)
            {
                if (i == Convert.ToUInt64(fileByteArray.Length) - 1)
                {
                    stringByteArray[i] = fileByteArray[i];
                    fileOutputString = System.Text.Encoding.UTF8.GetString(stringByteArray);
                    break;
                }
                if (fileByteArray[i] == (byte)'\n')
                {
                    fileOutputString = System.Text.Encoding.UTF8.GetString(stringByteArray);
                    i++;
                    fFilePosition = i;
                    break;
                }
                if (fileByteArray[i] != (byte)'\n')
                {
                    stringByteArray[i] = fileByteArray[i];
                }
            }
            return fileOutputString;
        }
        string sStringParser(byte[] fileByteArray, ulong fileByteArrayLength, ulong position)
        {
            byte[] stringByteArray = new byte[fileByteArray.Length];
            string fileOutputString = "";
            for (ulong i = position; position < fileByteArrayLength; i++)
            {
                if (i == Convert.ToUInt64(fileByteArray.Length) - 1)
                {
                    stringByteArray[i] = fileByteArray[i];
                    fileOutputString = System.Text.Encoding.UTF8.GetString(stringByteArray);
                    break;
                }
                if (fileByteArray[i] == (byte)'\n')
                {
                    fileOutputString = System.Text.Encoding.UTF8.GetString(stringByteArray);
                    i++;
                    sFilePosition = i;
                    break;
                }
                if (fileByteArray[i] != (byte)'\n')
                {
                    stringByteArray[i] = fileByteArray[i];
                }

            }
            return fileOutputString;
        }
        public void FileReadingStream(string firstFilePath, string secondFilePath)
        {
            RendererFunctions renderer = new RendererFunctions();

            byte[] fFileByteArray = ByteArrayInit(firstFilePath);
            byte[] sFileByteArray = ByteArrayInit(secondFilePath);

            ulong fCount = StringCounter(fFileByteArray);
            ulong sCount = StringCounter(sFileByteArray);

            if (fCount >= sCount)
            {
                for (ulong i = 0; i < fCount; i++)
                {
                    if (i < sCount)
                        renderer.Reader(fStringParser(fFileByteArray, Convert.ToUInt64(fFileByteArray.Length), fFilePosition),
                            sStringParser(sFileByteArray, Convert.ToUInt64(sFileByteArray.Length), sFilePosition));
                    else
                        renderer.AdditionLineReader(fStringParser(fFileByteArray, Convert.ToUInt64(fFileByteArray.Length), fFilePosition));
                }
            }
            else
            {
                for (ulong i = 0; i < sCount; i++)
                {
                    if (i < fCount)
                        renderer.Reader(fStringParser(fFileByteArray, Convert.ToUInt64(fFileByteArray.Length), fFilePosition),
                            sStringParser(sFileByteArray, Convert.ToUInt64(sFileByteArray.Length), sFilePosition));
                    else
                        renderer.AdditionLineReader(sStringParser(sFileByteArray, Convert.ToUInt64(sFileByteArray.Length), sFilePosition));
                }
            }


        }

    }
        
    
}