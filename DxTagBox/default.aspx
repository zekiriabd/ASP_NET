<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxDataView" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <script type="text/javascript">
         function Add(key) {
             ASPxDataView1.PerformCallback("ADD|" + txtag.GetText());
             txtag.SetText(''); 
       }

       function Delete(key) {
          ASPxDataView1.PerformCallback("DELETE|" + key);
       }

	</script> 
    <form id="form1" runat="server">
        <div>
            <dx:ASPxTextBox runat="server" ID="txtag" ClientInstanceName="txtag" />
            <dx:ASPxButton runat="server" ID="btnAdd" AutoPostBack="false" >
                <ClientSideEvents Click="function(s,e){Add();}" />
            </dx:ASPxButton>

            <dx:ASPxDataView ID="ASPxDataView1" runat="server" 
                AllowPaging="False"
                Height="50px" Width="500px"
                ItemSpacing="0px" 
                ItemStyle-BackColor="White"
                ItemStyle-Border-BorderStyle="None"
                ItemStyle-Paddings-Padding="0"
                Border-BorderStyle="Solid"
                Border-BorderWidth="1px"
                OnCustomCallback="ASPxDataView1_CustomCallback" ColumnCount="10"
                >
                <SettingsTableLayout ColumnCount="5" />
                <ItemTemplate>
                     <table style="border:1px solid #666">
                         <tr >
                             <td><dx:ASPxLabel ID="btnIcq" runat="server" Text='<%# Eval("Text")%>' /></td>
                             <td><a href='javascript:Delete("<%# Eval("Text") %>");'>
                                    <img src="delete.gif" alt="Delete" title="Delete" width="16" height="16"/>
                                 </a>
                             </td>
                        </tr>
                    </table>
                 </ItemTemplate>

<ItemStyle Height="40px" BackColor="White">
<Border BorderStyle="None"></Border>
</ItemStyle>

<Border BorderStyle="Solid" BorderWidth="1px"></Border>
            </dx:ASPxDataView>
        </div>
      <dx:ASPxButton runat="server" ID="btnSave" OnClick="btnSave_Click"></dx:ASPxButton>
    </form>
</body>
</html>
