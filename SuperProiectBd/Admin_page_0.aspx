<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_page_0.aspx.cs" Inherits="SuperProiectBd.Admin_page_0" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            text-align: left;
            height: 2036px;
        }
        .auto-style3 {
            margin-left: 410px;
            margin-top: 0px;
        }
        .auto-style4 {
            width: 762px;
            height: 347px;
        }
        .auto-style18 {
            width: 380px;
            height: 49px;
        }
        .auto-style19 {
            width: 380px;
            height: 50px;
        }
        .auto-style21 {
            width: 380px;
            height: 92px;
        }
        .auto-style22 {
            text-align: center;
            margin-left: 258px;
        }
        .auto-style23 {
            width: 100%;
            height: 444px;
        }
        .auto-style28 {
            height: 49px;
        }
        .auto-style29 {
            height: 50px;
        }
        .auto-style30 {
            height: 49px;
            width: 451px;
        }
        .auto-style31 {
            height: 50px;
            width: 451px;
        }
        .auto-style32 {
            text-align: center;
            margin-left: 326px;
        }
        .auto-style33 {
            width: 100%;
            height: 162px;
            margin-top: 0px;
        }
        .auto-style34 {
            width: 359px;
            text-align: center;
        }
        .auto-style35 {
            text-align: center;
        }
        .auto-style36 {
            width: 359px;
            height: 74px;
        }
        .auto-style37 {
            text-align: center;
            height: 74px;
        }
        .auto-style38 {
            text-align: center;
            margin-left: 126px;
        }
        .auto-style39 {
            width: 100%;
            height: 201px;
        }
        .auto-style40 {
            width: 506px;
        }
        .auto-style41 {
            width: 506px;
            height: 102px;
        }
        .auto-style42 {
            height: 102px;
        }
        .auto-style43 {
            width: 799px;
            height: 261px;
        }
        .auto-style45 {
            width: 398px;
            height: 53px;
        }
        .auto-style46 {
            height: 53px;
            text-align: center;
            width: 399px;
        }
        .auto-style50 {
            width: 398px;
            height: 52px;
        }
        .auto-style51 {
            height: 52px;
            width: 399px;
        }
        .auto-style52 {
            width: 98%;
            height: 298px;
        }
        .auto-style53 {
            width: 610px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Felicitari esti logata ca admin!</div>
        <p>
            <asp:Label ID="InfoMesage" runat="server" BackColor="#009933" Font-Bold="True" Font-Size="XX-Large" ForeColor="Black" Text="Label"></asp:Label>
        </p>
        <p>
            Adimii pot efectua una dintre acesta opreatiuni (click pe buton):</p>
        <p>
            <asp:Button ID="AdInstructor" runat="server" OnClick="Button1_Click" Text="Adauga Instructor" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="StergeInstuctor" runat="server" OnClick="StergeInstuctor_Click" Text="Sterge Instructor" Width="195px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="UpdateInstructorB1" runat="server" OnClick="UpdateInstructorB1_Click" Text="Update Instructor" Width="185px" />
        &nbsp;&nbsp;
            <asp:Button ID="Statistici" runat="server" OnClick="Statistici_Click" Text="Statistici" Width="172px" />
        </p>
        <p>
            <asp:Button ID="AdProfesor" runat="server" OnClick="AdProfesor_Click" Text="Adauga Proesor" Width="196px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Buton1StergeProfesor" runat="server" OnClick="Buton1StergeProfesor_Click" Text="Sterge Profesor" Width="200px" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="UpdateProfsorB1" runat="server" OnClick="UpdateProfsorB1_Click" Text="Update Profesor" Width="183px" />
        </p>
        <p>
            &nbsp;<asp:Button ID="AdElev" runat="server" OnClick="AdElev_Click" Text="Adauga Elev" Width="193px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="StergeElevB1" runat="server" OnClick="StergeElevB1_Click" Text="Sterge Elev" Width="196px" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="UpdateElevB1" runat="server" Text="UpdateElev" Width="183px" OnClick="UpdateElevB1_Click" />
        </p>
        <asp:Panel ID="Panel1" runat="server" BackColor="#FF9966" CssClass="auto-style3" Height="495px" HorizontalAlign="Center" Width="785px">
            <asp:Label ID="Label1" runat="server" Text="Datele Instructorului"></asp:Label>
            <table class="auto-style4">
                <tr>
                    <td class="auto-style18">
                        <asp:TextBox ID="NumeInstructor" runat="server" Height="30px" Width="344px"></asp:TextBox>
                    </td>
                    <td class="auto-style18">Nume</td>
                </tr>
                <tr>
                    <td id="PrenumeInstructor" class="auto-style18">
                        <asp:TextBox ID="PrenumeInstructor" runat="server" Height="30px" Width="344px"></asp:TextBox>
                    </td>
                    <td class="auto-style18">Prenume</td>
                </tr>
                <tr>
                    <td class="auto-style18">
                        <asp:TextBox ID="CategorieInstructor" runat="server" Height="30px" Width="344px"></asp:TextBox>
                    </td>
                    <td id="CategorieInstructor" class="auto-style18">Categorie</td>
                </tr>
                <tr>
                    <td id="CNPInstructor" class="auto-style19">
                        <asp:TextBox ID="CNPInstructor" runat="server" Height="30px" Width="344px"></asp:TextBox>
                    </td>
                    <td class="auto-style19">CNP</td>
                </tr>
                <tr>
                    <td id="SalariuInstructor" class="auto-style19">
                        <asp:TextBox ID="SalariuInstructor" runat="server" Height="30px" Width="344px"></asp:TextBox>
                    </td>
                    <td class="auto-style19">Salariu</td>
                </tr>
                <tr>
                    <td id="ExpirareInstructor" class="auto-style19">
                        <asp:TextBox ID="ExpirareInstructor" runat="server" Height="39px" TextMode="Date" Width="345px"></asp:TextBox>
                    </td>
                    <td class="auto-style19">Data expirarii licentei</td>
                </tr>
                <tr>
                    <td id="Anuleaza" class="auto-style21">
                        <asp:Button ID="AnuleazaInstructor" runat="server" Height="65px" OnClick="AnuleazaInstructor_Click" Text="Anuleaza" Width="212px" />
                    </td>
                    <td class="auto-style21">
                        <asp:Button ID="AdaugaInstructor" runat="server" Height="61px" OnClick="AdaugaInstructor_Click" Text="Adauga" Width="219px" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <div class="auto-style2">
            <br />
            <asp:Panel ID="Panel2" runat="server" BackColor="#FF9933" CssClass="auto-style22" Height="548px" Width="905px">
                <asp:Label ID="Label2" runat="server" Text="Date Elev"></asp:Label>
                <table class="auto-style23">
                    <tr>
                        <td class="auto-style30">
                            <asp:TextBox ID="NumeElev" runat="server" Height="31px" Width="316px"></asp:TextBox>
                        </td>
                        <td class="auto-style28">
                            <asp:Label ID="Num" runat="server" Text="Nume"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td id="PrenumeElev" class="auto-style30">
                            <asp:TextBox ID="PrenumeElev" runat="server" Height="31px" Width="316px"></asp:TextBox>
                        </td>
                        <td class="auto-style28">
                            <asp:Label ID="prenume" runat="server" Text="Prenume"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td id="CNPElev" class="auto-style30">
                            <asp:TextBox ID="CnpElev" runat="server" Height="31px" Width="316px"></asp:TextBox>
                        </td>
                        <td class="auto-style28">
                            <asp:Label ID="Label6" runat="server" Text="CNP"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td id="TelefonElev" class="auto-style30">
                            <asp:TextBox ID="TelefonElev" runat="server" Height="31px" Width="316px"></asp:TextBox>
                        </td>
                        <td class="auto-style28">
                            <asp:Label ID="Label7" runat="server" Text="Telefon"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style30">
                            <asp:TextBox ID="CategorieElev" runat="server" Height="31px" Width="316px"></asp:TextBox>
                        </td>
                        <td class="auto-style28">
                            <asp:Label ID="Label8" runat="server" Text="Categoria"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style30">
                            <asp:TextBox ID="SumaPlatitaElev" runat="server" Height="31px" Width="316px"></asp:TextBox>
                        </td>
                        <td class="auto-style28">
                            <asp:Label ID="Label9" runat="server" Text="Suma Platita"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style31">
                            <asp:DropDownList ID="NumeInstructorElev" runat="server" Height="18px" Width="310px">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style29">
                            <asp:Label ID="Label10" runat="server" Text="Instructor"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style31">
                            <asp:TextBox ID="DataScolarizarii" runat="server" Height="30px" TextMode="Date" Width="327px"></asp:TextBox>
                        </td>
                        <td class="auto-style29">
                            <asp:Label ID="Label12" runat="server" Text="Data Scolarizarii"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td id="ProfesoriLegislatieElev" class="auto-style31">
                            <asp:DropDownList ID="ProfesorLegislatieElev" runat="server" Height="18px" Width="310px">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style29">
                            <asp:Label ID="Label11" runat="server" Text="Profesor Legislatie"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style31">
                            <asp:Button ID="AnuleazaElev" runat="server" Height="42px" Text="Anuleaza" Width="224px" />
                        </td>
                        <td class="auto-style29">
                            <asp:Button ID="AdaugaElevGrid" runat="server" Height="42px" OnClick="AdaugaElevGrid_Click" Text="Adauga" Width="224px" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <br />
            <br />
            <asp:Panel ID="StergeInstructorPopUp" runat="server" BackColor="#FF6666" CssClass="auto-style32" Height="261px" HorizontalAlign="Center" Width="873px">
                <asp:Label ID="StergeLabel" runat="server" Text="Sterge Instructor" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                <br />
                <br />
                <table class="auto-style33">
                    <tr>
                        <td class="auto-style36">
                            <asp:DropDownList ID="ListaInstructoriStergere" runat="server" Height="16px" Width="252px">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style37">
                            <asp:Label ID="Label13" runat="server" Font-Size="X-Large" Text="Numele instructorului care va fi sters"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style34">
                            <asp:Button ID="AnuleazaStergeInstructor" runat="server" Height="42px" OnClick="AnuleazaStergeInstructor_Click" Text="Anuleaza" Width="224px" />
                        </td>
                        <td id="S" class="auto-style35">
                            <asp:Button ID="StergeInstructorGrid" runat="server" Height="43px" OnClick="StergeInstructorGrid_Click" Text="Sterge" Width="218px" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <br />
            <br />
            <br />
            <br />
            <asp:Panel ID="PanelUpdateIstructor" runat="server" BackColor="#339966" Height="303px" Width="807px">
                <asp:Label ID="Label16" runat="server" Text="Update Instructor"></asp:Label>
                <table class="auto-style43">
                    <tr>
                        <td class="auto-style50">
                            <asp:Label ID="Label17" runat="server" Text="Ce vrei sa modifici:"></asp:Label>
                        </td>
                        <td class="auto-style51">
                            <asp:DropDownList ID="DropDownList2" runat="server" Height="24px" Width="296px">
                                <asp:ListItem>Nume</asp:ListItem>
                                <asp:ListItem>Prenume</asp:ListItem>
                                <asp:ListItem>DataExpriariiLicentei</asp:ListItem>
                                <asp:ListItem>Categorie</asp:ListItem>
                                <asp:ListItem>Salariu</asp:ListItem>
                                <asp:ListItem>CNP</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style50">
                            <asp:Label ID="Label18" runat="server" Text="Alege Instructorul"></asp:Label>
                        </td>
                        <td class="auto-style51">
                            <asp:DropDownList ID="ListaInstructoriUpdateInstructor" runat="server" Height="16px" Width="310px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style50">Valoarea cu care modifici</td>
                        <td class="auto-style51">
                            <asp:TextBox ID="UpdateInstructorTextBox" runat="server" Height="23px" Width="302px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style50">
                            <asp:Button ID="AfiseazaValActualUpdateInstructor" runat="server" Height="35px" OnClick="AfiseazaValActualUpdateInstructor_Click" Text="Afiseaza Val Actuala" Width="280px" />
                        </td>
                        <td class="auto-style51">
                            <asp:Label ID="ValoareaActualaInstructor" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style45">
                            <asp:Button ID="AnuleazaUpdateInstructor" runat="server" Text="Inapoi" Width="304px" OnClick="AnuleazaUpdateInstructor_Click" />
                        </td>
                        <td class="auto-style46">
                            <asp:Button ID="ModificaInstructor" runat="server" Height="34px" OnClick="ModificaInstructor_Click" Text="Modifica" Width="297px" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel5" runat="server" BackColor="#EAC720" Height="338px" Width="629px">
                <asp:Label ID="Label19" runat="server" Text="Update elev"></asp:Label>
                <table class="auto-style52">
                    <tr>
                        <td class="auto-style53">ALEGE ELEVUL:</td>
                        <td>
                            <asp:DropDownList ID="ListaElevi2" runat="server" Height="16px" Width="241px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style53">Ce vrei sa modifici:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList3" runat="server" Width="232px">
                                <asp:ListItem>Nume</asp:ListItem>
                                <asp:ListItem>Prenume</asp:ListItem>
                                <asp:ListItem>CNP</asp:ListItem>
                                <asp:ListItem>Telefon</asp:ListItem>
                                <asp:ListItem>Categoria</asp:ListItem>
                                <asp:ListItem>SumaPlatita</asp:ListItem>
                                <asp:ListItem>DataScolarizaii</asp:ListItem>
                                <asp:ListItem>Instructor</asp:ListItem>
                                <asp:ListItem>Profesor</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style53">
                            <asp:Button ID="ValCurentElev" runat="server" Text="Afiseaza Valoarea curenta" Width="235px" OnClick="ValCurentElev_Click" />
                        </td>
                        <td class="auto-style35">
                            <asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style53">Valoarea cu care modifici:</td>
                        <td class="auto-style35">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style53">
                            <asp:Button ID="Button1" runat="server" Text="Inapoi" Width="189px" />
                        </td>
                        <td class="auto-style35">
                            <asp:Button ID="ModificaElev" runat="server" OnClick="ModificaElev_Click" Text="Modifica" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <br />
            <br />
            <br />
            <br />
            <asp:Panel ID="PanelStergeElevi" runat="server" BackColor="#FFCCCC" CssClass="auto-style38" Height="241px" Width="998px">
                <asp:Label ID="Label14" runat="server" Text="Sterge Elev" Font-Bold="True" Font-Size="Large"></asp:Label>
                <table class="auto-style39">
                    <tr>
                        <td class="auto-style41">
                            <asp:DropDownList ID="ListaElevi" runat="server" Height="21px" Width="345px">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style42">
                            <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Size="Large" Text="Nume elev + CNP"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style40">
                            <asp:Button ID="AnuleazaStergeElevi" runat="server" Height="64px" OnClick="AnuleazaStergeElevi_Click" Text="Anuleaza" Width="243px" />
                        </td>
                        <td>
                            <asp:Button ID="StergeElevB2" runat="server" Height="57px" OnClick="StergeElevB2_Click" Text="StergeElev" Width="212px" />
                        </td>
                    </tr>
                </table>
                <br />
            </asp:Panel>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Panel ID="Panel4" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
