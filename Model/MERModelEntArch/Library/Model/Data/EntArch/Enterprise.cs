 
using System; 
using System.Configuration; 
using System.Data; 
using System.Data.SqlClient; 
using System.Xml; 
using MERModelEntArch.Library.Controller.Base.Data.Model; 
 
namespace MERModelEntArch.Library.Model.Data.EntArch 
{ 
  public class Enterprise : DataObjectHandler 
  { 
 
    private int _ID = 1; 
    private int _ParentID = 1; 
    private string _Handle = ""; 
    private string _Code = ""; 
    private string _Description = ""; 
    private string _Definition = ""; 
 
    private int _EnterpriseClassID = 1; 
    private string _RegistrationNumber = ""; 
 
    private string _ActionUser = ""; 
    private string _AuditLog = ""; 
 
    private bool _StateLock = true; 
 
    private const string _SQL_SET_PROCEDURE_NAME = "setEnterprise"; 
    private const string _SQL_GET_PROCEDURE_NAME = "getEnterprise"; 
 
    public Enterprise() 
    { 
      SetVariables("EntArch"); 
    } 
 
    public Enterprise(int ID, string Code, string Description) 
    { 
      _ID = ID; 
      _Code = Code; 
      _Description = Description; 
    } 
 
    public int GetID() 
    {return _ID;} 
 
    public int GetParentID() 
    {return _ParentID;} 
 
    public string GetHandle() 
    {return _Handle;} 
 
    public string GetCode() 
    {return _Code;} 
 
    public string GetDescription() 
    {return _Description;} 
 
    public string GetDefinition() 
    {return _Definition;} 
 
    public int GetEnterpriseClassID() 
    {return _EnterpriseClassID;} 
 
    public string GetRegistrationNumber() 
    {return _RegistrationNumber;} 
 
    public bool GetStateLock() 
    {return _StateLock;} 
 
    public bool GetListActivate(out DataSet Data) 
    { 
      //Returns Only Record 1 Unspecified 
      bool result = true; 
      Data = null;  
      result = GetExecute("LISTACTIVATE", out Data);  
      return result; 
    } 
 
    public bool GetListOfValues(out DataSet Data) 
    { 
      //Returns All Records 
      bool result = true; 
      Data = null; 
      result = GetExecute("LISTOFVALUES", out Data); 
      return result; 
    } 
 
    public bool GetListItem(int pItem, int pMaxItems, out DataSet pData) 
    { 
      //Returns All Records 
      bool result = true; 
      pData = null; 
      _ID = pItem; 
      _ParentID = pMaxItems; 
      result = GetExecute("LISTITEM", out pData); 
      return result; 
    } 
 
    public int GetListItemCount() 
    { 
      bool result = true; 
      DataSet data = null; 
      int rcount = 0; 
      result = GetExecute("LISTITEMCOUNT", out data); 
      DataTable table = data.Tables[0]; 
      foreach (DataRow row in table.Rows) 
      { rcount = Int32.Parse(row["Total"].ToString()); } 
      return rcount; 
    } 
 
    public bool GetListItemPrev(int pItem, int pMaxItems, out DataSet pData) 
    { 
      //Returns All Records  
      bool result = true; 
      pData = null; 
      _ID = pItem; 
      _ParentID = pMaxItems; 
      result = GetExecute("LISTITEMPREV", out pData); 
      return result; 
    } 
 
    public bool GetListItemNext(int pItem, int pMaxItems, out DataSet pData) 
    { 
      //Returns All Records  
      bool result = true; 
      pData = null; 
      _ID = pItem; 
      _ParentID = pMaxItems; 
      result = GetExecute("LISTITEMNEXT", out pData); 
      return result; 
    } 
 
    public bool GetListByParent(out DataSet Data) 
    { 
      //Returns Children of ParentID 
      bool result = true; 
      Data = null; 
      result = GetExecute("LISTBYPARENT", out Data); 
      return result; 
    } 
 
