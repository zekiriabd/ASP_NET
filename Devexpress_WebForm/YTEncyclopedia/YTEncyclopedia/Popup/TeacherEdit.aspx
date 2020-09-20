<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherEdit.aspx.cs" Inherits="YTEncyclopedia.Popup.TeacherEdit" %>



<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v19.2, Version=19.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <label>First Name</label>
        <dx:ASPxTextBox ID="txFirstName"  runat="server" />
        <label>Last Name</label>
        <dx:ASPxTextBox ID="txLastName"  runat="server" />
        <label>Channel Name</label>
        <dx:ASPxTextBox ID="txChannelName"  runat="server" />
        <label>Image</label>
        <dx:ASPxUploadControl runat="server" ID="fuImage"/>
        <label>Image</label>
        <dx:ASPxHtmlEditor ID="txDescription" runat="server"></dx:ASPxHtmlEditor>
<dx:ASPxButton ID="btnSave"   runat="server" OnClick="btnSave_Click"></dx:ASPxButton>
<dx:ASPxButton ID="btnCancel" runat="server" AutoPostBack="false">
    <ClientSideEvents Click="function(s, e){window.parent.TeacherEditPopup.Hide();}" />
</dx:ASPxButton>
        
    </form>
</body>
</html>
