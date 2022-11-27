<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Assignment5.User.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>Welcome to user Home Page</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="empId" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
    <Columns>
        <asp:BoundField DataField="empname" HeaderText="Name" />
        <asp:BoundField DataField="empemail" HeaderText="Email" />
        
        <asp:BoundField DataField="empage" HeaderText="Age" />
        <asp:CommandField DataField="Update" ShowEditButton="true" />
        <asp:CommandField DataField="Delete" HeaderText="Name" ShowDeleteButton="true"/>
        </Columns>
</asp:GridView>
</asp:Content>
