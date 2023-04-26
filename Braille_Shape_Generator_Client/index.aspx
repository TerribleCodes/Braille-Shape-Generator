<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs"
Inherits="Braille_Shape_Generator_Client.index" %>

<!DOCTYPE html>

<%-- 
    +++++++++ FRONTEND +++++++++

    Braille_Shape_Generator_Client

    Tasks: 
        - [x] Basic frontend design
        - [ ] Additional UI/UX features
    
    Completed by KGB AKASH on 01/04/2023
--%>


<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <title>Braille Shape Generator</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
      .auto-style1 {
        height: 47px;
      }
      .auto-style2 {
        height: 321px;
      }
      .auto-style3 {
        height: 533px;
      }
      .auto-style4 {
        width: 100%;
        height: 319px;
      }
      .auto-style7 {
        height: 49px;
      }
      .auto-style8 {
        height: 49px;
        width: 550px;
      }
      .auto-style9 {
        width: 550px;
      }
      .auto-style12 {
        width: 550px;
        height: 68px;
      }
      .auto-style13 {
        height: 68px;
      }
        .auto-style14 {
            height: 63px;
            width: 550px;
        }
        .auto-style15 {
            height: 63px;
        }
        .auto-style16 {
            height: 56px;
            width: 550px;
        }
    </style>
  </head>
  <body style="height: 909px">
    <form id="form1" runat="server">
      <div class="auto-style1">
        <asp:Label
          ID="Label1"
          runat="server"
          Font-Bold="False"
          Font-Names="Montserrat Alternates Black"
          Font-Size="Larger"
          Height="40px"
          Align="center"
          Text="Hima's Braille Shape Generator"
          Width="1498px"
        ></asp:Label>
      </div>
      <hr />
      <div class="auto-style2">
        <table class="auto-style4">
          <tr>
            <td class="auto-style8">
              <asp:Label
                ID="Label2"
                runat="server"
                Font-Bold="True"
                Font-Names="Montserrat Alternates Medium"
                Font-Size="Larger"
                Text="Shapes"
              ></asp:Label>
            </td>
            <td class="auto-style8">
              <asp:Label
                ID="Label3"
                runat="server"
                Font-Bold="True"
                Font-Names="Montserrat Alternates Medium"
                Font-Size="Larger"
                Text="Characters"
              ></asp:Label>
            </td>
            <td class="auto-style7">
              <asp:Label
                ID="Label4"
                runat="server"
                Font-Bold="True"
                Font-Names="Montserrat Alternates Medium"
                Font-Size="Larger"
                Text="History"
              ></asp:Label>
            </td>
          </tr>
          <tr>
            <td class="auto-style9">
              <asp:Label
                ID="Label5"
                runat="server"
                Font-Names="Montserrat Alternates SemiBold"
                Text="Select Shape: "
              ></asp:Label>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:DropDownList
                ID="shape_drop_down"
                runat="server"
                onchange="EnableDisableTextBox(this)"
                Height="30px"
                Width="180px"
                CssClass="options"
              >
                <asp:ListItem  value="select"> Select a Shape </asp:ListItem>
                <asp:ListItem  value="square"> Square </asp:ListItem>
                <asp:ListItem  value="rectangle"> Rectangle </asp:ListItem>
                <asp:ListItem  value="triangle"> Triangle </asp:ListItem>
                <asp:ListItem  value="circle"> Circle </asp:ListItem>
                <%-- +++ Removed additional shapes by Madawa De Siva on
                04/02/2023@9:35AM +++ --%> <%--<asp:ListItem>
                  Oval
                </asp:ListItem>
                <asp:ListItem> Hexagon </asp:ListItem>
                <asp:ListItem> Pentagon </asp:ListItem>
                <asp:ListItem> Diamond(Ruombus) </asp:ListItem>
                <asp:ListItem> Parallelogram </asp:ListItem>
                <asp:ListItem> Star </asp:ListItem>
                <asp:ListItem> Semicircle </asp:ListItem>
                <asp:ListItem> Trapezoid </asp:ListItem>--%>
              </asp:DropDownList>
            </td>
            <td class="auto-style9">
              <asp:Label
                ID="Label6"
                runat="server"
                Font-Names="Montserrat Alternates SemiBold"
                Text="Select Character: "
              ></asp:Label>
              <asp:DropDownList
                ID="CharactersDropDownList2"
                runat="server"
                Height="30px"
                Width="240px"
                CssClass="options"
              >
                <%--++ Edited the DropDownList by Nalitha Fernando on 04/13/2023 ++--%>
                <asp:ListItem> Select a Character </asp:ListItem>
                <asp:ListItem Text = "A" Value = "A"></asp:ListItem>
                <asp:ListItem Text = "B" Value = "B"></asp:ListItem>
                <asp:ListItem Text = "C" Value = "C"></asp:ListItem>
                <asp:ListItem Text = "D" Value = "D"></asp:ListItem>
                <asp:ListItem Text = "E" Value = "E"></asp:ListItem>
                <asp:ListItem Text = "F" Value = "F"></asp:ListItem>
                <asp:ListItem Text = "G" Value = "G"></asp:ListItem>
                <asp:ListItem Text = "H" Value = "H"></asp:ListItem>
                <asp:ListItem Text = "I" Value = "I"></asp:ListItem>
                <asp:ListItem Text = "J" Value = "J"></asp:ListItem>
                <asp:ListItem Text = "K" Value = "K"></asp:ListItem>
                <asp:ListItem Text = "L" Value = "L"></asp:ListItem>
                <asp:ListItem Text = "M" Value = "M"></asp:ListItem>
                <asp:ListItem Text = "N" Value = "N"></asp:ListItem>
                <asp:ListItem Text = "O" Value = "O"></asp:ListItem>
                <asp:ListItem Text = "P" Value = "P"></asp:ListItem>
                <asp:ListItem Text = "Q" Value = "Q"></asp:ListItem>
                <asp:ListItem Text = "R" Value = "R"></asp:ListItem>
                <asp:ListItem Text = "S" Value = "S"></asp:ListItem>
                <asp:ListItem Text = "T" Value = "T"></asp:ListItem>
                <asp:ListItem Text = "U" Value = "U"></asp:ListItem>
                <asp:ListItem Text = "V" Value = "V"></asp:ListItem>
                <asp:ListItem Text = "W" Value = "W"></asp:ListItem>
                <asp:ListItem Text = "X" Value = "X"></asp:ListItem>
                <asp:ListItem Text = "Y" Value = "Y"></asp:ListItem>
                <asp:ListItem Text = "Z" Value = "Z"></asp:ListItem>
                  <%--++ Edited the DropDownList by Himasha Gayathri on 04/06/2023 ++--%>
                <asp:ListItem Text="0" Value="0"></asp:ListItem>
                <asp:ListItem Text="1" Value="1"></asp:ListItem>
                <asp:ListItem Text="2" Value="2"></asp:ListItem>
                <asp:ListItem Text="3" Value="3"></asp:ListItem>
                <asp:ListItem Text="4" Value="4"></asp:ListItem>
                <asp:ListItem Text="5" Value="5"></asp:ListItem>
                <asp:ListItem Text="6" Value="6"></asp:ListItem>
                <asp:ListItem Text="7" Value="7"></asp:ListItem>
                <asp:ListItem Text="8" Value="8"></asp:ListItem>
                <asp:ListItem Text="9" Value="9"></asp:ListItem>

              </asp:DropDownList>
            </td>
           
          </tr>
          <tr>
            <td class="auto-style9">
              <asp:Label
                ID="Label7"
                runat="server"
                Font-Names="Montserrat Alternates SemiBold"
                Text="Enter Radius:"
              ></asp:Label>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox
                ID="EnterRadius"
                runat="server"
                CssClass="inputBox"
                disabled="disabled"
              ></asp:TextBox>
                <span class="ibspan1">Enter Radius</span>
            </td>
            <td class="auto-style9">
              <asp:Button
                ID="Lowercase"
                runat="server"
                Font-Names="Montserrat Alternates SemiBold"
                Text="Lower Case" CssClass="btn2"
              />
              &nbsp;
              <asp:Button
                ID="Uppercase"
                runat="server"
                Font-Names="Montserrat Alternates SemiBold"
                Text="Upper Case" CssClass="btn2"
              />
            </td>
            <td colspan="2">
                <asp:GridView ID="Madawa" runat="server"></asp:GridView>
            </td>
          </tr>
          <tr>
            <td class="auto-style14">
              <asp:Label
                ID="Label8"
                runat="server"
                Font-Names="Montserrat Alternates SemiBold"
                Text="Enter Height:"
              ></asp:Label>
              &nbsp;&nbsp;&nbsp;&nbsp;
              <asp:TextBox
                ID="EnterHeight"
                runat="server"
                CssClass="inputBox"
                disabled="disabled"
              ></asp:TextBox>
                <span class="ibspan2">Entert Height</span>
            </td>
            <td class="auto-style15">Filler</td>
            <td class="auto-style15">
              
            </td>
          </tr>
          <tr>
            <td class="auto-style16">
              <asp:Label
                ID="Label9"
                runat="server"
                Font-Names="Montserrat Alternates SemiBold"
                Text="Enter Width:"
              ></asp:Label
              >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:TextBox
                ID="EnterWidth"
                runat="server"
                CssClass="inputBox"
                disabled="disabled"
              ></asp:TextBox>
                <span class="ibspan3">Enter Width</span>
            </td>
          </tr>
          <tr>
            <td class="auto-style9">
              <asp:Button
                ID="Button3"
                runat="server"
                Font-Bold="True"
                Font-Names="Montserrat Alternates SemiBold"
                Font-Size="Medium"
                Text="Generate"
                OnClick="Button3_Click1" 
                CssClass="btn"
              />
              &nbsp;
              <asp:Button
                ID="Button4"
                runat="server"
                Font-Bold="True"
                Font-Names="Montserrat Alternates SemiBold"
                Font-Size="Medium"
                Text="Reset" 
                CssClass="btn"
              />
              &nbsp; <%-- +++ Removed the Print button by Madawa De Silva on
              04/02/2023@9:40AM as the Print and Generate buttons perform the
              same action +++ --%> <%--<asp:Button
                ID="Button7"
                runat="server"
                Font-Bold="True"
                Font-Names="Montserrat Alternates SemiBold"
                Font-Size="Medium"
                Text="Print"
              />--%>
            </td>
            <td class="auto-style9">
              <asp:Button
                ID="Button5"
                runat="server"
                Font-Bold="True"
                Font-Names="Montserrat Alternates SemiBold"
                Font-Size="Medium"
                Text="Generate"
                OnClick="Button5_Click" CssClass="btn"
              />
              &nbsp;
              <asp:Button
                type="reset"
                ID="Button6"
                runat="server"
                Font-Bold="True"
                Font-Names="Montserrat Alternates SemiBold"
                Font-Size="Medium"
                Text="Reset" CssClass="btn"
              />
              &nbsp;
                <%-- +++ Removed the Print button by Himasha Gayathri on
              04/06/2023 +++ --%>
                <%--++ 
              <asp:Button
                ID="Button8"
                runat="server"
                Font-Bold="True"
                Font-Names="Montserrat Alternates SemiBold"
                Font-Size="Medium"
                Text="Print"
              />++--%>
            </td>
            <td>
              
            </td>
          </tr>
          <tr>
            <td class="auto-style12">
              &nbsp; &nbsp;
              <hr />
            </td>
            <td class="auto-style12">
              &nbsp; &nbsp;
              <hr />
            </td>
            <td class="auto-style13">
              &nbsp;
              <hr />
            </td>
          </tr>
        </table>
      </div>
      <div class="auto-style3">
        <asp:Label ID="Label10" runat="server"></asp:Label> &nbsp; &nbsp;
          &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
          &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
          &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
          &nbsp; &nbsp; &nbsp; &nbsp;  
          <%--++ Added two labels by Himasha Gayathri 04/06/2023 ++--%>
          <asp:Label ID="Label11" runat="server" Text="Number of dots required:"></asp:Label>&nbsp; &nbsp;   
          <asp:Label ID="Label12" runat="server" ></asp:Label>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
         
      </div>
    </form>
  </body>
  <%-- +++ FrontEnd Shape Generator Validation +++ By Madawa De Silva on
  04.02.2023@11:09AM --%>
  <script type="text/javascript">
    function EnableDisableTextBox(shape_drop_down) {
      var selectedValue =
        shape_drop_down.options[shape_drop_down.selectedIndex].value;
      if (selectedValue == "square") {
        // Square ---> Height * Height
        // console.log("rectangle"); // For the verification
        document.getElementById("EnterHeight").disabled = false; // Only the height is required
        document.getElementById("EnterRadius").disabled = true;
        document.getElementById("EnterWidth").disabled = true;
      }
      if (selectedValue == "rectangle") {
        // Rectangle ---> Height * Width
        // console.log("rectangle"); // For the verification
        document.getElementById("EnterWidth").disabled = false;
        document.getElementById("EnterHeight").disabled = false;
        document.getElementById("EnterRadius").disabled = true;
      }
      if (selectedValue == "triangle") {
        // Triangle ---> 1/2 * Width * Height
        // console.log("triangle"); // For the verification
        document.getElementById("EnterWidth").disabled = false;
        document.getElementById("EnterHeight").disabled = false;
        document.getElementById("EnterRadius").disabled = true;
      }
      if (selectedValue == "circle") {
        // Circle ---> 22/7 * Radius * Radius
        // console.log("circle"); // For the verification
        document.getElementById("EnterRadius").disabled = false;
        document.getElementById("EnterWidth").disabled = true;
        document.getElementById("EnterHeight").disabled = true;
      }
      if (selectedValue == "select") {
        // console.log("none"); // For the verification
        document.getElementById("EnterRadius").disabled = true;
        document.getElementById("EnterWidth").disabled = true;
        document.getElementById("EnterHeight").disabled = true;
      }
    }
  </script>
</html>