    public bool GetListByEnterpriseClass(out DataSet Data) 
    { 
      //Returns Members of EnterpriseClassID 
      bool result = true; 
      Data = null; 
      result = GetExecute("LISTBYENTERPRISECLASS", out Data); 
      return result; 
    } 
 
    public bool GetSearch(out DataSet Data) 
    { 
      bool result = true; 
      Data = null; 
      result = GetExecute("SEARCH", out Data); 
      return result; 
    } 
 
    public int GetRecordCount() 
    { 
      bool result = true; 
      DataSet data = null; 
      int rcount = 0; 
      result = GetExecute("RECORDCOUNT", out data); 
      DataTable table = data.Tables[0]; 
      foreach(DataRow row in table.Rows) 
      {rcount = Int32.Parse(row["RecordCount"].ToString());} 
      return rcount; 
    } 
 
    public bool GetSelectByID(int ID) 
    { 
      bool result = true; 
      DataSet data = null; 
      _ID = ID; 
      result = GetExecute("SELECTBYID", out data); 
      DataTable table = data.Tables[0]; 
      foreach(DataRow row in table.Rows) 
      { 
        _ID = Int32.Parse(row["ID"].ToString()); 
        _ParentID = Int32.Parse(row["ParentID"].ToString()); 
        _Handle = row["Handle"].ToString(); 
        _Code = row["Code"].ToString(); 
        _Description = row["Description"].ToString(); 
        _Definition = row["Definition"].ToString(); 
        _EnterpriseClassID = Int32.Parse(row["EnterpriseClassID"].ToString()); 
        _RegistrationNumber = row["RegistrationNumber"].ToString(); 
      } 
      _StateLock = true; 
      return result; 
    } 
 
    public bool GetSelectByHandle(string Handle) 
    { 
      bool result = true; 
      DataSet data = null; 
      _Handle = Handle; 
      result = GetExecute("SELECTBYHANDLE", out data); 
      DataTable table = data.Tables[0]; 
      foreach(DataRow row in table.Rows) 
      { 
        _ID = Int32.Parse(row["ID"].ToString()); 
        _ParentID = Int32.Parse(row["ParentID"].ToString()); 
        _Handle = row["Handle"].ToString(); 
        _Code = row["Code"].ToString(); 
        _Description = row["Description"].ToString(); 
        _Definition = row["Definition"].ToString(); 
        _EnterpriseClassID = Int32.Parse(row["EnterpriseClassID"].ToString()); 
        _RegistrationNumber = row["RegistrationNumber"].ToString(); 
      } 
      _StateLock = true; 
      return result; 
    } 
 
    public bool GetSelectByCode(string Code) 
    { 
      bool result = true; 
      DataSet data = null; 
      _Code = Code; 
      result = GetExecute("SELECTBYCODE", out data); 
      DataTable table = data.Tables[0]; 
      foreach(DataRow row in table.Rows) 
      { 
        _ID = Int32.Parse(row["ID"].ToString()); 
        _ParentID = Int32.Parse(row["ParentID"].ToString()); 
        _Handle = row["Handle"].ToString(); 
        _Code = row["Code"].ToString(); 
        _Description = row["Description"].ToString(); 
        _Definition = row["Definition"].ToString(); 
        _EnterpriseClassID = Int32.Parse(row["EnterpriseClassID"].ToString()); 
        _RegistrationNumber = row["RegistrationNumber"].ToString(); 
      } 
      _StateLock = true; 
      return result; 
    } 
 
    public void SetID(int ID) 
    {if(_StateLock == false){_ID = ID;}} 
 
    public void SetParentID(int ParentID) 
    {if(_StateLock == false){_ParentID = ParentID;}} 
 
    public void SetHandle(string Handle) 
    {if(_StateLock == false){_Handle = Handle;}} 
 
    public void SetCode(string Code) 
    {if(_StateLock == false){_Code = Code;}} 
 
    public void SetDescription(string Description) 
    {if (_StateLock == false){_Description = Description;}} 
 
