<%@ Page Title="" Language="C#" MasterPageFile="~/Parish_memb.Master" AutoEventWireup="true" CodeBehind="view_teachersParishMemb.aspx.cs" Inherits="ChurchWebPortal.view_teachersParishMemb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="nav-justified">
    <tr>
        <td style="width: 391px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 391px">&nbsp;</td>
        <td>
            <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="times new roman" ForeColor="#0066FF" Text="TEACHERS DETAILS"></asp:Label>
            </h3>
        </td>
    </tr>
    <tr>
        <td style="width: 391px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 391px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 391px">&nbsp;</td>
        <td>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Font-Names="times new roman" Font-Size="Medium">
                <Columns>
                    <asp:TemplateField HeaderText="Teachers Name">
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("teacher_name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Standard">
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("std") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="No of Student">
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("noofstudent") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Joining Date">
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Eval("joining_date") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td style="width: 391px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 391px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 391px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 391px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 391px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>

</asp:Content>
