<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="YTEncyclopedia.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <script>
         function VideoPopupShow(url) {
           VideoPopup.SetContentUrl(url);
           VideoPopup.Show();
         }
     </script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <dx:ASPxGridView ID="gvVideoList" runat="server" AutoGenerateColumns="False" SkinID="GridViewSkin1">
        <Columns>
            
            <dx:GridViewDataTextColumn FieldName="Image" Caption="Image"  Width="10%">
                <DataItemTemplate>
                    <a href='<%#  "javascript:VideoPopupShow(\"" + Eval("Url") + "\")"  %>'>
                        <dx:ASPxImage  ImageUrl='<%#  "Images/" + Eval("Image")  %>' runat="server" Width="200px" Height="100px"/>
                    </a>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>

            <dx:GridViewDataTextColumn FieldName="Name" Caption="Name" Width="20%" />
            <dx:GridViewDataTextColumn FieldName="Date" Caption="Date" Width="10%"  />
            <dx:GridViewDataTextColumn FieldName="LikedCount" Caption="LikedCount"  Width="10%"/>
            <dx:GridViewDataTextColumn FieldName="Date" Caption="Date"  Width="10%"/>
            <dx:GridViewDataTextColumn FieldName="FirstName" Caption="First Name"  Width="10%"/>
            <dx:GridViewDataTextColumn FieldName="LastName" Caption="Last Name"  Width="10%"/>
            <dx:GridViewDataTextColumn FieldName="ChannelName" Caption="Channel Name"  Width="10%"/>
            <dx:GridViewDataTextColumn FieldName="Course_Name" Caption="Course Name"  Width="10%"/>

            

        </Columns>
    </dx:ASPxGridView>

   

    <dx:ASPxPopupControl 
        ID="VideoPopup" 
        ClientInstanceName="VideoPopup" 
        runat="server" 

        ContentUrl="https://www.youtube.com/embed/I4xmX4SBm7M" 

        HeaderText="Video Show" 
        ClientIDMode="AutoID"  
        Height="300px" 
        Width="550px"
        SkinID="PopupSkin1"
        >
    </dx:ASPxPopupControl>



 
</asp:Content>
 