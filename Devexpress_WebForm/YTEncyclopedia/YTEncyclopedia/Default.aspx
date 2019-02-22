<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="YTEncyclopedia.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <dx:ASPxGridView ID="gvVideoList" runat="server" AutoGenerateColumns="False" SkinID="GridViewSkin1">
        <Columns>
            <dx:GridViewDataTextColumn FieldName="Name" Caption="Name" Width="20%" />
            <dx:GridViewDataTextColumn FieldName="Date" Caption="Date" Width="10%"  />
            <dx:GridViewDataTextColumn FieldName="LikedCount" Caption="LikedCount"  Width="10%"/>
            
        </Columns>
    </dx:ASPxGridView>
</asp:Content>
