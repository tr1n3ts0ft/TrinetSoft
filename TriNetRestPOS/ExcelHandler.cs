// Decompiled with JetBrains decompiler
// Type: TriNetRestPOS.ExcelHandler
// Assembly: TriNetRestPOS, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 43377352-E952-4AC1-9BA6-CCBE4AE5F575
// Assembly location: C:\log\TriNetRestPOS.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;

namespace TriNetRestPOS
{
  public class ExcelHandler
  {
    public DataSet GetDataFromExcel(string a_sFilepath, int pintOpcion)
    {
      DataSet dataSet = new DataSet();
      OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + a_sFilepath + ";Extended Properties=Excel 8.0;");
      try
      {
        selectConnection.Open();
      }
      catch (OleDbException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        OleDbException oleDbException = ex;
        Console.WriteLine(oleDbException.Message);
        ModGeneralFunctions.MessageMistake(oleDbException.Message);
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        Console.WriteLine(exception.Message);
        ModGeneralFunctions.MessageMistake(exception.Message);
        ProjectData.ClearProjectError();
      }
      DataTable dataTable = new DataTable();
      DataTable oleDbSchemaTable = selectConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, (object[]) null);
      if (oleDbSchemaTable != null || oleDbSchemaTable.Rows.Count > 0)
      {
        int index = 0;
        do
        {
          try
          {
            string srcTable = oleDbSchemaTable.Rows[index]["table_name"].ToString();
            string selectCommandText = "";
            switch (pintOpcion)
            {
              case 1:
                selectCommandText = "SELECT 'Esperando ...' AS ESTADO,* FROM [" + srcTable + "] ";
                break;
              case 2:
                selectCommandText = "SELECT 'Esperando ...' AS ESTADO,GRUPO,SUBGRUPO,CODIGO AS COD,NOMBRE,MARCA,MODELO,COLOR,TACO,TALLA,FORMAT(P_COMPRA_C_IGV,\"0.00\") as P_COMPRA,FORMAT(P_VENTA_C_IGV,\"0.00\") as P_VENTA,U_M,COD_BARRAS,AREA1,AREA2,CANTIDAD,PRECIO,AFECTO_IGV FROM [" + srcTable + "] ";
                break;
            }
            new OleDbDataAdapter(selectCommandText, selectConnection).Fill(dataSet, srcTable);
          }
          catch (DataException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            DataException dataException = ex;
            Console.WriteLine(dataException.Message);
            ModGeneralFunctions.MessageMistake(dataException.Message);
            ProjectData.ClearProjectError();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            Console.WriteLine(exception.Message);
            ModGeneralFunctions.MessageMistake(exception.Message);
            ProjectData.ClearProjectError();
          }
          checked { ++index; }
        }
        while (index <= 0);
      }
      selectConnection.Close();
      return dataSet;
    }

    public DataSet GetDataFromExcel1(string a_sFilepath, int pintOpcion)
    {
      DataSet dataSet = new DataSet();
      OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + a_sFilepath + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"");
      try
      {
        selectConnection.Open();
      }
      catch (OleDbException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        OleDbException oleDbException = ex;
        Console.WriteLine(oleDbException.Message);
        ModGeneralFunctions.MessageMistake(oleDbException.Message);
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        Console.WriteLine(exception.Message);
        ModGeneralFunctions.MessageMistake(exception.Message);
        ProjectData.ClearProjectError();
      }
      DataTable dataTable = new DataTable();
      DataTable oleDbSchemaTable = selectConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, (object[]) null);
      if (oleDbSchemaTable != null || oleDbSchemaTable.Rows.Count > 0)
      {
        int index = 0;
        do
        {
          try
          {
            string srcTable = oleDbSchemaTable.Rows[index]["table_name"].ToString();
            string selectCommandText = "";
            switch (pintOpcion)
            {
              case 1:
                selectCommandText = "SELECT 'Esperando ...' AS ESTADO,* FROM [" + srcTable + "] ";
                break;
              case 2:
                selectCommandText = "SELECT 'Esperando ...' AS ESTADO,GRUPO,SUBGRUPO,CODIGO AS COD,NOMBRE,MARCA,MODELO,COLOR,TACO,TALLA,FORMAT(P_COMPRA_C_IGV,\"0.00\") as P_COMPRA,FORMAT(P_VENTA_C_IGV,\"0.00\") as P_VENTA,U_M,COD_BARRAS,AREA1,AREA2,CANTIDAD,PRECIO,AFECTO_IGV FROM [" + srcTable + "] ";
                break;
            }
            new OleDbDataAdapter(selectCommandText, selectConnection).Fill(dataSet, srcTable);
          }
          catch (DataException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            DataException dataException = ex;
            Console.WriteLine(dataException.Message);
            ModGeneralFunctions.MessageMistake(dataException.Message);
            ProjectData.ClearProjectError();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            Console.WriteLine(exception.Message);
            ModGeneralFunctions.MessageMistake(exception.Message);
            ProjectData.ClearProjectError();
          }
          checked { ++index; }
        }
        while (index <= 0);
      }
      selectConnection.Close();
      return dataSet;
    }

    private object[,] GetData(DataTable a_dtData)
    {
      object[,] objArray = new object[checked (a_dtData.Rows.Count + 1 - 1 + 1), checked (a_dtData.Columns.Count - 1 + 1)];
      try
      {
        int num1 = checked (a_dtData.Columns.Count - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          objArray[0, index1] = (object) a_dtData.Columns[index1].Caption;
          checked { ++index1; }
        }
        DateTime result = new DateTime();
        string str = string.Empty;
        int count = a_dtData.Rows.Count;
        int index2 = 1;
        while (index2 <= count)
        {
          int num2 = checked (a_dtData.Columns.Count - 1);
          int index3 = 0;
          while (index3 <= num2)
          {
            if ((object) a_dtData.Columns[index3].DataType == (object) result.GetType())
            {
              if (a_dtData.Rows[checked (index2 - 1)][index3] != DBNull.Value)
              {
                DateTime.TryParse(a_dtData.Rows[checked (index2 - 1)][index3].ToString(), out result);
                objArray[index2, index3] = (object) result.ToString("MM/dd/yy hh:mm tt");
              }
              else
                objArray[index2, index3] = RuntimeHelpers.GetObjectValue(a_dtData.Rows[checked (index2 - 1)][index3]);
            }
            else if ((object) a_dtData.Columns[index3].DataType == (object) str.GetType())
            {
              if (a_dtData.Rows[checked (index2 - 1)][index3] != DBNull.Value)
              {
                str = a_dtData.Rows[checked (index2 - 1)][index3].ToString().Replace("\r", "");
                objArray[index2, index3] = (object) str;
              }
              else
                objArray[index2, index3] = RuntimeHelpers.GetObjectValue(a_dtData.Rows[checked (index2 - 1)][index3]);
            }
            else
              objArray[index2, index3] = RuntimeHelpers.GetObjectValue(a_dtData.Rows[checked (index2 - 1)][index3]);
            checked { ++index3; }
          }
          checked { ++index2; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Console.WriteLine(ex.Message);
        ProjectData.ClearProjectError();
      }
      return objArray;
    }
  }
}
