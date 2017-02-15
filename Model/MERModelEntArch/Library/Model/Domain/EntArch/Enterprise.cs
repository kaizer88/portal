using System; 
using System.Configuration; 
using System.Data; 
using System.Data.SqlClient; 
using System.Xml; 
using MERModelEntArch.Library.Controller.Base.Data.Model; 
using MERModelEntArch.Library.Model; 
 
namespace MERModelEntArch.Library.Model.Domain.EntArch 
{ 
  public class Enterprise : BusinessObjectHandler 
  { 
 
    public Enterprise() 
    { 
 
    } 
 
    private Data.EntArch.Enterprise _DataObject = new Data.EntArch.Enterprise(); 
 
    private int _ID = 1; 
    private int _ParentID = 1; 
    private string _Handle = ""; 
    private string _Code = ""; 
    private string _Description = ""; 
    private string _Definition = ""; 
    private int _EnterpriseClassID = 1; 
    private string _RegistrationNumber = ""; 
 
    public int ID 
    { 
      get {return _ID;} 
      set {_ID = value;} 
    } 
 
    public int ParentID 
    { 
      get {return _ParentID;} 
      set {_ParentID = value;} 
    } 
 
    public string Handle 
    { 
      get {return _Handle;} 
      set {_Handle = value;} 
    } 
 
    public string Code 
    { 
      get {return _Code;} 
      set {_Code = value;} 
    } 
 
    public string Description 
    { 
      get {return _Description;} 
      set {_Description = value;} 
    } 
 
    public string Definition 
    { 
      get {return _Definition;} 
      set {_Definition = value;} 
    } 
 
    public int EnterpriseClassID 
    { 
      get {return _EnterpriseClassID;} 
      set {_EnterpriseClassID = value;} 
    } 
 
    public string RegistrationNumber 
    { 
      get {return _RegistrationNumber;} 
      set {_RegistrationNumber = value;} 
    } 
 
    public bool GetListActivate(out DataSet Data) 
    { 
      bool result = true; 
      Data = null; 
      result = _DataObject.GetListActivate(out Data); 
      return result; 
    } 
 
    public bool GetListOfValues(out DataSet Data) 
    { 
      bool result = true; 
      Data = null; 
      result = _DataObject.GetListOfValues(out Data); 
      return result; 
    } 
 
    public bool GetListItem(int pItem, int pMaxItems, out DataSet pData) 
    { 
      bool result = true; 
      pData = null; 
      result = _DataObject.GetListItem(pItem, pMaxItems, out pData); 
      return result; 
    } 
 
    public int GetListItemCount() 
    { 
      int rcount; 
      rcount = _DataObject.GetListItemCount(); 
      return rcount; 
    } 
 
    public bool GetListItemPrev(int pItem, int pMaxItems, out DataSet pData) 
    { 
      bool result = true; 
      pData = null; 
      result = _DataObject.GetListItemPrev(pItem, pMaxItems, out pData); 
      return result; 
    } 
 
    public bool GetListItemNext(int pItem, int pMaxItems, out DataSet pData) 
    { 
      bool result = true; 
      pData = null; 
      result = _DataObject.GetListItemNext(pItem, pMaxItems, out pData); 
      return result; 
    } 
 
    public bool GetListByParent(out DataSet Data) 
    { 
      bool result = true; 
      Data = null; 
      _DataObject.SetParentID(_ParentID); 
      result = _DataObject.GetListByParent(out Data); 
      return result; 
    } 
 
    public bool GetListByEnterpriseClass(out DataSet Data) 
    { 
      bool result = true; 
      Data = null; 
      _DataObject.SetEnterpriseClassID(_EnterpriseClassID); 
      result = _DataObject.GetListByEnterpriseClass(out Data); 
      return result; 
    } 
 
    public bool GetSearch(out DataSet Data) 
    { 
      bool result = true; 
      Data = null; 
      _DataObject.SetID(_ID); 
      _DataObject.SetParentID(_ParentID); 
      _DataObject.SetCode(_Code); 
      _DataObject.SetDescription(_Description); 
      result = _DataObject.GetSearch(out Data); 
      return result; 
    } 
 
