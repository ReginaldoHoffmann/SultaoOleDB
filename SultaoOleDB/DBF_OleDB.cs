using System;
using System.Runtime.InteropServices;

namespace SultaoOleDB
{
    [InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("85a96db6-15a9-4c62-9e73-a8e12f381cc4")]
    public interface IDBF_OleDB
    {
        string OlaMundo();
    }

    [ClassInterface(ClassInterfaceType.None), Guid("5e204233-2cdd-4be4-b41c-2dd6c4f06b2f"), ProgId("SultaoOleDB.DBF_OleDB")]
    public class DBF_OleDB : IDBF_OleDB
    {
        public string OlaMundo()
        {
            return DateTime.Now.ToString();
        }
    }
}
