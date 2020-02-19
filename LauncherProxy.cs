/// <remarks/>
[System.Web.Services.WebServiceBinding(Name="Service1Soap", Namespace="http://tempurl.com/")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueType))]
public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback RetrieveCompanyListOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrieveDoctrineHeaderOperationCompleted;
    
    private System.Threading.SendOrPostCallback CreateCompanyOperationCompleted;
    
    private System.Threading.SendOrPostCallback TestBattleFileOperationCompleted;
    
    private System.Threading.SendOrPostCallback ReadyForBattleFileOperationCompleted;
    
    private System.Threading.SendOrPostCallback RecieveReportOperationCompleted;
    
    private System.Threading.SendOrPostCallback SetToCompletedOperationCompleted;
    
    private System.Threading.SendOrPostCallback RecieveSquadQueueOperationCompleted;
    
    private System.Threading.SendOrPostCallback RecieveDoctrineSelectionQueueOperationCompleted;
    
    private System.Threading.SendOrPostCallback
          RecieveAdvantageSelectionQueueOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrieveDoctrineOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrieveReinforcementsOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrieveAdvantagesOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrieveReportsOperationCompleted;
    
    private System.Threading.SendOrPostCallback RecievePrimaryDoctrineOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrieveBattleListOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrieveAvailabilityOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrieveNewsOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrieveTickerOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrieveWarProgressOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrieveBattleAdvantageListOperationCompleted;
    
    private System.Threading.SendOrPostCallback RecieveBattleAdvantageQueueOperationCompleted;
    
    private System.Threading.SendOrPostCallback RecieveRewardQueueOperationCompleted;
    
    private System.Threading.SendOrPostCallback RecieveXFireAccountOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrieveChatOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrieveSectorListOperationCompleted;
    
    private System.Threading.SendOrPostCallback SendChatOperationCompleted;
    
    private System.Threading.SendOrPostCallback SendXFireOperationCompleted;
    
    private System.Threading.SendOrPostCallback RequestJoinBattleOperationCompleted;
    
    private System.Threading.SendOrPostCallback RequestLeaveBattleOperationCompleted;
    
    private System.Threading.SendOrPostCallback RequestCreateBattleOperationCompleted;
    
    private System.Threading.SendOrPostCallback ChangeBattlePlayersOperationCompleted;
    
    private System.Threading.SendOrPostCallback ChangeBattleGameTypeOperationCompleted;
    
    private System.Threading.SendOrPostCallback ChangeBattlePlayerPhaseOperationCompleted;
    
    private System.Threading.SendOrPostCallback RequestDeleteCompanyOperationCompleted;
    
    private System.Threading.SendOrPostCallback RequestBattleFileOperationCompleted;
    
    private System.Threading.SendOrPostCallback RequestUCSFileOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrieveDoctrineHeadersOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrievePUnitsOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrievePUnitListOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrieveUnitsOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrieveRewardsOperationCompleted;
    
    private System.Threading.SendOrPostCallback RetrieveProfileOperationCompleted;
    
    private System.Threading.SendOrPostCallback VerifyLoginOperationCompleted;
    
    private System.Threading.SendOrPostCallback VerifyUserVersionOperationCompleted;
    
    private System.Threading.SendOrPostCallback AttemptLoginOperationCompleted;
    
    public Service1() {
        this.Url = "http://67.223.225.161:8081/service/Service1.asmx";
    }
    
    public event RetrieveCompanyListCompletedEventHandler RetrieveCompanyListCompleted;
    
    public event RetrieveDoctrineHeaderCompletedEventHandler RetrieveDoctrineHeaderCompleted;
    
    public event CreateCompanyCompletedEventHandler CreateCompanyCompleted;
    
    public event TestBattleFileCompletedEventHandler TestBattleFileCompleted;
    
    public event ReadyForBattleFileCompletedEventHandler ReadyForBattleFileCompleted;
    
    public event RecieveReportCompletedEventHandler RecieveReportCompleted;
    
    public event SetToCompletedCompletedEventHandler SetToCompletedCompleted;
    
    public event RecieveSquadQueueCompletedEventHandler RecieveSquadQueueCompleted;
    
    public event RecieveDoctrineSelectionQueueCompletedEventHandler
          RecieveDoctrineSelectionQueueCompleted;
    
    public event RecieveAdvantageSelectionQueueCompletedEventHandler
          RecieveAdvantageSelectionQueueCompleted;
    
    public event RetrieveDoctrineCompletedEventHandler RetrieveDoctrineCompleted;
    
    public event RetrieveReinforcementsCompletedEventHandler RetrieveReinforcementsCompleted;
    
    public event RetrieveAdvantagesCompletedEventHandler RetrieveAdvantagesCompleted;
    
    public event RetrieveReportsCompletedEventHandler RetrieveReportsCompleted;
    
    public event RecievePrimaryDoctrineCompletedEventHandler RecievePrimaryDoctrineCompleted;
    
    public event RetrieveBattleListCompletedEventHandler RetrieveBattleListCompleted;
    
    public event RetrieveAvailabilityCompletedEventHandler RetrieveAvailabilityCompleted;
    
    public event RetrieveNewsCompletedEventHandler RetrieveNewsCompleted;
    
    public event RetrieveTickerCompletedEventHandler RetrieveTickerCompleted;
    
    public event RetrieveWarProgressCompletedEventHandler RetrieveWarProgressCompleted;
    
    public event RetrieveBattleAdvantageListCompletedEventHandler
          RetrieveBattleAdvantageListCompleted;
    
    public event RecieveBattleAdvantageQueueCompletedEventHandler
          RecieveBattleAdvantageQueueCompleted;
    
    public event RecieveRewardQueueCompletedEventHandler RecieveRewardQueueCompleted;
    
    public event RecieveXFireAccountCompletedEventHandler RecieveXFireAccountCompleted;
    
    public event RetrieveChatCompletedEventHandler RetrieveChatCompleted;
    
    public event RetrieveSectorListCompletedEventHandler RetrieveSectorListCompleted;
    
    public event SendChatCompletedEventHandler SendChatCompleted;
    
    public event SendXFireCompletedEventHandler SendXFireCompleted;
    
    public event RequestJoinBattleCompletedEventHandler RequestJoinBattleCompleted;
    
    public event RequestLeaveBattleCompletedEventHandler RequestLeaveBattleCompleted;
    
    public event RequestCreateBattleCompletedEventHandler RequestCreateBattleCompleted;
    
    public event ChangeBattlePlayersCompletedEventHandler ChangeBattlePlayersCompleted;
    
    public event ChangeBattleGameTypeCompletedEventHandler ChangeBattleGameTypeCompleted;
    
    public event ChangeBattlePlayerPhaseCompletedEventHandler ChangeBattlePlayerPhaseCompleted;
    
    public event RequestDeleteCompanyCompletedEventHandler RequestDeleteCompanyCompleted;
    
    public event RequestBattleFileCompletedEventHandler RequestBattleFileCompleted;
    
    public event RequestUCSFileCompletedEventHandler RequestUCSFileCompleted;
    
    public event RetrieveDoctrineHeadersCompletedEventHandler RetrieveDoctrineHeadersCompleted;
    
    public event RetrievePUnitsCompletedEventHandler RetrievePUnitsCompleted;
    
    public event RetrievePUnitListCompletedEventHandler RetrievePUnitListCompleted;
    
    public event RetrieveUnitsCompletedEventHandler RetrieveUnitsCompleted;
    
    public event RetrieveRewardsCompletedEventHandler RetrieveRewardsCompleted;
    
    public event RetrieveProfileCompletedEventHandler RetrieveProfileCompleted;
    
    public event VerifyLoginCompletedEventHandler VerifyLoginCompleted;
    
    public event VerifyUserVersionCompletedEventHandler VerifyUserVersionCompleted;
    
    public event AttemptLoginCompletedEventHandler AttemptLoginCompleted;
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveCompanyList", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public CompanyList RetrieveCompanyList(LoginV2 login) {
        object[] results = this.Invoke("RetrieveCompanyList", new object[] {
                    login});
        return ((CompanyList)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveCompanyList(LoginV2 login, System.AsyncCallback
          callback, object asyncState) {
        return this.BeginInvoke("RetrieveCompanyList", new object[] {
                    login}, callback, asyncState);
    }
    
    public CompanyList EndRetrieveCompanyList(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((CompanyList)(results[0]));
    }
    
    public void RetrieveCompanyListAsync(LoginV2 login) {
        this.RetrieveCompanyListAsync(login, null);
    }
    
    public void RetrieveCompanyListAsync(LoginV2 login, object userState) {
        if ((this.RetrieveCompanyListOperationCompleted == null)) {
            this.RetrieveCompanyListOperationCompleted = new
                  System.Threading.SendOrPostCallback(this.OnRetrieveCompanyListCompleted);
        }
        this.InvokeAsync("RetrieveCompanyList", new object[] {
                    login}, this.RetrieveCompanyListOperationCompleted, userState);
    }
    
    private void OnRetrieveCompanyListCompleted(object arg) {
        if ((this.RetrieveCompanyListCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveCompanyListCompleted(this, new RetrieveCompanyListCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveDoctrineHeader", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public DoctrinesHeader RetrieveDoctrineHeader(LoginV2 login) {
        object[] results = this.Invoke("RetrieveDoctrineHeader", new object[] {
                    login});
        return ((DoctrinesHeader)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveDoctrineHeader(LoginV2 login, System.AsyncCallback
          callback, object asyncState) {
        return this.BeginInvoke("RetrieveDoctrineHeader", new object[] {
                    login}, callback, asyncState);
    }
    
    public DoctrinesHeader EndRetrieveDoctrineHeader(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((DoctrinesHeader)(results[0]));
    }
    
    public void RetrieveDoctrineHeaderAsync(LoginV2 login) {
        this.RetrieveDoctrineHeaderAsync(login, null);
    }
    
    public void RetrieveDoctrineHeaderAsync(LoginV2 login, object userState) {
        if ((this.RetrieveDoctrineHeaderOperationCompleted == null)) {
            this.RetrieveDoctrineHeaderOperationCompleted = new
                  System.Threading.SendOrPostCallback(this.OnRetrieveDoctrineHeaderCompleted);
        }
        this.InvokeAsync("RetrieveDoctrineHeader", new object[] {
                    login}, this.RetrieveDoctrineHeaderOperationCompleted, userState);
    }
    
    private void OnRetrieveDoctrineHeaderCompleted(object arg) {
        if ((this.RetrieveDoctrineHeaderCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveDoctrineHeaderCompleted(this, new
                  RetrieveDoctrineHeaderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error,
                  invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/CreateCompany", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public CompanyList CreateCompany(LoginV2 login, string relicname, int doc) {
        object[] results = this.Invoke("CreateCompany", new object[] {
                    login,
                    relicname,
                    doc});
        return ((CompanyList)(results[0]));
    }
    
    public System.IAsyncResult BeginCreateCompany(LoginV2 login, string relicname, int doc,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("CreateCompany", new object[] {
                    login,
                    relicname,
                    doc}, callback, asyncState);
    }
    
    public CompanyList EndCreateCompany(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((CompanyList)(results[0]));
    }
    
    public void CreateCompanyAsync(LoginV2 login, string relicname, int doc) {
        this.CreateCompanyAsync(login, relicname, doc, null);
    }
    
    public void CreateCompanyAsync(LoginV2 login, string relicname, int doc, object userState) {
        if ((this.CreateCompanyOperationCompleted == null)) {
            this.CreateCompanyOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnCreateCompanyCompleted);
        }
        this.InvokeAsync("CreateCompany", new object[] {
                    login,
                    relicname,
                    doc}, this.CreateCompanyOperationCompleted, userState);
    }
    
    private void OnCreateCompanyCompleted(object arg) {
        if ((this.CreateCompanyCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.CreateCompanyCompleted(this, new CreateCompanyCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/TestBattleFile", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public void TestBattleFile(string battle, string ucs, int btid) {
        this.Invoke("TestBattleFile", new object[] {
                    battle,
                    ucs,
                    btid});
    }
    
    public System.IAsyncResult BeginTestBattleFile(string battle, string ucs, int btid,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("TestBattleFile", new object[] {
                    battle,
                    ucs,
                    btid}, callback, asyncState);
    }
    
    public void EndTestBattleFile(System.IAsyncResult asyncResult) {
        this.EndInvoke(asyncResult);
    }
    
    public void TestBattleFileAsync(string battle, string ucs, int btid) {
        this.TestBattleFileAsync(battle, ucs, btid, null);
    }
    
    public void TestBattleFileAsync(string battle, string ucs, int btid, object userState) {
        if ((this.TestBattleFileOperationCompleted == null)) {
            this.TestBattleFileOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnTestBattleFileCompleted);
        }
        this.InvokeAsync("TestBattleFile", new object[] {
                    battle,
                    ucs,
                    btid}, this.TestBattleFileOperationCompleted, userState);
    }
    
    private void OnTestBattleFileCompleted(object arg) {
        if ((this.TestBattleFileCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.TestBattleFileCompleted(this, new
                  System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error,
                  invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/ReadyForBattleFile", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public bool ReadyForBattleFile(int btid) {
        object[] results = this.Invoke("ReadyForBattleFile", new object[] {
                    btid});
        return ((bool)(results[0]));
    }
    
    public System.IAsyncResult BeginReadyForBattleFile(int btid, System.AsyncCallback callback,
          object asyncState) {
        return this.BeginInvoke("ReadyForBattleFile", new object[] {
                    btid}, callback, asyncState);
    }
    
    public bool EndReadyForBattleFile(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    public void ReadyForBattleFileAsync(int btid) {
        this.ReadyForBattleFileAsync(btid, null);
    }
    
    public void ReadyForBattleFileAsync(int btid, object userState) {
        if ((this.ReadyForBattleFileOperationCompleted == null)) {
            this.ReadyForBattleFileOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnReadyForBattleFileCompleted);
        }
        this.InvokeAsync("ReadyForBattleFile", new object[] {
                    btid}, this.ReadyForBattleFileOperationCompleted, userState);
    }
    
    private void OnReadyForBattleFileCompleted(object arg) {
        if ((this.ReadyForBattleFileCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.ReadyForBattleFileCompleted(this, new ReadyForBattleFileCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RecieveReport", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public bool RecieveReport(Login login, string report) {
        object[] results = this.Invoke("RecieveReport", new object[] {
                    login,
                    report});
        return ((bool)(results[0]));
    }
    
    public System.IAsyncResult BeginRecieveReport(Login login, string report,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RecieveReport", new object[] {
                    login,
                    report}, callback, asyncState);
    }
    
    public bool EndRecieveReport(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    public void RecieveReportAsync(Login login, string report) {
        this.RecieveReportAsync(login, report, null);
    }
    
    public void RecieveReportAsync(Login login, string report, object userState) {
        if ((this.RecieveReportOperationCompleted == null)) {
            this.RecieveReportOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRecieveReportCompleted);
        }
        this.InvokeAsync("RecieveReport", new object[] {
                    login,
                    report}, this.RecieveReportOperationCompleted, userState);
    }
    
    private void OnRecieveReportCompleted(object arg) {
        if ((this.RecieveReportCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RecieveReportCompleted(this, new RecieveReportCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/SetToCompleted", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public bool SetToCompleted(Login login, int bid) {
        object[] results = this.Invoke("SetToCompleted", new object[] {
                    login,
                    bid});
        return ((bool)(results[0]));
    }
    
    public System.IAsyncResult BeginSetToCompleted(Login login, int bid, System.AsyncCallback
          callback, object asyncState) {
        return this.BeginInvoke("SetToCompleted", new object[] {
                    login,
                    bid}, callback, asyncState);
    }
    
    public bool EndSetToCompleted(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    public void SetToCompletedAsync(Login login, int bid) {
        this.SetToCompletedAsync(login, bid, null);
    }
    
    public void SetToCompletedAsync(Login login, int bid, object userState) {
        if ((this.SetToCompletedOperationCompleted == null)) {
            this.SetToCompletedOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnSetToCompletedCompleted);
        }
        this.InvokeAsync("SetToCompleted", new object[] {
                    login,
                    bid}, this.SetToCompletedOperationCompleted, userState);
    }
    
    private void OnSetToCompletedCompleted(object arg) {
        if ((this.SetToCompletedCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.SetToCompletedCompleted(this, new SetToCompletedCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RecieveSquadQueue", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public bool RecieveSquadQueue(LoginV2 login, DataSquadQueue dsq, int bid) {
        object[] results = this.Invoke("RecieveSquadQueue", new object[] {
                    login,
                    dsq,
                    bid});
        return ((bool)(results[0]));
    }
    
    public System.IAsyncResult BeginRecieveSquadQueue(LoginV2 login, DataSquadQueue dsq, int
          bid, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RecieveSquadQueue", new object[] {
                    login,
                    dsq,
                    bid}, callback, asyncState);
    }
    
    public bool EndRecieveSquadQueue(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    public void RecieveSquadQueueAsync(LoginV2 login, DataSquadQueue dsq, int bid) {
        this.RecieveSquadQueueAsync(login, dsq, bid, null);
    }
    
    public void RecieveSquadQueueAsync(LoginV2 login, DataSquadQueue dsq, int bid, object
          userState) {
        if ((this.RecieveSquadQueueOperationCompleted == null)) {
            this.RecieveSquadQueueOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRecieveSquadQueueCompleted);
        }
        this.InvokeAsync("RecieveSquadQueue", new object[] {
                    login,
                    dsq,
                    bid}, this.RecieveSquadQueueOperationCompleted, userState);
    }
    
    private void OnRecieveSquadQueueCompleted(object arg) {
        if ((this.RecieveSquadQueueCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RecieveSquadQueueCompleted(this, new RecieveSquadQueueCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RecieveDoctrineSelectionQueue",
          RequestNamespace="http://tempurl.com/", ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public bool RecieveDoctrineSelectionQueue(LoginV2 login, DataDoctrineSelectionQueue dsq,
          int bid) {
        object[] results = this.Invoke("RecieveDoctrineSelectionQueue", new object[] {
                    login,
                    dsq,
                    bid});
        return ((bool)(results[0]));
    }
    
    public System.IAsyncResult BeginRecieveDoctrineSelectionQueue(LoginV2 login,
          DataDoctrineSelectionQueue dsq, int bid, System.AsyncCallback callback, object
          asyncState) {
        return this.BeginInvoke("RecieveDoctrineSelectionQueue", new object[] {
                    login,
                    dsq,
                    bid}, callback, asyncState);
    }
    
    public bool EndRecieveDoctrineSelectionQueue(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    public void RecieveDoctrineSelectionQueueAsync(LoginV2 login, DataDoctrineSelectionQueue
          dsq, int bid) {
        this.RecieveDoctrineSelectionQueueAsync(login, dsq, bid, null);
    }
    
    public void RecieveDoctrineSelectionQueueAsync(LoginV2 login, DataDoctrineSelectionQueue
          dsq, int bid, object userState) {
        if ((this.RecieveDoctrineSelectionQueueOperationCompleted == null)) {
            this.RecieveDoctrineSelectionQueueOperationCompleted = new
                  System.Threading.SendOrPostCallback(
                 this.OnRecieveDoctrineSelectionQueueCompleted);
        }
        this.InvokeAsync("RecieveDoctrineSelectionQueue", new object[] {
                    login,
                    dsq,
                    bid}, this.RecieveDoctrineSelectionQueueOperationCompleted, userState);
    }
    
    private void OnRecieveDoctrineSelectionQueueCompleted(object arg) {
        if ((this.RecieveDoctrineSelectionQueueCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RecieveDoctrineSelectionQueueCompleted(this, new
                  RecieveDoctrineSelectionQueueCompletedEventArgs(invokeArgs.Results,
                  invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RecieveAdvantageSelectionQueue",
          RequestNamespace="http://tempurl.com/", ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public bool RecieveAdvantageSelectionQueue(Login login, AdvantageQueue asq, int bid) {
        object[] results = this.Invoke("RecieveAdvantageSelectionQueue", new object[] {
                    login,
                    asq,
                    bid});
        return ((bool)(results[0]));
    }
    
    public System.IAsyncResult BeginRecieveAdvantageSelectionQueue(Login login, AdvantageQueue
          asq, int bid, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RecieveAdvantageSelectionQueue", new object[] {
                    login,
                    asq,
                    bid}, callback, asyncState);
    }
    
    public bool EndRecieveAdvantageSelectionQueue(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    public void RecieveAdvantageSelectionQueueAsync(Login login, AdvantageQueue asq, int bid) {
        this.RecieveAdvantageSelectionQueueAsync(login, asq, bid, null);
    }
    
    public void RecieveAdvantageSelectionQueueAsync(Login login, AdvantageQueue asq, int bid,
          object userState) {
        if ((this.RecieveAdvantageSelectionQueueOperationCompleted == null)) {
            this.RecieveAdvantageSelectionQueueOperationCompleted = new
                  System.Threading.SendOrPostCallback(
                 this.OnRecieveAdvantageSelectionQueueCompleted);
        }
        this.InvokeAsync("RecieveAdvantageSelectionQueue", new object[] {
                    login,
                    asq,
                    bid}, this.RecieveAdvantageSelectionQueueOperationCompleted, userState);
    }
    
    private void OnRecieveAdvantageSelectionQueueCompleted(object arg) {
        if ((this.RecieveAdvantageSelectionQueueCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RecieveAdvantageSelectionQueueCompleted(this, new
                  RecieveAdvantageSelectionQueueCompletedEventArgs(invokeArgs.Results,
                  invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveDoctrine", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public Doctrine RetrieveDoctrine(Login login, int did, int bid) {
        object[] results = this.Invoke("RetrieveDoctrine", new object[] {
                    login,
                    did,
                    bid});
        return ((Doctrine)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveDoctrine(Login login, int did, int bid,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RetrieveDoctrine", new object[] {
                    login,
                    did,
                    bid}, callback, asyncState);
    }
    
    public Doctrine EndRetrieveDoctrine(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Doctrine)(results[0]));
    }
    
    public void RetrieveDoctrineAsync(Login login, int did, int bid) {
        this.RetrieveDoctrineAsync(login, did, bid, null);
    }
    
    public void RetrieveDoctrineAsync(Login login, int did, int bid, object userState) {
        if ((this.RetrieveDoctrineOperationCompleted == null)) {
            this.RetrieveDoctrineOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRetrieveDoctrineCompleted);
        }
        this.InvokeAsync("RetrieveDoctrine", new object[] {
                    login,
                    did,
                    bid}, this.RetrieveDoctrineOperationCompleted, userState);
    }
    
    private void OnRetrieveDoctrineCompleted(object arg) {
        if ((this.RetrieveDoctrineCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveDoctrineCompleted(this, new RetrieveDoctrineCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveReinforcements", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public Reinforcements RetrieveReinforcements(Login login, int bid) {
        object[] results = this.Invoke("RetrieveReinforcements", new object[] {
                    login,
                    bid});
        return ((Reinforcements)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveReinforcements(Login login, int bid,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RetrieveReinforcements", new object[] {
                    login,
                    bid}, callback, asyncState);
    }
    
    public Reinforcements EndRetrieveReinforcements(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Reinforcements)(results[0]));
    }
    
    public void RetrieveReinforcementsAsync(Login login, int bid) {
        this.RetrieveReinforcementsAsync(login, bid, null);
    }
    
    public void RetrieveReinforcementsAsync(Login login, int bid, object userState) {
        if ((this.RetrieveReinforcementsOperationCompleted == null)) {
            this.RetrieveReinforcementsOperationCompleted = new
                  System.Threading.SendOrPostCallback(this.OnRetrieveReinforcementsCompleted);
        }
        this.InvokeAsync("RetrieveReinforcements", new object[] {
                    login,
                    bid}, this.RetrieveReinforcementsOperationCompleted, userState);
    }
    
    private void OnRetrieveReinforcementsCompleted(object arg) {
        if ((this.RetrieveReinforcementsCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveReinforcementsCompleted(this, new
                  RetrieveReinforcementsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error,
                  invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveAdvantages", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public AdvantageList RetrieveAdvantages(Login login, int bid) {
        object[] results = this.Invoke("RetrieveAdvantages", new object[] {
                    login,
                    bid});
        return ((AdvantageList)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveAdvantages(Login login, int bid,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RetrieveAdvantages", new object[] {
                    login,
                    bid}, callback, asyncState);
    }
    
    public AdvantageList EndRetrieveAdvantages(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((AdvantageList)(results[0]));
    }
    
    public void RetrieveAdvantagesAsync(Login login, int bid) {
        this.RetrieveAdvantagesAsync(login, bid, null);
    }
    
    public void RetrieveAdvantagesAsync(Login login, int bid, object userState) {
        if ((this.RetrieveAdvantagesOperationCompleted == null)) {
            this.RetrieveAdvantagesOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRetrieveAdvantagesCompleted);
        }
        this.InvokeAsync("RetrieveAdvantages", new object[] {
                    login,
                    bid}, this.RetrieveAdvantagesOperationCompleted, userState);
    }
    
    private void OnRetrieveAdvantagesCompleted(object arg) {
        if ((this.RetrieveAdvantagesCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveAdvantagesCompleted(this, new RetrieveAdvantagesCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveReports", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public ReportList RetrieveReports(int btid) {
        object[] results = this.Invoke("RetrieveReports", new object[] {
                    btid});
        return ((ReportList)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveReports(int btid, System.AsyncCallback callback,
          object asyncState) {
        return this.BeginInvoke("RetrieveReports", new object[] {
                    btid}, callback, asyncState);
    }
    
    public ReportList EndRetrieveReports(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((ReportList)(results[0]));
    }
    
    public void RetrieveReportsAsync(int btid) {
        this.RetrieveReportsAsync(btid, null);
    }
    
    public void RetrieveReportsAsync(int btid, object userState) {
        if ((this.RetrieveReportsOperationCompleted == null)) {
            this.RetrieveReportsOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRetrieveReportsCompleted);
        }
        this.InvokeAsync("RetrieveReports", new object[] {
                    btid}, this.RetrieveReportsOperationCompleted, userState);
    }
    
    private void OnRetrieveReportsCompleted(object arg) {
        if ((this.RetrieveReportsCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveReportsCompleted(this, new RetrieveReportsCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RecievePrimaryDoctrine", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public bool RecievePrimaryDoctrine(Login login, int did) {
        object[] results = this.Invoke("RecievePrimaryDoctrine", new object[] {
                    login,
                    did});
        return ((bool)(results[0]));
    }
    
    public System.IAsyncResult BeginRecievePrimaryDoctrine(Login login, int did,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RecievePrimaryDoctrine", new object[] {
                    login,
                    did}, callback, asyncState);
    }
    
    public bool EndRecievePrimaryDoctrine(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    public void RecievePrimaryDoctrineAsync(Login login, int did) {
        this.RecievePrimaryDoctrineAsync(login, did, null);
    }
    
    public void RecievePrimaryDoctrineAsync(Login login, int did, object userState) {
        if ((this.RecievePrimaryDoctrineOperationCompleted == null)) {
            this.RecievePrimaryDoctrineOperationCompleted = new
                  System.Threading.SendOrPostCallback(this.OnRecievePrimaryDoctrineCompleted);
        }
        this.InvokeAsync("RecievePrimaryDoctrine", new object[] {
                    login,
                    did}, this.RecievePrimaryDoctrineOperationCompleted, userState);
    }
    
    private void OnRecievePrimaryDoctrineCompleted(object arg) {
        if ((this.RecievePrimaryDoctrineCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RecievePrimaryDoctrineCompleted(this, new
                  RecievePrimaryDoctrineCompletedEventArgs(invokeArgs.Results, invokeArgs.Error,
                  invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveBattleList", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public BattleList RetrieveBattleList(int bid, string datetime) {
        object[] results = this.Invoke("RetrieveBattleList", new object[] {
                    bid,
                    datetime});
        return ((BattleList)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveBattleList(int bid, string datetime,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RetrieveBattleList", new object[] {
                    bid,
                    datetime}, callback, asyncState);
    }
    
    public BattleList EndRetrieveBattleList(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((BattleList)(results[0]));
    }
    
    public void RetrieveBattleListAsync(int bid, string datetime) {
        this.RetrieveBattleListAsync(bid, datetime, null);
    }
    
    public void RetrieveBattleListAsync(int bid, string datetime, object userState) {
        if ((this.RetrieveBattleListOperationCompleted == null)) {
            this.RetrieveBattleListOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRetrieveBattleListCompleted);
        }
        this.InvokeAsync("RetrieveBattleList", new object[] {
                    bid,
                    datetime}, this.RetrieveBattleListOperationCompleted, userState);
    }
    
    private void OnRetrieveBattleListCompleted(object arg) {
        if ((this.RetrieveBattleListCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveBattleListCompleted(this, new RetrieveBattleListCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveAvailability", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public AvailabilityPool RetrieveAvailability(int bid) {
        object[] results = this.Invoke("RetrieveAvailability", new object[] {
                    bid});
        return ((AvailabilityPool)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveAvailability(int bid, System.AsyncCallback callback,
          object asyncState) {
        return this.BeginInvoke("RetrieveAvailability", new object[] {
                    bid}, callback, asyncState);
    }
    
    public AvailabilityPool EndRetrieveAvailability(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((AvailabilityPool)(results[0]));
    }
    
    public void RetrieveAvailabilityAsync(int bid) {
        this.RetrieveAvailabilityAsync(bid, null);
    }
    
    public void RetrieveAvailabilityAsync(int bid, object userState) {
        if ((this.RetrieveAvailabilityOperationCompleted == null)) {
            this.RetrieveAvailabilityOperationCompleted = new
                  System.Threading.SendOrPostCallback(this.OnRetrieveAvailabilityCompleted);
        }
        this.InvokeAsync("RetrieveAvailability", new object[] {
                    bid}, this.RetrieveAvailabilityOperationCompleted, userState);
    }
    
    private void OnRetrieveAvailabilityCompleted(object arg) {
        if ((this.RetrieveAvailabilityCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveAvailabilityCompleted(this, new RetrieveAvailabilityCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveNews", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public string RetrieveNews(int bid) {
        object[] results = this.Invoke("RetrieveNews", new object[] {
                    bid});
        return ((string)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveNews(int bid, System.AsyncCallback callback, object
          asyncState) {
        return this.BeginInvoke("RetrieveNews", new object[] {
                    bid}, callback, asyncState);
    }
    
    public string EndRetrieveNews(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    public void RetrieveNewsAsync(int bid) {
        this.RetrieveNewsAsync(bid, null);
    }
    
    public void RetrieveNewsAsync(int bid, object userState) {
        if ((this.RetrieveNewsOperationCompleted == null)) {
            this.RetrieveNewsOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRetrieveNewsCompleted);
        }
        this.InvokeAsync("RetrieveNews", new object[] {
                    bid}, this.RetrieveNewsOperationCompleted, userState);
    }
    
    private void OnRetrieveNewsCompleted(object arg) {
        if ((this.RetrieveNewsCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveNewsCompleted(this, new RetrieveNewsCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveTicker", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public string RetrieveTicker(int bid) {
        object[] results = this.Invoke("RetrieveTicker", new object[] {
                    bid});
        return ((string)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveTicker(int bid, System.AsyncCallback callback,
          object asyncState) {
        return this.BeginInvoke("RetrieveTicker", new object[] {
                    bid}, callback, asyncState);
    }
    
    public string EndRetrieveTicker(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    public void RetrieveTickerAsync(int bid) {
        this.RetrieveTickerAsync(bid, null);
    }
    
    public void RetrieveTickerAsync(int bid, object userState) {
        if ((this.RetrieveTickerOperationCompleted == null)) {
            this.RetrieveTickerOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRetrieveTickerCompleted);
        }
        this.InvokeAsync("RetrieveTicker", new object[] {
                    bid}, this.RetrieveTickerOperationCompleted, userState);
    }
    
    private void OnRetrieveTickerCompleted(object arg) {
        if ((this.RetrieveTickerCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveTickerCompleted(this, new RetrieveTickerCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveWarProgress", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public WarProgress RetrieveWarProgress() {
        object[] results = this.Invoke("RetrieveWarProgress", new object[0]);
        return ((WarProgress)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveWarProgress(System.AsyncCallback callback, object
          asyncState) {
        return this.BeginInvoke("RetrieveWarProgress", new object[0], callback, asyncState);
    }
    
    public WarProgress EndRetrieveWarProgress(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((WarProgress)(results[0]));
    }
    
    public void RetrieveWarProgressAsync() {
        this.RetrieveWarProgressAsync(null);
    }
    
    public void RetrieveWarProgressAsync(object userState) {
        if ((this.RetrieveWarProgressOperationCompleted == null)) {
            this.RetrieveWarProgressOperationCompleted = new
                  System.Threading.SendOrPostCallback(this.OnRetrieveWarProgressCompleted);
        }
        this.InvokeAsync("RetrieveWarProgress", new object[0],
              this.RetrieveWarProgressOperationCompleted, userState);
    }
    
    private void OnRetrieveWarProgressCompleted(object arg) {
        if ((this.RetrieveWarProgressCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveWarProgressCompleted(this, new RetrieveWarProgressCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveBattleAdvantageList",
          RequestNamespace="http://tempurl.com/", ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public BattleAdvantageList RetrieveBattleAdvantageList(int bid, int btid) {
        object[] results = this.Invoke("RetrieveBattleAdvantageList", new object[] {
                    bid,
                    btid});
        return ((BattleAdvantageList)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveBattleAdvantageList(int bid, int btid,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RetrieveBattleAdvantageList", new object[] {
                    bid,
                    btid}, callback, asyncState);
    }
    
    public BattleAdvantageList EndRetrieveBattleAdvantageList(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((BattleAdvantageList)(results[0]));
    }
    
    public void RetrieveBattleAdvantageListAsync(int bid, int btid) {
        this.RetrieveBattleAdvantageListAsync(bid, btid, null);
    }
    
    public void RetrieveBattleAdvantageListAsync(int bid, int btid, object userState) {
        if ((this.RetrieveBattleAdvantageListOperationCompleted == null)) {
            this.RetrieveBattleAdvantageListOperationCompleted = new
                  System.Threading.SendOrPostCallback(
                 this.OnRetrieveBattleAdvantageListCompleted);
        }
        this.InvokeAsync("RetrieveBattleAdvantageList", new object[] {
                    bid,
                    btid}, this.RetrieveBattleAdvantageListOperationCompleted, userState);
    }
    
    private void OnRetrieveBattleAdvantageListCompleted(object arg) {
        if ((this.RetrieveBattleAdvantageListCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveBattleAdvantageListCompleted(this, new
                  RetrieveBattleAdvantageListCompletedEventArgs(invokeArgs.Results,
                  invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RecieveBattleAdvantageQueue",
          RequestNamespace="http://tempurl.com/", ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public bool RecieveBattleAdvantageQueue(LoginV2 login, int bid, int btid,
          BattleAdvantageQueue bal) {
        object[] results = this.Invoke("RecieveBattleAdvantageQueue", new object[] {
                    login,
                    bid,
                    btid,
                    bal});
        return ((bool)(results[0]));
    }
    
    public System.IAsyncResult BeginRecieveBattleAdvantageQueue(LoginV2 login, int bid, int
          btid, BattleAdvantageQueue bal, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RecieveBattleAdvantageQueue", new object[] {
                    login,
                    bid,
                    btid,
                    bal}, callback, asyncState);
    }
    
    public bool EndRecieveBattleAdvantageQueue(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    public void RecieveBattleAdvantageQueueAsync(LoginV2 login, int bid, int btid,
          BattleAdvantageQueue bal) {
        this.RecieveBattleAdvantageQueueAsync(login, bid, btid, bal, null);
    }
    
    public void RecieveBattleAdvantageQueueAsync(LoginV2 login, int bid, int btid,
          BattleAdvantageQueue bal, object userState) {
        if ((this.RecieveBattleAdvantageQueueOperationCompleted == null)) {
            this.RecieveBattleAdvantageQueueOperationCompleted = new
                  System.Threading.SendOrPostCallback(
                 this.OnRecieveBattleAdvantageQueueCompleted);
        }
        this.InvokeAsync("RecieveBattleAdvantageQueue", new object[] {
                    login,
                    bid,
                    btid,
                    bal}, this.RecieveBattleAdvantageQueueOperationCompleted, userState);
    }
    
    private void OnRecieveBattleAdvantageQueueCompleted(object arg) {
        if ((this.RecieveBattleAdvantageQueueCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RecieveBattleAdvantageQueueCompleted(this, new
                  RecieveBattleAdvantageQueueCompletedEventArgs(invokeArgs.Results,
                  invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RecieveRewardQueue", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public bool RecieveRewardQueue(LoginV2 login, int bid, DataRewardQueue brq) {
        object[] results = this.Invoke("RecieveRewardQueue", new object[] {
                    login,
                    bid,
                    brq});
        return ((bool)(results[0]));
    }
    
    public System.IAsyncResult BeginRecieveRewardQueue(LoginV2 login, int bid, DataRewardQueue
          brq, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RecieveRewardQueue", new object[] {
                    login,
                    bid,
                    brq}, callback, asyncState);
    }
    
    public bool EndRecieveRewardQueue(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    public void RecieveRewardQueueAsync(LoginV2 login, int bid, DataRewardQueue brq) {
        this.RecieveRewardQueueAsync(login, bid, brq, null);
    }
    
    public void RecieveRewardQueueAsync(LoginV2 login, int bid, DataRewardQueue brq, object
          userState) {
        if ((this.RecieveRewardQueueOperationCompleted == null)) {
            this.RecieveRewardQueueOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRecieveRewardQueueCompleted);
        }
        this.InvokeAsync("RecieveRewardQueue", new object[] {
                    login,
                    bid,
                    brq}, this.RecieveRewardQueueOperationCompleted, userState);
    }
    
    private void OnRecieveRewardQueueCompleted(object arg) {
        if ((this.RecieveRewardQueueCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RecieveRewardQueueCompleted(this, new RecieveRewardQueueCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RecieveXFireAccount", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public void RecieveXFireAccount(int bid, string xfire) {
        this.Invoke("RecieveXFireAccount", new object[] {
                    bid,
                    xfire});
    }
    
    public System.IAsyncResult BeginRecieveXFireAccount(int bid, string xfire,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RecieveXFireAccount", new object[] {
                    bid,
                    xfire}, callback, asyncState);
    }
    
    public void EndRecieveXFireAccount(System.IAsyncResult asyncResult) {
        this.EndInvoke(asyncResult);
    }
    
    public void RecieveXFireAccountAsync(int bid, string xfire) {
        this.RecieveXFireAccountAsync(bid, xfire, null);
    }
    
    public void RecieveXFireAccountAsync(int bid, string xfire, object userState) {
        if ((this.RecieveXFireAccountOperationCompleted == null)) {
            this.RecieveXFireAccountOperationCompleted = new
                  System.Threading.SendOrPostCallback(this.OnRecieveXFireAccountCompleted);
        }
        this.InvokeAsync("RecieveXFireAccount", new object[] {
                    bid,
                    xfire}, this.RecieveXFireAccountOperationCompleted, userState);
    }
    
    private void OnRecieveXFireAccountCompleted(object arg) {
        if ((this.RecieveXFireAccountCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RecieveXFireAccountCompleted(this, new
                  System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error,
                  invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveChat", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public Chat RetrieveChat(int bid, string dateTime) {
        object[] results = this.Invoke("RetrieveChat", new object[] {
                    bid,
                    dateTime});
        return ((Chat)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveChat(int bid, string dateTime, System.AsyncCallback
          callback, object asyncState) {
        return this.BeginInvoke("RetrieveChat", new object[] {
                    bid,
                    dateTime}, callback, asyncState);
    }
    
    public Chat EndRetrieveChat(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Chat)(results[0]));
    }
    
    public void RetrieveChatAsync(int bid, string dateTime) {
        this.RetrieveChatAsync(bid, dateTime, null);
    }
    
    public void RetrieveChatAsync(int bid, string dateTime, object userState) {
        if ((this.RetrieveChatOperationCompleted == null)) {
            this.RetrieveChatOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRetrieveChatCompleted);
        }
        this.InvokeAsync("RetrieveChat", new object[] {
                    bid,
                    dateTime}, this.RetrieveChatOperationCompleted, userState);
    }
    
    private void OnRetrieveChatCompleted(object arg) {
        if ((this.RetrieveChatCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveChatCompleted(this, new RetrieveChatCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveSectorList", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public SectorList RetrieveSectorList(int bid, string dateTime) {
        object[] results = this.Invoke("RetrieveSectorList", new object[] {
                    bid,
                    dateTime});
        return ((SectorList)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveSectorList(int bid, string dateTime,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RetrieveSectorList", new object[] {
                    bid,
                    dateTime}, callback, asyncState);
    }
    
    public SectorList EndRetrieveSectorList(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((SectorList)(results[0]));
    }
    
    public void RetrieveSectorListAsync(int bid, string dateTime) {
        this.RetrieveSectorListAsync(bid, dateTime, null);
    }
    
    public void RetrieveSectorListAsync(int bid, string dateTime, object userState) {
        if ((this.RetrieveSectorListOperationCompleted == null)) {
            this.RetrieveSectorListOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRetrieveSectorListCompleted);
        }
        this.InvokeAsync("RetrieveSectorList", new object[] {
                    bid,
                    dateTime}, this.RetrieveSectorListOperationCompleted, userState);
    }
    
    private void OnRetrieveSectorListCompleted(object arg) {
        if ((this.RetrieveSectorListCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveSectorListCompleted(this, new RetrieveSectorListCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempurl.com/SendChat",
          RequestNamespace="http://tempurl.com/", ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public Chat SendChat(int bid, string text) {
        object[] results = this.Invoke("SendChat", new object[] {
                    bid,
                    text});
        return ((Chat)(results[0]));
    }
    
    public System.IAsyncResult BeginSendChat(int bid, string text, System.AsyncCallback
          callback, object asyncState) {
        return this.BeginInvoke("SendChat", new object[] {
                    bid,
                    text}, callback, asyncState);
    }
    
    public Chat EndSendChat(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Chat)(results[0]));
    }
    
    public void SendChatAsync(int bid, string text) {
        this.SendChatAsync(bid, text, null);
    }
    
    public void SendChatAsync(int bid, string text, object userState) {
        if ((this.SendChatOperationCompleted == null)) {
            this.SendChatOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnSendChatCompleted);
        }
        this.InvokeAsync("SendChat", new object[] {
                    bid,
                    text}, this.SendChatOperationCompleted, userState);
    }
    
    private void OnSendChatCompleted(object arg) {
        if ((this.SendChatCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.SendChatCompleted(this, new SendChatCompletedEventArgs(invokeArgs.Results,
                  invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempurl.com/SendXFire",
          RequestNamespace="http://tempurl.com/", ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public Chat SendXFire(int bid, int broadcasting) {
        object[] results = this.Invoke("SendXFire", new object[] {
                    bid,
                    broadcasting});
        return ((Chat)(results[0]));
    }
    
    public System.IAsyncResult BeginSendXFire(int bid, int broadcasting, System.AsyncCallback
          callback, object asyncState) {
        return this.BeginInvoke("SendXFire", new object[] {
                    bid,
                    broadcasting}, callback, asyncState);
    }
    
    public Chat EndSendXFire(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Chat)(results[0]));
    }
    
    public void SendXFireAsync(int bid, int broadcasting) {
        this.SendXFireAsync(bid, broadcasting, null);
    }
    
    public void SendXFireAsync(int bid, int broadcasting, object userState) {
        if ((this.SendXFireOperationCompleted == null)) {
            this.SendXFireOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnSendXFireCompleted);
        }
        this.InvokeAsync("SendXFire", new object[] {
                    bid,
                    broadcasting}, this.SendXFireOperationCompleted, userState);
    }
    
    private void OnSendXFireCompleted(object arg) {
        if ((this.SendXFireCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.SendXFireCompleted(this, new SendXFireCompletedEventArgs(invokeArgs.Results,
                  invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RequestJoinBattle", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public bool RequestJoinBattle(LoginV2 login, int bid, int btid) {
        object[] results = this.Invoke("RequestJoinBattle", new object[] {
                    login,
                    bid,
                    btid});
        return ((bool)(results[0]));
    }
    
    public System.IAsyncResult BeginRequestJoinBattle(LoginV2 login, int bid, int btid,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RequestJoinBattle", new object[] {
                    login,
                    bid,
                    btid}, callback, asyncState);
    }
    
    public bool EndRequestJoinBattle(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    public void RequestJoinBattleAsync(LoginV2 login, int bid, int btid) {
        this.RequestJoinBattleAsync(login, bid, btid, null);
    }
    
    public void RequestJoinBattleAsync(LoginV2 login, int bid, int btid, object userState) {
        if ((this.RequestJoinBattleOperationCompleted == null)) {
            this.RequestJoinBattleOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRequestJoinBattleCompleted);
        }
        this.InvokeAsync("RequestJoinBattle", new object[] {
                    login,
                    bid,
                    btid}, this.RequestJoinBattleOperationCompleted, userState);
    }
    
    private void OnRequestJoinBattleCompleted(object arg) {
        if ((this.RequestJoinBattleCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RequestJoinBattleCompleted(this, new RequestJoinBattleCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RequestLeaveBattle", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public bool RequestLeaveBattle(LoginV2 login, int bid) {
        object[] results = this.Invoke("RequestLeaveBattle", new object[] {
                    login,
                    bid});
        return ((bool)(results[0]));
    }
    
    public System.IAsyncResult BeginRequestLeaveBattle(LoginV2 login, int bid,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RequestLeaveBattle", new object[] {
                    login,
                    bid}, callback, asyncState);
    }
    
    public bool EndRequestLeaveBattle(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    public void RequestLeaveBattleAsync(LoginV2 login, int bid) {
        this.RequestLeaveBattleAsync(login, bid, null);
    }
    
    public void RequestLeaveBattleAsync(LoginV2 login, int bid, object userState) {
        if ((this.RequestLeaveBattleOperationCompleted == null)) {
            this.RequestLeaveBattleOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRequestLeaveBattleCompleted);
        }
        this.InvokeAsync("RequestLeaveBattle", new object[] {
                    login,
                    bid}, this.RequestLeaveBattleOperationCompleted, userState);
    }
    
    private void OnRequestLeaveBattleCompleted(object arg) {
        if ((this.RequestLeaveBattleCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RequestLeaveBattleCompleted(this, new RequestLeaveBattleCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RequestCreateBattle", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public bool RequestCreateBattle(LoginV2 login, int bid, int campaign) {
        object[] results = this.Invoke("RequestCreateBattle", new object[] {
                    login,
                    bid,
                    campaign});
        return ((bool)(results[0]));
    }
    
    public System.IAsyncResult BeginRequestCreateBattle(LoginV2 login, int bid, int campaign,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RequestCreateBattle", new object[] {
                    login,
                    bid,
                    campaign}, callback, asyncState);
    }
    
    public bool EndRequestCreateBattle(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    public void RequestCreateBattleAsync(LoginV2 login, int bid, int campaign) {
        this.RequestCreateBattleAsync(login, bid, campaign, null);
    }
    
    public void RequestCreateBattleAsync(LoginV2 login, int bid, int campaign, object
          userState) {
        if ((this.RequestCreateBattleOperationCompleted == null)) {
            this.RequestCreateBattleOperationCompleted = new
                  System.Threading.SendOrPostCallback(this.OnRequestCreateBattleCompleted);
        }
        this.InvokeAsync("RequestCreateBattle", new object[] {
                    login,
                    bid,
                    campaign}, this.RequestCreateBattleOperationCompleted, userState);
    }
    
    private void OnRequestCreateBattleCompleted(object arg) {
        if ((this.RequestCreateBattleCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RequestCreateBattleCompleted(this, new RequestCreateBattleCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/ChangeBattlePlayers", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public bool ChangeBattlePlayers(LoginV2 login, int btid, int num) {
        object[] results = this.Invoke("ChangeBattlePlayers", new object[] {
                    login,
                    btid,
                    num});
        return ((bool)(results[0]));
    }
    
    public System.IAsyncResult BeginChangeBattlePlayers(LoginV2 login, int btid, int num,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("ChangeBattlePlayers", new object[] {
                    login,
                    btid,
                    num}, callback, asyncState);
    }
    
    public bool EndChangeBattlePlayers(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    public void ChangeBattlePlayersAsync(LoginV2 login, int btid, int num) {
        this.ChangeBattlePlayersAsync(login, btid, num, null);
    }
    
    public void ChangeBattlePlayersAsync(LoginV2 login, int btid, int num, object userState) {
        if ((this.ChangeBattlePlayersOperationCompleted == null)) {
            this.ChangeBattlePlayersOperationCompleted = new
                  System.Threading.SendOrPostCallback(this.OnChangeBattlePlayersCompleted);
        }
        this.InvokeAsync("ChangeBattlePlayers", new object[] {
                    login,
                    btid,
                    num}, this.ChangeBattlePlayersOperationCompleted, userState);
    }
    
    private void OnChangeBattlePlayersCompleted(object arg) {
        if ((this.ChangeBattlePlayersCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.ChangeBattlePlayersCompleted(this, new ChangeBattlePlayersCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/ChangeBattleGameType", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public bool ChangeBattleGameType(LoginV2 login, int bid, int btid, int type) {
        object[] results = this.Invoke("ChangeBattleGameType", new object[] {
                    login,
                    bid,
                    btid,
                    type});
        return ((bool)(results[0]));
    }
    
    public System.IAsyncResult BeginChangeBattleGameType(LoginV2 login, int bid, int btid, int
          type, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("ChangeBattleGameType", new object[] {
                    login,
                    bid,
                    btid,
                    type}, callback, asyncState);
    }
    
    public bool EndChangeBattleGameType(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    public void ChangeBattleGameTypeAsync(LoginV2 login, int bid, int btid, int type) {
        this.ChangeBattleGameTypeAsync(login, bid, btid, type, null);
    }
    
    public void ChangeBattleGameTypeAsync(LoginV2 login, int bid, int btid, int type, object
          userState) {
        if ((this.ChangeBattleGameTypeOperationCompleted == null)) {
            this.ChangeBattleGameTypeOperationCompleted = new
                  System.Threading.SendOrPostCallback(this.OnChangeBattleGameTypeCompleted);
        }
        this.InvokeAsync("ChangeBattleGameType", new object[] {
                    login,
                    bid,
                    btid,
                    type}, this.ChangeBattleGameTypeOperationCompleted, userState);
    }
    
    private void OnChangeBattleGameTypeCompleted(object arg) {
        if ((this.ChangeBattleGameTypeCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.ChangeBattleGameTypeCompleted(this, new ChangeBattleGameTypeCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/ChangeBattlePlayerPhase", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public bool ChangeBattlePlayerPhase(LoginV2 login, int bid, int btid, int phase) {
        object[] results = this.Invoke("ChangeBattlePlayerPhase", new object[] {
                    login,
                    bid,
                    btid,
                    phase});
        return ((bool)(results[0]));
    }
    
    public System.IAsyncResult BeginChangeBattlePlayerPhase(LoginV2 login, int bid, int btid,
          int phase, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("ChangeBattlePlayerPhase", new object[] {
                    login,
                    bid,
                    btid,
                    phase}, callback, asyncState);
    }
    
    public bool EndChangeBattlePlayerPhase(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    public void ChangeBattlePlayerPhaseAsync(LoginV2 login, int bid, int btid, int phase) {
        this.ChangeBattlePlayerPhaseAsync(login, bid, btid, phase, null);
    }
    
    public void ChangeBattlePlayerPhaseAsync(LoginV2 login, int bid, int btid, int phase,
          object userState) {
        if ((this.ChangeBattlePlayerPhaseOperationCompleted == null)) {
            this.ChangeBattlePlayerPhaseOperationCompleted = new
                  System.Threading.SendOrPostCallback(this.OnChangeBattlePlayerPhaseCompleted);
        }
        this.InvokeAsync("ChangeBattlePlayerPhase", new object[] {
                    login,
                    bid,
                    btid,
                    phase}, this.ChangeBattlePlayerPhaseOperationCompleted, userState);
    }
    
    private void OnChangeBattlePlayerPhaseCompleted(object arg) {
        if ((this.ChangeBattlePlayerPhaseCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.ChangeBattlePlayerPhaseCompleted(this, new
                  ChangeBattlePlayerPhaseCompletedEventArgs(invokeArgs.Results,
                  invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RequestDeleteCompany", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public bool RequestDeleteCompany(LoginV2 login, int bid) {
        object[] results = this.Invoke("RequestDeleteCompany", new object[] {
                    login,
                    bid});
        return ((bool)(results[0]));
    }
    
    public System.IAsyncResult BeginRequestDeleteCompany(LoginV2 login, int bid,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RequestDeleteCompany", new object[] {
                    login,
                    bid}, callback, asyncState);
    }
    
    public bool EndRequestDeleteCompany(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    public void RequestDeleteCompanyAsync(LoginV2 login, int bid) {
        this.RequestDeleteCompanyAsync(login, bid, null);
    }
    
    public void RequestDeleteCompanyAsync(LoginV2 login, int bid, object userState) {
        if ((this.RequestDeleteCompanyOperationCompleted == null)) {
            this.RequestDeleteCompanyOperationCompleted = new
                  System.Threading.SendOrPostCallback(this.OnRequestDeleteCompanyCompleted);
        }
        this.InvokeAsync("RequestDeleteCompany", new object[] {
                    login,
                    bid}, this.RequestDeleteCompanyOperationCompleted, userState);
    }
    
    private void OnRequestDeleteCompanyCompleted(object arg) {
        if ((this.RequestDeleteCompanyCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RequestDeleteCompanyCompleted(this, new RequestDeleteCompanyCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RequestBattleFile", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public string RequestBattleFile(Login login, int btid) {
        object[] results = this.Invoke("RequestBattleFile", new object[] {
                    login,
                    btid});
        return ((string)(results[0]));
    }
    
    public System.IAsyncResult BeginRequestBattleFile(Login login, int btid,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RequestBattleFile", new object[] {
                    login,
                    btid}, callback, asyncState);
    }
    
    public string EndRequestBattleFile(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    public void RequestBattleFileAsync(Login login, int btid) {
        this.RequestBattleFileAsync(login, btid, null);
    }
    
    public void RequestBattleFileAsync(Login login, int btid, object userState) {
        if ((this.RequestBattleFileOperationCompleted == null)) {
            this.RequestBattleFileOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRequestBattleFileCompleted);
        }
        this.InvokeAsync("RequestBattleFile", new object[] {
                    login,
                    btid}, this.RequestBattleFileOperationCompleted, userState);
    }
    
    private void OnRequestBattleFileCompleted(object arg) {
        if ((this.RequestBattleFileCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RequestBattleFileCompleted(this, new RequestBattleFileCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RequestUCSFile", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public string RequestUCSFile(Login login, int btid) {
        object[] results = this.Invoke("RequestUCSFile", new object[] {
                    login,
                    btid});
        return ((string)(results[0]));
    }
    
    public System.IAsyncResult BeginRequestUCSFile(Login login, int btid, System.AsyncCallback
          callback, object asyncState) {
        return this.BeginInvoke("RequestUCSFile", new object[] {
                    login,
                    btid}, callback, asyncState);
    }
    
    public string EndRequestUCSFile(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    public void RequestUCSFileAsync(Login login, int btid) {
        this.RequestUCSFileAsync(login, btid, null);
    }
    
    public void RequestUCSFileAsync(Login login, int btid, object userState) {
        if ((this.RequestUCSFileOperationCompleted == null)) {
            this.RequestUCSFileOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRequestUCSFileCompleted);
        }
        this.InvokeAsync("RequestUCSFile", new object[] {
                    login,
                    btid}, this.RequestUCSFileOperationCompleted, userState);
    }
    
    private void OnRequestUCSFileCompleted(object arg) {
        if ((this.RequestUCSFileCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RequestUCSFileCompleted(this, new RequestUCSFileCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveDoctrineHeaders", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public DoctrineHeaders RetrieveDoctrineHeaders(Login login) {
        object[] results = this.Invoke("RetrieveDoctrineHeaders", new object[] {
                    login});
        return ((DoctrineHeaders)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveDoctrineHeaders(Login login, System.AsyncCallback
          callback, object asyncState) {
        return this.BeginInvoke("RetrieveDoctrineHeaders", new object[] {
                    login}, callback, asyncState);
    }
    
    public DoctrineHeaders EndRetrieveDoctrineHeaders(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((DoctrineHeaders)(results[0]));
    }
    
    public void RetrieveDoctrineHeadersAsync(Login login) {
        this.RetrieveDoctrineHeadersAsync(login, null);
    }
    
    public void RetrieveDoctrineHeadersAsync(Login login, object userState) {
        if ((this.RetrieveDoctrineHeadersOperationCompleted == null)) {
            this.RetrieveDoctrineHeadersOperationCompleted = new
                  System.Threading.SendOrPostCallback(this.OnRetrieveDoctrineHeadersCompleted);
        }
        this.InvokeAsync("RetrieveDoctrineHeaders", new object[] {
                    login}, this.RetrieveDoctrineHeadersOperationCompleted, userState);
    }
    
    private void OnRetrieveDoctrineHeadersCompleted(object arg) {
        if ((this.RetrieveDoctrineHeadersCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveDoctrineHeadersCompleted(this, new
                  RetrieveDoctrineHeadersCompletedEventArgs(invokeArgs.Results,
                  invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrievePUnits", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public UnitList RetrievePUnits(Login login) {
        object[] results = this.Invoke("RetrievePUnits", new object[] {
                    login});
        return ((UnitList)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrievePUnits(Login login, System.AsyncCallback callback,
          object asyncState) {
        return this.BeginInvoke("RetrievePUnits", new object[] {
                    login}, callback, asyncState);
    }
    
    public UnitList EndRetrievePUnits(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((UnitList)(results[0]));
    }
    
    public void RetrievePUnitsAsync(Login login) {
        this.RetrievePUnitsAsync(login, null);
    }
    
    public void RetrievePUnitsAsync(Login login, object userState) {
        if ((this.RetrievePUnitsOperationCompleted == null)) {
            this.RetrievePUnitsOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRetrievePUnitsCompleted);
        }
        this.InvokeAsync("RetrievePUnits", new object[] {
                    login}, this.RetrievePUnitsOperationCompleted, userState);
    }
    
    private void OnRetrievePUnitsCompleted(object arg) {
        if ((this.RetrievePUnitsCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrievePUnitsCompleted(this, new RetrievePUnitsCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrievePUnitList", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public UnitList RetrievePUnitList(Login login, int bid) {
        object[] results = this.Invoke("RetrievePUnitList", new object[] {
                    login,
                    bid});
        return ((UnitList)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrievePUnitList(Login login, int bid,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RetrievePUnitList", new object[] {
                    login,
                    bid}, callback, asyncState);
    }
    
    public UnitList EndRetrievePUnitList(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((UnitList)(results[0]));
    }
    
    public void RetrievePUnitListAsync(Login login, int bid) {
        this.RetrievePUnitListAsync(login, bid, null);
    }
    
    public void RetrievePUnitListAsync(Login login, int bid, object userState) {
        if ((this.RetrievePUnitListOperationCompleted == null)) {
            this.RetrievePUnitListOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRetrievePUnitListCompleted);
        }
        this.InvokeAsync("RetrievePUnitList", new object[] {
                    login,
                    bid}, this.RetrievePUnitListOperationCompleted, userState);
    }
    
    private void OnRetrievePUnitListCompleted(object arg) {
        if ((this.RetrievePUnitListCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrievePUnitListCompleted(this, new RetrievePUnitListCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveUnits", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public Battalion RetrieveUnits(Login login, int bid) {
        object[] results = this.Invoke("RetrieveUnits", new object[] {
                    login,
                    bid});
        return ((Battalion)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveUnits(Login login, int bid, System.AsyncCallback
          callback, object asyncState) {
        return this.BeginInvoke("RetrieveUnits", new object[] {
                    login,
                    bid}, callback, asyncState);
    }
    
    public Battalion EndRetrieveUnits(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Battalion)(results[0]));
    }
    
    public void RetrieveUnitsAsync(Login login, int bid) {
        this.RetrieveUnitsAsync(login, bid, null);
    }
    
    public void RetrieveUnitsAsync(Login login, int bid, object userState) {
        if ((this.RetrieveUnitsOperationCompleted == null)) {
            this.RetrieveUnitsOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRetrieveUnitsCompleted);
        }
        this.InvokeAsync("RetrieveUnits", new object[] {
                    login,
                    bid}, this.RetrieveUnitsOperationCompleted, userState);
    }
    
    private void OnRetrieveUnitsCompleted(object arg) {
        if ((this.RetrieveUnitsCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveUnitsCompleted(this, new RetrieveUnitsCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveRewards", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public Rewards RetrieveRewards(int bid) {
        object[] results = this.Invoke("RetrieveRewards", new object[] {
                    bid});
        return ((Rewards)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveRewards(int bid, System.AsyncCallback callback,
          object asyncState) {
        return this.BeginInvoke("RetrieveRewards", new object[] {
                    bid}, callback, asyncState);
    }
    
    public Rewards EndRetrieveRewards(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Rewards)(results[0]));
    }
    
    public void RetrieveRewardsAsync(int bid) {
        this.RetrieveRewardsAsync(bid, null);
    }
    
    public void RetrieveRewardsAsync(int bid, object userState) {
        if ((this.RetrieveRewardsOperationCompleted == null)) {
            this.RetrieveRewardsOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRetrieveRewardsCompleted);
        }
        this.InvokeAsync("RetrieveRewards", new object[] {
                    bid}, this.RetrieveRewardsOperationCompleted, userState);
    }
    
    private void OnRetrieveRewardsCompleted(object arg) {
        if ((this.RetrieveRewardsCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveRewardsCompleted(this, new RetrieveRewardsCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/RetrieveProfile", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public Profile RetrieveProfile(Login login) {
        object[] results = this.Invoke("RetrieveProfile", new object[] {
                    login});
        return ((Profile)(results[0]));
    }
    
    public System.IAsyncResult BeginRetrieveProfile(Login login, System.AsyncCallback callback,
          object asyncState) {
        return this.BeginInvoke("RetrieveProfile", new object[] {
                    login}, callback, asyncState);
    }
    
    public Profile EndRetrieveProfile(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Profile)(results[0]));
    }
    
    public void RetrieveProfileAsync(Login login) {
        this.RetrieveProfileAsync(login, null);
    }
    
    public void RetrieveProfileAsync(Login login, object userState) {
        if ((this.RetrieveProfileOperationCompleted == null)) {
            this.RetrieveProfileOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnRetrieveProfileCompleted);
        }
        this.InvokeAsync("RetrieveProfile", new object[] {
                    login}, this.RetrieveProfileOperationCompleted, userState);
    }
    
    private void OnRetrieveProfileCompleted(object arg) {
        if ((this.RetrieveProfileCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RetrieveProfileCompleted(this, new RetrieveProfileCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempurl.com/VerifyLogin",
          RequestNamespace="http://tempurl.com/", ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public bool VerifyLogin(Login login) {
        object[] results = this.Invoke("VerifyLogin", new object[] {
                    login});
        return ((bool)(results[0]));
    }
    
    public System.IAsyncResult BeginVerifyLogin(Login login, System.AsyncCallback callback,
          object asyncState) {
        return this.BeginInvoke("VerifyLogin", new object[] {
                    login}, callback, asyncState);
    }
    
    public bool EndVerifyLogin(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    public void VerifyLoginAsync(Login login) {
        this.VerifyLoginAsync(login, null);
    }
    
    public void VerifyLoginAsync(Login login, object userState) {
        if ((this.VerifyLoginOperationCompleted == null)) {
            this.VerifyLoginOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnVerifyLoginCompleted);
        }
        this.InvokeAsync("VerifyLogin", new object[] {
                    login}, this.VerifyLoginOperationCompleted, userState);
    }
    
    private void OnVerifyLoginCompleted(object arg) {
        if ((this.VerifyLoginCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.VerifyLoginCompleted(this, new VerifyLoginCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/VerifyUserVersion", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public LoginResponse VerifyUserVersion(Login login, string ver) {
        object[] results = this.Invoke("VerifyUserVersion", new object[] {
                    login,
                    ver});
        return ((LoginResponse)(results[0]));
    }
    
    public System.IAsyncResult BeginVerifyUserVersion(Login login, string ver,
          System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("VerifyUserVersion", new object[] {
                    login,
                    ver}, callback, asyncState);
    }
    
    public LoginResponse EndVerifyUserVersion(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((LoginResponse)(results[0]));
    }
    
    public void VerifyUserVersionAsync(Login login, string ver) {
        this.VerifyUserVersionAsync(login, ver, null);
    }
    
    public void VerifyUserVersionAsync(Login login, string ver, object userState) {
        if ((this.VerifyUserVersionOperationCompleted == null)) {
            this.VerifyUserVersionOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnVerifyUserVersionCompleted);
        }
        this.InvokeAsync("VerifyUserVersion", new object[] {
                    login,
                    ver}, this.VerifyUserVersionOperationCompleted, userState);
    }
    
    private void OnVerifyUserVersionCompleted(object arg) {
        if ((this.VerifyUserVersionCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.VerifyUserVersionCompleted(this, new VerifyUserVersionCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
         "http://tempurl.com/AttemptLogin", RequestNamespace="http://tempurl.com/",
          ResponseNamespace="http://tempurl.com/",
          ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,
          Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public LoginResponseV2 AttemptLogin(LoginV2 login) {
        object[] results = this.Invoke("AttemptLogin", new object[] {
                    login});
        return ((LoginResponseV2)(results[0]));
    }
    
    public System.IAsyncResult BeginAttemptLogin(LoginV2 login, System.AsyncCallback callback,
          object asyncState) {
        return this.BeginInvoke("AttemptLogin", new object[] {
                    login}, callback, asyncState);
    }
    
    public LoginResponseV2 EndAttemptLogin(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((LoginResponseV2)(results[0]));
    }
    
    public void AttemptLoginAsync(LoginV2 login) {
        this.AttemptLoginAsync(login, null);
    }
    
    public void AttemptLoginAsync(LoginV2 login, object userState) {
        if ((this.AttemptLoginOperationCompleted == null)) {
            this.AttemptLoginOperationCompleted = new System.Threading.SendOrPostCallback(
                 this.OnAttemptLoginCompleted);
        }
        this.InvokeAsync("AttemptLogin", new object[] {
                    login}, this.AttemptLoginOperationCompleted, userState);
    }
    
    private void OnAttemptLoginCompleted(object arg) {
        if ((this.AttemptLoginCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((
                 System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.AttemptLoginCompleted(this, new AttemptLoginCompletedEventArgs(
                 invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                  invokeArgs.UserState));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class LoginV2 : ValueType {
    
    /// <remarks/>
    public string pass;
    
    /// <remarks/>
    public string login;
    
    /// <remarks/>
    public string ver;
    
    /// <remarks/>
    public string mID;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LoginV2))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Login))]
public partial class ValueType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Login : ValueType {
    
    /// <remarks/>
    public string pass;
    
    /// <remarks/>
    public string login;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class CompanyList {
    
    /// <remarks/>
    public int ppid;
    
    /// <remarks/>
    public int username;
    
    /// <remarks/>
    public CompanyNode[] companies;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class CompanyNode {
    
    /// <remarks/>
    public int bid;
    
    /// <remarks/>
    public int rid;
    
    /// <remarks/>
    public int did;
    
    /// <remarks/>
    public string doctrine;
    
    /// <remarks/>
    public string name;
    
    /// <remarks/>
    public int xp;
    
    /// <remarks/>
    public int pp;
    
    /// <remarks/>
    public int win;
    
    /// <remarks/>
    public int loss;
    
    /// <remarks/>
    public int draw;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class DoctrinesHeader {
    
    /// <remarks/>
    public Doctrines[] doctrineLists;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Doctrines {
    
    /// <remarks/>
    public int rid;
    
    /// <remarks/>
    public Doctrine[] doctrines;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Doctrine {
    
    /// <remarks/>
    public int did;
    
    /// <remarks/>
    public string dname;
    
    /// <remarks/>
    public DoctrineSelection[] doctrineSelections;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class DoctrineSelection {
    
    /// <remarks/>
    public int did;
    
    /// <remarks/>
    public int dsid;
    
    /// <remarks/>
    public string dsname;
    
    /// <remarks/>
    public string descr;
    
    /// <remarks/>
    public int ppCost;
    
    /// <remarks/>
    public int tier;
    
    /// <remarks/>
    public int preReq;
    
    /// <remarks/>
    public int preReq2;
    
    /// <remarks/>
    public int xPos;
    
    /// <remarks/>
    public int yPos;
    
    /// <remarks/>
    public int icon;
    
    /// <remarks/>
    public int iconSheet;
    
    /// <remarks/>
    public bool selected;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class DataSquadQueue {
    
    /// <remarks/>
    public DataSquadCommand[] dataSquadCommands;
    
    /// <remarks/>
    public int ppTotal;
    
    /// <remarks/>
    public int ppCost;
    
    /// <remarks/>
    public int spTotal;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class DataSquadCommand {
    
    /// <remarks/>
    public Command command;
    
    /// <remarks/>
    public Squad data;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public enum Command {
    
    /// <remarks/>
    Add,
    
    /// <remarks/>
    Remove,
    
    /// <remarks/>
    Update,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Squad {
    
    /// <remarks/>
    public int sid;
    
    /// <remarks/>
    public int uid;
    
    /// <remarks/>
    public int rid;
    
    /// <remarks/>
    public int duid;
    
    /// <remarks/>
    public int sidt;
    
    /// <remarks/>
    public string name;
    
    /// <remarks/>
    public int pop;
    
    /// <remarks/>
    public int pid;
    
    /// <remarks/>
    public int xp;
    
    /// <remarks/>
    public int vet;
    
    /// <remarks/>
    public int icon;
    
    /// <remarks/>
    public int iconSheet;
    
    /// <remarks/>
    public int effectID;
    
    /// <remarks/>
    public int effectCost;
    
    /// <remarks/>
    public int origin;
    
    /// <remarks/>
    public int index;
    
    /// <remarks/>
    public Resources resources;
    
    /// <remarks/>
    public Upgrade[] upgrades;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Resources {
    
    /// <remarks/>
    public int MP;
    
    /// <remarks/>
    public int MU;
    
    /// <remarks/>
    public int FU;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Upgrade {
    
    /// <remarks/>
    public int upgid;
    
    /// <remarks/>
    public string name;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItem(IsNullable=false)]
    public int[] upgexcludes;
    
    /// <remarks/>
    public Resources resources;
    
    /// <remarks/>
    public int icon;
    
    /// <remarks/>
    public int iconSheet;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class DataDoctrineSelectionQueue {
    
    /// <remarks/>
    public int reid;
    
    /// <remarks/>
    public int ppTotal;
    
    /// <remarks/>
    public DataDoctrineSelectionCommand[] dataDoctrineSelectionCommands;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class DataDoctrineSelectionCommand {
    
    /// <remarks/>
    public Command command;
    
    /// <remarks/>
    public DoctrineSelection data;
    
    /// <remarks/>
    public int ppCost;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class AdvantageQueue {
    
    /// <remarks/>
    public Advantage[] advantagesBought;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Advantage {
    
    /// <remarks/>
    public string name;
    
    /// <remarks/>
    public int advid;
    
    /// <remarks/>
    public int cost;
    
    /// <remarks/>
    public AdvantageTier tier;
    
    /// <remarks/>
    public AdvantageTierGroup tiergroup;
    
    /// <remarks/>
    public string descr;
    
    /// <remarks/>
    public bool selected;
    
    /// <remarks/>
    public bool toggled;
    
    /// <remarks/>
    public int prereq;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public enum AdvantageTier {
    
    /// <remarks/>
    One,
    
    /// <remarks/>
    Two,
    
    /// <remarks/>
    Three,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public enum AdvantageTierGroup {
    
    /// <remarks/>
    Resources,
    
    /// <remarks/>
    Faction,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Reinforcements {
    
    /// <remarks/>
    public ReinforcementSelection[] reinforcementSelections;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class ReinforcementSelection {
    
    /// <remarks/>
    public int reid;
    
    /// <remarks/>
    public int dsid;
    
    /// <remarks/>
    public int rid;
    
    /// <remarks/>
    public int fid;
    
    /// <remarks/>
    public string name;
    
    /// <remarks/>
    public int xPos;
    
    /// <remarks/>
    public int yPos;
    
    /// <remarks/>
    public int icon;
    
    /// <remarks/>
    public int iconsheet;
    
    /// <remarks/>
    public Unit[] units;
    
    /// <remarks/>
    public bool selected;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Unit {
    
    /// <remarks/>
    public int uid;
    
    /// <remarks/>
    public int rid;
    
    /// <remarks/>
    public bool hidden;
    
    /// <remarks/>
    public string effectName;
    
    /// <remarks/>
    public int effectPID;
    
    /// <remarks/>
    public int effectID;
    
    /// <remarks/>
    public int effectUses;
    
    /// <remarks/>
    public int effectCost;
    
    /// <remarks/>
    public int ppl;
    
    /// <remarks/>
    public int slots;
    
    /// <remarks/>
    public int maxppl;
    
    /// <remarks/>
    public int vetmod;
    
    /// <remarks/>
    public int vet2cost;
    
    /// <remarks/>
    public int vet3cost;
    
    /// <remarks/>
    public string name;
    
    /// <remarks/>
    public int pop;
    
    /// <remarks/>
    public int maxunit;
    
    /// <remarks/>
    public string vet1desc;
    
    /// <remarks/>
    public string vet2desc;
    
    /// <remarks/>
    public string vet3desc;
    
    /// <remarks/>
    public string abilitydesc;
    
    /// <remarks/>
    public string eirrmoddesc;
    
    /// <remarks/>
    public Resources resources;
    
    /// <remarks/>
    public Availability avail;
    
    /// <remarks/>
    public Upgrade[] upgrades;
    
    /// <remarks/>
    public int icon;
    
    /// <remarks/>
    public int iconSheet;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Availability {
    
    /// <remarks/>
    public int inr;
    
    /// <remarks/>
    public int ins;
    
    /// <remarks/>
    public int cost;
    
    /// <remarks/>
    public int poolindex;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class AdvantageList {
    
    /// <remarks/>
    public Advantage[] advantages;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class ReportList {
    
    /// <remarks/>
    public int btid;
    
    /// <remarks/>
    public Report[] reports;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Report {
    
    /// <remarks/>
    public int btid;
    
    /// <remarks/>
    public int duration;
    
    /// <remarks/>
    public int result;
    
    /// <remarks/>
    public int playerside;
    
    /// <remarks/>
    public string map;
    
    /// <remarks/>
    public int gameType;
    
    /// <remarks/>
    public int gamestate;
    
    /// <remarks/>
    public string report;
    
    /// <remarks/>
    public ReportsTrack[] tracking;
    
    /// <remarks/>
    public ReportsPlayer[] players;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class ReportsTrack {
    
    /// <remarks/>
    public int increment;
    
    /// <remarks/>
    public string report;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class ReportsPlayer {
    
    /// <remarks/>
    public int ppid;
    
    /// <remarks/>
    public int bid;
    
    /// <remarks/>
    public int rid;
    
    /// <remarks/>
    public int xp;
    
    /// <remarks/>
    public string forumname;
    
    /// <remarks/>
    public string battalionname;
    
    /// <remarks/>
    public string report;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class BattleList {
    
    /// <remarks/>
    public Battle[] battleList;
    
    /// <remarks/>
    public string datetime;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Battle {
    
    /// <remarks/>
    public int btid;
    
    /// <remarks/>
    public int players;
    
    /// <remarks/>
    public int phase;
    
    /// <remarks/>
    public int location;
    
    /// <remarks/>
    public int creator;
    
    /// <remarks/>
    public int viewType;
    
    /// <remarks/>
    public int gameType;
    
    /// <remarks/>
    public string name;
    
    /// <remarks/>
    public string pass;
    
    /// <remarks/>
    public int alliesrank;
    
    /// <remarks/>
    public int axisrank;
    
    /// <remarks/>
    public BattlePlayer[] battlePlayers;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class BattlePlayer {
    
    /// <remarks/>
    public int ppid;
    
    /// <remarks/>
    public int phase;
    
    /// <remarks/>
    public int bid;
    
    /// <remarks/>
    public int rid;
    
    /// <remarks/>
    public string name;
    
    /// <remarks/>
    public int rank;
    
    /// <remarks/>
    public int position;
    
    /// <remarks/>
    public string xfire;
    
    /// <remarks/>
    public int broadcasting;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class AvailabilityPool {
    
    /// <remarks/>
    public Pool[] pools;
    
    /// <remarks/>
    public int basepool;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Pool {
    
    /// <remarks/>
    public string poolname;
    
    /// <remarks/>
    public int poolindex;
    
    /// <remarks/>
    public int poolamount;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class WarProgress {
    
    /// <remarks/>
    public int sectorindex;
    
    /// <remarks/>
    public int progress;
    
    /// <remarks/>
    public int played;
    
    /// <remarks/>
    public int momentum;
    
    /// <remarks/>
    public WarMap[] maps;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class WarMap {
    
    /// <remarks/>
    public int sectorpos;
    
    /// <remarks/>
    public string mapname;
    
    /// <remarks/>
    public string name;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class BattleAdvantageList {
    
    /// <remarks/>
    public BattleAdvantage[] trainingAdvantages;
    
    /// <remarks/>
    public BattleAdvantage[] battleAdvantages;
    
    /// <remarks/>
    public int trainingpoints;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class BattleAdvantage {
    
    /// <remarks/>
    public int baid;
    
    /// <remarks/>
    public int iconSheet;
    
    /// <remarks/>
    public int icon;
    
    /// <remarks/>
    public int type;
    
    /// <remarks/>
    public string name;
    
    /// <remarks/>
    public string descr;
    
    /// <remarks/>
    public int cost1;
    
    /// <remarks/>
    public int cost2;
    
    /// <remarks/>
    public int num;
    
    /// <remarks/>
    public int max;
    
    /// <remarks/>
    public int free;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class BattleAdvantageQueue {
    
    /// <remarks/>
    public BattleAdvantageChosen[] battleAdvantages;
    
    /// <remarks/>
    public int ppspent;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class BattleAdvantageChosen {
    
    /// <remarks/>
    public int baid;
    
    /// <remarks/>
    public int total;
    
    /// <remarks/>
    public string bp;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class DataRewardQueue {
    
    /// <remarks/>
    public DataRewardCommand[] dataRewardCommands;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class DataRewardCommand {
    
    /// <remarks/>
    public Reward data;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Reward {
    
    /// <remarks/>
    public string rname;
    
    /// <remarks/>
    public string rdescr;
    
    /// <remarks/>
    public string ename;
    
    /// <remarks/>
    public int rType;
    
    /// <remarks/>
    public int ID;
    
    /// <remarks/>
    public int uses;
    
    /// <remarks/>
    public int cost;
    
    /// <remarks/>
    public int fid;
    
    /// <remarks/>
    public int rid;
    
    /// <remarks/>
    public int sheet;
    
    /// <remarks/>
    public int icon;
    
    /// <remarks/>
    public int bought;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Chat {
    
    /// <remarks/>
    public ChatPlayer[] players;
    
    /// <remarks/>
    public ChatLine[] lines;
    
    /// <remarks/>
    public string dateTime;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class ChatPlayer {
    
    /// <remarks/>
    public string profile;
    
    /// <remarks/>
    public string player;
    
    /// <remarks/>
    public int bid;
    
    /// <remarks/>
    public int rid;
    
    /// <remarks/>
    public int win;
    
    /// <remarks/>
    public int loss;
    
    /// <remarks/>
    public int draw;
    
    /// <remarks/>
    public int rank;
    
    /// <remarks/>
    public int ppTotal;
    
    /// <remarks/>
    public int xpTotal;
    
    /// <remarks/>
    public int cpTotal;
    
    /// <remarks/>
    public int skTotal;
    
    /// <remarks/>
    public System.DateTime lasttime;
    
    /// <remarks/>
    public System.DateTime now;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class ChatLine {
    
    /// <remarks/>
    public int cid;
    
    /// <remarks/>
    public string player;
    
    /// <remarks/>
    public string profile;
    
    /// <remarks/>
    public int bid;
    
    /// <remarks/>
    public int rid;
    
    /// <remarks/>
    public int rank;
    
    /// <remarks/>
    public string text;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class SectorList {
    
    /// <remarks/>
    public Sector[] sectors;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Sector {
    
    /// <remarks/>
    public int wsid;
    
    /// <remarks/>
    public int state;
    
    /// <remarks/>
    public int act_allied;
    
    /// <remarks/>
    public int act_axis;
    
    /// <remarks/>
    public int str_allied;
    
    /// <remarks/>
    public int str_axis;
    
    /// <remarks/>
    public int faction;
    
    /// <remarks/>
    public int supply;
    
    /// <remarks/>
    public int x;
    
    /// <remarks/>
    public int y;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItem(IsNullable=false)]
    public int[] routesTo;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class DoctrineHeaders {
    
    /// <remarks/>
    public DoctrineHeader[] doctrineHeaders;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class DoctrineHeader {
    
    /// <remarks/>
    public string name;
    
    /// <remarks/>
    public int did;
    
    /// <remarks/>
    public int rid;
    
    /// <remarks/>
    public int iconSheet;
    
    /// <remarks/>
    public int icon;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class UnitList {
    
    /// <remarks/>
    public Unit[] units;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Battalion {
    
    /// <remarks/>
    public bool locked;
    
    /// <remarks/>
    public string name;
    
    /// <remarks/>
    public int ppTotal;
    
    /// <remarks/>
    public int pp;
    
    /// <remarks/>
    public int xp;
    
    /// <remarks/>
    public int sp;
    
    /// <remarks/>
    public int bid;
    
    /// <remarks/>
    public int fid;
    
    /// <remarks/>
    public int rid;
    
    /// <remarks/>
    public int did;
    
    /// <remarks/>
    public int reid;
    
    /// <remarks/>
    public int win;
    
    /// <remarks/>
    public int loss;
    
    /// <remarks/>
    public int draw;
    
    /// <remarks/>
    public Squad[] squads;
    
    /// <remarks/>
    public string xfire;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Rewards {
    
    /// <remarks/>
    public int profileRewards;
    
    /// <remarks/>
    public int battalionRewards;
    
    /// <remarks/>
    public Reward[] rewards;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public partial class Profile {
    
    /// <remarks/>
    public string pname;
    
    /// <remarks/>
    public string username;
    
    /// <remarks/>
    public int bid;
    
    /// <remarks/>
    public int ppid;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public enum LoginResponse {
    
    /// <remarks/>
    ProfileNotFound,
    
    /// <remarks/>
    ProfileOnly,
    
    /// <remarks/>
    ProfileFound,
    
    /// <remarks/>
    WrongVersion,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempurl.com/")]
public enum LoginResponseV2 {
    
    /// <remarks/>
    UnknownError,
    
    /// <remarks/>
    IncorrectVersion,
    
    /// <remarks/>
    IncorrectPass,
    
    /// <remarks/>
    MultiMachineID,
    
    /// <remarks/>
    LoginSuccessful,
}

public partial class RetrieveCompanyListCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveCompanyListCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public CompanyList Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((CompanyList)(this.results[0]));
        }
    }
}

public delegate void RetrieveCompanyListCompletedEventHandler(object sender,
      RetrieveCompanyListCompletedEventArgs args);

public partial class RetrieveDoctrineHeaderCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveDoctrineHeaderCompletedEventArgs(object[] results, System.Exception
          exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public DoctrinesHeader Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((DoctrinesHeader)(this.results[0]));
        }
    }
}

public delegate void RetrieveDoctrineHeaderCompletedEventHandler(object sender,
      RetrieveDoctrineHeaderCompletedEventArgs args);

public partial class CreateCompanyCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal CreateCompanyCompletedEventArgs(object[] results, System.Exception exception, bool
          cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public CompanyList Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((CompanyList)(this.results[0]));
        }
    }
}

public delegate void CreateCompanyCompletedEventHandler(object sender,
      CreateCompanyCompletedEventArgs args);

public delegate void TestBattleFileCompletedEventHandler(object sender,
      System.ComponentModel.AsyncCompletedEventArgs args);

public partial class ReadyForBattleFileCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal ReadyForBattleFileCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

public delegate void ReadyForBattleFileCompletedEventHandler(object sender,
      ReadyForBattleFileCompletedEventArgs args);

public partial class RecieveReportCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RecieveReportCompletedEventArgs(object[] results, System.Exception exception, bool
          cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

public delegate void RecieveReportCompletedEventHandler(object sender,
      RecieveReportCompletedEventArgs args);

public partial class SetToCompletedCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal SetToCompletedCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

public delegate void SetToCompletedCompletedEventHandler(object sender,
      SetToCompletedCompletedEventArgs args);

public partial class RecieveSquadQueueCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RecieveSquadQueueCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

public delegate void RecieveSquadQueueCompletedEventHandler(object sender,
      RecieveSquadQueueCompletedEventArgs args);

public partial class RecieveDoctrineSelectionQueueCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RecieveDoctrineSelectionQueueCompletedEventArgs(object[] results, System.Exception
          exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

public delegate void RecieveDoctrineSelectionQueueCompletedEventHandler(object sender,
      RecieveDoctrineSelectionQueueCompletedEventArgs args);

public partial class RecieveAdvantageSelectionQueueCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RecieveAdvantageSelectionQueueCompletedEventArgs(object[] results,
          System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

public delegate void RecieveAdvantageSelectionQueueCompletedEventHandler(object sender,
      RecieveAdvantageSelectionQueueCompletedEventArgs args);

public partial class RetrieveDoctrineCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveDoctrineCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public Doctrine Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((Doctrine)(this.results[0]));
        }
    }
}

public delegate void RetrieveDoctrineCompletedEventHandler(object sender,
      RetrieveDoctrineCompletedEventArgs args);

public partial class RetrieveReinforcementsCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveReinforcementsCompletedEventArgs(object[] results, System.Exception
          exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public Reinforcements Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((Reinforcements)(this.results[0]));
        }
    }
}

public delegate void RetrieveReinforcementsCompletedEventHandler(object sender,
      RetrieveReinforcementsCompletedEventArgs args);

public partial class RetrieveAdvantagesCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveAdvantagesCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public AdvantageList Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((AdvantageList)(this.results[0]));
        }
    }
}

public delegate void RetrieveAdvantagesCompletedEventHandler(object sender,
      RetrieveAdvantagesCompletedEventArgs args);

public partial class RetrieveReportsCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveReportsCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public ReportList Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((ReportList)(this.results[0]));
        }
    }
}

public delegate void RetrieveReportsCompletedEventHandler(object sender,
      RetrieveReportsCompletedEventArgs args);

public partial class RecievePrimaryDoctrineCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RecievePrimaryDoctrineCompletedEventArgs(object[] results, System.Exception
          exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

public delegate void RecievePrimaryDoctrineCompletedEventHandler(object sender,
      RecievePrimaryDoctrineCompletedEventArgs args);

public partial class RetrieveBattleListCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveBattleListCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public BattleList Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((BattleList)(this.results[0]));
        }
    }
}

public delegate void RetrieveBattleListCompletedEventHandler(object sender,
      RetrieveBattleListCompletedEventArgs args);

public partial class RetrieveAvailabilityCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveAvailabilityCompletedEventArgs(object[] results, System.Exception
          exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public AvailabilityPool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((AvailabilityPool)(this.results[0]));
        }
    }
}

public delegate void RetrieveAvailabilityCompletedEventHandler(object sender,
      RetrieveAvailabilityCompletedEventArgs args);

public partial class RetrieveNewsCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveNewsCompletedEventArgs(object[] results, System.Exception exception, bool
          cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public string Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

public delegate void RetrieveNewsCompletedEventHandler(object sender,
      RetrieveNewsCompletedEventArgs args);

public partial class RetrieveTickerCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveTickerCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public string Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

public delegate void RetrieveTickerCompletedEventHandler(object sender,
      RetrieveTickerCompletedEventArgs args);

public partial class RetrieveWarProgressCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveWarProgressCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public WarProgress Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((WarProgress)(this.results[0]));
        }
    }
}

public delegate void RetrieveWarProgressCompletedEventHandler(object sender,
      RetrieveWarProgressCompletedEventArgs args);

public partial class RetrieveBattleAdvantageListCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveBattleAdvantageListCompletedEventArgs(object[] results, System.Exception
          exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public BattleAdvantageList Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((BattleAdvantageList)(this.results[0]));
        }
    }
}

public delegate void RetrieveBattleAdvantageListCompletedEventHandler(object sender,
      RetrieveBattleAdvantageListCompletedEventArgs args);

public partial class RecieveBattleAdvantageQueueCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RecieveBattleAdvantageQueueCompletedEventArgs(object[] results, System.Exception
          exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

public delegate void RecieveBattleAdvantageQueueCompletedEventHandler(object sender,
      RecieveBattleAdvantageQueueCompletedEventArgs args);

public partial class RecieveRewardQueueCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RecieveRewardQueueCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

public delegate void RecieveRewardQueueCompletedEventHandler(object sender,
      RecieveRewardQueueCompletedEventArgs args);

public delegate void RecieveXFireAccountCompletedEventHandler(object sender,
      System.ComponentModel.AsyncCompletedEventArgs args);

public partial class RetrieveChatCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveChatCompletedEventArgs(object[] results, System.Exception exception, bool
          cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public Chat Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((Chat)(this.results[0]));
        }
    }
}

public delegate void RetrieveChatCompletedEventHandler(object sender,
      RetrieveChatCompletedEventArgs args);

public partial class RetrieveSectorListCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveSectorListCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public SectorList Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((SectorList)(this.results[0]));
        }
    }
}

public delegate void RetrieveSectorListCompletedEventHandler(object sender,
      RetrieveSectorListCompletedEventArgs args);

public partial class SendChatCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
      {
    
    private object[] results;
    
    internal SendChatCompletedEventArgs(object[] results, System.Exception exception, bool
          cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public Chat Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((Chat)(this.results[0]));
        }
    }
}

public delegate void SendChatCompletedEventHandler(object sender, SendChatCompletedEventArgs
      args);

public partial class SendXFireCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal SendXFireCompletedEventArgs(object[] results, System.Exception exception, bool
          cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public Chat Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((Chat)(this.results[0]));
        }
    }
}

public delegate void SendXFireCompletedEventHandler(object sender, SendXFireCompletedEventArgs
      args);

public partial class RequestJoinBattleCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RequestJoinBattleCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

public delegate void RequestJoinBattleCompletedEventHandler(object sender,
      RequestJoinBattleCompletedEventArgs args);

public partial class RequestLeaveBattleCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RequestLeaveBattleCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

public delegate void RequestLeaveBattleCompletedEventHandler(object sender,
      RequestLeaveBattleCompletedEventArgs args);

public partial class RequestCreateBattleCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RequestCreateBattleCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

public delegate void RequestCreateBattleCompletedEventHandler(object sender,
      RequestCreateBattleCompletedEventArgs args);

public partial class ChangeBattlePlayersCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal ChangeBattlePlayersCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

public delegate void ChangeBattlePlayersCompletedEventHandler(object sender,
      ChangeBattlePlayersCompletedEventArgs args);

public partial class ChangeBattleGameTypeCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal ChangeBattleGameTypeCompletedEventArgs(object[] results, System.Exception
          exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

public delegate void ChangeBattleGameTypeCompletedEventHandler(object sender,
      ChangeBattleGameTypeCompletedEventArgs args);

public partial class ChangeBattlePlayerPhaseCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal ChangeBattlePlayerPhaseCompletedEventArgs(object[] results, System.Exception
          exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

public delegate void ChangeBattlePlayerPhaseCompletedEventHandler(object sender,
      ChangeBattlePlayerPhaseCompletedEventArgs args);

public partial class RequestDeleteCompanyCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RequestDeleteCompanyCompletedEventArgs(object[] results, System.Exception
          exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

public delegate void RequestDeleteCompanyCompletedEventHandler(object sender,
      RequestDeleteCompanyCompletedEventArgs args);

public partial class RequestBattleFileCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RequestBattleFileCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public string Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

public delegate void RequestBattleFileCompletedEventHandler(object sender,
      RequestBattleFileCompletedEventArgs args);

public partial class RequestUCSFileCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RequestUCSFileCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public string Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

public delegate void RequestUCSFileCompletedEventHandler(object sender,
      RequestUCSFileCompletedEventArgs args);

public partial class RetrieveDoctrineHeadersCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveDoctrineHeadersCompletedEventArgs(object[] results, System.Exception
          exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public DoctrineHeaders Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((DoctrineHeaders)(this.results[0]));
        }
    }
}

public delegate void RetrieveDoctrineHeadersCompletedEventHandler(object sender,
      RetrieveDoctrineHeadersCompletedEventArgs args);

public partial class RetrievePUnitsCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrievePUnitsCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public UnitList Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((UnitList)(this.results[0]));
        }
    }
}

public delegate void RetrievePUnitsCompletedEventHandler(object sender,
      RetrievePUnitsCompletedEventArgs args);

public partial class RetrievePUnitListCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrievePUnitListCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public UnitList Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((UnitList)(this.results[0]));
        }
    }
}

public delegate void RetrievePUnitListCompletedEventHandler(object sender,
      RetrievePUnitListCompletedEventArgs args);

public partial class RetrieveUnitsCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveUnitsCompletedEventArgs(object[] results, System.Exception exception, bool
          cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public Battalion Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((Battalion)(this.results[0]));
        }
    }
}

public delegate void RetrieveUnitsCompletedEventHandler(object sender,
      RetrieveUnitsCompletedEventArgs args);

public partial class RetrieveRewardsCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveRewardsCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public Rewards Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((Rewards)(this.results[0]));
        }
    }
}

public delegate void RetrieveRewardsCompletedEventHandler(object sender,
      RetrieveRewardsCompletedEventArgs args);

public partial class RetrieveProfileCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RetrieveProfileCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public Profile Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((Profile)(this.results[0]));
        }
    }
}

public delegate void RetrieveProfileCompletedEventHandler(object sender,
      RetrieveProfileCompletedEventArgs args);

public partial class VerifyLoginCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal VerifyLoginCompletedEventArgs(object[] results, System.Exception exception, bool
          cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

public delegate void VerifyLoginCompletedEventHandler(object sender,
      VerifyLoginCompletedEventArgs args);

public partial class VerifyUserVersionCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal VerifyUserVersionCompletedEventArgs(object[] results, System.Exception exception,
          bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public LoginResponse Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((LoginResponse)(this.results[0]));
        }
    }
}

public delegate void VerifyUserVersionCompletedEventHandler(object sender,
      VerifyUserVersionCompletedEventArgs args);

public partial class AttemptLoginCompletedEventArgs :
      System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal AttemptLoginCompletedEventArgs(object[] results, System.Exception exception, bool
          cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public LoginResponseV2 Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((LoginResponseV2)(this.results[0]));
        }
    }
}

public delegate void AttemptLoginCompletedEventHandler(object sender,
      AttemptLoginCompletedEventArgs args);