    public int GetRecordCount() 
    { 
      int rcount; 
      rcount = _DataObject.GetRecordCount(); 
      return rcount; 
    } 
 
    public bool GetSelectByID(int ID) 
    { 
      bool result = true; 
      result = _DataObject.GetSelectByID(ID); 
      _ID = _DataObject.GetID(); 
      _ParentID = _DataObject.GetParentID(); 
      _Handle = _DataObject.GetHandle(); 
      _Code = _DataObject.GetCode(); 
      _Description = _DataObject.GetDescription(); 
      _Definition = _DataObject.GetDefinition(); 
      _EnterpriseClassID = _DataObject.GetEnterpriseClassID(); 
      _RegistrationNumber = _DataObject.GetRegistrationNumber(); 
      return result; 
    } 
 
    public bool GetSelectByHandle(string Handle) 
    { 
      bool result = true; 
      result = _DataObject.GetSelectByHandle(Handle); 
      _ID = _DataObject.GetID(); 
      _ParentID = _DataObject.GetParentID(); 
      _Handle = _DataObject.GetHandle(); 
      _Code = _DataObject.GetCode(); 
      _Description = _DataObject.GetDescription(); 
      _Definition = _DataObject.GetDefinition(); 
      _EnterpriseClassID = _DataObject.GetEnterpriseClassID(); 
      _RegistrationNumber = _DataObject.GetRegistrationNumber(); 
      return result; 
    } 
 
    public bool GetSelectByCode(string Code) 
    { 
      bool result = true; 
      result = _DataObject.GetSelectByCode(Code); 
      _ID = _DataObject.GetID(); 
      _ParentID = _DataObject.GetParentID(); 
      _Handle = _DataObject.GetHandle(); 
      _Code = _DataObject.GetCode(); 
      _Description = _DataObject.GetDescription(); 
      _Definition = _DataObject.GetDefinition(); 
      _EnterpriseClassID = _DataObject.GetEnterpriseClassID(); 
      _RegistrationNumber = _DataObject.GetRegistrationNumber(); 
      return result; 
    } 
 
    public void SetNew() 
    { 
      _ID = 1; 
      _ParentID = 1; 
      _Handle = ""; 
      _Code = ""; 
      _Description = ""; 
      _Definition = ""; 
      _EnterpriseClassID = 1; 
      _RegistrationNumber = ""; 
      _DataObject.SetNew(); 
    } 
 
    public void SetEdit() 
    { 
      _DataObject.SetEdit(); 
    } 
 
    public bool SetAdd() 
    { 
      bool result = true; 
      _DataObject.SetID(_ID); 
      _DataObject.SetParentID(_ParentID); 
      _DataObject.SetHandle(_Handle); 
      _DataObject.SetCode(_Code); 
      _DataObject.SetDescription(_Description); 
      _DataObject.SetDefinition(_Definition); 
      _DataObject.SetEnterpriseClassID(_EnterpriseClassID); 
      _DataObject.SetRegistrationNumber(_RegistrationNumber); 
      result = _DataObject.SetAdd(); 
      return result; 
    } 
 
    public bool SetSave() 
    { 
      bool result = true; 
      _DataObject.SetID(_ID); 
      _DataObject.SetParentID(_ParentID); 
      _DataObject.SetHandle(_Handle); 
      _DataObject.SetCode(_Code); 
      _DataObject.SetDescription(_Description); 
      _DataObject.SetDefinition(_Definition); 
      _DataObject.SetEnterpriseClassID(_EnterpriseClassID); 
      _DataObject.SetRegistrationNumber(_RegistrationNumber); 
      result = _DataObject.SetSave(); 
      return result; 
    } 
 
    public bool SetDelete() 
    { 
      bool result = true; 
      _DataObject.SetID(_ID); 
      result = _DataObject.SetDelete(); 
      return result; 
    } 
 
    public bool SetUnDelete() 
    { 
      bool result = true; 
      _DataObject.SetID(_ID); 
      result = _DataObject.SetUnDelete(); 
      return result; 
    } 
 
    ~ Enterprise() 
    { 
 
    } 
 
  } 
 
} 

