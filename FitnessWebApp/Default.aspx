<%@ Page 
    Title="Fitness app" 
    Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="Default.aspx.cs" 
    Inherits="FitnessWebApp._Default" 
%>
<%@ Register 
    Src="~/UserControls/TimerControl.ascx" 
    TagPrefix="uc" 
    TagName="TimerControl" 
%>

<asp:Content 
    ID="BodyContent" 
    ContentPlaceHolderID="MainContent" 
    runat="server">

  <!-- ========== Fitness Stopwatch ========== -->
  <h2 class="mb-3">Fitness Stopwatch</h2>
  <uc:TimerControl ID="TimerControl1" runat="server" />

  <!-- Optional: force a full postback to verify state persistence -->

  <hr />


  <!-- ======= BMI Calculator Tester ======= -->
  <h3 class="mb-2">Test BMI Calculator</h3>

  <div class="mb-2">
    <asp:Label 
        ID="lblHeight" 
        runat="server" 
        AssociatedControlID="txtHeight"
        Text="Height (cm):" />
    <asp:TextBox 
        ID="txtHeight" 
        runat="server" 
        Width="60px" />
  </div>

  <div class="mb-3">
    <asp:Label 
        ID="lblWeight" 
        runat="server" 
        AssociatedControlID="txtWeight"
        Text="Weight (kg):" />
    <asp:TextBox 
        ID="txtWeight" 
        runat="server" 
        Width="60px" />
  </div>

  <asp:Button 
      ID="btnCalcBMI" 
      runat="server" 
      Text="Calculate BMI" 
      CssClass="btn btn-primary"
      OnClick="btnCalcBMI_Click" />
  <br /><br />
  <asp:Label 
      ID="lblBMIResult" 
      runat="server" 
      CssClass="fw-bold text-info" />
    <hr />
    <!-- ======= Service Directory ======= -->
    <h2>Component Service Directory</h2>
<table class="table table-bordered">
  <thead>
    <tr>
      <th>Provider</th>
      <th>Component</th>
      <th>Description</th>
      <th>TryIt</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Ebraheem Baadiyan</td>
      <td>Session Tracker (Global.asax)</td>
      <td>
        Logs session start/end times to XML.
        Inputs: (automatic on Session_Start/End)
        Outputs: App_Data/SessionLog.xml
      </td>
      <td>
        <asp:Button runat="server" Text="End Session Now" OnClick="btnEndSession_Click" CssClass="btn btn-sm btn-warning"/>
      </td>
    </tr>
    <tr>
      <td>Ebraheem Baadiyan</td>
      <td>Fitness Stopwatch (UserControl)</td>
      <td>
        Start/Stop/Reset timer for fitness. 
        Inputs: Start, Stop, Reset clicks. 
        Outputs: Elapsed time label.
      </td>
      <td>
        (Use the stopwatch above)
      </td>
    </tr>
    <tr>
      <td>Ebraheem Baadiyan</td>
      <td>BMI Calculator (ASMX)</td>
      <td>
        Calculates BMI from height (cm) &amp; weight (kg). 
        Inputs: heightCm (float), weightKg (float). 
        Output: “BMI: 24.2 (Normal)”.
      </td>
      <td>
        <a runat="server" href="BMICalculator.asmx?op=CalculateBMI" 
           target="_blank" class="btn btn-sm btn-primary">
          Service WSDL
        </a>
      </td>
    </tr>
  </tbody>
</table>
     <!-- ======== Session‑End Helper ======== -->
 <asp:Button 
     ID="btnEndSession" 
     runat="server" 
     Text="End Session Now" 
     CssClass="btn btn-warning"
     OnClick="btnEndSession_Click" />
 &nbsp;
 <asp:Label 
     ID="lblEndSessionMsg" 
     runat="server" 
     CssClass="text-success fw-bold" />
     <!-- ======== admin and Member ======== -->
    <div class="btn-group" role="group" style="margin-bottom:20px;">
  <asp:Button 
    ID="btnMemberPage" 
    runat="server" 
    CssClass="btn btn-success" 
    Text="Member Page" 
    OnClick="btnMemberPage_Click" />

  <asp:Button 
    ID="btnStaffPage" 
    runat="server" 
    CssClass="btn btn-danger" 
    Text="Admin Page" 
    OnClick="btnStaffPage_Click" />
</div>

</asp:Content>
