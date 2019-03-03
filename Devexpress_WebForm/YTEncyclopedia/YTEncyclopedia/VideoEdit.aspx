<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="VideoEdit.aspx.cs" Inherits="YTEncyclopedia.VideoEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function TeacherEdit() {
                TeacherEditPopup.SetContentUrl("Popup/TeacherEdit.aspx");
                TeacherEditPopup.Show();
        }
        function CourseEdit() {
                CourseEditPopup.SetContentUrl("Popup/CourseEdit.aspx");
                CourseEditPopup.Show();
        }

     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div>
            
            <label>Name</label>
            <dx:ASPxTextBox runat="server" ID="txName"></dx:ASPxTextBox>
            
            <label>Url</label>
            <dx:ASPxTextBox runat="server" ID="txUrl"></dx:ASPxTextBox>
            
            <label>Image</label>
            <dx:ASPxUploadControl runat="server" ID="fuImageVideo"></dx:ASPxUploadControl>
    <br />
            <label>Teacher</label>
            <dx:ASPxGridLookup ID="cbxTeacher" runat="server" KeyFieldName="IDteacher" NullText="" 
                AutoGenerateColumns="False" SkinID="GridLookup1">
                            <Columns>
                                <dx:GridViewDataTextColumn Caption=" " FieldName="TeacherName" Width="50%" />
                                <dx:GridViewDataTextColumn Caption=" " FieldName="ChannelName" Width="50%" />
                               
                            </Columns>
          </dx:ASPxGridLookup>
    <a href="javascript:TeacherEdit()">New Teacher</a>
    <br /><br />
       
                <label>Course</label>
                <dx:ASPxGridLookup ID="cbxCourse" runat="server" KeyFieldName="IDcourse" NullText="" 
                AutoGenerateColumns="False" SkinID="GridLookup1">
                <Columns>
                    <dx:GridViewDataTextColumn Caption=" " FieldName="Name" Width="50%" />
                </Columns>
          </dx:ASPxGridLookup>
    <a href="javascript:CourseEdit()">New Course</a>
    


        </div>

        <dx:ASPxPopupControl ID="TeacherEditPopup" ClientInstanceName="TeacherEditPopup" 
        runat="server" ContentUrl="Popup/TeacherEdit.aspx" 
        HeaderText="Teacher Edit" ClientIDMode="AutoID"  Height="400px" Width="500px" 
        SkinID="PopupSkin1"
        />
        <dx:ASPxPopupControl ID="CourseEditPopup" ClientInstanceName="CourseEditPopup" 
        runat="server" ContentUrl="Popup/CourseEdit.aspx" 
        HeaderText="Course Edit" ClientIDMode="AutoID"  Height="400px" Width="500px" 
        SkinID="PopupSkin1"/>



</asp:Content>