    public void SetDefinition(string Definition) 
    {if (_StateLock == false){_Definition = Definition;}} 
 
    public void SetEnterpriseClassID(int EnterpriseClassID) 
    {if(_StateLock == false){_EnterpriseClassID = EnterpriseClassID;}} 
 
    public void SetRegistrationNumber(string RegistrationNumber) 
    {if (_StateLock == false){_RegistrationNumber = RegistrationNumber;}} 
 
    public void SetEnterprise(int ID, string Code, string Description) 
    { 
      _ID = ID; 
      _Code = Code; 
      _Description = Description; 
    } 
 
    public void SetNew() 
    { 
      _ID = 0; 
      _ParentID = 1; 
      _Handle = ""; 
      _Code = ""; 
      _Description = ""; 
      _Definition = ""; 
      _EnterpriseClassID = 1; 
      _RegistrationNumber = ""; 
      _StateLock = false; 
    } 
 
    public void SetEdit() 
    {_StateLock = false;} 
 
    public bool SetAdd() 
    { 
      bool result = true; 
      result = SetExecute("INSERT"); 
      _StateLock = true; 
      return result; 
    } 
 
    public bool SetSave() 
    { 
      bool result = true; 
      result = SetExecute("UPDATE"); 
      _StateLock = true; 
      return result; 
    } 
 
    public bool SetDelete() 
    { 
      bool result = true; 
      result = SetExecute("DELETE"); 
      _StateLock = true; 
      return result; 
    } 
 
    public bool SetUnDelete() 
    { 
      bool result = true; 
      result = SetExecute("UNDELETE"); 
      _StateLock = true; 
      return result; 
    } 
 
    private void SetParameters(string Action) 
    { 
      switch (Action) 
      { 
        case "INSERT": 
          base.SetParameterObject(Action, _ID, _ParentID, _Handle, _Code, _Description, _Definition, _EnterpriseClassID, _RegistrationNumber, _ActionUser, _AuditLog); 
          break; 
        case "UPDATE": 
          goto case "INSERT"; 
        case "DELETE": 
          goto case "INSERT"; 
        case "UNDELETE": 
          goto case "INSERT"; 
        case "LISTOFVALUES": 
          base.SetParameterObject(Action, _ID, _ParentID, _Handle, _Code, _Description, _EnterpriseClassID, _AuditLog); 
          break; 
        case "LISTITEM": 
          goto case "LISTOFVALUES"; 
        case "LISTITEMCOUNT": 
          goto case "LISTOFVALUES"; 
        case "LISTITEMNEXT": 
          goto case "LISTOFVALUES"; 
        case "LISTITEMPREV": 
          goto case "LISTOFVALUES"; 
        case "RECORDCOUNT": 
          goto case "LISTOFVALUES"; 
        case "LISTACTIVATE": 
          goto case "LISTOFVALUES"; 
        case "LISTBYPARENT": 
          goto case "LISTOFVALUES"; 
        case "SELECTBYID": 
          goto case "LISTOFVALUES"; 
        case "SELECTBYCODE": 
          goto case "LISTOFVALUES"; 
        case "SELECTBYHANDLE": 
          goto case "LISTOFVALUES"; 
        case "SEARCH": 
          goto case "LISTOFVALUES"; 
        case "LISTBYENTERPRISECLASS": 
          goto case "LISTOFVALUES"; 
        default: 
          break; 
      } 
    } 
 
    private bool GetExecute(string Action, out DataSet Data) 
    { 
      bool result = true; 
      Data = null; 
      SetParameters(Action); 
      result = base.GetExecute(out Data, _SQL_GET_PROCEDURE_NAME); 
      return result; 
    } 
 
    private new bool SetExecute(string Action) 
    { 
      bool result = true; 
      SetParameters(Action); 
      result = base.SetExecute(_SQL_SET_PROCEDURE_NAME); 
      return result; 
    } 
  } 
} 
 
